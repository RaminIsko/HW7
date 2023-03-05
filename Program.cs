using System;
using static System.Console;


double[,] GetDoubleArray (int rows, int columns, int minValue, int maxValue){
    double[,] result = new double[rows, columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            result[i,j] = Convert.ToDouble(new Random().Next(minValue * 10, (maxValue + 1) * 10) / 10.0);;
        }
    }
    return result;
}

void PrintDoubleArray (double[,] array) {
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Write($"{array[i,j]} ");
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


