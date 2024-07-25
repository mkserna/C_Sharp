//Lista
List<int> miLista = new List<int> { 7, 10, 2, 5, 4, 6, 8, 1, 3 };

var numerosParesArray = miLista.Where(item => item % 2 == 0).ToList();