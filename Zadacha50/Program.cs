/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/ 

int rows = ReadInt("Введите количество строк для создания массива: ");
int columns = ReadInt("Введите количество столбцов для создания массива: ");

int elementRow = ReadInt("Введите номер строки искомого элемента: ");
int elementColumn = ReadInt("Введите номер столбца искомого элемента: ");

elementRow--; 
elementColumn--;

int[,] numbers = new int[rows, columns];

FillMatrixRandomNumbers(numbers);

WriteMatrix(numbers);

if (elementRow > rows || elementColumn > columns)
   Console.WriteLine("Элемента с заданными координатами не существует в массиве");

else
    Console.WriteLine($"Число с координатами ({elementRow+1},{elementColumn+1}) -> {numbers[elementRow,elementColumn]}");



void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

