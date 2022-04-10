using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WendyApp.Server.Interfaces.IRepository;
using WendyApp.Server.Models;
using WendyApp.Shared.Domain;

namespace WendyApp.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class SucursalController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<SucursalController> _logger;
        private readonly IMapper _mapper;

        public SucursalController(IUnitOfWork unitOfWork, ILogger<SucursalController> logger,
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
        public async Task<IActionResult> GetSucursales()
        {
            var sucursales = await _unitOfWork.Sucursales.GetAll();
            var results = _mapper.Map<List<SucursalDTO>>(sucursales);
            return Ok(results);
        }

        [HttpGet("{id:int}", Name = "GetSucursal")]
        ////[ResponseCache(CacheProfileName = "120SecondsDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetSucursal(int id)
        {
            //throw new Exception("Error message");
            var sucursal = await _unitOfWork.Sucursales.Get(q => q.SucursalId == id);
            var result = _mapper.Map<SucursalDTO>(sucursal);
            return Ok(result);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateSucursal([FromBody] SucursalDTO sucursalDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateSucursal)}");
                return BadRequest(ModelState);
            }

            var sucursal = _mapper.Map<Sucursal>(sucursalDTO);
            await _unitOfWork.Sucursales.Insert(sucursal);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetSucursal", new { id = sucursal.SucursalId }, sucursal);

        }

        //[Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateSucursal(int id, [FromBody] SucursalDTO sucursalDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateSucursal)}");
                return BadRequest(ModelState);
            }

            var sucursal = await _unitOfWork.Sucursales.Get(q => q.SucursalId == id);
            if (sucursal == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateSucursal)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(sucursalDTO, sucursal);
            _unitOfWork.Sucursales.Update(sucursal);
            await _unitOfWork.Save();

            return NoContent();

        }

        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteSucursal(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteSucursal)}");
                return BadRequest();
            }

            var sucursal = await _unitOfWork.Sucursales.Get(q => q.SucursalId == id);
            if (sucursal == null)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteSucursal)}");
                return BadRequest("Submitted data is invalid");
            }

            await _unitOfWork.Sucursales.Delete(id);
            await _unitOfWork.Save();

            return NoContent();

        }
    }
    
}
