namespace WebApiReservas.Models
{
    public class Reserva
    {
        internal object FechaReserva;

        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ServicioId { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public Servicio Servicio { get; set; }
    }
}
