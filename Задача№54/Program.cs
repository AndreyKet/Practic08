// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = 
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
};
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] array)
{
    int value  = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    value = array[i,k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = value;
                }
            }
        }
    }
}

PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);