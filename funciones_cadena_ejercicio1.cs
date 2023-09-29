using System;

class ejercicio1
{
    public static void Main(string[] args) 
    { 
        Console.WriteLine("ingrese una cadena de texto");
        string cadena = Console.ReadLine();
        char pad = '$';
        string result;

        result = cadena.PadLeft(25, pad);
        Console.WriteLine(result);
       
    }
}
