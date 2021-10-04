using System;

namespace ejerciciosPrimeraClase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tarea 2: Crea un programa que diga el resultado de sumar 200 y 56.
            //  Console.WriteLine("La suma de 200 y 56 es:");
            //  Console.WriteLine(200 + 56);

            // Tarea 3: Haz un programa que calcule el producto de los números 13 y 12.
            /* Console.WriteLine("El producto de  13 y  12 es :");
               Console.WriteLine(13 * 12); */

            //  Tarea 4: Un programa que calcule la diferencia(resta) entre 321 y 213
            /* Console.WriteLine(" La diferencia entre 321 y 213 es :");
               Console.WriteLine(321 - 213);*/

            // Tarea 5: Calcular el resultado de(20 + 5) % 6
            /* Console.WriteLine("El resultado de 20 + 5 % 6 es:");
               Console.WriteLine((20 + 5) % 6);*/

            //  Tarea 6: Crea un programa que calcule el producto de los números 12 y 102, usando
            //  variables.
            /* int num1 = 12;
               int num2 = 102;
               int resultado = 12 * 102;
               Console.WriteLine("El producto de {0} y {1} es:{2}",num1, num2,resultado);*/

            // Tarea 7: Crea un programa que calcule la suma de 200 y 1111, usando variables.
            /* int primerNumero = 200;
               int segundoNumero = 1111;
               int suma = primerNumero + segundoNumero;
               Console.WriteLine("La suma de {0} + {1} es : {2}",primerNumero,segundoNumero,suma); */

            // Tarea 8: Crea un programa que calcule el producto de los números 10 y 25, usando
            // variables llamadas "numero1" y "numero2".
            /* int numero1 = 10;
               int numero2 = 25;
               Console.WriteLine("El producto de {0} y {1} es:", numero1, numero2);
               Console.WriteLine(10 * 25);*/

            // Tarea 9: Crea un programa que calcule el producto de dos números introducidos por el
            // usuario.
            // int numero1;
            //int numero2;
            //int producto;
            // Console.WriteLine("Ingrese el primer numero");
            // numero1 = System.Convert.ToInt32(System.Console.ReadLine());
            // Console.WriteLine("Ingrese el segundo numero");
            // numero2 = System.Convert.ToInt32(System.Console.ReadLine());
            // producto = numero1 * numero2;
            // Console.WriteLine("El producto de {0} y {1} es:{2}", numero1, numero2, producto);

            // Tarea 10: Crea un programa que pida al usuario un número entero y diga si es par
            /* int numeroIngresado;
               int resultado;
               Console.WriteLine("Ingrese un numero entero");
               numeroIngresado = System.Convert.ToInt32(System.Console.ReadLine());
               resultado = numeroIngresado % 2; 
               if(resultado == 0)
               {
                Console.WriteLine("El numero es par");
               } else
               {
                   Console.WriteLine("El numero no es par");
               } */

            //Tarea 11: Crea un programa que pida al usuario dos números enteros y diga cuál es el
            // mayor de ellos.
            /*int primerNumero;
             int segundoNumero;
             int mayor;
             Console.WriteLine("Ingrese el primer numero");
             primerNumero = System.Convert.ToInt32(System.Console.ReadLine());
             Console.WriteLine("Ingrese el segundo numero");
             segundoNumero = System.Convert.ToInt32(System.Console.ReadLine());
             mayor = primerNumero > segundoNumero ? primerNumero : segundoNumero;

             Console.WriteLine("El numero mayor es {0}", mayor); */

            /* Tarea 12: Crea un programa que pida al usuario dos números enteros. Si el segundo no
             es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el contrario,
             si el segundo número es cero, escribirá "Error: No se puede dividir entre cero".*/

            /* int a, b;
             Console.WriteLine("Ingrese un numero");
             a = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("Ingrese el segundo numero");
             b = Convert.ToInt16(Console.ReadLine());
             if (b > 0 )
              {
               int division = a / b;
                Console.WriteLine("El resultado de dividir{0}por{1}es igual a:{2}",a,b,division);
              }else
              {
               Console.WriteLine("ERROR:no se puede dividir entre cero");
              }*/

            /* Tarea 13: Crea un programa que pida un número del 1 al 5 al usuario, y escriba el
              nombre de ese número, usando "switch"*/

            /* int numero;
             Console.WriteLine("Ingrese un numero entre el 1 y el 5");
             numero = Convert.ToInt16(Console.ReadLine());
             switch (numero)
             {
                 case 1: Console.WriteLine("uno"); break;
                 case 2: Console.WriteLine("dos"); break;
                 case 3: Console.WriteLine("tres"); break;
                 case 4: Console.WriteLine("cuatro"); break;
                 case 5: Console.WriteLine("cinco"); break;
                 default: Console.WriteLine("Numero incorrecto"); break;

             }*/

            /* Tarea 14: Crea un programa que escriba en pantalla los números del 1 al 10, usando
             "while".*/

            /* int n = 1;
              while (n < 11)
              {
               Console.WriteLine(n);
               n = n + 1;
              }*/

            /* Tarea 15: Crea un programa que escriba en pantalla los números del 1 al 10, usando
             "do..while".*/

            /* int n = 1;
              do
              {
                Console.WriteLine(n);
                n = n + 1;
              } while (n < 11);*/

            /* Tarea 16: Crea un programa que muestre los números del 10 al 20, ambos incluidos,
               usando “for */

            int contador;
            for (contador = 1; contador <= 20; contador++)

                Console.WriteLine("{0}", contador);

        }
    }
}
