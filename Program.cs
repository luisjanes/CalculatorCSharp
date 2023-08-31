using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        string mathContinue = "s";
        while (mathContinue != "n")
        {

            Console.WriteLine("Informe o primeiro número: ");
            float numberOne = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            float numberTwo = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a operação matemática desejada: ");
            Console.WriteLine("/ para divisão");
            Console.WriteLine("* para multiplicação");
            Console.WriteLine("- para subtração");
            Console.WriteLine("+ para soma");
            string mathOperator = Console.ReadLine();
            float resultOf;

            switch (mathOperator)
            {
                case "+":
                    OperatorPlus(numberOne, numberTwo);
                    break;
                case "-":
                    OperatorSubtraction(numberOne, numberTwo);
                    break;
                case "*":
                    OperatorMultiply(numberOne, numberTwo);
                    break;
                case "/":
                    OperatorDivide(numberOne, numberTwo);
                    break;
                default:
                    Console.WriteLine("Nenhuma opção selecionada.");
                    break;
            }
            Console.WriteLine("Deseja continuar? s para sim e n para não");
            mathContinue = Console.ReadLine();
        }
    }

    static void OperatorPlus(float numberOne, float numberTwo)
    {
        float result = numberOne + numberTwo;
        Console.WriteLine($"O resultado da soma é {result}");
    }
    static void OperatorSubtraction(float numberOne, float numberTwo)
    {
        float result = numberOne - numberTwo;
        Console.WriteLine($"O resultado da subtração é {result}");
    }
    static void OperatorMultiply(float numberOne, float numberTwo)
    {
        float result = numberOne * numberTwo;
        Console.WriteLine($"O resultado da multiplicação é {result}");
    }
    static void OperatorDivide(float numberOne, float numberTwo)
    {
        float result = numberOne / numberTwo;
        Console.WriteLine($"O resultado da divisão é {result}");
    }
}