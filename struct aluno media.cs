using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura
{
    class Program
    {
        public struct MediaAluno
        {
            public string nome;
            public double nota1;
            public double nota2;
            public double media;
        }

        static void Main(string[] args)
        {
            string situacao;
            

            MediaAluno[] aluno = new MediaAluno[15];

           for ( int i = 0; i < 2; i++)
           {
                Console.Write("Digite o Nome do Aluno: ");
                aluno[i].nome = Console.ReadLine();

                Console.Write("Digite a Primeira Nota: ");
                aluno[i].nota1 = double.Parse(Console.ReadLine());

                Console.Write("Digite a Segunda Nota : ");
                aluno[i].nota2 = double.Parse(Console.ReadLine());

                aluno[i].media = (aluno[i].nota1 + aluno[i].nota2) / 2;

                

                Console.WriteLine();


                

           }

            
            Console.WriteLine("==============================LISTA==========================================");
            Console.WriteLine("Aluno     |      Nota 1      |   Nota 2      |    Media        |    Situação ");

            for ( int i = 0; i < 2; i++)
            { 
                Console.WriteLine(aluno[i].nome + "             " + aluno[i].nota1 +"              "+ aluno[i].nota2 +"             "+ aluno[i].media+"            ");

            }                               
               

            Console.ReadKey();
                            

           
        }

        

    }
}
