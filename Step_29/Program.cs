// Задача 29 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 5 -> [1, 2, 5, 7, 19]; 3 -> [6, 1, 33] */

int Prompt(string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result; 
}

int [] MyArray(int length, int minDigit, int maxDigit)
{
    int [] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
       array[i] = rnd.Next(minDigit, maxDigit +1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[ i ]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("]");
}

int length = Prompt($"Длина массива: ");
int minDigit = Prompt("Начальное значение для диапазона случайных числел: ");
int maxDigit = Prompt("Конечное значение для диапазона случайных числел: ");
int [] array = MyArray(length, minDigit, maxDigit);

PrintArray(array);