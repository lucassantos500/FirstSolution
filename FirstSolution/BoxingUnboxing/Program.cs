using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;//Criando variável do tipo inteiro a
            object o = (object)a;//criando uma variável do tipo object(GENERICA) o e armazenado o valor do inteiro a
            Console.WriteLine(o.GetType().ToString());//Convertendo o valor genérico para string

            int b = (int)o;//Convertendo a variável genérica em um inteiro e armazenando em b
            //((int)o).ToString()
            Console.WriteLine(b);//imprimindo b

            b.GetType();//retorna o tipo de b
            System.Type t = b.GetType();//Cria uma variável t do mesmo tipo da variável de b
            Console.ReadKey();
            

        }
    }
}
