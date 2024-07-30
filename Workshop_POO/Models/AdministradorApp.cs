using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop_POO.Models
{
    public static class AdministradorApp
    {
        public static List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>{
            new Estudiante("Juan", "Perez", "DNI", "123456789", "juan.perez@gmail.com", "(34) 987654321", "Camilo Perez", "Matematicas",  new DateOnly(1995, 1, 1), new List<double>{90.0, 85.0, 100.0}),

            new Estudiante("Maria", "Lopez", "DNI", "987654321", "maria.lopez@gmail.com", "(34) 123456789", "Maria Lopez", "Física", new DateOnly(1996, 2, 15), new List<double>{40.0, 50.0, 60.0}),

            new Estudiante("Carlos", "Martinez", "DNI", "123123123", "carlos.martinez@gmail.com", "(34) 234567890", "Carlos Martinez", "Química", new DateOnly(1994, 3, 10), new List<double>{75.0, 80.0, 90.0}),

            new Estudiante("Ana", "Garcia", "DNI", "456456456", "ana.garcia@gmail.com", "(34) 345678901", "Ana Garcia", "Historia", new DateOnly(1997, 4, 25), new List<double>{100.0, 100.0, 100.0}),

            new Estudiante("Luis", "Gonzalez", "DNI", "789789789", "luis.gonzalez@gmail.com", "(34) 456789012", "Luis Gonzalez", "Lengua", new DateOnly(1998, 5, 5), new List<double>{45.0, 65.0, 85.0}),
        };
        public static List<Profesor> Profesores { get; set; } = new List<Profesor>{
            new Profesor("Juan", "Perez", "DNI", "123456789", "juan.perez@gmail.com", "(34) 987654321", new DateOnly(1995, 1, 1), "Matematicas", 1.0, new DateOnly(1995, 1, 1), new List<string>{"Matemáticas", "Física", "Química", "Historia", "Lengua", "Biología", "Infirmática", "Educación Física"}),

            new Profesor("Maria", "Lopez", "DNI", "987654321", "maria.lopez@gmail.com", "(34) 123456789", new DateOnly(1996, 2, 15), "Física", 4.0, new DateOnly(1996, 2, 15), new List<string>{"Matemáticas", "Física", "Química", "Historia", "Lengua", "Biología", "Infirmática", "Educación Física"}),

            new Profesor("Carlos", "Martinez", "DNI", "123123123", "carlos.martinez@gmail.com", "(34) 234567890", new DateOnly(1994, 3, 10), "Química", 7.0, new DateOnly(1994, 3, 10), new List<string>{"Matemáticas", "Física", "Química", "Historia", "Lengua", "Biología", "Infirmática", "Educación Física"}),
        };

        //**************************SECCION ESTUDIANTES*****************************
        //metodo AgregarEstudiante
        public static void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
            Console.WriteLine("Estudiante agregado con éxito");
        }

        //metodo MostrarEstudiantes
        public static void MostrarEstudiantes()
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine($"-------------------------- INFORMACION DEL ESTUDIANTE -------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------");
            foreach (Estudiante estudiante in Estudiantes)
            {
                estudiante.MostrarInformacionEstudiante();
            }
        }

        //Metodo EliminarEstudiante por numero de documento
        public static void EliminarEstudiante()
        {
            MostrarEstudiantes();

            Console.WriteLine("");
            Console.Write("Ingrese el numero de documento del estudiante a eliminar: "); string? numeroDocumento = Console.ReadLine();
            numeroDocumento = numeroDocumento.Trim();

            Estudiante estudiante = Estudiantes.Find(x => x.GetNumeroDocumento() == numeroDocumento);
            if (estudiante != null)
            {
                Estudiantes.Remove(estudiante);
                Console.WriteLine("");
                Console.WriteLine("Estudiante eliminado con éxito");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Estudiante no encontrado");
            }
        }

        //Metodo ActualizarEstudiante por numero de documento
        public static void ActualizarEstudiante()
        {
            MostrarEstudiantes();
            Console.WriteLine("Ingresa el numero de documento del estudiante a editar: "); string? numeroDocumento = Console.ReadLine();


            Estudiante estudiante = Estudiantes.Find(x => x.GetNumeroDocumento() == numeroDocumento);

            if (estudiante != null)
            {

                Console.Write($"Ingresa el nuevo nombre o presiona Intro para mantener el mismo ({estudiante.GetNombre()}): "); string? nombre = Console.ReadLine();

                Console.Write($"Ingresa el nuevo apellido o presiona Intro para mantener el mismo ({estudiante.GetApellido()}): "); string? apellido = Console.ReadLine();

                Console.Write($"Ingresa el nuevo tipo de documento o presiona Intro para mantener el mismo ({estudiante.GetTipoDeDocumento()}): "); string? tipoDeDocumento = Console.ReadLine();

                Console.Write($"Ingresa el nuevo número de documento o presiona Intro para mantener el mismo ({estudiante.GetNumeroDocumento()}): "); string? numeroDocumentoNuevo = Console.ReadLine();

                Console.Write($"Ingresa el nuevo correo electrónico o presiona Intro para mantener el mismo ({estudiante.GetEmail()}): "); string? email = Console.ReadLine();

                Console.Write($"Ingresa el nuevo número de Celular o presiona Intro para mantener el mismo ({estudiante.GetTelefono()}): "); string? telefono = Console.ReadLine();

                Console.Write($"Ingresa el nuevo nombre del acudiente o presiona Intro para mantener el mismo ({estudiante.NombreAcudiente}): "); string? nombreAcudiente = Console.ReadLine();

                Console.Write($"Ingresa el nuevo curso actual o presiona Intro para mantener el mismo ({estudiante.CursoActual}): "); string? cursoActual = Console.ReadLine();


                DateOnly fechaNacimiento = InputDateOnly($"Ingresa la nueva fecha de nacimiento o presiona Intro para mantener el mismo ({estudiante.FechaNacimiento}): ");


                estudiante.SetNombre(string.IsNullOrEmpty(nombre) ? estudiante.GetNombre() : nombre);
                estudiante.SetApellido(string.IsNullOrEmpty(apellido) ? estudiante.GetApellido() : apellido);
                estudiante.SetTipoDeDocumento(string.IsNullOrEmpty(tipoDeDocumento) ? estudiante.GetTipoDeDocumento() : tipoDeDocumento);
                estudiante.SetNumeroDocumento(string.IsNullOrEmpty(numeroDocumentoNuevo) ? estudiante.GetNumeroDocumento() : numeroDocumentoNuevo);
                estudiante.SetEmail(string.IsNullOrEmpty(email) ? estudiante.GetEmail() : email);
                estudiante.SetTelefono(string.IsNullOrEmpty(telefono) ? estudiante.GetTelefono() : telefono);
                estudiante.NombreAcudiente = string.IsNullOrEmpty(nombreAcudiente) ? estudiante.NombreAcudiente : nombreAcudiente;
                estudiante.CursoActual = string.IsNullOrEmpty(cursoActual) ? estudiante.CursoActual : cursoActual;
                estudiante.FechaNacimiento = fechaNacimiento == default ? estudiante.FechaNacimiento : fechaNacimiento;


                Console.WriteLine("");
                Console.WriteLine("Estudiante actualizado con éxito!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Numero de documento inválido. Por favor, inténtalo de nuevo.");
                return;
            }



        }
        //****************************************************************************

        //**************************SECCION PROFESORES********************************
        //metodo AgregarProfesor
        public static void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
            Console.WriteLine("Profesor agregado con éxito");
        }

        //metodo MostrarProfesores
        public static void MostrarProfesores()
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine($"-------------------------- INFORMACION DEL PROFESOR ---------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------");
            foreach (Profesor profesor in Profesores)
            {
                profesor.MostrarInformacionProfesor();
            }
        }

        //Metodo EliminarProfesor por numero de documento
        public static void EliminarProfesor()
        {
            MostrarProfesores();

            Console.WriteLine("");
            Console.Write("Ingrese el numero de documento del profesor a eliminar: "); string? numeroDocumento = Console.ReadLine();
            numeroDocumento = numeroDocumento.Trim();

            Profesor profesor = Profesores.Find(x => x.GetNumeroDocumento() == numeroDocumento);
            if (profesor != null)
            {
                Profesores.Remove(profesor);
                Console.WriteLine("");
                Console.WriteLine("Profesor eliminado con éxito");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Profesor no encontrado");
            }
        }

        //Metodo editarProfesor por numero de documento
        public static void ActualizarProfesor()
        {
            MostrarProfesores();
            Console.WriteLine("Ingresa el numero de documento del profesor a editar: "); string? numeroDocumento = Console.ReadLine();

            Profesor profesor = Profesores.Find(x => x.GetNumeroDocumento() == numeroDocumento);

            if (profesor != null)
            {
                Console.Write($"Ingresa el nuevo nombre o presiona Intro para mantener el mismo ({profesor.GetNombre()}): "); string? nombre = Console.ReadLine();

                Console.Write($"Ingresa el nuevo apellido o presiona Intro para mantener el mismo ({profesor.GetApellido()}): "); string? apellido = Console.ReadLine();

                Console.Write($"Ingresa el nuevo tipo de documento o presiona Intro para mantener el mismo ({profesor.GetTipoDeDocumento()}): "); string? tipoDeDocumento = Console.ReadLine();

                Console.Write($"Ingresa el nuevo número de documento o presiona Intro para mantener el mismo ({profesor.GetNumeroDocumento()}): "); string? numeroDocumentoNuevo = Console.ReadLine();

                Console.Write($"Ingresa el nuevo correo electrónico o presiona Intro para mantener el mismo ({profesor.GetEmail()}): "); string? email = Console.ReadLine();

                Console.Write($"Ingresa el nuevo número de Celular o presiona Intro para mantener el mismo ({profesor.GetTelefono()}): "); string? telefono = Console.ReadLine();

                Console.Write($"Ingresa la nueva asignatura o presiona Intro para mantener el mismo ({profesor.Asignatura}): "); string? asignatura = Console.ReadLine();

                DateOnly fechaContratacion = InputDateOnly($"Ingresa la nueva fecha de contratación o presiona Intro para mantener el mismo ({profesor.FechaContratacion}): ");


                profesor.SetNombre(string.IsNullOrEmpty(nombre) ? profesor.GetNombre() : nombre);
                profesor.SetApellido(string.IsNullOrEmpty(apellido) ? profesor.GetApellido() : apellido);
                profesor.SetTipoDeDocumento(string.IsNullOrEmpty(tipoDeDocumento) ? profesor.GetTipoDeDocumento() : tipoDeDocumento);
                profesor.SetNumeroDocumento(string.IsNullOrEmpty(numeroDocumentoNuevo) ? profesor.GetNumeroDocumento() : numeroDocumentoNuevo);
                profesor.SetEmail(string.IsNullOrEmpty(email) ? profesor.GetEmail() : email);
                profesor.SetTelefono(string.IsNullOrEmpty(telefono) ? profesor.GetTelefono() : telefono);
                profesor.Asignatura = string.IsNullOrEmpty(asignatura) ? profesor.Asignatura : asignatura;
                profesor.FechaContratacion = fechaContratacion == default ? profesor.FechaContratacion : fechaContratacion;


                Console.WriteLine("");
                Console.WriteLine("Estudiante actualizado con éxito!");
                Console.WriteLine("");
            }
            else if (numeroDocumento == null || numeroDocumento.Length == 0)
            {
                Console.WriteLine("Numero de documento inválido. Por favor, inténtalo de nuevo.");
                return;
            }
        }
        public static DateOnly InputDateOnly(string prompt)
        {
            Console.Write(prompt);
            DateTime tempDateTime;
            while (!DateTime.TryParse(Console.ReadLine(), out tempDateTime))
            {
                Console.WriteLine("Por favor, ingresa una fecha válida:");
                Console.Write(prompt);
            }
            return DateOnly.FromDateTime(tempDateTime);
        }
        //****************************************************************************

        //**************************SECCION ESTADISTICAS*****************************

        //Metodo Estudiantes con promedios superiores a  85%
        public static void MostrarEstudiantesConPromedioSuperiorA85()
        {
            foreach (Estudiante estudiante in Estudiantes)
            {
                if (estudiante.CalcularCalificaciones(estudiante.Calificaciones) > 85)
                {
                    Console.WriteLine("-------------------------Estudiantes con promedio superior a 85%-------------------");
                    Console.WriteLine($"Nombre: {estudiante.GetNombre()}");
                    Console.WriteLine($"Apellido: {estudiante.GetApellido()}");
                    Console.WriteLine($"Tipo de documento: {estudiante.GetTipoDeDocumento()}");
                    Console.WriteLine($"Numero de documento: {estudiante.GetNumeroDocumento()}");
                    Console.WriteLine($"Email: {estudiante.GetEmail()}");
                    Console.WriteLine($"Telefono: {estudiante.GetTelefono()}");
                    Console.WriteLine($"Nombre del acudidente: {estudiante.NombreAcudiente}");
                    Console.WriteLine($"Curso actual: {estudiante.CursoActual}");
                    Console.WriteLine($"Fecha de nacimiento: {estudiante.FechaNacimiento}");
                    Console.WriteLine($"Calificaciones: {string.Join(", ", estudiante.Calificaciones)}");
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
            }
        }

        //Metodo Profesores que enseñan mas de un curso
        public static void MostrarProfesoresQueEnsenanMasDeUnCurso()
        {
            foreach (Profesor profesor in Profesores)
            {
                if (profesor.Cursos.Count > 1)
                {
                    Console.WriteLine($"Nombre: {profesor.GetNombre()}");
                    Console.WriteLine($"Apellido: {profesor.GetApellido()}");
                    Console.WriteLine($"Tipo de documento: {profesor.GetTipoDeDocumento()}");
                    Console.WriteLine($"Numero de documento: {profesor.GetNumeroDocumento()}");
                    Console.WriteLine($"Email: {profesor.GetEmail()}");
                    Console.WriteLine($"Telefono: {profesor.GetTelefono()}");
                    Console.WriteLine($"Asignatura: {profesor.Asignatura}");
                    Console.WriteLine($"Fecha de contratacion: {profesor.FechaContratacion}");
                    Console.WriteLine($"Salario: ${profesor.GetSalario()}");
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
            }
        }

        //Metodo Estudiantes mayores de 16 años
        public static void MostrarEstudiantesMayoresDe16Anos()
        {
            foreach (Estudiante estudiante in Estudiantes)
            {
                if (estudiante.CalcularEdad() >= 16)
                {
                    Console.WriteLine($"Nombre: {estudiante.GetNombre()}");
                    Console.WriteLine($"Apellido: {estudiante.GetApellido()}");
                    Console.WriteLine($"Tipo de documento: {estudiante.GetTipoDeDocumento()}");
                    Console.WriteLine($"Numero de documento: {estudiante.GetNumeroDocumento()}");
                    Console.WriteLine($"Email: {estudiante.GetEmail()}");
                    Console.WriteLine($"Telefono: {estudiante.GetTelefono()}");
                    Console.WriteLine($"Nombre del acudidente: {estudiante.NombreAcudiente}");
                    Console.WriteLine($"Curso actual: {estudiante.CursoActual}");
                    Console.WriteLine($"Fecha de nacimiento: {estudiante.FechaNacimiento}");
                    Console.WriteLine($"Calificaciones: {string.Join(", ", estudiante.Calificaciones)}");
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
            }
        }

        //  Metodo Estudiantes ordenados por apellido (Asendente)
        public static void MostrarEstudiantesOrdenadosPorApellido()
        {
            foreach (Estudiante estudiante in Estudiantes.OrderBy(x => x.GetApellido()))
            {
                Console.WriteLine($"Nombre: {estudiante.GetNombre()}");
                Console.WriteLine($"Apellido: {estudiante.GetApellido()}");
                Console.WriteLine($"Tipo de documento: {estudiante.GetTipoDeDocumento()}");
                Console.WriteLine($"Numero de documento: {estudiante.GetNumeroDocumento()}");
                Console.WriteLine($"Email: {estudiante.GetEmail()}");
                Console.WriteLine($"Telefono: {estudiante.GetTelefono()}");
                Console.WriteLine($"Nombre del acudidente: {estudiante.NombreAcudiente}");
                Console.WriteLine($"Curso actual: {estudiante.CursoActual}");
                Console.WriteLine($"Fecha de nacimiento: {estudiante.FechaNacimiento}");
                Console.WriteLine($"Calificaciones: {string.Join(", ", estudiante.Calificaciones)}");
                Console.WriteLine("-----------------------------------------------------------------------------------");
            }
        }

        //Metodo Salario total de todos los profesores
        public static void MostrarSalarioTotalDeTodosLosProfesores()
        {
            double totalSalario = 0;

            foreach (Profesor profesor in Profesores)
            {
                totalSalario += profesor.GetSalario();
            }

            Console.WriteLine($"El salario total de todos los profesores es de ${totalSalario}");
        }

        //Metodo Estudiante con la mayor calificacion 
        public static void MostrarEtudianteConMayorCalificacion()
        {
            double calificacionMaxima = 0;
            Estudiante estudianteMaxima = null;

            foreach (Estudiante estudiante in Estudiantes)
            {
                if (estudiante.Calificaciones.Max() > calificacionMaxima)
                {
                    calificacionMaxima = estudiante.Calificaciones.Max();
                    estudianteMaxima = estudiante;
                }
            }

            Console.WriteLine($"El estudiante con la mayor calificacion es {estudianteMaxima.GetNombre()}");
        }

        //Metodo Cantidad de estudiantes por curso
        public static void MostrarCantidadDeEstudiantesPorCurso()
        {
            Dictionary<string, int> cursos = new Dictionary<string, int>();

            foreach (Estudiante estudiante in Estudiantes)
            {
                cursos.Add(estudiante.CursoActual, cursos[estudiante.CursoActual] + 1);
            }

            foreach (KeyValuePair<string, int> curso in cursos)
            {
                Console.WriteLine($"Curso: {curso.Key}");
                Console.WriteLine($"Cantidad de estudiantes: {curso.Value}");
                Console.WriteLine("-----------------------------------------------------------------------------------");
            }
        }

        //Metodo Profesores con mas de 10 años de antigüedad
        public static void MostrarProfesoresConMasDe10AniosDeAntiguedad()
        {
            foreach (Profesor profesor in Profesores)
            {
                if (profesor.CalcularAntiguedad() >= 10)
                {
                    Console.WriteLine($"Nombre: {profesor.GetNombre()}");
                    Console.WriteLine($"Apellido: {profesor.GetApellido()}");
                    Console.WriteLine($"Tipo de documento: {profesor.GetTipoDeDocumento()}");
                    Console.WriteLine($"Numero de documento: {profesor.GetNumeroDocumento()}");
                    Console.WriteLine($"Email: {profesor.GetEmail()}");
                    Console.WriteLine($"Telefono: {profesor.GetTelefono()}");
                    Console.WriteLine($"Asignatura: {profesor.Asignatura}");
                    Console.WriteLine($"Fecha de contratacion: {profesor.FechaContratacion}");
                    Console.WriteLine($"Salario: ${profesor.GetSalario()}");
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
            }
        }


        //Metodo Materias de la escuela 
        public static void MostrarMateriasDeLaEscuela()
        {
            foreach (Profesor profesor in Profesores)
            {
                Console.WriteLine($"{profesor.Cursos}");
            }
        }

        //Metodo Estudiantes con nombre 'Maria'
        public static void MostrarEstudiantesConNombreMaria()
        {
            foreach (Estudiante estudiante in Estudiantes)
            {
                if (estudiante.GetNombre() == "Maria")
                {
                    Console.WriteLine($"Nombre: {estudiante.GetNombre()}");
                    Console.WriteLine($"Apellido: {estudiante.GetApellido()}");
                    Console.WriteLine($"Tipo de documento: {estudiante.GetTipoDeDocumento()}");
                    Console.WriteLine($"Numero de documento: {estudiante.GetNumeroDocumento()}");
                    Console.WriteLine($"Email: {estudiante.GetEmail()}");
                    Console.WriteLine($"Telefono: {estudiante.GetTelefono()}");
                    Console.WriteLine($"Nombre del acudidente: {estudiante.NombreAcudiente}");
                    Console.WriteLine($"Curso actual: {estudiante.CursoActual}");
                    Console.WriteLine($"Fecha de nacimiento: {estudiante.FechaNacimiento}");
                    Console.WriteLine($"Calificaciones: {string.Join(", ", estudiante.Calificaciones)}");
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
            }
        }

        //Metodo Profesores ordenados por salario (Desendente)
        public static void MostrarProfesoresOrdenadosPorSalario()
        {
            foreach (Profesor profesor in Profesores.OrderByDescending(x => x.GetSalario()))
            {
                Console.WriteLine($"Nombre: {profesor.GetNombre()}");
                Console.WriteLine($"Apellido: {profesor.GetApellido()}");
                Console.WriteLine($"Tipo de documento: {profesor.GetTipoDeDocumento()}");
                Console.WriteLine($"Numero de documento: {profesor.GetNumeroDocumento()}");
                Console.WriteLine($"Email: {profesor.GetEmail()}");
                Console.WriteLine($"Telefono: {profesor.GetTelefono()}");
                Console.WriteLine($"Asignatura: {profesor.Asignatura}");
                Console.WriteLine($"Fecha de contratacion: {profesor.FechaContratacion}");
                Console.WriteLine($"Salario: ${profesor.GetSalario()}");
                Console.WriteLine("-----------------------------------------------------------------------------------");
            }
        }

        //Metodo Promedio de la edad de todos los estudiantes
        public static void MostrarPromedioDeLaEdadDeTodosLosEstudiantes()
        {
            double promedioEdad = 0;

            foreach (Estudiante estudiante in Estudiantes)
            {
                promedioEdad += estudiante.CalcularEdad();
            }

            promedioEdad /= Estudiantes.Count;
            Console.WriteLine($"El promedio de la edad de todos los estudiantes es de {promedioEdad}");
        }

        //Metodo Profesores que enseñan 'Matematicas' 
        public static void MostrarProfesoresQueEnsenanMatematicas()
        {
            foreach (Profesor profesor in Profesores)
            {
                if (profesor.Asignatura == "Matematicas")
                {
                    Console.WriteLine($"Nombre: {profesor.GetNombre()}");
                    Console.WriteLine($"Apellido: {profesor.GetApellido()}");
                    Console.WriteLine($"Tipo de documento: {profesor.GetTipoDeDocumento()}");
                    Console.WriteLine($"Numero de documento: {profesor.GetNumeroDocumento()}");
                    Console.WriteLine($"Email: {profesor.GetEmail()}");
                    Console.WriteLine($"Telefono: {profesor.GetTelefono()}");
                    Console.WriteLine($"Asignatura: {profesor.Asignatura}");
                    Console.WriteLine($"Fecha de contratacion: {profesor.FechaContratacion}");
                    Console.WriteLine($"Salario: ${profesor.GetSalario()}");
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
            }
        }

        //Metodo Estudiantes con mas de 3 calificaciones
        public static void MostrarEstudiantesConMasDe3Calificaciones()
        {
            foreach (Estudiante estudiante in Estudiantes)
            {
                if (estudiante.Calificaciones.Count >= 3)
                {
                    Console.WriteLine($"Nombre: {estudiante.GetNombre()}");
                    Console.WriteLine($"Apellido: {estudiante.GetApellido()}");
                    Console.WriteLine($"Tipo de documento: {estudiante.GetTipoDeDocumento()}");
                    Console.WriteLine($"Numero de documento: {estudiante.GetNumeroDocumento()}");
                    Console.WriteLine($"Email: {estudiante.GetEmail()}");
                    Console.WriteLine($"Telefono: {estudiante.GetTelefono()}");
                    Console.WriteLine($"Nombre del acudidente: {estudiante.NombreAcudiente}");
                    Console.WriteLine($"Curso actual: {estudiante.CursoActual}");
                    Console.WriteLine($"Fecha de nacimiento: {estudiante.FechaNacimiento}");
                    Console.WriteLine($"Calificaciones: {string.Join(", ", estudiante.Calificaciones)}");
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
            }
        }

        //Metodo Antiguedad promedio de todos los profesores
        public static void MostrarAntiguedadPromedioDeTodosLosProfesores()
        {
            double promedioAntiguedad = 0;

            foreach (Profesor profesor in Profesores)
            {
                promedioAntiguedad += profesor.CalcularAntiguedad();
            }

            promedioAntiguedad /= Profesores.Count;
            Console.WriteLine($"El promedio de la antiguedad de todos los profesores es de {promedioAntiguedad}");
        }

    }
}