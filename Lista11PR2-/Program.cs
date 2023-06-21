using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11PR2_
{
    internal class Program
    {
        public static void Ex1()
        {
            int[] vet;
            int num;
            vet = new int[1000];
            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                vet[i] = rand.Next(1, 1500);
                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if (num == vet[i])
                {
                    Console.WriteLine("Está no vetor");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Não está no vetor");
                }
            }
        }
        public static void Ex2()
        {
            int num = 0, n = 0;
            int[] vet;
            vet = new int[20000];
            Random rand = new Random();

            for (int i = 0; i < 5000; i++)
            {
                vet[i] = rand.Next(1, 5);
                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if (num != vet[i])
                {
                    Console.WriteLine();
                }
                else
                {
                    n += 1;
                    Console.WriteLine("O número aparece " + n + " vezes no vetor");

                    i = 5000;
                }
            }
        }
        public static void Ex3()
        {

        }
        public static void Ex4()
        {
            int[] vet;
            vet = new int[5000];
            Random ran = new Random();

            for (int i = 0; i < 5000; i++)
            {
                vet[i] = ran.Next(1, 5);
            }
        }
        static void Main(string[] args)
        {
            int op;

            Console.WriteLine("===MENU===");
            Console.WriteLine("Exercício 1");
            Console.WriteLine("Exercício 2");
            Console.WriteLine("Exercício 3");
            Console.WriteLine("Exercício 4");
            Console.WriteLine("Escolha um exercício: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Ex1();
                    break;
                case 2:
                    Ex2();
                    break;
                case 3:
                    Ex3();
                    break;
                case 4:
                    Ex4();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}