using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lysbeth cruz Hernadez 16 - miin - 1 - 104");
            Console.WriteLine("Ivanna Sanchez Taveras 16 - miin - 1 - 068");
            Console.WriteLine("Erika Tejada 16-miin-1-144");
            Console.WriteLine("seccion 0463");

            int cuenta;
            float saldo, suma;
            string linea;

            suma = 0;
            do
            {

                Console.Write("ingrese numero de cuenta:");

                linea = Console.ReadLine();

                cuenta = int.Parse(linea);
                if (cuenta >= 0)

                {

                    Console.Write("ingrese saldo:");
                    linea = Console.ReadLine();
                    saldo = float.Parse(linea);
                    if (saldo > 0)

                    {
                        Console.WriteLine("saldo acreedor.");

                        suma = suma + saldo;
                        suma = suma;
                    }
                    else

                    {

                        if (saldo < 0)

                        {

                            Console.WriteLine("saldo deudor.");
                            suma = suma + saldo;
                            suma = suma;
                        }

                        else
                        {

                            Console.WriteLine("saldo nulo.");
                        }
                    }
                }


            } while (cuenta >= 0);

            Console.WriteLine("total de saldos acreedores:");

            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
