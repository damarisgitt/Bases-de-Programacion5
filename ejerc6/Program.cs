using System;

namespace ejerc6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite UN número y luego calcule y emita un cartel
            //aclaratorio si el mismo es primo o no es primo.
            //Nota: usando While. Ya lo hicimos con FOR, ahora con While.


                int N, D, cont;
                cont = 0;
                D = 1;

                Console.WriteLine("dame un numero");
                N = int.Parse(Console.ReadLine());
                
                
                while (D <= N){
                        if(N % D == 0){
                            cont ++;
                            D ++;
                        }
                }if(cont == 2){
                   Console.WriteLine("es tu primo");
                }else{
                    if(cont != 2 ) {
                    Console.WriteLine("no es tu primo ");}
                }





        }
    }
}
