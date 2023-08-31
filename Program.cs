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
                    resultOf = OperatorPlus(numberOne, numberTwo);
                    Console.WriteLine($"O resultado da soma é {resultOf}");
                    break;
                case "-":
                    resultOf = OperatorSubtraction(numberOne, numberTwo);
                    Console.WriteLine($"O resultado da subtração é {resultOf}");
                    break;
                case "*":
                    resultOf = OperatorMultiply(numberOne, numberTwo);
                    Console.WriteLine($"O resultado da multiplicação é {resultOf}");
                    break;
                case "/":
                    resultOf = OperatorDivide(numberOne, numberTwo);
                    Console.WriteLine($"O resultado da divisão é {resultOf}");
                    break;
            }
            Console.WriteLine("Deseja continuar? s para sim e n para não");
            mathContinue = Console.ReadLine();
        }
    }

    static float OperatorPlus(float numberOne, float numberTwo)
    {
        float result = numberOne + numberTwo;
        return result;
    }
    static float OperatorSubtraction(float numberOne, float numberTwo)
    {
        float result = numberOne - numberTwo;
        return result;
    }
    static float OperatorMultiply(float numberOne, float numberTwo)
    {
        float result = numberOne * numberTwo;
        return result;
    }
    static float OperatorDivide(float numberOne, float numberTwo)
    {
        float result = numberOne / numberTwo;
        return result;
    }
}