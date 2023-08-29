using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUIL
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo;
            string DNI;
            int suma = 0;
            int redondeo;
            int N;
            int DV;


            Console.WriteLine("Ingresar si es hombre (H), mujer (M) o empresa (E)");
            tipo = Console.ReadLine();

            Console.WriteLine("Ingrese su número de DNI");
            DNI = Console.ReadLine();



            switch (tipo)
            {
                case "h":


                    suma = 10 + ((int)char.GetNumericValue(DNI[0]) * 3) + ((int)char.GetNumericValue(DNI[1]) * 2) + ((int)char.GetNumericValue(DNI[2]) * 7) + ((int)char.GetNumericValue(DNI[3]) * 6) + ((int)char.GetNumericValue(DNI[4]) * 5) + ((int)char.GetNumericValue(DNI[5]) * 4) + ((int)char.GetNumericValue(DNI[6]) * 3) + ((int)char.GetNumericValue(DNI[7]) * 2);

                    redondeo = suma / 11;

                    Console.WriteLine(redondeo);
                    Console.ReadKey();



                    N = suma - (redondeo * 11);

                    DV = N + 11;

                    Console.WriteLine($"20{DNI}{DV}");
                    Console.WriteLine(DV);

                    break;




            }


            /*     DNI 12.345.678 Masculino


                      2 0 1 2 3 4 5 6 7 8
                      x
                      5 4 3 2 7 6 5 4 3 2
                     ———————————————————— 
                     10 + 0 + 3 + 4 + 21 + 24 + 25 + 24 + 21 + 16 = 148


             148 dividido 11 = 5(porque 148 / 11 = 13, 454 –; .454 se redondea a 5). 
             11 - 5 = 6




             Entonces, el CUIL | CUIT es 20 - 12345678 - 6 */



            Console.ReadKey();

        }
    }
}
