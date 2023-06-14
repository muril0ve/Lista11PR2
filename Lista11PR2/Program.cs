using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11PR2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.WriteLine("here ex1 will be encoded");
            int[] numeros;
            int nmr = 0;
            numeros = new int[1000];
            Random rand = new Random();


            for (int i = 0; i < 1000; i++)
            {

                numeros[i] = rand.Next(1, 1000);


            }
            Console.WriteLine("chute o valor entre 0 e 1000");
            nmr = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
            {
                if (numeros[i] == nmr)
                {
                    Console.WriteLine("parabens, voce acertou.");
                    break;
                    
                }
               
            }

        }
        public static void Exercicio2()
        {
            Console.WriteLine("here ex2 will be encoded");
            
            int[] numeros;
            int nmr = 0, ct =0;
            numeros = new int[20000];
            Random rand = new Random();


            for (int i = 0; i < 20000; i++)
            {

                numeros[i] = rand.Next(1, 20000);


            }
            Console.WriteLine("digite um valor de numero:");
            nmr = int.Parse(Console.ReadLine());

            for(int i = 0; i < 20000; i++)
            {
                if (numeros[i] == nmr)
                {
                    ct++;
                }
            }
            for(int i =0; i<20000; i++)
            {
                Console.WriteLine("p numero aparece: " + ct++);
            }
        }
        public static void Exercicio3()
        {
            Console.WriteLine("here ex3 will be encoded");
        }
        public static void Exercicio4()
        {
            Console.WriteLine("here ex4 will be encoded");
            int[] numeros;
            int nmr = 0;
            numeros = new int[5000];
            Random rand = new Random();


            for (int i = 0; i < 5000; i++)
            {

                numeros[i] = rand.Next(1, 5000);


            }
            Console.WriteLine("digite um nmr qulaquer: ");

            for (int i = 0; i < 5000; i++)
            {
                if (numeros[i] % 2 != 0 && numeros[i] % 3 != 0 && numeros[i] % 5 != 0)
                {
                    Console.WriteLine("o numeros digitado é primo");
                    Console.WriteLine("numeros primos {0} ", numeros[i]);
                }
            }


        }
       

        static void Main(string[] args)
        {

            int option;

            do
            {
                Console.WriteLine("===========MENU=========");
                Console.WriteLine("para executar o exercício 1 - digite 1");
                Console.WriteLine("para executar o exercício 2 - digite 2");
                Console.WriteLine("para executar o exercício 3 - digite 3");
                Console.WriteLine("para executar o exercício 4 - digite 4");
                Console.WriteLine("para executar o exercício 5 - digite 5");
                Console.WriteLine("para sair digite 0");

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Thank you for using my system!");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    
                }

            }
            while (option != 0);

            {

            }
        }
    }
}


