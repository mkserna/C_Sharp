// // Ejercicio 01
// Console.Write("Ingresa un número: ");
// string? numero = Console.ReadLine();
// var numeroConvert = Convert.ToInt32(numero);

// if(numeroConvert > 0) {
//     Console.WriteLine("El número es positivo");
// }else {
//     Console.WriteLine("El número es negativo");
// }

// Ejercicio 02

// // Ejercicio 03
// Console.Write("Ingresa tu edad: "); string? edad = Console.ReadLine();
// var edadConvert = Convert.ToInt32(edad);

// if(edadConvert >= 18) {
//     Console.WriteLine("Eres mayor de edad");
// }else {
//     Console.WriteLine("Eres menor de edad");
// }

// Ejercicio 04
// Console.Write("Ingresa un número para saber su día: ");
// string? dia = Console.ReadLine();
// var diaConvert = Convert.ToInt32(dia);

// switch(diaConvert) {
//     case 1:
//     Console.WriteLine("Lunes");
//     break;

//     case 2:
//     Console.WriteLine("Martes");
//     break;

//     case 3:
//     Console.WriteLine("Miercoles");
//     break;

//     case 4:
//     Console.WriteLine("Jueves");
//     break;

//     case 5:
//     Console.WriteLine("Viernes");
//     break;

//     case 6:
//     Console.WriteLine("Sabado");
//     break;

//     case 7:
//     Console.WriteLine("Domingo");
//     break;

//     default:
//     Console.WriteLine("No es un día de la semana");
//     break;
// }

// Ejercicio 05

// Console.Write("Ingresa tu nacionalidad: ");
// string? nacionalidad = Console.ReadLine();
// string estandar = nacionalidad.ToLower();
// var condicionalNacionalidad = estandar == "colombiana" ? "Nativo" : "Extrenjero";
// Console.WriteLine($"Eres {condicionalNacionalidad}");

// Ejercicio 06

// Console.Write("Ingresa tres números: ");
// int number01 = Convert.ToInt32(Console.ReadLine());
// int number02 = Convert.ToInt32(Console.ReadLine());
// int number03 = Convert.ToInt32(Console.ReadLine());

// if (number01 > number02 && number01 > number03) {
//     Console.WriteLine($"El numero mayor es {number01}");
// } else if (number02 > number01 && number02 > number03){
//     Console.WriteLine($"El numero mayor es {number02}");
// } else {
//     Console.WriteLine($"El numero mayor es {number03}");
// }

// Ejercicio 07
// Console.Write("Ingresa tu contraseña: ");
// string? password = Console.ReadLine();

// if (string.IsNullOrEmpty(password)) {
//     Console.WriteLine("La contraseña no puede estar vacía");
// } else {
//     Console.WriteLine("Contraseña correcta");
// }

// Ejercicio 08

// Console.Write("Ingresa un número para saber su mes: ");
// string? mes = Console.ReadLine();
// var mesConvert = Convert.ToInt32(mes);

// switch(mesConvert) {
//     case 1:
//     Console.WriteLine("Enero");
//     break;

//     case 2:
//     Console.WriteLine("Febrero");
//     break;

//     case 3:
//     Console.WriteLine("Marzo");
//     break;

//     case 4:
//     Console.WriteLine("Abril");
//     break;

//     case 5:
//     Console.WriteLine("Mayo");
//     break;

//     case 6:
//     Console.WriteLine("Junio");
//     break;

//     case 7:
//     Console.WriteLine("Julio");
//     break;

//     case 8:
//     Console.WriteLine("Agosto");
//     break;

//     case 9:
//     Console.WriteLine("Septiembre");
//     break;

//     case 10:
//     Console.WriteLine("Octubre");
//     break;

//     case 11:
//     Console.WriteLine("Noviembre");
//     break;

//     case 12:
//     Console.WriteLine("Diciembre");
//     break;

//     default:
//     Console.WriteLine("No es un mes del año");
//     break;
// }

// Ejercicio 9

// Console.Write("Ingresa tu calificación numérica: ");
// double calificacion = double.Parse(Console.ReadLine());

// if (calificacion >= 90.00 && calificacion <= 100.00){
//     Console.WriteLine("Tu calificación sería 'A'");
// } else if (calificacion >= 80.00){
//     Console.WriteLine("Tu calificación sería 'B'");
// } else if (calificacion >=70.00){
//     Console.WriteLine("Tu calificación sería 'C'");
// } else if (calificacion >=60.00){
//     Console.WriteLine("Tu calificación sería 'D'");
// } else {
//     Console.WriteLine("Tu calificación sería 'F'");
// }

// Ejercicio 10

// Console.Write("Escribe una letra: ");
// char letra = Convert.ToChar(Console.ReadLine());


// switch(letra){

//     case 'a':
//     case 'e':
//     case 'i':
//     case 'o':
//     case 'u':
//     Console.WriteLine("Es una vocal");
//     break;

//     default:
//     Console.WriteLine("Es una consonante");
//     break;
// }

// // Ejercicio 11
// Console.Write("Ingresa dos números: ");
// int num1 = int.Parse(Console.ReadLine());
// int num2 = int.Parse(Console.ReadLine());

// if (num1 == num2){
//     Console.WriteLine("Los números son iguales");
// }else {
//     Console.WriteLine("Los números son diferentes");
// }

// Ejercicio 12

// Console.Write("Ingresa tu dirección: ");
// string? address = Console.ReadLine();

// if (string.IsNullOrEmpty(address)) {
//     Console.WriteLine("La dirección no puede estar vacía");
// } else if (address.Contains("   ")) {
//     Console.WriteLine("Ingrese una dirección");
// } else {
//     Console.WriteLine("La dirección es correcta");
// }

// Ejercicio 13

// Console.Write("Ingresa un número: ");
// int num = int.Parse(Console.ReadLine());

// if (num == 0){
//     Console.WriteLine("El número es cero");
// } else if (num > 0) {
//     Console.WriteLine("El número es positivo");
// } else {
//     Console.WriteLine("El número es negativo");
// }

// Ejercicio 14

// Console.Write("Escribe una vocal: ");
// char letra = Convert.ToChar(Console.ReadLine());


// switch(letra){

//     case 'a':
//     case 'e':
//     case 'i':
//     case 'o':
//     case 'u':
//     Console.WriteLine("Es una vocal");
//     break;

//     default:
//     Console.WriteLine("Ingresa una vocal");
//     break;
// }

// Ejercicio 15

// Console.Write("Ingresa  una temperatura en grados Celsius: ");
// double celsius = double.Parse(Console.ReadLine());

// if  (celsius >= 30){
//     Console.WriteLine("La temperatura es alta");
// } else if ( celsius >= 10 && celsius <= 29) {
//     Console.WriteLine("La temperatura es normal");
// } else {
//     Console.WriteLine("La temperatura es baja");
// }

// Ejercicio 16 

// Console.Write("Ingresa un año para saber si es bisiesto: ");
// int year = int.Parse(Console.ReadLine());

// if (year % 4 == 0){
//     Console.WriteLine("El año es bisiesto");
// } else {
//     Console.WriteLine("El año no es bisiesto");
// }

// Ejercicio 17

// Console.Write("Ingresa un número: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (string.IsNullOrEmpty(num)) {
//     Console.WriteLine("El número no puede estar vacío");
// } else if (num.Contains("   ")) {
//     Console.WriteLine("Ingrese una número");
// } else {
//     Console.WriteLine("El número es correcto");
// }

// Ejercicio 18 

Console.Write("Ingresa un número para saber su día laboral: ");
string? dia = Console.ReadLine();
var diaConvert = Convert.ToInt32(dia);

switch(diaConvert) {
    case 1:
    Console.WriteLine("Lunes. Debes trabajar");
    break;

    case 2:
    Console.WriteLine("Martes. Debes trabajar");
    break;

    case 3:
    Console.WriteLine("Miercoles. Debes trabajar");
    break;

    case 4:
    Console.WriteLine("Jueves. Debes trabajar");
    break;

    case 5:
    Console.WriteLine("Viernes. Debes trabajar");
    break;

    case 6:
    Console.WriteLine("Sabado. Puedes descansar");
    break;

    case 7:
    Console.WriteLine("Domingo. Puedes descansar");
    break;

    default:
    Console.WriteLine("No es un día de la semana");
    break;
}


