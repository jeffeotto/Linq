using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] numeros = new int[] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };


            //Fase1
            var numeroArray = numeros.Where(n => Primo(n)).ToArray();


            foreach (int num in numeroArray)
            {
                Console.Write("{0,1} ", num);
            }

            //Fase2

            notaMaxima(numeros);
            notaMinima(numeros);


            //Fase3
            var numerosPlus =
               (from n in numeros
                where n > 5
                select n).ToArray();

            Console.WriteLine("Números mayores que 5.");
            foreach (var number in numerosPlus)
            {
                Console.WriteLine(number);
            }

            var numerosLess =
               (from n in numeros
                where n < 5
                select n).ToArray();

            Console.WriteLine("Números menores que 5.");
            foreach (var number in numerosLess)
            {
                Console.WriteLine(number);
            }



            //Fase4

            string[] names = new string[7] { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };

            var letterO =
                from name in names
                where name.StartsWith('O')
                select name;


            Console.WriteLine("Nombre que empiezan por la O");
            foreach (var name in letterO)
            {
                Console.WriteLine(name);
            }



            Console.WriteLine("Nombre con más de 6 letras");
            var plusSix =
                from name in names
                where name.Length > 6
                select name;

            foreach (var name in plusSix)
            {
                Console.WriteLine(name);
            }



            Console.WriteLine("Array nombres en orden descendiente");
            var descentOrder =
               from name in names
               orderby name descending
               select name;

            foreach (var name in descentOrder)
            {
                Console.WriteLine(name);
            }

        }


        static void notaMaxima(int[] numeros)
        {
            var max = numeros[0];
            for (var i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > max)
                {
                    max = numeros[i];
                }
            }
            Console.WriteLine($"La nota máxima del array es {max}");
        }

        static void notaMinima(int[] numeros)
        {
            var min = numeros.Length == 0 ? 0 : numeros[0];
            for (var i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < min)
                {
                    min = numeros[i];
                }
            }
            Console.WriteLine($"La mínima del array es {min}");
        }


        public static bool Primo(int numero)
        {
            int divisor = 2;

            while (divisor < numero)
            {
                if (numero % divisor == 0) return false;
                divisor += 1;
            }
            return true;
        }


    }
}
