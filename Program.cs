using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laco_repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ex 1 - Contagem Crescente");
            Console.WriteLine("Ex 2 - Tabuada");
            Console.WriteLine("Ex 3 - Soma de números");
            Console.WriteLine("Ex 4 - Advinhar o número entre 1 e 100");
            menu = int.Parse(Console.ReadLine());


            if (menu == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                int contador = 1;
               
                Console.Write("Digite um número: ");
                int escolha = int.Parse(Console.ReadLine());


                while (contador <= escolha)
                {
                   
                    Console.WriteLine(contador);
                    contador = contador + 1;
                }
            }

            if (menu == 2)
            {
                Console.Clear ();
                Console.ForegroundColor= ConsoleColor.Blue;
                int contador = 1;

                Console.Write("Digite um número inteiro desejado para a tabuada: ");
                int escolha = int.Parse(Console.ReadLine());
                
                while(contador <= 10)
                {
                    
                    int resultado = escolha * contador;
                    Console.WriteLine(escolha + " X " + contador + " = " + resultado);
                    contador++;
                }


            }

            if (menu == 3)
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Magenta;
                //int contador = 1;

                Console.Write("Insira um valor: ");
                int valor = int.Parse(Console.ReadLine());
                int soma = 0;
                
                while (valor != 0)
                {
                    soma = valor + soma;
                    Console.WriteLine("Total = " + soma);
                    Console.Write("\nDigite outro valor ou 0 para finalizar: ");
                    valor = int.Parse(Console.ReadLine());

                    if (valor == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nO Resultado da soma foi: " + soma);
                    }
                }
            }

            if (menu == 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Random num = new Random();
                int valor = num.Next(0, 101);

                //Console.WriteLine(valor);
                int tentativas = 0;
                int chute = 0;

                

                while (chute != valor)
                {
                    tentativas++;
                    Console.ResetColor();
                    Console.Write("\nDê um chute: ");
                    chute = int.Parse(Console.ReadLine());
                    
                    if (chute < valor)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nSeu valor está abaixo!");
                        
                    }

                    else if (chute > valor)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nSeu valor está acima!");
                    }

                    else 
                    {
                        Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine("\nParabéns, Você acertou com apenas "+tentativas+" Tentativas!");
                        
                    }


                }
            }

            Console.ReadKey();
        }
    }
}