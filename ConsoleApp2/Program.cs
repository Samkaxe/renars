namespace ConsoleApp2;

internal class Program
{
    static void Main(string[] args)
    {
        IntCalculater calculater = new IntCalculater();

        calculater.add(int.MaxValue);
        Console.WriteLine($"{calculater.Result :N0}");
        
        calculater.add(1);
        Console.WriteLine($"{calculater.Result :N0}");
    }
}

