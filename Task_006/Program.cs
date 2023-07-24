// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//  4 -> да
// -3 -> нет
// 7 -> нет


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number == 0)

            Console.Write("Нулевое число");

        else if (number > 0)

            if (number % 2 == 0)

                Console.Write($"Введенное число является четным");

            else

                Console.WriteLine($"Введенное число нечетное");

        else

            if (number % 2 == 0)

            Console.Write($"Введенное число является четным");

        else

            Console.Write($"Введенное число нечетное");
    }
}