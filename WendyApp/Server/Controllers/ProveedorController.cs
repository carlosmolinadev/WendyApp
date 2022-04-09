using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WendyApp.Server.IRepository;
using WendyApp.Server.Models;
using WendyApp.Shared.Domain;

namespace WendyApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProveedorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ProveedorController> _logger;
        private readonly IMapper _mapper;

        public ProveedorController(IUnitOfWork unitOfWork, ILogger<ProveedorController> logger,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        // Can be used to override global caching on a particular endpoint at any point. 
        ////[HttpCacheExpiration(CacheLocation = CacheLocation.Public, MaxAge = 60)]
        ////[HttpCacheValidation(MustRevalidate = false)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProveedores()
        {
            var proveedores = await _unitOfWork.Proveedores.GetAll();
            var results = _mapper.Map<List<ProveedorDTO>>(proveedores);
            return Ok(results);
        }

        [HttpGet("{id:int}", Name = "GetProveedor")]
        ////[ResponseCache(CacheProfileName = "120SecondsDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProveedor(int id)
        {
            //throw new Exception("Error message");
            var insumo = await _unitOfWork.Proveedores.Get(q => q.ProveedorId == id); //, include: q => q.Include(x => x.Sucursales)
            var result = _mapper.Map<ProveedorDTO>(insumo);
            return Ok(result);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateProveedor([FromBody] ProveedorDTO insumoDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateProveedor)}");
                return BadRequest(ModelState);
            }

            var insumo = _mapper.Map<Proveedor>(insumoDTO);
            await _unitOfWork.Proveedores.Insert(insumo);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetProveedor", new { id = insumo.ProveedorId }, insumo);

        }

        //[Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateProveedor(int id, [FromBody] ProveedorDTO insumoDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateProveedor)}");
                return BadRequest(ModelState);
            }

            var insumo = await _unitOfWork.Proveedores.Get(q => q.ProveedorId == id);
            if (insumo == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateProveedor)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(insumoDTO, insumo);
            _unitOfWork.Proveedores.Update(insumo);
            await _unitOfWork.Save();

            return NoContent();

        }

        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteProveedor(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteProveedor)}");
                return BadRequest();
            }

            var insumo = await _unitOfWork.Proveedores.Get(q => q.ProveedorId == id);
            if (insumo == null)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteProveedor)}");
                return BadRequest("Submitted data is invalid");
            }

            await _unitOfWork.Proveedores.Delete(id);
            await _unitOfWork.Save();

            return NoContent();

        }
    }
}
