using System;
using static System.Console;


double[,] GetDoubleArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Convert.ToDouble(new Random().Next(minValue * 10, (maxValue + 1) * 10) / 10.0); ;
        }
    }
    return result;
}

void PrintDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

WriteLine("Задача №47: ");

Write("Введите количество строк в массиве: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(ReadLine()!);

Write("Введите минимальное значение в массиве: ");
int min = int.Parse(ReadLine()!);

Write("Введите максимальное значение в массиве: ");
int max = int.Parse(ReadLine()!);

double[,] array = GetDoubleArray(rows, columns, min, max);
PrintDoubleArray(array);



int InputRowIndex()
{
    Write("Введите индекс строки: ");
    int rowIndex = int.Parse(ReadLine()!);
    return rowIndex;
}

int InputColumnIndex()
{
    Write("Введите индекс столбца: ");
    int columnIndex = int.Parse(ReadLine()!);
    return columnIndex;
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(10, 20);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

void isNumberEqualIndex(int[,] table, int[] array, int rows, int columns)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (array[0] == i && array[1] == j)
            {
                WriteLine($"Число в таблице с индексами {array[0]}, {array[1]} - {table[i, j]}");
            }
        }
    }
    if ((array[0] >= rows && array[1] >= columns) || (array[0] < 0 && array[1] < 0))
    {
        WriteLine($"Числа с индексами {array[0]}, {array[1]} - Нет");
    }
}

WriteLine("Задача №50: ");

Write("Введите количество строк в массиве: ");
int rows2 = int.Parse(ReadLine()!);

Write("Введите количество столбцов в массиве: ");
int columns2 = int.Parse(ReadLine()!);

Write("Введите минимальное значение элементов: ");
int minValue = int.Parse(ReadLine()!);

Write("Введите максимальное значение элементов: ");
int maxValue = int.Parse(ReadLine()!);

int[] rowColumnIndex = { InputRowIndex(), InputColumnIndex() };

int[,] array2 = GetArray(rows2, columns2, minValue, maxValue);
PrintArray(array2);
isNumberEqualIndex(array2, rowColumnIndex, rows2, columns2);



Clear();

void ColumnAverageArifmetic(int[,] table)
{
    Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < table.GetLength(0); i++){
        double array2 = 0;
        for (int j = 0; j < table.GetLength(1); j++){
            array2 += Convert.ToDouble(array[i, j]);
        }
        Write($"{array2 / table.GetLength(0)}; ");
    }
}

WriteLine("Задача №53: ");

Write("Введите количество строк в массиве: ");
int rows3 = int.Parse(ReadLine()!);

Write("Введите количество столбцов в массиве: ");
int columns3 = int.Parse(ReadLine()!);

Write("Введите минимальное значение элементов: ");
int minValue3 = int.Parse(ReadLine()!);

Write("Введите максимальное значение элементов: ");
int maxValue3 = int.Parse(ReadLine()!);

int[,] array3 = GetArray(rows3, columns3, minValue3, maxValue3);
PrintArray(array3);
ColumnAverageArifmetic(array3);





