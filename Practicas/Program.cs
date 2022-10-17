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

            const string RESPUESTA_AFIRMATIVA = "S";
            const string RESPUESTA_NEGATIVA = "N";

            //Practica1();
            //Practica2();
            //Practica3();
            Practica4();

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
            int puede_conducir = int.Parse(Console.ReadLine());
            string tieneCarnet = "si";

            if (puede_conducir >= 18)
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

            Console.WriteLine("¿Quieres entrar? S/N");

            Console.Write("respuesta: ");
            string respuesta = LeerRespuesta(Console.ReadLine());
            Console.WriteLine("Bien, has introducido S o N"); ;

            string LeerRespuesta(string respuesta2)
            {

                while (respuesta2 != "S" && respuesta2 != "N")
                {

                    Console.Write("El valor no es correcto, debe ser una S o una N: ");
                    respuesta2 = Console.ReadLine();
                }

                return respuesta2;

            }
        }

        #endregion

        #region Practica4

        static void Practica4()
        {
            Console.WriteLine("¿Quieres entrar? S/N");

            string respuesta2 = LeerRespuestaConDoWhile(Console.ReadLine().ToUpper());


            string LeerRespuestaConDoWhile(string respuesta)
            {

                do
                {
                    Console.Write("El valor no es correcto, debe ser una S o una N: ");
                    respuesta = Console.ReadLine();

                } while (respuesta.Equals("S") || respuesta.Equals("N"));

                return respuesta;

            }
        }


        #endregion

    }
}

