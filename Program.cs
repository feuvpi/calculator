
internal class Program
{

    static void sum()
    {


        Console.Clear();
        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;
        Console.WriteLine("");
        Console.WriteLine("O resultado da soma é: " + resultado);
    }

    static void Subtraction()
    {
        Console.Clear();
        Console.WriteLine("First value:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Second value:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine($"Result is: {v1 - v2}");
        Console.ReadKey();

    }


    private static void Main(string[] args)
    {

        Subtraction();//functions


    }


}