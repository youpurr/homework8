// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void SummRows(int[,]array)
{
    int minRowSum = 0; 
    int rowIndex = 0; 
    int tempSum = 0; 
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minRowSum += array[0, j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i, j];
        }
        if (tempSum < minRowSum)
        {
            minRowSum = tempSum;
            rowIndex = i;
        }
        tempSum = 0;
    }
    Console.WriteLine($"{rowIndex + 1}-я строка является строкой с наименьшей суммой элементов ({minRowSum})");
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество солбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SummRows(array);
