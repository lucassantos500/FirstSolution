using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[3];//Criando uma array de inteiros de tamanho 3
            vetor1[0] = 10;//adicionando valor 10 a posição 0 do vetor
            vetor1[1] = 20;//adicionando valor 20 a posição 1 do vetor
            vetor1[2] = 30;//adicionando valor 30 a posição 2 do vetor

            int[] vetor2 = new int[3] { 10, 20, 30 };//Outra forma de adicionar os valores as posições

            int[,] vetor3 = new int[3, 3];//Criando uma array multidimensioonal de inteiros de tamanho 3x3
            vetor3[0, 0] = 10;//adicionando valor 10 a posição 0,0 do vetor

            Console.WriteLine(vetor1);
            Console.ReadLine();

            ArrayList arrayList = new ArrayList();//Criando uma ArrayList de tamanho dinâmico (importa biblioteca Collections)
            arrayList.Add(10);//adicionando valor int 10 a posição 0 no ArrayList
            arrayList.Add("Ok");//adicionando string OK na posição 1 do ArrayList
            arrayList.Add(true);//adicionado boolean true na posição 2 do ArrayList
        }
    }
}
