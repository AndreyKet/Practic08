// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[6, 4];

void MinRowInArray(int[,] array)
{
    int sumRow = 0;
    int minSumRow = 0;
    int row = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSumRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            row = i;
        }
        sumRow = 0;
    }
    Console.Write($"Строка с наименьшей суммой элементов: {row + 1}");
}



FillArray(array);
PrintArray(array);
Console.WriteLine();
MinRowInArray(array);
