// // 1. Escribe un programa que imprima los números del 1 al 100 usando un ciclo for.

// for (int i = 1; i <= 100; i++){
//     Console.WriteLine(i);
// }


// // 2. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los
// // números pares desde 1 hasta ese número usando un ciclo for.

// Console.Write("Ingresa un número entero positivo: ");
// int numero = int.Parse(Console.ReadLine());

// for (int i = 0; i <= numero; i+=2){
//     Console.WriteLine(i);
// }

// // 3. Escribe un programa que pida al usuario un número entero positivo e imprima la tabla de
// // multiplicar de ese número del 1 al 10 usando un ciclo for.

// Console.Write("Ingrese un número entero positivo: ");
// int numeroTablas = int.Parse(Console.ReadLine());

// if (numeroTablas < 0){
//     Console.WriteLine("Ingrese un número positivo");
    
// } else if (numeroTablas % 2 == 0) {
//     for (int i = 1; i <= 10; i++){
//         Console.WriteLine($"{numeroTablas} X {i} = " + numeroTablas * i);
//     }
// }else {
//     Console.WriteLine("Ingrese un número par");
// }

// // 4. Escribe un programa que genere un número aleatorio entre 1 y 100. Pídele al usuario que
// // adivine el número. Muestra un mensaje indicando si el número ingresado es demasiado
// // alto, demasiado bajo o correcto. Continúa pidiendo al usuario que adivine hasta que
// // adivine correctamente usando un ciclo do-while.

// Random random = new();
// int randomNumero = random.Next(1, 100);

// do{
//     Console.Write("Adivina el número oculto entre 1 y 100: ");
//     int numeroUsuario = int.Parse(Console.ReadLine());

//     if (numeroUsuario == randomNumero){
//         Console.WriteLine($"¡Felicidades! Adivinaste el número {randomNumero}");
//         break;
//     }

//     if (numeroUsuario > randomNumero) {
//         Console.WriteLine($"Tu número {numeroUsuario} está por encima del número oculto");
//     } else if (numeroUsuario < randomNumero) {
//         Console.WriteLine($"Tu número {numeroUsuario} está por debajo del número oculto");
//     }

// } while(true);

// 5. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los
// números impares desde ese número hasta 1 usando un ciclo while.

// Console.Write("Ingresa un número entero positivo: ");
// int numeroImpar = int.Parse(Console.ReadLine());

// if(numeroImpar <= 0){
//     Console.Write("Ingrese un número positivo. ");
// }
// else if (numeroImpar % 2 != 0){
//     Console.Write("Ingrese un número par. ");
// } 
// else {
//     int cont = numeroImpar;
 
//     while (cont >= 1)
//             {
//                 if (cont % 2 != 0) 
//                 {
//                     Console.WriteLine(cont);
//                 }
//                 cont--;
//             }
// }

// 6. Escribe un programa que solicite al usuario una contraseña. Si la contraseña ingresada no
// es "secreta", sigue pidiendo al usuario que ingrese la contraseña hasta que sea correcta
// usando un ciclo while.



// 7. Escribe un programa que solicite al usuario un número entero positivo e imprima la
// secuencia de Fibonacci hasta ese número usando un ciclo for.

// Console.Write("Ingrese un número: ");
// int numeroFibonacci = int.Parse(Console.ReadLine());

// for (int i = 0; i <= numeroFibonacci; i++){

// }

// 8. Escribe un programa que solicite al usuario un número entero positivo e imprima si el
// número es primo o no usando un ciclo for.

// 9. Escribe un programa que solicite al usuario una palabra y luego imprima cada letra de la
// palabra en una línea separada usando un ciclo foreach.

// 10. Escribe un programa que solicite al usuario un número entero positivo e imprima la suma
// de todos los números desde 1 hasta ese número usando un ciclo for.