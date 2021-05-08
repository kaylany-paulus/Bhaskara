using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            int numericName;
            bool validUsername, validNumber;

            double a = 1.0, b = 1.0, c = -4.0;
            double delta = (b * b) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("\nBEM VINDO(A)! ESTE PROGRAMA CALCULARÁ BHASKARA PARA VOCÊ, DEIXANDO TUDO MAIS FACÍL!");
            Console.ResetColor();
            Console.Write("\nMas antes por favor me diga seu nome..: ");
            username=Console.ReadLine();
            validUsername= Int32.TryParse(username, out numericName);

                if (validUsername)
                {
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine(
                        "\nO VALOR DIGITADO NÃO CORRESPONDE A UM VALOR LITERAL!");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }
            Console.Clear();
            Console.Write("\nDigite o valor de (A)..:");
            double.TryParse(Console.ReadLine(), out a);

                if(a == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine(
                        $"\n\nO VALOR FORNECIDO NÃO É UMA EQUAÇÃO DE SEGUNDO GRAU!");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }

            Console.Write("Digite o valor de (B)..:");
            double.TryParse(Console.ReadLine(), out b);

                if(b < 0)
                {
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine(
                        $"\n\nCOMO DELTA = {delta}, A EQUAÇÃO NÃO POSSUÍ RAÍZES REAIS!");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }

            Console.Write("Digite o valor de (C)..:");
            double.TryParse(Console.ReadLine(), out c);

            Console.WriteLine("\n\n-- Equação do segundo grau --");
            Console.WriteLine($"\n\nResultado (x1)..:{x1:N2}");
            Console.WriteLine($"\nResultado (x2)..:{x2:N2}");

            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine($"\nOBRIGADA {username.ToUpper()} POR UTILIZAR O PROGRAMA!");
            Console.ResetColor();
            Environment.Exit(-1);
        }
    }
}
