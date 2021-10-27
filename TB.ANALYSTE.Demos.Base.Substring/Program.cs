using System;

namespace TB.ANALYSTE.Demos.Base.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!".Substring(0,5));
            string message = "Hola! Bienvenu en C#!";
            string matiere = message.Substring(18);
            Console.WriteLine(matiere);
            string input = Console.ReadLine();
            input = input.Substring(3);
            Console.WriteLine( input );
        }
    }
}
