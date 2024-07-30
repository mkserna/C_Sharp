using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop_POO.Models;

namespace Workshop_POO.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = true;
            while (salir)
            {
                Console.WriteLine("");
                Console.WriteLine("|¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|");
                Console.WriteLine("|      ESCUELA JOSÉ MARÍA CORDOVA      |");
                Console.WriteLine("|--------------------------------------|");
                Console.WriteLine("|        1. Seccion de Estudiantes     |");
                Console.WriteLine("|        2. Seccion de Profesores      |");
                Console.WriteLine("|        3. Ver Estadisticas           |");
                Console.WriteLine("|        4. Salir                      |");
                Console.WriteLine("|______________________________________|");
                Console.Write("Ingresa una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        bool salirEstudiante = true;
                        while (salirEstudiante)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("|¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|");
                            Console.WriteLine("|        SECCION DE ESTUDIANTES        |");
                            Console.WriteLine("|--------------------------------------|");
                            Console.WriteLine("|        1. Agregar Estudiante         |");
                            Console.WriteLine("|        2. Mostrar Estudiantes        |");
                            Console.WriteLine("|        3. Editar Estudiante          |");
                            Console.WriteLine("|        4. Eliminar Estudiante        |");
                            Console.WriteLine("|        5. Salir                      |");
                            Console.WriteLine("|______________________________________|");

                            Console.Write("Ingresa una opción: ");
                            int opcionEstudiante = int.Parse(Console.ReadLine());

                            switch (opcionEstudiante)
                            {
                                case 1:
                                    AgregarEstudiante();
                                    break;
                                case 2:
                                    AdministradorApp.MostrarEstudiantes();
                                    break;
                                case 3:
                                    AdministradorApp.ActualizarEstudiante();
                                    break;

                                case 4:
                                    AdministradorApp.EliminarEstudiante();
                                    break;
                                case 5:
                                    salirEstudiante = false;
                                    break;

                                default:
                                    Console.WriteLine("Ingresa una opción válida");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        bool salirProfesor = true;
                        while (salirProfesor)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("|¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|");
                            Console.WriteLine("|        SECCION DE PROFESORES         |");
                            Console.WriteLine("|--------------------------------------|");
                            Console.WriteLine("|          1. Agregar Profesor         |");
                            Console.WriteLine("|          2. Mostrar Profesores       |");
                            Console.WriteLine("|          3. Editar Profesor          |");
                            Console.WriteLine("|          4. Eliminar Profesor        |");
                            Console.WriteLine("|          5. Salir                    |");
                            Console.WriteLine("|--------------------------------------|");
                            Console.WriteLine("");

                            Console.Write("Ingresa una opción: ");
                            int opcionProfesor = int.Parse(Console.ReadLine());

                            switch (opcionProfesor)
                            {
                                case 1:
                                    AgregarProfesor();
                                    break;
                                case 2:
                                    AdministradorApp.MostrarProfesores();
                                    break;
                                case 3:
                                    AdministradorApp.ActualizarProfesor();
                                    break;
                                case 4:
                                    AdministradorApp.EliminarProfesor();
                                    break;
                                case 5:
                                    salirProfesor = false;
                                    break;

                                default:
                                    Console.WriteLine("Ingresa una opción válida");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        bool salirEstadisticas = true;
                        while (salirEstadisticas)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("|¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|");
                            Console.WriteLine("|                      SECCION DE ESTADISTICAS                     |");
                            Console.WriteLine("|------------------------------------------------------------------|");
                            Console.WriteLine("|          1. Estudiantes con promedios superiores a  85%          |");
                            Console.WriteLine("|          2. Profesores que enseñan mas de un curso               |");
                            Console.WriteLine("|          3. Estudiantes mayores de 16 años                       |");
                            Console.WriteLine("|          4. Estudiantes ordenados por apellido (Asendente)       |");
                            Console.WriteLine("|          5. Salario total de todos los profesores                |");
                            Console.WriteLine("|          6. Estudiante con la mayor calificacion                 |");
                            Console.WriteLine("|          7. Cantidad de estudiantes por curso                    |");
                            Console.WriteLine("|          8. Profesores con mas de 10 años de antigüedad          |");
                            Console.WriteLine("|          9. Materias de la escuela                               |");
                            Console.WriteLine("|          10. Estudiantes con nombre 'Maria'                      |");
                            Console.WriteLine("|          11. Profesores ordenados por salario (Desendente)       |");
                            Console.WriteLine("|          12. Promedio de la edad de todos los estudiantes        |");
                            Console.WriteLine("|          13. Profesores que enseñan 'Matematicas'                |");
                            Console.WriteLine("|          14. Estudiantes con mas de 3 calificaciones             |");
                            Console.WriteLine("|          15. Antiguedad promedio de todos los profesores         |");
                            Console.WriteLine("|          16. Salir                                               |");
                            Console.WriteLine("|__________________________________________________________________|");
                            Console.WriteLine("");

                            Console.Write("Ingresa una opción: ");
                            int opcionEstadisticas = int.Parse(Console.ReadLine());

                            switch (opcionEstadisticas)
                            {
                                case 1:
                                    AdministradorApp.MostrarEstudiantesConPromedioSuperiorA85();
                                    break;
                                case 2:
                                    AdministradorApp.MostrarProfesoresQueEnsenanMasDeUnCurso();
                                    break;
                                case 3:
                                    AdministradorApp.MostrarEstudiantesMayoresDe16Anos();
                                    break;
                                case 4:
                                    AdministradorApp.MostrarEstudiantesOrdenadosPorApellido();
                                    break;
                                case 5:
                                    AdministradorApp.MostrarSalarioTotalDeTodosLosProfesores();
                                    break;
                                case 6:
                                    AdministradorApp.MostrarEtudianteConMayorCalificacion();
                                    break;
                                case 7:
                                    AdministradorApp.MostrarCantidadDeEstudiantesPorCurso();
                                    break;
                                case 8:
                                    AdministradorApp.MostrarProfesoresConMasDe10AniosDeAntiguedad();
                                    break;
                                case 9:
                                    AdministradorApp.MostrarMateriasDeLaEscuela();
                                    break;
                                case 10:
                                    AdministradorApp.MostrarEstudiantesConNombreMaria();
                                    break;
                                case 11:
                                    AdministradorApp.MostrarProfesoresOrdenadosPorSalario();
                                    break;
                                case 12:
                                    AdministradorApp.MostrarPromedioDeLaEdadDeTodosLosEstudiantes();
                                    break;
                                case 13:
                                    AdministradorApp.MostrarProfesoresQueEnsenanMatematicas();
                                    break;
                                case 14:
                                    AdministradorApp.MostrarEstudiantesConMasDe3Calificaciones();
                                    break;
                                case 15:
                                    AdministradorApp.MostrarAntiguedadPromedioDeTodosLosProfesores();
                                    break;
                                case 16:
                                    salirEstadisticas = false;
                                    break;

                                default:
                                    Console.WriteLine("Ingresa una opción válida");
                                    break;
                            }
                        }
                        break;
                    case 4:
                        salir = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }
        public static void AgregarEstudiante()
        {
            Console.Write("Nombre: "); string? Nombre = Console.ReadLine();
            Nombre = Nombre.Trim();

            Console.Write($"Apellido: "); string? Apellido = Console.ReadLine();
            Apellido = Apellido.Trim();

            Console.Write($"Tipo de documento: "); string? TipoDeDocumento = Console.ReadLine();
            TipoDeDocumento = TipoDeDocumento.Trim();

            Console.Write($"Numero de documento: "); string? NumeroDocumento = Console.ReadLine();
            NumeroDocumento = NumeroDocumento.Trim();

            Console.Write($"Email: "); string? Email = Console.ReadLine();
            Email = Email.Trim();

            Console.Write($"Telefono: "); string? Telefono = Console.ReadLine();
            Telefono = Telefono.Trim();

            Console.Write($"Nombre del Acudiente: "); string? NombreAcudiente = Console.ReadLine();
            NombreAcudiente = NombreAcudiente.Trim();

            Console.Write($"Fecha de nacimiento (aaaa/mm/dd): "); string? FechaNacimiento = Console.ReadLine();
            FechaNacimiento = FechaNacimiento.Trim();
            DateOnly fechaNacimientoParseada = DateOnly.Parse(FechaNacimiento);

            Console.Write($"Curso actual: "); string? CursoActual = Console.ReadLine();
            CursoActual = CursoActual.Trim();

            //Ingresa las calificaciones del estudiante en el curso actual (Ejemplo: 1.0, 2.0, 3.0) 
            Console.Write($"Calificaciones: "); List<double> Calificaciones = new List<double>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Calificacion {i + 1}: "); double calificacion = Convert.ToDouble(Console.ReadLine());
                Calificaciones.Add(calificacion);
            }

            Estudiante Estudiante = new Estudiante(Nombre, Apellido, TipoDeDocumento, NumeroDocumento, Email, Telefono, NombreAcudiente, CursoActual, fechaNacimientoParseada, Calificaciones);

            AdministradorApp.AgregarEstudiante(Estudiante);
        }
        public static void AgregarProfesor()
        {
            Console.Write("Nombre: "); string? Nombre = Console.ReadLine();
            Nombre?.Trim();

            Console.Write($"Apellido: "); string? Apellido = Console.ReadLine();
            Apellido?.Trim();

            Console.Write($"Tipo de documento: "); string? TipoDeDocumento = Console.ReadLine();
            TipoDeDocumento?.Trim();

            Console.Write($"Numero de documento: "); string? NumeroDocumento = Console.ReadLine();
            NumeroDocumento?.Trim();

            Console.Write($"Email: "); string? Email = Console.ReadLine();
            Email?.Trim();

            Console.Write($"Telefono: "); string? Telefono = Console.ReadLine();
            Telefono?.Trim();

            Console.Write($"Fecha de nacimiento (aaaa/mm/dd): "); string? FechaNacimiento = Console.ReadLine();
            FechaNacimiento?.Trim();
            DateOnly fechaNacimientoParseada = DateOnly.Parse(FechaNacimiento);

            Console.Write($"Asignatura: "); string? Asignatura = Console.ReadLine();
            Asignatura?.Trim();

            Console.Write($"Salario: "); double Salario = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Fecha de contratacion: "); string? FechaContratacion = Console.ReadLine();
            FechaContratacion?.Trim();
            DateOnly fechaContratacionParseada = DateOnly.Parse(FechaContratacion);

            List<string> Cursos = new List<string>();

            Profesor nuevoProfesor = new Profesor(Nombre, Apellido, TipoDeDocumento, NumeroDocumento, Email, Telefono, fechaNacimientoParseada, Asignatura, Salario, fechaContratacionParseada, Cursos);

            AdministradorApp.AgregarProfesor(nuevoProfesor);
        }
    }
}