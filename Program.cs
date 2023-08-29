// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = new int[3, 4];

Console.WriteLine("Введите элементы массива:");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("Элемент [{0}, {1}]: ", i, j);
        array[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("{0}\t", array[i, j]);
    }
    Console.WriteLine();
}

Console.Write("Введите значение элемента: ");
int value = int.Parse(Console.ReadLine());

bool found = false;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == value)
        {
            Console.WriteLine("Позиция элемента [{0}, {1}]", i, j);
            found = true;
        }
    }
}

if (!found)
{
    Console.WriteLine("Такого элемента в массиве нет.");
}
