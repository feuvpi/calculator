
internal class Program
{
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Qual operação deseja realizar?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("--------------");
        short res = short.Parse(Console.ReadLine());
        switch (res)
        {
            case 1: Sum(); break;
            case 2: Subtraction(); break;
            case 3: Multiplication(); break;
            case 4: Division(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    static void Sum()
    {


        Console.Clear();
        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;
        Console.WriteLine("");
        Console.WriteLine("O resultado da soma é: " + resultado);
        Console.ReadKey();
        Menu();
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
        Menu();

    }

    static void Division()
    {
        Console.Clear();
        Console.WriteLine("First value:");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Second value:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine($"Result is: {v1 / v2}");
        Console.ReadKey();
        Menu();

    }

    static void Multiplication()
    {

        Console.Clear();
        Console.WriteLine("First value:");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Second value:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine($"Result is: {v1 * v2}");
        Console.ReadKey();
        Menu();

    }
    private static void Main(string[] args)
    {

        Menu();

    }


}