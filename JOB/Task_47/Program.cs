/*
Задача 47. 
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

Пример: m = 3, n = 4.
0,5    7      -2     -0,2
1     -3,3     8     -9,9
8      7,8    -7,1    9
*/
System.Console.WriteLine("Укажите размер двумерного массива:\n-m- количество строк..\n-n- количество столбцов..");
System.Console.WriteLine("-----------------------");
System.Console.WriteLine("Введите значение -m-");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите значение -n-");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];
Random random = new Random();

System.Console.WriteLine("-----------------------\nМассив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(-999, 999) / (Double)10;
        System.Console.Write(array[i, j] + "\t");
    }
    System.Console.WriteLine();
}
