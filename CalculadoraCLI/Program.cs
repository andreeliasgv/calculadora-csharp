using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("CALCULADORA CLI");
        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Potenciação");
        Console.WriteLine("6 - Radiciação");
        Console.WriteLine("7 - Logaritmo");
        Console.WriteLine("8 - Seno");
        Console.WriteLine("9 - Cosseno");
        Console.WriteLine("10 - Tangente");

        Console.WriteLine();
        Console.Write("> ");
        int operacao = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Operação escolhida: ");
        switch (operacao)
        {
            case 1: Console.WriteLine("Adição"); break;
            case 2: Console.WriteLine("Subtração"); break;
            case 3: Console.WriteLine("Multiplicação"); break;
            case 4: Console.WriteLine("Divisão"); break;
            case 5: Console.WriteLine("Potenciação"); break;
            case 6: Console.WriteLine("Radiciação"); break;
            case 7: Console.WriteLine("Logaritmo"); break;
            case 8: Console.WriteLine("Seno"); break;
            case 9: Console.WriteLine("Cosseno"); break;
            case 10: Console.WriteLine("Tangente"); break;
            default: Console.WriteLine("Operação inválida"); break;
        }

        double numero1 = 0.0;
        double numero2 = 0.0;


        if (operacao < 8) { 

        Console.WriteLine("Digite o primeiro número:");
        Console.Write("> ");
        numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Digite o segundo número:");
        Console.Write("> ");
        numero2 = Convert.ToDouble(Console.ReadLine());
        } else

        {
            Console.WriteLine("Digite o número:");
            Console.Write("> ");
            numero1 = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine();

        Console.WriteLine("Calculando...");

        Console.WriteLine();

        switch (operacao)
        {
            case 1: Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}"); break;
            case 2: Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}"); break;
            case 3: Console.WriteLine($"{numero1} x {numero2} = {numero1 * numero2}"); break;
            case 4:
                if (numero2 != 0)
                {
                    Console.WriteLine($"{numero1} / {numero2} = {(double)numero1 / numero2}");
                }
                
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                } break;
            case 5: Console.WriteLine($"{numero1} ^ {numero2} = {Math.Pow(numero1, numero2)}"); break;
            case 6:
                if (numero2 != 0)
                {
                    Console.WriteLine($"^{numero2}√{numero1} = {Math.Pow(numero1, (1.0 / numero2))}");
                }
                else
                {
                    Console.WriteLine("Erro: O índice da raiz não pode ser zero.");
                }
                break;
            case 7:
                if (numero1 > 0 && numero2 > 0 && numero2 != 1)
                {
                    Console.WriteLine($"log{numero2}({numero1}) = {Math.Log(numero1, numero2)}");
                }
                else
                {
                    Console.WriteLine("Erro: valores inválidos para logaritmo.");
                }
                break;
            case 8:
                double senoRadiano = numero1 * Math.PI / 180;
                Console.WriteLine($"sen({numero1}) = {Math.Sin(senoRadiano)}");
                break;

            case 9:
                double cosRadiano = numero1 * Math.PI / 180;
                Console.WriteLine($"cos({numero1}) = {Math.Cos(cosRadiano)}");
                break;

            case 10:
                double tanRadiano = numero1 * Math.PI / 180;
                Console.WriteLine($"tan({numero1}) = {Math.Tan(tanRadiano)}");
                break;
        }
    }
}