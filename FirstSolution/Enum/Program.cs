using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum acessorio { Sapato, Bolsa, Cinto, Carteira, Colar}//Criando Enum
    class Program
    {
        static void Main(string[] args)
        {
            int item = (int) acessorio.Sapato;//Pegando a posição do item sapato && utilizando casting
            Console.WriteLine(item);//Imprimindo a pisição do item sapato
            Console.ReadLine();

            string S = "200";//Crianvo variável do tipo String
            int I = int.Parse(S);//Convertendo uma String para um int
            Console.Write(I);//Imprimindo a variável int;
            Console.ReadLine();
        }
    }
}
