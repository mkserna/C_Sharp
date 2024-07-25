/*//LISTA DE NUMEROS

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Filtrar y mostrar solo los números pares de la lista numbers.

var numerosPares = from number in numbers
                   where number % 2 == 0
                   select number;

foreach (var item in numerosPares)
{
    Console.WriteLine(item);
}

// ● Usando LINQ, calcular la suma de todos los números impares en la lista numbers.
var numerosImparesSuma = numbers.Where(number => number % 2 != 0).Sum();
Console.WriteLine(numerosImparesSuma);

// ● Ordenar de manera descendente los números mayores que 5 en la lista numbers.
var numerosMayoresQueCinco = numbers.Where(number => number > 5).OrderByDescending(number => number);

foreach (var item in numerosMayoresQueCinco)
{
    Console.WriteLine(item);
}

// ● Contar cuántos números son menores o iguales a 3 en la lista numbers.
var countMenoresOIgualesTres = numbers.Count(number => number <= 3);
Console.WriteLine($"Cantidad de números menores o iguales a 3: {countMenoresOIgualesTres}");

// ● Seleccionar cada número en la lista numbers y multiplicarlo por 2.
var numerosMultiplicadosPorDos = numbers.Select(number => number * 2);

Console.WriteLine("Números multiplicados por 2:");
foreach (var item in numerosMultiplicadosPorDos)
{
    Console.WriteLine(item);
}*/


/*//LISTA DE STRINGS 
List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David",
"Eve"};

// Ordenar los nombres en la lista names alfabéticamente.
Console.WriteLine("---------------------------------");
var listaOrganizada = names.OrderBy(name => name);
foreach (var item in listaOrganizada)
{
    Console.WriteLine(item);
}

// ● Seleccionar los nombres en la lista names que empiezan con la letra 'A'.
Console.WriteLine("---------------------------------");
var listaPorA = names.Where(item => item.StartsWith("A"));
foreach (var item in listaPorA)
{
    Console.WriteLine(item);
}

// ● Contar cuántos nombres en la lista names tienen más de 5 caracteres.
Console.WriteLine("---------------------------------");
var nombreMayorCinco = names.Count(nameof => nameof.Length >= 5);
Console.WriteLine(nombreMayorCinco);

// ● Concatenar todos los nombres de la lista names en una sola cadena separada por
// espacios.
Console.WriteLine("---------------------------------");
string listaConcat = String.Join(" ", names);
Console.WriteLine(listaConcat);

// ● Encontrar y mostrar el nombre más largo en la lista names.
Console.WriteLine("---------------------------------");
var nombreMayor = names.OrderBy(name => name.Length).Last();
Console.WriteLine(nombreMayor);*/

/*//LISTA DE PALABRAS
List<string> words = new List<string> { "apple", "banana", "cherry", "date",
"elderberry" };

// ● Verificar si todas las palabras en la lista words tienen más de 3 caracteres.
Console.WriteLine("---------------------------------");
bool contarLetras = words.All(word => word.Length > 3);
Console.WriteLine(contarLetras);

// ● Encontrar y mostrar la primera palabra en la lista words que empieza con la letra 'b'.
Console.WriteLine("---------------------------------");
var inicioLetra = words.Where(word => word.StartsWith("b"));
foreach (var item in inicioLetra)
{
    Console.WriteLine(item);
}

// ● Contar cuántas palabras en la lista words contienen la letra 'e'.
Console.WriteLine("---------------------------------");
var contar = words.Count(word => word.Contains("e"));
Console.WriteLine(contar);

// ● Seleccionar todas las palabras en la lista words y convertirlas a mayúsculas.
Console.WriteLine("---------------------------------");
var cambio = words.Select(item => item.ToUpper());
foreach (var item in cambio)
{
    Console.WriteLine(item);   
}

// ● Verificar si alguna palabra en la lista words termina con la letra 'y'
Console.WriteLine("---------------------------------");
var letraFinal = words.Where(word => word.EndsWith("e"));
foreach (var item in letraFinal)
{
    Console.WriteLine(item);   
}*/

//LISTAS

List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 , 18};
List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13};

// ● Combinar y ordenar las listas data y moreData de forma ascendente.
Console.WriteLine("---------------------------------");
var listasCombinadas = data.Concat(moreData).OrderBy(numeros => numeros).ToList();
foreach (var item in listasCombinadas)
{
    Console.WriteLine(item);   
}

// ● Calcular la suma de todos los números pares en la lista data.
Console.WriteLine("---------------------------------");
var sumaTotal = data.Where(numero => numero % 2 == 0).Sum();
Console.WriteLine(sumaTotal);

// ● Encontrar el número más grande en la lista data.
Console.WriteLine("---------------------------------");
var numeroMayor = data.Max(numero => numero);
Console.WriteLine(numeroMayor);

// ● Unir las listas data y moreData, eliminando los elementos duplicados.
Console.WriteLine("---------------------------------");
var duplicados = data.Concat(moreData).Distinct();
foreach (var item in duplicados)
{
    Console.WriteLine(item);
}
// ● Calcular el promedio de la lista moreData y seleccionar los números en data que son
// mayores que ese promedio.
Console.WriteLine("---------------------------------");
var promedio = moreData.Average();

foreach (var item in data)
{
    if (item > promedio){
        Console.WriteLine(item);
    }
}

// ● Contar cuántos números en la lista moreData son números primos(te recomiendo crear
// una función independiente que valide si el número es primo o no lo es, luego esa funciona
// pasala al método LINQ adecuado).
Console.WriteLine("---------------------------------");
