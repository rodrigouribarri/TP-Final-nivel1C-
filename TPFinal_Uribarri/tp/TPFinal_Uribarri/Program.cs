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

            int mayorPar , contImpares = 0, menorPrimo, n;
            int [] numeros = new int[];

            Console.WriteLine("Por favor ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            while (n !=0)
            {
                if (n %2 != 0)
                    contImpares ++;
                else
                {
                    if (n > mayorPar)
                    {
                        mayorPar = n;
                    }
                }


                con ++;
                numeros[con] = n;
                Console.WriteLine("Por favor ingrese otro número o cero para terminar: ");
                n = int.Parse(Console.ReadLine());
            }
        }
        static int primo(int a){
            if (a )
            {
                
            }
        }
    }
}
