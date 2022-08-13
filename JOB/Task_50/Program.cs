/*
Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
*/
System.Console.WriteLine("Массив со случайными числами:");
System.Console.WriteLine("---------------------------------------------------------------------------");
int height = 10;
int width = 10;
int[,] array = new int[height, width];
Random random = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(99);
        System.Console.Write(array[i, j] + "\t");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("---------------------------------------------------------------------------");

System.Console.WriteLine
($"Чтобы узнать число под определённой позицией,\nукажите параметры значения:");
System.Console.Write("индекспо высоте: ");
int indexHeight = int.Parse(Console.ReadLine());
System.Console.Write("индекс по ширине: ");
int indexWidthe = int.Parse(Console.ReadLine());
if (indexHeight < 10 && indexWidthe < 10)
{
    System.Console.Write("По данному адресу находится значение: ");
    System.Console.WriteLine(array[indexHeight, indexWidthe]);
}
else
{
    System.Console.WriteLine("значения с такими параметрами не существует!!!");
}