// Задача 58: Задайте два двумерных массива (от 0 до 10).
// Напишите программу, которая будет находить 
// произведение двух массивов (поэлементное).

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
Console.Write("Введите размер массива: ");
int value = int.Parse(Console.ReadLine());
int[,] firstArray = new int[value, value];
int[,] secondArray = new int[value, value];

int[,] newArray = new int[value, value];

FillArray(firstArray);
FillArray(secondArray);

for (int i = 0; i < value; i++)
{

    for (int j = 0; j < value; j++)
    {
        for (int k = 0; k < value; k++)
        {
            int sum = 0;
            sum += firstArray[i, j] * secondArray[i, j];
            newArray[i, j] = sum;
        }
    }
}

PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();
Console.WriteLine("Произведение двух массивов.");
PrintArray(newArray);