using System;

namespace ejerc11
{
    class Program
    {
        static void Main(string[] args)
        {
        //Hacer un programa para ingresar una lista de números que corta cuando se
        //ingresa un cero y luego mostrar: la cantidad de números primos, la cantidad de
        //números pares, la cantidad de positivos y la cantidad de negativos.

        int n, pos, neg, pares, primos, CONT,D;
        pos = 0;
        neg = 0;
        pares = 0;  
        primos = 0;
        CONT = 0;
        D = 1;

        Console.WriteLine("INGRESE UN NUMERO");
        n = int.Parse(Console.ReadLine());

        

        while (n != 0)
        {
          
          if(n > 0){
            pos++;
          }else{
            neg++;
          }


          if(n % 2 == 0){
              pares++;
          }

          //while(D <= n){
             // if(n % D == 0){
                //CONT++;
               // D++;
             // }
          //} 
            
          //if(CONT == 2){
             // primos++;
          //}
          while (D <= n){
                        if(n % D == 0){
                            CONT ++;
                          }
                        D++;

                }
                if(CONT == 2){
                   primos++;
                }
          
          Console.WriteLine("ingrese un numero");
          n = int.Parse(Console.ReadLine());

        }
          Console.WriteLine("la cantidad de negativos son: " + neg);
          Console.WriteLine("la cantidad de positivos son: " + pos);
          Console.WriteLine("la cantidad de pares es: " + pares);
          Console.WriteLine("la cantidad de primos es: " + primos);
             
      } 
    }     

}

  




    
    

