namespace WebApiReservas.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
    }
}
