using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIO 001 ESTRUCTURAS DE CONTROL Y CICLOS

            /* 
              Console.WriteLine("Ingrese un Numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro Numero");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine(" La suma de " +num1+ " y de " +num2 + " es " + sum);

            Console.WriteLine("Ingrese un Numero");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro Numero");
            int num4 = int.Parse(Console.ReadLine();

            int div = num3 / num4;
            Console.WriteLine("La division de " + num3 + " y " + num4 + " Es " + div);

            Console.ReadLine();
            */

            // EJERCICIO 002 CONTADORES Y ACOMULACIONES

            /*
            Console.WriteLine("Empresa La Fabrica");
            Console.WriteLine("Surcusal Parque Patricios");

            Console.WriteLine("Ingrese El Monto De Enero");
            int enero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese El Monto De Febrero");
            int febrero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese El Monto De Marzo");
            int marzo = int.Parse(Console.ReadLine());

            Console.WriteLine("El monto de la Sucursal de Parque Patricios del Mes de enero es de " + enero + " pesos");
            Console.WriteLine("El monto de la Sucursal de Parque Patricios del Mes de febrero es de " + febrero + " pesos");
            Console.WriteLine("El monto de la Sucursal de Parque Patricios del Mes de marzo es de " + marzo + " pesos");

            Console.WriteLine("Surcusal Caballito");

            Console.WriteLine("Ingrese El Monto De Enero");
            int enero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese El Monto De Febrero");
            int febrero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese El Monto De Marzo");
            int marzo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("El monto de la Sucursal de Caballito del Mes de enero es de " + enero1 + " pesos");
            Console.WriteLine("El monto de la Sucursal de Caballito del Mes de febrero es de " + febrero1 + " pesos");
            Console.WriteLine("El monto de la Sucursal de Caballito del Mes de marzo es de " + marzo1 + " pesos");

            int sum = enero + febrero + marzo;
            Console.WriteLine("El monto total de la Sucursal Parque Patricios de los Meses Enero, Febrero, Marzo es de " + sum);
           
            int sum1 = enero1 + febrero1 + marzo1;
            Console.WriteLine("El monto total de la Sucursal Caballito de los Meses Enero, Febrero, Marzo es de " + sum1);

            int sum2 = sum + sum1;
            Console.WriteLine("La suma del monto de La Sucursal Parque Patricios y La Sucursal Caballito es de " + sum2);

            Console.Read();
            */

            // EJERCICIO 003 VARIEDADES 

            //Ejerc001

            Console.WriteLine("Calculadora");

            Console.WriteLine("Ingrese el Primer Numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese El segundo Numero");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("La suma de " + num1 + " + " + num2 + " Es " + sum);

            int rest = num1 - num2;
            Console.WriteLine("La resta de " + num1 + " - " + num2 + " Es " + rest);

            int mult = num1 * num2;
            Console.WriteLine("La Multiplicacion de " + num1 + " x " + num2 + " Es " + mult);

            int div = num1 / num2;
            Console.WriteLine("La Division de " + num1 + " / " + num2 + " Es " + div);

            Console.Read();

            //Ejerc002

            int sum1 = num1 * num2 / 100;

                






        }
    }
}
