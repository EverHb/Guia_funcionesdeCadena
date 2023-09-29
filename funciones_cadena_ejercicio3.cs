using System;

class Ejercicio3
{
    static void Main(string[] args)
    {
        string cadena = "MI MAMA ME MIMA, AMO A MI MAMA";

        string cadenaMin = cadena.ToLower();

        string[] palabras = cadenaMin.Split(' ');

        string[] resultado = new string[palabras.Length];

        for (int i = 0; i < palabras.Length; i++)
        {
            if (palabras[i].Length < 3)
            {
                resultado[i] = palabras[i] + "%";
            }
            else
            {
                resultado[i] = palabras[i];
            }
        }
        string cadenaResultante = string.Join(" ", resultado);

        Console.WriteLine(cadenaResultante);
    }
}
