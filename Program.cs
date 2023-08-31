using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Informe a operação matemática desejada: ");
        Console.WriteLine("/ para divisão");
        Console.WriteLine("* para multiplicação");
        Console.WriteLine("- para subtração");
        Console.WriteLine("+ para soma");
        Console.WriteLine("5 para sair do programa");
        string mathOperator = Console.ReadLine();
        float resultOf;

        switch (mathOperator)
        {
            case "+":
                OperatorPlus();
                break;
            case "-":
                OperatorSubtraction();
                break;
            case "*":
                OperatorMultiply();
                break;
            case "/":
                OperatorDivide();
                break;
            case "5":
                System.Environment.Exit(0);
                break;
            default:
                Menu();
                break;
        }
    }
    static void OperatorPlus()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro número: ");
        float numberOne = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo número: ");
        float numberTwo = float.Parse(Console.ReadLine());
        float result = numberOne + numberTwo;
        Console.WriteLine($"O resultado da soma é {result}");
        Console.ReadKey();
        Menu();
    }
    static void OperatorSubtraction()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro número: ");
        float numberOne = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo número: ");
        float numberTwo = float.Parse(Console.ReadLine());
        float result = numberOne - numberTwo;
        Console.WriteLine($"O resultado da subtração é {result}");
        Console.ReadKey();
        Menu();
    }
    static void OperatorMultiply()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro número: ");
        float numberOne = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo número: ");
        float numberTwo = float.Parse(Console.ReadLine());
        float result = numberOne * numberTwo;
        Console.WriteLine($"O resultado da multiplicação é {result}");
        Console.ReadKey();
        Menu();
    }
    static void OperatorDivide()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro número: ");
        float numberOne = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo número: ");
        float numberTwo = float.Parse(Console.ReadLine());
        float result = numberOne / numberTwo;
        Console.WriteLine($"O resultado da divisão é {result}");
        Console.ReadKey();
        Menu();
    }

}