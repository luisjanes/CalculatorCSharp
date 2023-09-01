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
        Console.WriteLine("1 para soma");
        Console.WriteLine("2 para subtração");
        Console.WriteLine("3 para multiplicação");
        Console.WriteLine("4 para divisão");
        Console.WriteLine("5 para porcentagem");
        Console.WriteLine("6 para resto");
        Console.WriteLine("7 para sair do programa");
        string mathOperator = Console.ReadLine();
        float resultOf;

        switch (mathOperator)
        {
            case "1":
                OperatorPlus();
                break;
            case "2":
                OperatorSubtraction();
                break;
            case "3":
                OperatorMultiply();
                break;
            case "4":
                OperatorDivide();
                break;
            case "5":
                OperatorPercentage();
                break;
            case "6":
                OperatorRemnant();
                break;
            case "7":
                System.Environment.Exit(0);
                break;
            default:
                Teste();
                break;
        }
    }

    static void Teste()
    {
        List<float> number = new List<float>();
        float soma = 0;
        bool condition = true; 
        for (int i = 1;condition==true;i++)
        {
            Console.WriteLine("Informe o " + i + "º número ou qualquer tecla para realizar a operação: ");
            var teste = float.TryParse(Console.ReadLine(), out float recebe);
            if (teste !=true)
            {
                break;
            } else {
                number.Add(recebe);
            }
        }
        for (int i = 0; i < number.Count; i++)
        {
            soma += number[i];
        }
        Console.WriteLine($"O resultado da soma é {soma}");
    }

    static void OperatorPlus()
    {
        List<float> listNumber = new List<float>();
        float plus = 0;
        bool condition = true;
        Console.WriteLine("Função soma escolhida, entre com o valor abaixo ou qualquer tecla para realizar a operação.");
        for (int i = 1; condition == true; i++)
        {
            Console.WriteLine("Informe o " + i + "º número: ");
            condition = float.TryParse(Console.ReadLine(), out float receive);
            if (condition != true)
            {
                break;
            }
            else
            {
                listNumber.Add(receive);
            }
        }
        for (int i = 0; i < listNumber.Count; i++)
        {
            plus += listNumber[i];
        }
        Console.WriteLine($"O resultado da soma é {plus}");
        Console.WriteLine("Para voltar ao menu, pressione enter.");
        Console.ReadKey();
        Menu();
    }
    static void OperatorSubtraction()
    {
        List<float> listNumber = new List<float>();
        float subtraction = 0;
        bool condition = true;
        Console.WriteLine("Função soma escolhida, entre com o valor abaixo ou qualquer tecla para realizar a operação.");
        for (int i = 1; condition == true; i++)
        {
            Console.WriteLine("Informe o " + i + "º número: ");
            condition = float.TryParse(Console.ReadLine(), out float receive);
            if (condition != true)
            {
                break;
            }
            else
            {
                listNumber.Add(receive);
            }
        }
        for (int i = 1; i < listNumber.Count; i++)
        {
            subtraction -= -listNumber[i];
        }
        Console.WriteLine($"O resultado da soma é {subtraction}");
        Console.WriteLine("Para voltar ao menu, pressione enter.");
        Console.ReadKey();
        Menu();
    }
    static void OperatorMultiply()
    {
        List<float> listNumber = new List<float>();
        float multiply = 1;
        bool condition = true;
        Console.WriteLine("Função soma escolhida, entre com o valor abaixo ou qualquer tecla para realizar a operação.");
        for (int i = 1; condition == true; i++)
        {
            Console.WriteLine("Informe o " + i + "º número: ");
            condition = float.TryParse(Console.ReadLine(), out float receive);
            if (condition != true)
            {
                break;
            }
            else
            {
                listNumber.Add(receive);
            }
        }
        for (int i = 0; i < listNumber.Count; i++)
        {
            multiply *= listNumber[i];
        }
        Console.WriteLine($"O resultado da multiplicação é {multiply}");
        Console.WriteLine("Para voltar ao menu, pressione enter.");
        Console.ReadKey();
        Menu();
    }
    static void OperatorDivide()
    {
        List<float> listNumber = new List<float>();
        bool condition = true;
        float? divide = 0;
        Console.WriteLine("Função soma escolhida, entre com o valor abaixo ou qualquer tecla para realizar a operação.");
        for (int i = 1; condition == true; i++)
        {
            Console.WriteLine("Informe o " + i + "º número: ");
            condition = float.TryParse(Console.ReadLine(), out float receive);
            if (condition != true)
            {
                break;
            }
            else
            {
                listNumber.Add(receive);
            }
        }
        divide = listNumber[0];
        for (int i = 1; i < listNumber.Count; i++)
        {
            divide /= listNumber[i];
        }
        Console.WriteLine($"O resultado da multiplicação é {divide}");
        Console.WriteLine("Para voltar ao menu, pressione enter.");
        Console.ReadKey();
        Menu();
    }
    static void OperatorPercentage()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro número: ");
        float numberOne = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe a porcentagem: ");
        float numberTwo = float.Parse(Console.ReadLine());
        float result = (numberOne * numberTwo)/100;
        Console.WriteLine($"{numberTwo} % de {numberOne} é {result}");
        Console.ReadKey();
        Menu();
    }
    static void OperatorRemnant()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro número: ");
        float numberOne = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo número: ");
        float numberTwo = float.Parse(Console.ReadLine());
        float result = numberOne % numberTwo;
        Console.WriteLine($"O resto da divisão é {result}");
        Console.ReadKey();
        Menu();
    }

}