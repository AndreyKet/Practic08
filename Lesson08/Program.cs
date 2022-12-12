// Задача 2: Из двумерного массива случайных целых чисел
// от 0 до 10 удалить строку и столбец, на пересечении 
// которых расположен наименьший элемент.

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }return array;
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

int[,] array = new int[3, 4];
array = FillArray(array);
PrintArray(array);
int minIndexLine = 0;
int minIndexColumns = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < array[ minIndexLine, minIndexColumns])
        {
            minIndexLine = i;
            minIndexColumns = j;
        }
    }
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0) - array.GetLength(minIndexLine); i++)
{
    
    for (int j = 0; j < array.GetLength(1) - array.GetLength(minIndexColumns); j++)
    {
        Console.Write(array[i, j] + " ");
    }
}Console.WriteLine();

