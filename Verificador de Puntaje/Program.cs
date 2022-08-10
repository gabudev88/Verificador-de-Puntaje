using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificador_de_Puntaje
{
    internal class Program
    {
        // DECLARO VARIABLES A REFERIR - JUGADOR CON MAYOR PUNTAJE DEL JUEGO

        static int puntajeRecord = 100;
        static string jugadorRecord = "Luis";

        static void Main(string[] args)
        {
            // INGRESO LOS DATOS DEL NUEVO JUGADOR

            Console.WriteLine("Ingrese su nombre de jugador: ");
            string nombreDeJugador = Console.ReadLine();

            // INGRESO EL PUNTAJE OBTENIDO POR EL NUEVO JUGADOR (BUSCAMOS NUMEROS DEL TIPO "INT")

            Console.WriteLine("Ingrese su puntaje: ");
            string ingresoPuntajeDeJugador = Console.ReadLine();
            int puntajeDeJugador = int.Parse(ingresoPuntajeDeJugador);

            // METODO AL CUAL LLAMAMOS PARA VERIFICAR LOS DATOS

            String(nombreDeJugador, puntajeDeJugador);


            Console.Read();

        }

        // SEGUN DEL PUNTAJE TENDREMOS UNA RESPUESTA POR MEDIO DEL CONDICIONAL "IF"

        public static void String(string nombreDeJugador, int puntajeDeJugador)
        {

            if (puntajeRecord > puntajeDeJugador)
            {
                Console.WriteLine("No se ha podido superar la puntuación mas alta " +
                    "de {0} hecha por {1}", puntajeRecord, jugadorRecord);
            }
            else if (puntajeRecord == puntajeDeJugador)
            {
                Console.WriteLine("Haz igualado la puntuacion record actual!!");
            }
            else
            {
                Console.WriteLine("La puntuación de {0} ha superado el record actual" +
                    " con {1} puntos!! Felicitaciones {2}!!", nombreDeJugador,
                    puntajeDeJugador, nombreDeJugador);
            }

        }
    }
}
