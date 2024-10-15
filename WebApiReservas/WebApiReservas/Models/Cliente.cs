namespace WebApiReservas.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
    }
}
