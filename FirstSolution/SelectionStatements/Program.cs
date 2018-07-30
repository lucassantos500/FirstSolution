using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());//lendo entrada do teclado e a convertendo em inteiro
            if (a < 10)
            {
                Console.WriteLine("Menor que 10");//se a entrada for menor que 10
            }
            else
            {
                Console.WriteLine("Maior que 10");//se a entrada for maior que 10
            }

            int b = (a < 10) ? 5 : 0;//Se a < 10 então b recebe 5, caso contrário b recebe 0

            int c;
            c = int.Parse(Console.ReadLine());
            
            switch (c)
            {
                case 1://se c for 1
                    Console.WriteLine("c == 1");
                    break;
                case 2://Se c for 2
                    Console.WriteLine("c == 2");
                    break;
                default://Se c for qualquer outra coisa
                    Console.WriteLine("c == "+c);
                    break;
            }
        }
    }
}
