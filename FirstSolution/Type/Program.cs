using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 10;//Criando uma variável do tipo int
            string B = "Olá";//Criando uma variável do tipo string
            char ch = 'A';//Criando uma variável do tipo char
            bool valor = true;//ou false
            float ff = 10.89F;//Criando uma variável do tipo float
            double dd = 90.9876;//Criando uma variável do tipo decimal
            decimal dec = 10.88M;//Criando uma variável do tipo dec

            float VERDE;//Variável com sublinhado verde = Não instânciada

            Console.WriteLine(A);//Imprimindo a variavel A na tela
            Console.WriteLine(B);//Imprimindo a variavel B na tela
            Console.ReadLine();
        }
    }
}
