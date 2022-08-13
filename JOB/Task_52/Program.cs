/*
Задача 52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void AvarageArrayClumn()
{
    System.Console.WriteLine("Укажите размеры массива:");
    System.Console.WriteLine("----------------------------------------------");
    System.Console.WriteLine("Введите ширину массива: ");
    int width = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите длинну массива: ");
    int height = int.Parse(Console.ReadLine());
    System.Console.WriteLine("----------------------------------------------");

    int[,] array = new int[height, width];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 5);
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

    double[] avarage = new double[width];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            avarage[i] += array[j, i];
        }
        avarage[i] = Math.Round((avarage[i] / (double)height), 1);

    }

    System.Console.WriteLine("----------------------------------------------");
    System.Console.WriteLine("среднеарифметическое каждого столбца:");
    for (int i = 0; i < avarage.Length; i++)
    {
        System.Console.Write(avarage[i] + "\t");
    }
}
AvarageArrayClumn();