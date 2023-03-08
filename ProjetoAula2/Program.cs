using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * minha solução
            int frente = 5 ;
            int lado = 10;
            Console.WriteLine("Perimetro = " + frente*2+lado*2);
            Console.WriteLine("Área= " + frente*lado);
            Console.ReadKey();
            */

            /* SOLUÇÃO DA PROFESSORA*/
            /*
                    double lado, frente, area, perimetro;

                    Console.WriteLine("Informe a metragem" + " da frente");
                    frente = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Informe a metragem" + " do lado");
                    lado = Convert.ToDouble(Console.ReadLine());

                    area = lado * frente;
                    perimetro = lado * 2 + frente * 2;
                    Console.WriteLine("Sua area é = " + area);
                    Console.WriteLine("Seu perimetro é = " + perimetro);

                    Console.ReadKey();
            */

            /*Minha solução teste converter int32
                       int frente;
                       int lado;
                       Console.Write("INSIRA O VALOR FRENTE = ");
                       frente = Convert.ToInt32(Console.ReadLine());

                       Console.Write("INSIRA O VALOR LADO = ");
                       lado = Convert.ToInt32(Console.ReadLine());

                       Console.WriteLine("SUA ÁREA É DE = " + lado*frente);
                       Console.WriteLine("SEU PERÍMETRO É DE = " + (lado+lado+frente+frente));

                       Console.ReadKey();
            */

            /* 1) Fazer um programa que recebe 2 notas e mostre a média.
            double nota1, nota2;

            Console.WriteLine("Insira a primeira nota = ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota = ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sua média é: " + ((nota1 + nota2) /2));

            Console.ReadKey();  
            */

            /* 2) Fazer um Programa que recebe o valor de um produto e mostre o valor a pagar.
             * considere o desconto de 5%

            double valor;

            Console.WriteLine("Insira seu valor = ");
            valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor a ser pago = " + (valor-(0.05*valor)));
            Console.ReadKey();

            */

            /* 3) FAzer um Programa que mostre o valor a pagar da castanha, sabe-se que o valor do quilo
             * da castanha é 65 reais e o programa recebe o peso em gramas */

            double castanhakg;

            Console.WriteLine("Quantos Quilos de castanha você quer?");
            castanhakg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor a ser pago = " + castanhakg * 65);

            Console.ReadKey();



        }
    }
}
