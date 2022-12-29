// Задача 50. Напишите программу, которая выводит позицию заданного элемента, который есть в массиве, 
// или указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = GetArrayMartix(rows, columns, 0, 10);
PrintArray(array);

int [,] GetArrayMartix(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i, j] ==N)
            {
            Console.WriteLine($"позиция элемента {i}, {j}");
            }
            else
            Console.WriteLine("Такого элемента нет");
        }
    }
