using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, total = 0;
            string operador;
            Console.WriteLine("Digite o 1 numero ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2 numero ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a operação");
            operador = Console.ReadLine(); 

           switch (operador) 
            {
                case "+": 
                    total = a + b; break;

                    case "-":
                    total = a - b;
                    break;

                    case "*":
                    total = a * b; break;

                    case "/":
                    total = a / b; break;

                
            }

            Console.WriteLine("O resultado foi: " + total);

        }
    }
}
