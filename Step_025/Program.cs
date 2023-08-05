// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите натуральное число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Exponentiation(numberA, numberB);

void Exponentiation(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
{
    result = result*a;
}
Console.WriteLine($"Число A возведенное в степень B = " + result);
}