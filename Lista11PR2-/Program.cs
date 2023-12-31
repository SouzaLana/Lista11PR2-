﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
                vet[i] = rand.Next(10, 1500);
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

            for (int i = 0; i < 20000; i++)
            {
                vet[i] = rand.Next(10, 5000);
            }

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 20000; i++)
            {
                if (num == vet[i])
                {
                    n += 1;
                }
            }
            Console.WriteLine("O número aparece " + n + " vezes no vetor");
            Console.ReadKey();
        }
        public static void Ex3()
        {
            int[] vet, vet1;
            vet = new int[10];
            vet1 = new int[10];
            Random ran = new Random();

            for (int i = 0; i < 5000; i++)
            {
                vet[i] = ran.Next(10, 50);
            }

            for (int i = 0; i < 5000; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    vet1[i] = vet[i] / 2;
                }
                else
                {
                    vet1[i] = vet[i] * 3;
                }
            }

            for (int i = 0; i < 5000; i++)
            {
                Console.WriteLine("vet[{0}] = {0}", i, vet[i]);
                Console.WriteLine("vet1[{0}] = {0}", i, vet1[i]);
            }
            Console.ReadKey();
        }
        public static void Ex4()
        {
            int k = 1, cont = 0;
            int[] vet, vet1 = new int[cont];
            vet = new int[5000];
            Random ran = new Random();

            for (int i = 0; i < 5000; i++)
            {
                vet[i] = ran.Next(10, 50);

                for(int j = 1; j < vet[i]; j++)
                {
                    if (vet[i] % j != 0)
                    {
                        cont += 1;
                        vet1[k] = vet[i];
                    }
                }
            }
            Console.WriteLine(vet1[k]);
            Console.ReadKey();
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