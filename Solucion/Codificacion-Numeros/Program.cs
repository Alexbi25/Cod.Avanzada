
//Crear lista vacia para almacenar los numeros en una lista
List<int> numeros = new List<int>();
//Cantidad de numeros a pedir
int cantidad = 3;
//Pedir numeros al usuario 1 en 1 
for (int i = 0; i < cantidad; i++)
{
    {
        Console.Write($"Introduce el número {i + 1}: ");

        // Convertir en int
        int numero = int.Parse(Console.ReadLine());

        // Agregar el número a la lista
        numeros.Add(numero);
        Console.Clear();
    }
}
//Mostrar la lista generada en la consola
Console.WriteLine("\nLista de números ingresados:");
foreach (int num in numeros)
{
    Console.WriteLine(num);
}
Console.Clear();
