using System;

namespace ejerc8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una lista de números que corta cuando se
            //ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.

            int n, min2, min1, b1, b2;
            b1 = 0;
            b2 = 0;
            min2 = 0;
            min1 = 0;

            Console.WriteLine("ingrese un numero por favor");
            n = int.Parse(Console.ReadLine());
             
            while (n != 0){
                if(b1 == 0){
                    min1 = n;
                    b1 = 1;
                }else{
                    if(b2 == 0){
                        if(n < min1){
                            min2 = min1;
                            min1 = n;
                            b2 = 1;
                        }else{
                            min2 = n;
                            b2 = 1;
                        }
                    }else{
                        if(n < min1){
                            min2 = min1;
                            min1 = n;
                        }else{
                            if(n < min2){
                                min2 = n;
                            }
                        }
                    } 
                }
                   Console.WriteLine("ingrese un numero por favor");
                   n = int.Parse(Console.ReadLine()); 
            }       
        
            Console.WriteLine("el minimo es: " + min1);
            Console.WriteLine("el segundo menor es: " + min2);
        
        
        } 
                
            
    }
}

