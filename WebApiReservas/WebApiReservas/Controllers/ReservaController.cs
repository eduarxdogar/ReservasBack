using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiReservas.Models;
using WebApiReservas.Repositorio;

namespace WebApiReservas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private readonly IReservaRepositorio _repositorio;

        public ReservasController(IReservaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpPost]
        public async Task<IActionResult> CrearReserva([FromBody] Reserva reserva)
        {
            var nuevaReserva = await _repositorio.CrearReserva(reserva);
            return CreatedAtAction(nameof(ObtenerReservaPorId), new { id = nuevaReserva.Id }, nuevaReserva);
        }

        [HttpGet]
        public async Task<ActionResult<List<Reserva>>> ObtenerReservas()
        {
            var reservas = await _repositorio.ObtenerReservas();
            return Ok(reservas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reserva>> ObtenerReservaPorId(int id)
        {
            var reserva = await _repositorio.ObtenerReservaPorId(id);
            if (reserva == null)
                return NotFound();
            return Ok(reserva);
        }

        // Implementar ModificarReserva y CancelarReserva
    }
}
