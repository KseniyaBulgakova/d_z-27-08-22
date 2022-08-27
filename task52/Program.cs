// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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




Console.Write($"Cреднее арифметическое:");
        
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
    double sred = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sred+=matrix[i,j];
    }
        
         Console.Write($"{sred/matrix.GetLength(0)}  ");
    
        }
    
Console.WriteLine();



