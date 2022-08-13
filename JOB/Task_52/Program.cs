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
int Width = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите длинну массива: ");
int Height = int.Parse(Console.ReadLine());
System.Console.WriteLine("----------------------------------------------");

int[,] massive = new int[Height, Width];
Random random = new Random();

for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        massive[i, j] = random.Next(0, 5);
        System.Console.Write(massive[i, j] + "\t");
    }
    System.Console.WriteLine();
}

double[] avarage = new double[Width];
for (int i = 0; i < massive.GetLength(1); i++)
{
    for (int j = 0; j < massive.GetLength(0); j++)
    {
        avarage[i] += massive[j,i];
    }
    avarage[i] = Math.Round((avarage[i]/(double)Height),1);
    
}

System.Console.WriteLine("----------------------------------------------");
System.Console.WriteLine("среднеарифметическое каждого столбца:");
for (int i = 0; i < avarage.Length; i++)
{
    System.Console.Write(avarage[i] + "\t");
}
}
AvarageArrayClumn();