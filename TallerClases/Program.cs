using TallerClases.models;

var empleado = new Empleado("Juan", "Perez", "juan_perez@gmail.com", 1500000, 5, 3, 7);
Console.WriteLine($"Hola {empleado.Nombre} {empleado.Apellido} tus deducciones son {empleado.CalcularSueldoEmpleado}");