using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using WendyApp.Server.IRepository;
using WendyApp.Server.Models;
using WendyApp.Shared.Domain;

namespace WendyApp.Server.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CategoriaController> _logger;
        private readonly IMapper _mapper;

        public CategoriaController(IUnitOfWork unitOfWork, ILogger<CategoriaController> logger,
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
        public async Task<IActionResult> GetCategorias()
        {
            var categorias = await _unitOfWork.Categorias.GetAll();
            var results = _mapper.Map<List<CategoriaDTO>>(categorias);
            return Ok(results);
        }

        [HttpGet("{id:int}", Name = "GetCategoria")]
        ////[ResponseCache(CacheProfileName = "120SecondsDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCategoria(int id)
        {
            //throw new Exception("Error message");
            var categoria = await _unitOfWork.Categorias.Get(q => q.CategoriaId == id);
            var insumosCategorias = await _unitOfWork.InsumosCategorias.GetAll(q => q.CategoriaId == id, include: q => q.Include(x => x.Insumo));
            var insumos = new List<InsumoDTO>();

            foreach (var item in insumosCategorias)
            {
                var insumo = _mapper.Map<InsumoDTO>(item.Insumo);
                insumos.Add(insumo);
            }

            var categoriaDTO = new CategoriaDTO { CategoriaId = categoria.CategoriaId, Nombre = categoria.Nombre, Insumos = insumos };

            
            //var categoria = await _unitOfWork.InsumosCategorias.GetAll(q => q.CategoriaId == id, include: q => q.Include(x => x.Insumo));
            //var insumos = await _unitOfWork.InsumosCategorias.GetAll(q => q.InsumoId == c);

            //var categoria = await _unitOfWork.InsumosCategorias.Get(q => q.CategoriaId == id);

            //var result = _mapper.Map<InsumoCategoriaDTO>(insumosCategorias);

            //var list = new List<InsumoDTO>();
            //list.Add(x.Insumos);
            return Ok(categoriaDTO);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateCategoria([FromBody] CategoriaDTO categoriaDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateCategoria)}");
                return BadRequest(ModelState);
            }

            var categoria = _mapper.Map<Categoria>(categoriaDTO);
            await _unitOfWork.Categorias.Insert(categoria);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetCategoria", new { id = categoria.CategoriaId }, categoria);

        }

        //[Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateCategoria(int id, [FromBody] CategoriaDTO categoriaDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateCategoria)}");
                return BadRequest(ModelState);
            }

            var categoria = await _unitOfWork.Categorias.Get(q => q.CategoriaId == id);
            if (categoria == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateCategoria)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(categoriaDTO, categoria);
            _unitOfWork.Categorias.Update(categoria);
            await _unitOfWork.Save();

            return NoContent();

        }

        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteCategoria(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteCategoria)}");
                return BadRequest();
            }

            var categoria = await _unitOfWork.Categorias.Get(q => q.CategoriaId == id);
            if (categoria == null)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteCategoria)}");
                return BadRequest("Submitted data is invalid");
            }

            await _unitOfWork.Categorias.Delete(id);
            await _unitOfWork.Save();

            return NoContent();

        }
    }
    
}
