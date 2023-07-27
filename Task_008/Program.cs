// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите целое число N: ");

        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите целое число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        if (a % 2! == 0)
            a+= 1;

        while (a <= N)
                   
            {
            Console.WriteLine(a +1);
            a+= 2;
            }
            
            
        
    }
}