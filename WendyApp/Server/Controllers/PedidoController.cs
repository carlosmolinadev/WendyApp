using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WendyApp.Server.Interfaces.IRepository;
using WendyApp.Server.Models;
using WendyApp.Shared.Domain;

namespace WendyApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<PedidoController> _logger;
        private readonly IMapper _mapper;

        public PedidoController(IUnitOfWork unitOfWork, ILogger<PedidoController> logger,
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
        public async Task<IActionResult> GetPedidos()
        {
            var pedidos = await _unitOfWork.Pedidos.GetAll();
            var results = _mapper.Map<List<PedidoDTO>>(pedidos);
            return Ok(results);
        }

        [HttpGet("{id:int}", Name = "GetPedido")]
        ////[ResponseCache(CacheProfileName = "120SecondsDuration")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPedido(int id)
        {
            //throw new Exception("Error message");
            var pedido = await _unitOfWork.Pedidos.Get(q => q.PedidoId == id); //, include: q => q.Include(x => x.Sucursales)
            var result = _mapper.Map<PedidoDTO>(pedido);
            return Ok(result);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreatePedido([FromBody] PedidoDTO pedidoDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreatePedido)}");
                return BadRequest(ModelState);
            }

            var pedido = _mapper.Map<Pedido>(pedidoDTO);
            await _unitOfWork.Pedidos.Insert(pedido);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetPedido", new { id = pedido.PedidoId }, pedido);

        }

        //[Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdatePedido(int id, [FromBody] PedidoDTO pedidoDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdatePedido)}");
                return BadRequest(ModelState);
            }

            var pedido = await _unitOfWork.Pedidos.Get(q => q.PedidoId == id);
            if (pedido == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdatePedido)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(pedidoDTO, pedido);
            _unitOfWork.Pedidos.Update(pedido);
            await _unitOfWork.Save();

            return NoContent();

        }

        //[Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeletePedido(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeletePedido)}");
                return BadRequest();
            }

            var pedido = await _unitOfWork.Pedidos.Get(q => q.PedidoId == id);
            if (pedido == null)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeletePedido)}");
                return BadRequest("Submitted data is invalid");
            }

            await _unitOfWork.Pedidos.Delete(id);
            await _unitOfWork.Save();

            return NoContent();

        }
    }
}
