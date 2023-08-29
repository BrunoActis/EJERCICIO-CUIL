using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUIL
{
    class Program
    {

        static string ValidarIngreso()
        {
            Console.WriteLine("Ingresar si es hombre (h), mujer (m) o empresa (e)");
            string tipo = Console.ReadLine();
            while ((tipo != "h") && (tipo != "m") && (tipo != "e"))
            {
                Console.Clear();
                Console.WriteLine("el valor ingresado no corresponde a las opciones, elija de nuevo por favor:");
                Console.WriteLine("Ingresar si es hombre (h), mujer (m) o empresa (e)");
                Console.Write("Su opcion es : ");
                tipo = Console.ReadLine();  
            }
            return tipo;
        }
        static string ValidarDni()
        {
            string letras = "[abcdefghijklmnopqrstuvwxyz]";
            Console.WriteLine("Ingrese su número de DNI");
            string DNI = Console.ReadLine();

            bool coincidencia = (letras.Intersect(DNI).Count() > 0);
            while (coincidencia == true || DNI.Length != 8)
            {
                Console.Clear();
                Console.WriteLine("Recuerde que el DNI no debe contener letras y debe ser de 8 digitos numericos");
                Console.Write("Vuelva a ingresar su DNI: ");
                DNI = Console.ReadLine();
                coincidencia = (letras.Intersect(DNI).Count() > 0);
                Console.ReadKey();
            }

            return DNI;
        }

        static void Main(string[] args)
        {
            string tipo;
            string DNI;
            int suma = 0;
            int redondeo;
            int N;
            int DV;

            tipo = ValidarIngreso();
            DNI = ValidarDni();

            switch (tipo)
            {
                case "h":

                    suma = 10 + ((int)char.GetNumericValue(DNI[0]) * 3) + ((int)char.GetNumericValue(DNI[1]) * 2) + ((int)char.GetNumericValue(DNI[2]) * 7) + ((int)char.GetNumericValue(DNI[3]) * 6) + ((int)char.GetNumericValue(DNI[4]) * 5) + ((int)char.GetNumericValue(DNI[5]) * 4) + ((int)char.GetNumericValue(DNI[6]) * 3) + ((int)char.GetNumericValue(DNI[7]) * 2);
                    redondeo = suma / 11;
                    N = suma - (redondeo * 11);
                    DV = (11 - N);
                    Console.WriteLine($"20-{DNI}-{DV}");
                    break;

                case "m":

                    suma = 38 + ((int)char.GetNumericValue(DNI[0]) * 3) + ((int)char.GetNumericValue(DNI[1]) * 2) + ((int)char.GetNumericValue(DNI[2]) * 7) + ((int)char.GetNumericValue(DNI[3]) * 6) + ((int)char.GetNumericValue(DNI[4]) * 5) + ((int)char.GetNumericValue(DNI[5]) * 4) + ((int)char.GetNumericValue(DNI[6]) * 3) + ((int)char.GetNumericValue(DNI[7]) * 2);
                    redondeo = suma / 11;
                    N = suma - (redondeo * 11);
                    DV = (11 - N);
                    Console.WriteLine($"20-{DNI}-{DV}");
                    break;

                case "e":

                    suma = 15 + ((int)char.GetNumericValue(DNI[0]) * 3) + ((int)char.GetNumericValue(DNI[1]) * 2) + ((int)char.GetNumericValue(DNI[2]) * 7) + ((int)char.GetNumericValue(DNI[3]) * 6) + ((int)char.GetNumericValue(DNI[4]) * 5) + ((int)char.GetNumericValue(DNI[5]) * 4) + ((int)char.GetNumericValue(DNI[6]) * 3) + ((int)char.GetNumericValue(DNI[7]) * 2);
                    redondeo = suma / 11;
                    N = suma - (redondeo * 11);
                    DV = (11 - N);
                    Console.WriteLine($"20-{DNI}-{DV}");

                    break;

            }

            Console.ReadKey();

        }
    }
}
