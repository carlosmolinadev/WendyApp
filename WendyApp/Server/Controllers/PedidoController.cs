using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Text.Json;
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
        private readonly IConfiguration Configuration;

        public PedidoController(IUnitOfWork unitOfWork, ILogger<PedidoController> logger,
            IMapper mapper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            Configuration = configuration;
        }

        [HttpGet("{pedidoId:int}/Historial")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> HistorialPedido(int pedidoId)
        {
            var historialPedido = await _unitOfWork.HistorialPedidos.GetAll(q => q.PedidoId == pedidoId, include: q => q.Include(x => x.EstadoPedidos));
            var historialPedidoDTO = new List<ReturnEstadoPedidoDTO>();

            foreach (var item in historialPedido)
            {
                var localHistorialPedido = new ReturnEstadoPedidoDTO
                {
                    EstadoPedidoId = item.EstadoPedidoId,
                    Estado = item.EstadoPedidos.Estado,
                    FechaCreacion = item.FechaCreacion,
                };

                historialPedidoDTO.Add(localHistorialPedido);
            }

            return Ok(historialPedidoDTO);
        }

        [HttpGet("Estado")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> EstadoPedido()
        {
            var estadoPedidos = await _unitOfWork.EstadoPedidos.GetAll();

            var result = _mapper.Map<List<ReturnEstadoPedidoDTO>>(estadoPedidos);
            return Ok(result);
        }

        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Pedidos(string proveedorId, string estadoId)
        {
            var pedidos = (List<Pedido>) await _unitOfWork.Pedidos.GetAll();
            var pedidosInsumo = (List<PedidoInsumo>) await _unitOfWork.PedidosInsumos.GetAll();
            var proveedor = (List<Proveedor>) await _unitOfWork.Proveedores.GetAll();
            var sucursal = (List<Sucursal>) await _unitOfWork.Sucursales.GetAll();
            var paisesProveedores = (List<PaisProveedor>) await _unitOfWork.PaisesProveedores.GetAll();
            var estadoPedidos = (List<EstadoPedido>) await _unitOfWork.EstadoPedidos.GetAll();
            var result = new List<ReturnPedidoDTO>();

            var filteredPedidos = new List<Pedido>();

            if (!string.IsNullOrEmpty(proveedorId) && !string.IsNullOrEmpty(estadoId))
            {
                var localPedidos = new List<Pedido>();
                var estadoSplit = estadoId.Split(",");
                var estadoIdList = new List<int>();

                pedidos.ForEach(item =>
                {
                    if (item.ProveedorId == Int16.Parse(proveedorId))
                    {
                        localPedidos.Add(item);
                    }
                });

                var finalPedidosList = new List<Pedido>();

                foreach (var estado in estadoSplit) { estadoIdList.Add(Int16.Parse(estado)); }

                foreach (var item in localPedidos)
                {
                    if (estadoIdList.Contains(item.EstadoPedidoId))
                    {
                        finalPedidosList.Add(item);
                    };
                }

                filteredPedidos = finalPedidosList;
            }
            else if (!string.IsNullOrEmpty(proveedorId))
            {

                var localPedidos = new List<Pedido>();
                pedidos.ForEach(item =>
                {
                    if (item.ProveedorId == Int16.Parse(proveedorId))
                    {
                        localPedidos.Add(item);
                    }
                });
                filteredPedidos = localPedidos;
            } else if (!string.IsNullOrEmpty(estadoId))
            {
                var estadoSplit = estadoId.Split(",");
                var estadoIdList = new List<int>();
                foreach (var estado in estadoSplit) { estadoIdList.Add(Int16.Parse(estado)); }

                foreach (var item in pedidos)
                {
                    if (estadoIdList.Contains(item.EstadoPedidoId))
                    {
                        filteredPedidos.Add(item);
                    };
                }
            }
            else
            {
                filteredPedidos = pedidos;
            }
            
            foreach (var pedido in filteredPedidos)
            {
                var pedidoActual = new ReturnPedidoDTO();
                var costoPedido = 0m;
                var costoTotal = 0m;

                var p = proveedor.Find(p => p.ProveedorId == pedido.ProveedorId);
                pedidoActual.Proveedor = new ReturnProveedorDTO { ProveedorId = p.ProveedorId, Nombre = p.Nombre };

                var s = sucursal.Find(s => s.SucursalId == pedido.SucursalId);
                pedidoActual.Sucursal = new ReturnSucursalDTO { SucursalId = s.SucursalId, Nombre = s.Nombre };

                var e = estadoPedidos.Find(e => e.EstadoPedidoId == pedido.EstadoPedidoId);
                pedidoActual.Estado = new ReturnEstadoPedidoDTO { EstadoPedidoId = e.EstadoPedidoId, Estado = e.Estado };

                var pp = paisesProveedores.Find(pp => pp.ProveedorId == pedidoActual.Proveedor.ProveedorId);
                pedidoActual.CostoTransporte = pp.CostoTransporte;

                var localPedidoInsumo = pedidosInsumo.FindAll(item => item.PedidoId == pedido.PedidoId);
                foreach (var pi in localPedidoInsumo)
                {
                    var costo = (pi.Cantidad * pi.Precio);
                    costoPedido += costo;
                }

                costoTotal = costoPedido + pedidoActual.CostoTransporte;

                pedidoActual.PedidoId = pedido.PedidoId;
                pedidoActual.FechaCreacion = pedido.FechaCreacion;
                pedidoActual.FechaEntrega = pedido.FechaEntrega;
                pedidoActual.CostoPedido = costoPedido;
                pedidoActual.Total = costoTotal;
                result.Add(pedidoActual);
            }

            result = result.OrderBy(p => p.PedidoId).ToList();

            return Ok(result);
        }

        [HttpGet("{pedidoId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PedidoDetalle(int pedidoId)
        {
            var pedidos = await _unitOfWork.Pedidos.Get(q => q.PedidoId == pedidoId, include: q => q.Include(x => x.Insumos));
            var pedidosInsumo = await _unitOfWork.PedidosInsumos.GetAll(q => q.PedidoId == pedidoId, include: q => q.Include(x => x.Insumo));
            var proveedor = await _unitOfWork.Proveedores.Get(q => q.ProveedorId == pedidos.ProveedorId);
            var sucursal = await _unitOfWork.Sucursales.Get(q => q.SucursalId == pedidos.SucursalId);
            var paisesProveedores = await _unitOfWork.PaisesProveedores.Get(q => q.Pais.PaisId == sucursal.PaisId && q.Proveedor.ProveedorId == proveedor.ProveedorId);
            var estadoPedidos = await _unitOfWork.EstadoPedidos.Get(q => q.EstadoPedidoId == pedidos.EstadoPedidoId);
            var costoTransporte = paisesProveedores.CostoTransporte;
            var costoPedido = 0m;
            var costoTotal = 0m;
            var insumosDTO = new List<ReturnInsumoDTO>();

            var historialPedido = await _unitOfWork.HistorialPedidos.GetAll(q => q.PedidoId == pedidoId, include: q => q.Include(x => x.EstadoPedidos));
            var historialPedidoDTO = new List<ReturnEstadoPedidoDTO>();

            foreach (var item in historialPedido)
            {
                var localHistorialPedido = new ReturnEstadoPedidoDTO
                {
                    EstadoPedidoId = item.EstadoPedidoId,
                    Estado = item.EstadoPedidos.Estado,
                    FechaCreacion = item.FechaCreacion,
                };

                historialPedidoDTO.Add(localHistorialPedido);
            }

            foreach (var p in pedidosInsumo)
            {
                var costo = (p.Cantidad * p.Precio);
                costoPedido += costo;
                var localInsumo = new ReturnInsumoDTO
                {
                    InsumoId = p.InsumoId,
                    Nombre = p.Insumo.Nombre,
                    Descripcion = p.Insumo.Descripcion,
                    Precio = p.Precio,
                    Cantidad = p.Cantidad,
                    Total = costo
                };
                insumosDTO.Add(localInsumo);
            }

            costoTotal = costoPedido + costoTransporte;

            var result = new ReturnPedidoDTO
            {
                PedidoId = pedidos.PedidoId,
                Proveedor = new ReturnProveedorDTO { ProveedorId = proveedor.ProveedorId, Nombre = proveedor.Nombre },
                Sucursal = new ReturnSucursalDTO { SucursalId = sucursal.SucursalId, Nombre = sucursal.Nombre },
                Estado = new ReturnEstadoPedidoDTO { EstadoPedidoId = estadoPedidos.EstadoPedidoId, Estado = estadoPedidos.Estado },
                Insumo = insumosDTO,
                Historial = historialPedidoDTO,
                FechaCreacion = pedidos.FechaCreacion,
                FechaEntrega = pedidos.FechaEntrega,
                CostoPedido = costoPedido,
                Total = costoTotal
            };

            return Ok(result);
        }

        [HttpPatch("{pedidoId:int}/estado/{estadoId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ActualizarEstadoPedido(int pedidoId, int estadoId, string descripcion)
        {
            var pedido = await _unitOfWork.Pedidos.Get(q => q.PedidoId == pedidoId);
            var estadoPedidos = await _unitOfWork.EstadoPedidos.Get(q => q.EstadoPedidoId == estadoId);
            var proveedor = await _unitOfWork.Proveedores.Get(q => q.ProveedorId == pedido.ProveedorId);
            var sucursal = await _unitOfWork.Sucursales.Get(q => q.SucursalId == pedido.SucursalId);

            if (string.IsNullOrEmpty(descripcion))
            {
                descripcion = $"Estado del pedido {pedido.PedidoId} ha sido modificado a {estadoPedidos.Estado}";
            }

            var historialPedidoDTO = new HistorialPedidoDTO
            {
                FechaCreacion = DateTime.Now,
                Descripcion = descripcion,
                PedidoId = pedido.PedidoId,
                EstadoPedidoId = estadoPedidos.EstadoPedidoId
            };

            pedido.EstadoPedidoId = estadoId;

            _unitOfWork.Pedidos.Update(pedido);

            var historialPedido = _mapper.Map<HistorialPedido>(historialPedidoDTO);
            await _unitOfWork.HistorialPedidos.Insert(historialPedido);
            await _unitOfWork.Save();

            var results = new ReturnBasicPedidoDetailDTO
            {
                PedidoId = proveedor.ProveedorId,
                Proveedor = new ReturnProveedorDTO { ProveedorId = proveedor.ProveedorId, Nombre = proveedor.Nombre },
                Sucursal = new ReturnSucursalDTO { SucursalId = sucursal.SucursalId, Nombre = sucursal.Nombre },
                Estado = new ReturnEstadoPedidoDTO { EstadoPedidoId = estadoPedidos.EstadoPedidoId, Estado = estadoPedidos.Estado },
            };
            return Ok(results);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreatePedido([FromBody] CreatePedidoDTO pedido)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreatePedido)}");
                return BadRequest(ModelState);
            }

            var sucursalJson = new JsonSucursal();
            var jwt = Request.Headers["Authorization"];
            if (string.IsNullOrEmpty(jwt))
            {
                return Unauthorized();
            }
            jwt = jwt.ToString().Split(' ')[1];
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(jwt);

            var claims = token.Payload.Claims;

            foreach (var item in claims)
            {
                if (item.Type == "sucursal")
                {
                    sucursalJson = JsonSerializer.Deserialize<JsonSucursal>(item.Value);
                }
            }

            var proveedor = await _unitOfWork.Proveedores.Get(q => q.ProveedorId == pedido.ProveedorId);
            var sucursal = await _unitOfWork.Sucursales.Get(q => q.SucursalId == sucursalJson.sucursalId);
            var paisesProveedores = await _unitOfWork.PaisesProveedores.Get(q => q.Pais.PaisId == sucursal.PaisId && q.Proveedor.ProveedorId == proveedor.ProveedorId);
            var costoTransporte = paisesProveedores.CostoTransporte;
            var insumos = pedido.Insumos;
            var costoPedido = 0m;
            var costoTotal = 0m;
            foreach (var p in insumos)
            {
                var costo = (p.Cantidad * p.Precio);
                costoPedido += costo;
            }
            costoTotal = costoPedido + costoTransporte;

            var pedidoCreated = new PedidoDTO { FechaCreacion = DateTime.Now, 
                                                FechaEntrega = pedido.FechaEntrega,
                                                ProveedorId = proveedor.ProveedorId,
                                                SucursalId = sucursal.SucursalId,
                                                EstadoPedidoId = 1
                                              };
            var pedidoDTO = _mapper.Map<Pedido>(pedidoCreated);

            await _unitOfWork.Pedidos.Insert(pedidoDTO);
            await _unitOfWork.Save();
            var id = pedidoDTO.PedidoId;

            var pedidoInsumoList = new List<PedidoInsumoDTO>();
            foreach (var p in insumos)
            {
                var localPedido = new PedidoInsumoDTO
                {
                    Cantidad = p.Cantidad,
                    Precio = p.Precio,
                    InsumoId = p.InsumoId,
                    PedidoId = id
                };
                pedidoInsumoList.Add(localPedido);
            }

            var descripcion = $"Estado de la orden {id} ha sido modificado a Enviada";

            var historialPedido = new HistorialPedido
            {
                FechaCreacion = DateTime.Now,
                Descripcion = descripcion,
                PedidoId = id,
                EstadoPedidoId = 1
            };

            await _unitOfWork.HistorialPedidos.Insert(historialPedido);

            var pedidoInsumo = _mapper.Map<List<PedidoInsumo>>(pedidoInsumoList);
            await _unitOfWork.PedidosInsumos.InsertRange(pedidoInsumo);
            await _unitOfWork.Save();

            var result = new ReturnPedidoDTO
            {
                PedidoId = id,
                Proveedor = new ReturnProveedorDTO { ProveedorId = proveedor.ProveedorId, Nombre = proveedor.Nombre },
                Sucursal = new ReturnSucursalDTO { SucursalId = sucursal.SucursalId, Nombre = sucursal.Nombre },
                Estado = new ReturnEstadoPedidoDTO { EstadoPedidoId = 1, Estado = "Enviada", FechaCreacion = DateTime.Now },
                FechaCreacion = pedidoCreated.FechaCreacion,
                FechaEntrega = pedidoCreated.FechaEntrega,
                CostoPedido = costoPedido,
                CostoTransporte = costoTransporte,
                Total = costoTotal
            };

            return Ok(result);
        }

        //[HttpGet]
        //// Can be used to override global caching on a particular endpoint at any point. 
        //////[HttpCacheExpiration(CacheLocation = CacheLocation.Public, MaxAge = 60)]
        //////[HttpCacheValidation(MustRevalidate = false)]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> GetPedidos()
        //{
        //    var pedidos = await _unitOfWork.Pedidos.GetAll();
        //    var results = _mapper.Map<List<PedidoDTO>>(pedidos);
        //    return Ok(results);
        //}

        //[HttpGet("{id:int}", Name = "GetPedido")]
        //////[ResponseCache(CacheProfileName = "120SecondsDuration")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> GetPedido(int id)
        //{
        //    //throw new Exception("Error message");
        //    var pedido = await _unitOfWork.Pedidos.Get(q => q.PedidoId == id); //, include: q => q.Include(x => x.Sucursales)
        //    var result = _mapper.Map<PedidoDTO>(pedido);
        //    return Ok(result);
        //}

        ////[Authorize(Roles = "Administrator")]
        //[HttpPost]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> CreatePedido([FromBody] PedidoDTO pedidoDTO)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        _logger.LogError($"Invalid POST attempt in {nameof(CreatePedido)}");
        //        return BadRequest(ModelState);
        //    }

        //    var pedido = _mapper.Map<Pedido>(pedidoDTO);
        //    await _unitOfWork.Pedidos.Insert(pedido);
        //    await _unitOfWork.Save();

        //    return CreatedAtRoute("GetPedido", new { id = pedido.PedidoId }, pedido);

        //}

        ////[Authorize]
        //[HttpPut("{id:int}")]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> UpdatePedido(int id, [FromBody] PedidoDTO pedidoDTO)
        //{
        //    if (!ModelState.IsValid || id < 1)
        //    {
        //        _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdatePedido)}");
        //        return BadRequest(ModelState);
        //    }

        //    var pedido = await _unitOfWork.Pedidos.Get(q => q.PedidoId == id);
        //    if (pedido == null)
        //    {
        //        _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdatePedido)}");
        //        return BadRequest("Submitted data is invalid");
        //    }

        //    _mapper.Map(pedidoDTO, pedido);
        //    _unitOfWork.Pedidos.Update(pedido);
        //    await _unitOfWork.Save();

        //    return NoContent();

        //}

        ////[Authorize]
        //[HttpDelete("{id:int}")]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> DeletePedido(int id)
        //{
        //    if (id < 1)
        //    {
        //        _logger.LogError($"Invalid DELETE attempt in {nameof(DeletePedido)}");
        //        return BadRequest();
        //    }

        //    var pedido = await _unitOfWork.Pedidos.Get(q => q.PedidoId == id);
        //    if (pedido == null)
        //    {
        //        _logger.LogError($"Invalid DELETE attempt in {nameof(DeletePedido)}");
        //        return BadRequest("Submitted data is invalid");
        //    }

        //    await _unitOfWork.Pedidos.Delete(id);
        //    await _unitOfWork.Save();

        //    return NoContent();

        //}
    }
}
