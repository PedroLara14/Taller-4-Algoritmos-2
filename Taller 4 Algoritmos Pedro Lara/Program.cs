using System;

namespace App
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra ");
            String palabra = Console.ReadLine();
            if (Verificacion_PalabraPalindroma(palabra)) Console.WriteLine("Es palíndroma");
            else Console.WriteLine("NO es palíndroma");
        }

        static Boolean Verificacion_PalabraPalindroma(String cadena)
        {
            if (cadena.Length < 2) return true;
            if (cadena[0] == cadena[cadena.Length - 1]) return Verificacion_PalabraPalindroma(cadena.Substring(1, cadena.Length - 2));
            return false;
        }
    }
}
