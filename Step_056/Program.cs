// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Print(int [,] arr)
{
    int rows_size = arr.GetLength(0);
    int columns_size = arr.GetLength(1);
    for (int i =0; i < rows_size; i++)
    {
        for (int j = 0; j < columns_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int [,] MassNum(int rows, int columns)                  
{
    int [,] arr = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            arr[i,j] = new Random().Next(1, 10);
    return arr;
}

int[] SumNum (int [,] arr)                                
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int[] all_num = new int [rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            all_num[i] += arr[i, j];
        }
    }
    return all_num;
}

void FindMin(int [] arr)
{
    int min_ind = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[min_ind]) min_ind = 1;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {min_ind  + 1} строка, Сумма элементов строки: {arr[min_ind]}");
}
Console.Write("Введите количество строк: ");
int rows_num = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns_num = int.Parse(Console.ReadLine()!);

int [,] mass = MassNum(rows_num, columns_num);                               
Print (mass);
int [] mass_sum = SumNum(mass);
FindMin(mass_sum);
