using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tercer_proyecto
{
    class cliente
    {
        private string nombre;
        private int monto;
        public cliente(string nom)
        {
            nombre = nom;
            monto = 0;
        }
        public void Depositar(int m)
        {
            monto = monto + m;
        }
        public void Extraer(int m)
        {
            monto = monto - m;
        }
        public int RetornarMonto()
        {
            return monto;
        }
        public void Imprimir()
        {
            Console.WriteLine(nombre + "tiene depositado la suma de " + monto);
        }
    }
    class Banco
    {
        private cliente cliente1, cliente2, cliente3;
        public Banco()
        {
            cliente1 = new cliente("yhonas");
            cliente2 = new cliente("Ana");
            cliente3 = new cliente("Pedro");
        }
        public void Operar()
        {
            cliente1.Depositar(200);
            cliente2.Depositar(150);
            cliente3.Depositar(500);
            cliente3.Extraer(250);
        }
        public void DepositosTotales()
        {
            int t = cliente1.RetornarMonto() + cliente2.RetornarMonto() + cliente3.RetornarMonto();
            Console.WriteLine("el total de dinero en el banco es:" + t);
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("lysbeth cruz Hernadez 16 - miin - 1 - 104");
            Console.WriteLine("Ivanna Sanchez Taveras 16 - miin - 1 - 068");
            Console.WriteLine("Erika Tejada 16-miin-1-144");
            Console.WriteLine("seccion 0463");

            Banco Banco1 = new Banco();
            Banco1.Operar();
            Banco1.DepositosTotales();
            Console.ReadKey();
       
        }
    }
}
