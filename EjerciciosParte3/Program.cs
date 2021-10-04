using System;

namespace EjerciciosParte3
{
    class Program
    {
        /*  public static int Signo(int num1)
          {
            if(num1 < 0)
               {
                  return num1 = -1;

              }else if (num1 > 0)
               {
                return  num1 = 1;   
               }else
               {
                return  num1 = 0;
              }


           } public static void Main()
           {
              int numeroIngresado;
              Console.WriteLine("Ingrese un numero");
               numeroIngresado = System.Convert.ToInt32(Console.ReadLine());
               Console.WriteLine(Signo(numeroIngresado));

           }*/


        // Ejercicio 2 Crea una función "Menor" que calcule el menor de dos números enteros que
        //  recibirá como parámetros.El resultado será otro número entero.


        /*  public static int Menor(int num1, int num2)
          {
             int numeroMenor = num1 < num2 ? num1 : num2;
              int resultado = numeroMenor - 1;
              return resultado;

         }
           public static void Main()
          {
              int primerNumero, segundoNumero;
              Console.WriteLine("Ingrese el primer numero");
              primerNumero = System.Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Ingrese el segundo numero");
              segundoNumero = System.Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Un numero menor es:"+ Menor(primerNumero, segundoNumero));
           }*/
        /*  public static void Main()
          {
              Console.WriteLine("ingrese un numero");
              int num;
              num = System.Convert.ToInt32(Console.ReadLine());
              Console.WriteLine(Primo(num));
              Console.ReadKey();


          }

          public static bool Primo(int esPrimo)
          {


            int  resultado1 = esPrimo / esPrimo;
              int resultado2 = esPrimo / 1;
              bool resultado = false;
              if (esPrimo == 1)
              {
                  resultado = true & (esPrimo == 0);
              }
              return resultado;
          } */
        /* public static void Main()
         {
             int opcion; int num1, num2;
             Console.WriteLine("Indique que opcion quiere usar");
             Console.WriteLine("presione 1 para sumar");
             Console.WriteLine("presione 2 para restar");
             Console.WriteLine("presione 3 para multiplicar");
             Console.WriteLine("presione 4 para dividir");
             opcion = System.Convert.ToInt32(Console.ReadLine());

             switch (opcion)
             {
                 case 1:
                     Console.WriteLine("Indique los dos numeros a sumar");
                     Console.WriteLine("ingrese el primer numero");
                     num1 = System.Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("ingrese el segundo numero ");
                     num2 = System.Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine(Sumar(num1, num2));
                     Console.ReadKey();
                     break;

                 case 2:
                     Console.WriteLine("Indique los dos numeros a restar");
                     Console.WriteLine("ingrese el primer numero");
                     num1 = System.Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("ingrese el segundo numero");
                     num2 = System.Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine(Resta(num1, num2));
                     Console.ReadKey();
                     break;

                 case 3:
                     Console.WriteLine("Indique los dos numero a multiplicar");
                     Console.WriteLine("ingrese el primer numero");
                     num1 = System.Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("ingrese el segundo numero");
                     num2 = System.Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine(Multi(num1, num2));
                     Console.ReadKey();
                     break;

                 case 4:
                     Console.WriteLine("Indique los dos numero a dividir");
                     Console.WriteLine("ingrese el primer numero");
                     num1 = System.Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("ingrese el segundo numero");
                     num2 = System.Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine(Division(num1, num2));
                     Console.ReadKey();
                     break;

             }
         }     public static int Sumar(int numeroPrimero, int numeroSegundo)
             {
                 int resultado = numeroPrimero + numeroSegundo;
                 return resultado;
             }

         public static int Resta(int numeroPrimero, int numeroSegundo)
         {
             int resultado = numeroPrimero - numeroSegundo;
             return resultado;
         }

         public static int Multi(int numeroPrimero, int numeroSegundo)
         {
             int resultado = numeroPrimero * numeroSegundo;
             return resultado;
         }

         public static int Division (int numeroPrimero, int numeroSegundo)
         {
             int resultado = numeroPrimero / numeroSegundo;
             return resultado;
         }*/

        /*  public static void Main()
          {
              int numeroIngresado;
              Console.WriteLine("ingrese su numero");
              numeroIngresado = System.Convert.ToInt32(Console.ReadLine());
              Console.WriteLine(SumarCifra(numeroIngresado));

          }

       public static int SumarCifra(int cifra)
          {
              int suma = 0;
              while (cifra > 0)
              {
                  suma = suma + cifra % 10;
                  cifra = cifra / 10;

              }
              return suma; 

          }*/
        public static void Main()
        {
            String letra;
            int num;
            Console.WriteLine("Ingrese un simbolo");
            letra = Console.ReadLine();
            Console.WriteLine("ingrese un numero");
            num = System.Convert.ToInt32(Console.ReadLine());
            Triangulo(letra, num);
            Console.ReadKey();

        }

        public static void Triangulo(String simbolo1, int num1)
        {
            

            for (int i = num1 ; i <= num1 ; i--)
            {
                Console.WriteLine("");
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(simbolo1);
                   
                }

            }
            
    }   } 
}
