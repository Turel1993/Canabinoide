using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //triangulo
            /* double Base, Altura, Resul;
             String linea;

             Console.Write("digita la base: ");
             linea = Console.ReadLine(); 

             Base = double.Parse(linea);
             Console.Write("digita la altura");
             linea = Console.ReadLine();

             Altura = double.Parse(linea);
             Resul = (Base * Altura) / 2;

             Console.WriteLine("Area del triangulo es " + String.Format("{0}", Resul));
             Console.WriteLine(""); */

            //Cuadrado
            double lado;
            String line;
            double resultado;

            Console.WriteLine("Digita la longitud del lado del cuadarado");
            line = Console.ReadLine();
            lado = Double.Parse(line);
            resultado = lado * lado;

            Console.WriteLine("El area del cuadrado es {0}", resultado);
        }
    }
}
