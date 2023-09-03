// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void Print(int [,] arr)
{
    int rows_size = arr.GetLength(0);
    int columns_size = arr.GetLength(1);
    for (int i =0; i < rows_size; i++)
    {
        for (int j = 0; j < columns_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int [,] MassNum(int rows, int columns)                  
{
    int [,] arr = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            arr[i, j] = new Random().Next(1, 10);
    return arr;
}

int [,] MatrixProduct(int[] arr_first, int[] arr_second)
{
    int rows_size = arr_first.GetLength(0);
    int columns_size = arr_second.GetLength(1);
    
int [,] prod_matrix = new int [rows_size, columns_size];
{
    if (rows_size != arr_second.GetLength(0) || columns_size != arr_second.GetLength(1)) return prod_matrix;
    {
    for (int i = 0; i < rows_size; i++);
        for (int j = 0; j < columns_size; j++)
            prod_matrix[ i, j] = arr_first[ i, j] * arr_second[ i, j];
        return prod_matrix;
    }
}  
}
Console.Write("Введите числа строки 1: ");
int rows_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите числа столбца 1: ");
int columns_1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите числа строки 2: ");
int rows_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите числа столбца 2: ");
int columns_2 = int.Parse(Console.ReadLine()!);

int[,] arr_1 = MassNum(rows_1, columns_1);
Print(arr_1);

int[,] arr_2 = MassNum(rows_2, columns_2);
Print(arr_2);

int[,] res_matrix = MatrixProduct[arr_1, arr_2];
Print(res_matrix);