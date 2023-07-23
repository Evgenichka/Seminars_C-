// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число");
        Console.WriteLine("Введите второе число");

        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе целое число");

        int number2 = Convert.ToInt32(Console.ReadLine());
        
        if (number1 > number2)
        {
            Console.WriteLine($"Большее число={number1}, меньшее число={number2}");
        }
        else
        {
            Console.WriteLine($"Большее число={number2}, меньшее число={number1}");
        }
    }
}