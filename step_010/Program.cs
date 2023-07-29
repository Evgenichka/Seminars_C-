internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число");
        int.TryParse(Console.ReadLine()!, out int x);

        if (x > 999 || x < 100)
        {
            Console.WriteLine("Количество знаков не соответсвует трем!");
            return;
        }
        int GetSecond(int x)
        {
            while (x >= 100) x /= 10;
            int a = x % 10;
            return a;
        }
        Console.WriteLine(GetSecond(x));
    }
}