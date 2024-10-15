##  Proyecto: Sistema de Reservas - Backend

Este proyecto es el servicio backend para un sistema de reservas, desarrollado con C# y .NET 8, que proporciona una API REST para gestionar reservas, clientes y servicios.

## Requisitos
.NET SDK 8.0
XAMPP (MySQL)
Visual Studio o cualquier editor compatible con C#
Instalación
Clona el repositorio:

bash
Copiar código
git clone https://github.com/tuusuario/ReservasAppBack.git
Configura la base de datos:

Instala y configura XAMPP para correr MySQL.
Crea una base de datos llamada ReservasDB.
Ejecuta los scripts SQL proporcionados en la carpeta Database para crear las tablas necesarias (Reservas, Clientes, Servicios).
Configura la cadena de conexión:

## En el archivo appsettings.json, actualiza la cadena de conexión:

json
Copiar código
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=ReservasDB;Uid=root;Pwd=;"
}
Restaurar paquetes e iniciar el proyecto:

En la raíz del proyecto, ejecuta:

# bash
Copiar código
dotnet restore
dotnet run
Documentación API:

Puedes acceder a la documentación Swagger en https://localhost:5001/swagger.

# Endpoints


POST /api/reservas - Crear una nueva reserva.
PUT /api/reservas/{id} - Modificar una reserva existente.
DELETE /api/reservas/{id} - Cancelar una reserva.
GET /api/reservas - Ver todas las reservas (con filtros).
