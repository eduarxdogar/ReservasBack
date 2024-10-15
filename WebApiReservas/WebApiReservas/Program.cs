using Microsoft.EntityFrameworkCore;
using WebApiReservas.Data;
using WebApiReservas.Repositories;
using WebApiReservas.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql("Reservas")); // O la conexión a tu base de datos XAMPP

builder.Services.AddScoped<IReservaRepositorio, ReservaRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

app.Run();
