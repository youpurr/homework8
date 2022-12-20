// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество солбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr1 = new int[m, n];
int[,] arr2 = new int[m, n];
int[,] matrix = new int[m, n];

void FillArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void doubleArr(int[,] arr1, int[,] arr2)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            matrix[i, j] = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                matrix[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    PrintArray(matrix);
}

FillArray(arr1);
FillArray(arr2);
PrintArray(arr1);
Console.WriteLine();
PrintArray(arr2);
Console.WriteLine("");
doubleArr(arr1, arr2);