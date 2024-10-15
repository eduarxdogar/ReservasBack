using WebApiReservas.Models;

namespace WebApiReservas.Repositorio
{
    public interface IReservaRepositorio
    {

        Task<Reserva> CrearReserva(Reserva reserva);
        Task<Reserva> ModificarReserva(int id, Reserva reserva);
        Task<bool> CancelarReserva(int id);
        Task<List<Reserva>> ObtenerReservas();
        Task<Reserva> ObtenerReservaPorId(int id);
    }
}
