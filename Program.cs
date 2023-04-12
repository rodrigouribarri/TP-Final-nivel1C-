using System;

namespace TPFinal_Uribarri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            //a. El mayor de los números pares.
            //b. La cantidad de números impares.
            //c. El menor de los números primos.

            //Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int mayorPar = 0, contImpares = 0, menorPrimo = 0, n;
            

            Console.WriteLine("Por favor ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (primo(n)){
                    if ((menorPrimo == 0) || (n < menorPrimo))
                        menorPrimo = n;
                }
                 

                if (n %2 != 0)
                {
                    contImpares++;
                }else
                {
                    if ( n > mayorPar)
                    {
                        mayorPar = n;
                    }
                }            
                Console.WriteLine("Por favor ingrese otro número o cero para terminar: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El número par mayor es: " + mayorPar);
            Console.WriteLine("La cantidad de números impares es: " + contImpares);
            if(menorPrimo == 0)
                Console.WriteLine("No se han ingresado números primos");
            else
                Console.WriteLine("El menor de los números primos es: " + menorPrimo);
        }

        static bool primo(int n){
        int con = 0;

        for (int x = 1; x <= n; x++)
        {
            if (n % x == 0 )
                con++;
        } 
        if (con == 2)
                return true;
            else
                return false;
         
        }
        
    }
}
