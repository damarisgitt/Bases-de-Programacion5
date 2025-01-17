using System;

namespace ejerc10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una lista de números que corta cuando se
            //ingresa un cero y luego emitir por pantalla el máximo de los números
            //negativos y el mínimo de los números positivos.

           int N1, MINP, B1, MAXN, B2;
            MINP = 0;
           B1 = 0; 
           B2 = 0; 
           MAXN = 0;
      


            Console.WriteLine("ingrese un numero");
            N1 = int.Parse(Console.ReadLine());

            while (N1 != 0)
            {   
                if (N1 > 0) {
                    if (B1 == 0){ 
                        MINP = N1;
                        B1 = 1;

                    }else {
                        if (N1 < MINP){
                            MINP = N1;
                            B1 = 1;

                        }
                    }
                } else{
                    if (B2 == 0){
                        MAXN = N1;
                        B2 = 1;
                        
                    }else {
                        if (N1 < MAXN){
                            MAXN = N1;
                            B2 = 1 ;
                        }
                    }
                }
                Console.WriteLine("ingrese un numero");
            N1 = int.Parse(Console.ReadLine());


            }  Console.WriteLine(" EL MINIMO POSITIVO ES  " + MINP  +  "  Y EL MAXIMONEGATIVO ES "  +  MAXN);


        }

    }
}
