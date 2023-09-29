using System;

class ejercicio2
{
    static void Main(string[] arg) 
    {
        Console.WriteLine("Ingrese la primera cadena:");
        string cadena1 = Console.ReadLine();

        Console.WriteLine("Ingrese la segunda cadena:");
        string cadena2 = Console.ReadLine();

        int resultadoCompareTo = cadena1.CompareTo(cadena2);

        if (resultadoCompareTo == 0)
        {
            Console.WriteLine("Las cadenas son iguales según CompareTo().");
        }
        else
        {
            Console.WriteLine("Las cadenas no son iguales según CompareTo().");
        }

        bool sonIguales = cadena1.Equals(cadena2);

        if (sonIguales)
        {
            Console.WriteLine("Las cadenas son iguales según Equals().");
        }
        else
        {
            Console.WriteLine("Las cadenas no son iguales según Equals().");
        }
    }
}

