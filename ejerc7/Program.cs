using System;

namespace ejerc7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una lista de números que corta cuando se
            //ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición
            //en la que fue ingresado.

            int N, MAX, POS;
            MAX = 0;
            POS = 0;

               Console.WriteLine("ingrese un numero");
                N = int.Parse(Console.ReadLine());


            while (N != 0){
                
                if(N > MAX){
                    MAX = N;
                    POS++;
                }
                
                

               Console.WriteLine("ingrese un numero");
                N = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("EL MAXIMO DE LOS NUMEROS ES: " + MAX);
            Console.WriteLine("LA POSICION EN LA QUE FUE INGRESADO ES: " + POS);
        }
    }
}
