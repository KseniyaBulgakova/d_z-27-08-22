// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение
//  этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.Clear();
Console.WriteLine("Задайте двумерный массив m*n");
        Console.WriteLine("Введите значение m:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение n:");
        int n = Convert.ToInt32(Console.ReadLine());

        int [,] matrix=new int [m,n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                 matrix[i, j] = new Random().Next(-10,11);
                Console.Write(matrix[i, j] + " ");

            }
            Console.WriteLine();
        }

Console.WriteLine("введите номер строки");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int b = Convert.ToInt32(Console.ReadLine());

if (z > matrix.GetLength(0) || b > matrix.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {z} строки и {b} столбца равно {matrix[z-1,b-1]}");
}



