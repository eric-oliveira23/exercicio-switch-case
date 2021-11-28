using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int teste;

            Console.WriteLine("Digite 1 ou 2.");
            teste = int.Parse(Console.ReadLine());

            switch (teste)
                {

                case 1:
                    Console.WriteLine("Um");
                    break;

                case 2:
                    Console.WriteLine("Dois");
                    break;

                default:
                    Console.WriteLine("Parâmetro Inválido.");
                    break;


                }

            Console.ReadKey();

            int n1, n2, resultado;
            string op;

            Console.WriteLine("Digite o Primeiro Operador.");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Operador.");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Operação. (+, -, *, /)");
            op = Console.ReadLine();




            switch (op)
            {

                case "+":
                    resultado = n1 + n2;
                    Console.WriteLine("O Resultado Será de: " + resultado);
                    break;

                case "-":
                    resultado = n1 - n2;
                    Console.WriteLine("O Resultado Será de: " + resultado);
                    break;

                case "*":
                    resultado = n1 * n2;
                    Console.WriteLine("O Resultado Será de: " + resultado);
                    break;

                case "/":
                    resultado = n1 / n2;
                    Console.WriteLine("O Resultado Será de: " + resultado);
                    break;

                default:
                    Console.WriteLine("Parâmetro Inválido.");
                    break;
            }

            Console.ReadKey();

            
        }
    }
}
