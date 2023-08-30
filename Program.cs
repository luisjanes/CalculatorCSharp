using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        string mathContinue = "s";
        while (mathContinue != "n")
        { 

            Console.WriteLine("Informe o primeiro número: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a operação matemática desejada: ");
            Console.WriteLine("/ para divisão");
            Console.WriteLine("* para multiplicação");
            Console.WriteLine("- para subtração");
            Console.WriteLine("+ para soma");
            string mathOperator = Console.ReadLine();

            switch (mathOperator)
            {
                case "+":
                    Calculator calculatorPlus = new Calculator();
                    Console.WriteLine(calculatorPlus.OperatorPlus(numberOne, numberTwo));
                    break;
                case "-":
                    Calculator calculatorSub = new Calculator();
                    Console.WriteLine(calculatorSub.OperatorSubtraction(numberOne, numberTwo));
                    break;
                case "*":
                    Calculator calculatorMultiply = new Calculator();
                    Console.WriteLine(calculatorMultiply.OperatorMultiply(numberOne, numberTwo));
                    break;
                case "/":
                    Calculator calculatorDivide = new Calculator();
                    Console.WriteLine(calculatorDivide.OperatorDivide(numberOne, numberTwo));
                    break;
            }
            Console.WriteLine("Deseja continuar? s para sim e n para não");
            mathContinue = Console.ReadLine();
        }
        

    }
    struct Calculator
    {
        public Calculator(int numberOne, int numberTwo)
        {
            NumberTwo = numberTwo;
            NumberOne = numberOne;
        }

        public int NumberOne;
        public int NumberTwo;

        public int OperatorPlus(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            return result;
        }        
        public int OperatorSubtraction(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            return result;
        }
        public int OperatorMultiply(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            return result;
        }
        public int OperatorDivide(int numberOne, int numberTwo)
        {
            int result = numberOne / numberTwo;
            return result;
        }
    }

}