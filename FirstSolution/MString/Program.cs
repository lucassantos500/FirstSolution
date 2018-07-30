using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "1,2";//Criando variável do tipo string com valores 1,2
            s1 += ",3";//Concatenando 3 a string e obtemos assim 1,2,3

            System.Text.StringBuilder sb = new StringBuilder();//Criando um objeto StringBuilder;
            sb.Append("1,");//adicionando o valor 1 ao StringBuilder
            sb.Append("2,");//adicionando o valor 2 ao StringBuilder
            sb.Append("3");//adicionando o valor 3 ao StringBuilder
            //Obtemos assim 1,2,3 com o StringBuilder

            Console.WriteLine(s1);
            Console.WriteLine(sb);
            Console.ReadKey();

            Console.WriteLine((sb.ToString()).IndexOf("2"));
            Console.WriteLine(s1.IndexOf("2"));
            Console.ReadKey();



        }
    }
}
