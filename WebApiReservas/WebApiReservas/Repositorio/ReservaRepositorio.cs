using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiReservas.Data;
using WebApiReservas.Models;
using WebApiReservas.Repositorio;

namespace WebApiReservas.Repositories
{
    public class ReservaRepository : IReservaRepositorio
    {
        private readonly AppDbContext _context;

        public ReservaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Reserva> CrearReserva(Reserva reserva)
        {
            _context.Reservas.Add(reserva);
            await _context.SaveChangesAsync();
            return reserva;
        }

        public async Task<Reserva> ModificarReserva(int id, Reserva reserva)
        {
            var reservaExistente = await _context.Reservas.FindAsync(id);
            if (reservaExistente == null)
                return null;

            reservaExistente.ClienteId = reserva.ClienteId;
            reservaExistente.ServicioId = reserva.ServicioId;
            reservaExistente.FechaReserva = reserva.FechaReserva;

            await _context.SaveChangesAsync();
            return reservaExistente;
        }

        public async Task<bool> CancelarReserva(int id)
        {
            var reserva = await _context.Reservas.FindAsync(id);
            if (reserva == null)
                return false;

            _context.Reservas.Remove(reserva);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Reserva>> ObtenerReservas()
        {
            return await _context.Reservas.ToListAsync();
        }

        public async Task<Reserva> ObtenerReservaPorId(int id)
        {
            return await _context.Reservas.FindAsync(id);
        }
    }
}
