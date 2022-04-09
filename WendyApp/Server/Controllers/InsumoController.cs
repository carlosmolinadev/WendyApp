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
    public class InsumoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<InsumoController> _logger;
        private readonly IMapper _mapper;

        public InsumoController(IUnitOfWork unitOfWork, ILogger<InsumoController> logger,
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
        public async Task<IActionResult> GetInsumos()
        {
            var insumos = await _unitOfWork.Insumos.GetAll();
            var results = _mapper.Map<List<InsumoDTO>>(insumos);
            return Ok(results);
        }

        [HttpGet("{id:int}", Name = "GetInsumo")]
        ////[ResponseCache(CacheProfileName = "120SecondsDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetInsumo(int id)
        {
            //throw new Exception("Error message");
            var insumo = await _unitOfWork.Insumos.Get(q => q.InsumoId == id); //, include: q => q.Include(x => x.Sucursales)
            var result = _mapper.Map<InsumoDTO>(insumo);
            return Ok(result);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateInsumo([FromBody] InsumoDTO insumoDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateInsumo)}");
                return BadRequest(ModelState);
            }

            var insumo = _mapper.Map<Insumo>(insumoDTO);
            await _unitOfWork.Insumos.Insert(insumo);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetInsumo", new { id = insumo.InsumoId }, insumo);

        }

        //[Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateInsumo(int id, [FromBody] InsumoDTO insumoDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateInsumo)}");
                return BadRequest(ModelState);
            }

            var insumo = await _unitOfWork.Insumos.Get(q => q.InsumoId == id);
            if (insumo == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateInsumo)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(insumoDTO, insumo);
            _unitOfWork.Insumos.Update(insumo);
            await _unitOfWork.Save();

            return NoContent();

        }

        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteInsumo(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteInsumo)}");
                return BadRequest();
            }

            var insumo = await _unitOfWork.Insumos.Get(q => q.InsumoId == id);
            if (insumo == null)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteInsumo)}");
                return BadRequest("Submitted data is invalid");
            }

            await _unitOfWork.Insumos.Delete(id);
            await _unitOfWork.Save();

            return NoContent();

        }
    }
}
