using System;

namespace ejerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            // HACER UN PROGRAMA QUE SOLICITE LA EDAD DE UN GRUPO DE PERSONAS. EL PROGRMA DEBERA 
            //PEDIR EDADES HASTA QUE SE INGRESE UNA EDAD MENOR A 18 AÑOS. DEBERA MOSTRAR POR PANTALLA 
            // CUANTAS PERSONAS MAYORES SE REGISTRARON.
            
            int edad, cont;
            cont = 0;
            Console.WriteLine("ingrese una edad");
            edad = int.Parse(Console.ReadLine());
         
            while(edad > 18){
                cont++;
                Console.WriteLine("ingrese una edad");
                edad = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("la cantidad de edades mayores a 18 son: " + cont);
        }
    }
}
