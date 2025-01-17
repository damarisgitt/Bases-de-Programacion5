using System;

namespace ejerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite dos números y luego muestre los números
            //entre el menor y el mayor de ellos. Acordate, usando While.

            int N1, N2, men, may;


            Console.WriteLine(" ingrese  un numero ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ingrese  un numero ");
            N2 = int.Parse(Console.ReadLine());

            if (N1 < N2) {
                men = N1;
                may = N2;
            }else{  
                men = N2;
                may = N1;
            }
            

            while (men < may ){
                
                Console.WriteLine(men);
                 men ++;

            }


    }
}

}
