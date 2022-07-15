using System;

namespace tabuadaCs
{
    class Tabuada
    {
        static void Main(string[] args)
        {

            int tabuada;

            Console.WriteLine("Iniciando Algoritmo de tabuada");
            Console.WriteLine("Escreva o número da tabuada");
            tabuada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tabuada de " + tabuada + " é: ");
            for(int i = 0; i <= 10; i++) {
                Console.WriteLine(tabuada + " X " + i + " = " + tabuada * i);
            }
        }
    }
}
