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
    public class PaisController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<PaisController> _logger;
        private readonly IMapper _mapper;

        public PaisController(IUnitOfWork unitOfWork, ILogger<PaisController> logger,
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
        public async Task<IActionResult> GetPaises()
        {
            var paises = await _unitOfWork.Paises.GetAll();
            var results = _mapper.Map<List<PaisDTO>>(paises);
            return Ok(results);
        }

        [HttpGet("{id:int}", Name = "GetPais")]
        ////[ResponseCache(CacheProfileName = "120SecondsDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPais(int id)
        {
            //throw new Exception("Error message");
            var pais = await _unitOfWork.Paises.Get(q => q.PaisId == id, include: q => q.Include(x => x.Sucursales));
            var result = _mapper.Map<PaisDTO>(pais);
            return Ok(result);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreatePais([FromBody] PaisDTO paisDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreatePais)}");
                return BadRequest(ModelState);
            }

            var pais = _mapper.Map<Pais>(paisDTO);
            await _unitOfWork.Paises.Insert(pais);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetPais", new { id = pais.PaisId }, pais);

        }

        //[Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdatePais(int id, [FromBody] PaisDTO paisDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdatePais)}");
                return BadRequest(ModelState);
            }

            var pais = await _unitOfWork.Paises.Get(q => q.PaisId == id);
            if (pais == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdatePais)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(paisDTO, pais);
            _unitOfWork.Paises.Update(pais);
            await _unitOfWork.Save();

            return NoContent();

        }

        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeletePais(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeletePais)}");
                return BadRequest();
            }

            var pais = await _unitOfWork.Paises.Get(q => q.PaisId == id);
            if (pais == null)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeletePais)}");
                return BadRequest("Submitted data is invalid");
            }

            await _unitOfWork.Paises.Delete(id);
            await _unitOfWork.Save();

            return NoContent();

        }
    }
    
}
