using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Practica1();
            //Practica2();
            Practica3();
            
        }
        #region Practica1
        static void Practica1()
        {
            Console.WriteLine("Éste programa te dice el área de un círculo");

            Console.WriteLine("Introduce el primer número");
            double radio = int.Parse(Console.ReadLine());

            const double PI = 3.14;

            double resultado = PI * Math.Pow(radio, 2);

            Console.WriteLine("El área del círculo de radio {0} es de: {1}", radio, resultado);
        }
        #endregion

        #region Practica2
        static void Practica2()
        {
            

            Console.WriteLine("Vamos a comprobar si puedes conducir.");

            Console.WriteLine("¿Cuántos años tienes?");
            int puede_conducir= int.Parse(Console.ReadLine());
            string tieneCarnet = "si";

            if(puede_conducir >= 18)
            {
                Console.WriteLine("¿Tienes carnet? (SI/NO)");
                string carnet_conducir = Console.ReadLine().ToLower();
                if (carnet_conducir.Equals(tieneCarnet))
                {
                    Console.WriteLine("Entonces SI puedes conducir.");
                } else
                {
                    Console.WriteLine("Entonces NO puedes conducir");
                }

            }
            else
            {
                Console.WriteLine("Eres menor de edad, no puedes conducir.");
            }




        }
        #endregion

        #region Practica 3
        static void Practica3()
        {

            Console.WriteLine("Â¿Quieres entrar? S/N");

            Console.Write("respuesta: ");
            string respuesta2 = LeerRespuesta(Console.ReadLine());
            Console.WriteLine("Bien, has introducido S o N"); ;
        }


        static string LeerRespuesta(string respuesta)
        {

            while (respuesta != "S" && respuesta != "N")
            {

                Console.Write("El valor no es correcto, debe ser una S o una N: ");
                respuesta = Console.ReadLine();
            }

            return respuesta;

        }
        #endregion
    }
}
