using System;

namespace ejerc9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar nuevamente el ejercicio 8 pero ahora debe devolver además la
            //posición en la que fue encontrado cada uno de los mínimos.
           
           int n, min2, min1, b1, b2, cont, pos1, pos2;
            b1 = 0;
            b2 = 0;
            min2 = 0;
            min1 = 0;
            cont = 0;
            pos1 = 0;
            pos2 = 0;

            Console.WriteLine("ingrese un numero por favor");
            n = int.Parse(Console.ReadLine());

            cont++;
             
            while (n != 0){
                if(b1 == 0){
                    min1 = n;
                    b1 = 1;
                    pos1 = cont;
                }else{
                    if(b2 == 0){
                        if(n < min1){
                            min2 = min1;
                            min1 = n;
                            b2 = 1;
                            pos2 = pos1;
                            pos1 = cont;
                        }else{
                            min2 = n;
                            b2 = 1;
                            pos2 = cont;
                        }
                    }else{
                        if(n < min1){
                            min2 = min1;
                            min1 = n;
                            pos2 = pos1;
                            pos1 = cont;
                        }else{
                            if(n < min2){
                                min2 = n;
                                pos2 = cont;
                            }
                        }
                    } 
                }
                   Console.WriteLine("ingrese un numero por favor");
                   n = int.Parse(Console.ReadLine()); 
                   cont++;
            }       
        
            Console.WriteLine("el minimo es: " + min1 + " la posicion es: " + pos1);
            Console.WriteLine("el segundo menor es: " + min2 + " la posicion es: " + pos2);
                
                
        }
    } 
}
