﻿using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, menor;

            Console.WriteLine("Ingrese un numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el ultimo numero");
            d = int.Parse(Console.ReadLine());

            if ( a < b ) {
                menor = a;
            } else {
                menor = b;
            }
            if ( c < menor ) {
                menor = c;
            } 
            if ( d < menor) {
                menor = d;
            }
            Console.WriteLine("el valor menor es : " + menor);
        }
    }
}
