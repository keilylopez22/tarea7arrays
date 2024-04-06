using System;

namespace Totito
{
    internal class Program
    {
        static int[,] tabla;
        static char[] simbolo = { '.', 'X', 'O' };
        static char jugadoractual = 'X';
        static bool Ganador;

        static void Main(string[] args)
        {
            Console.WriteLine("TOTITO");
            Console.WriteLine(" X O ");
            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey();

            tabla = new int[3, 3];

            while (!Ganador)
            {
                pantalla();
                usuario(jugadoractual);
                Comprobar();
                moverXO();
                Pausa();
            }
        }

        private static void Pausa()
        {
            Console.ReadKey();
        }

        private static void Comprobar()
        {
            Ganador = false;

            for (int fila = 0; fila < 3; fila++)
            {
                if (tabla[fila, 0] == tabla[fila, 1] &&

                    tabla[fila, 0] == tabla[fila, 2] &&

                    tabla[fila, 0] != 0)
                {
                    Ganador = true;

                    Console.WriteLine($"{simbolo[tabla[fila, 0]]} Ganador!");

                    return;
                }
            }

            for (int columna = 0; columna < 3; columna++)
            {
                if (tabla[0, columna] == tabla[1, columna] &&

                    tabla[0, columna] == tabla[2, columna] &&

                    tabla[0, columna] != 0)
                {
                    Console.WriteLine($"{simbolo[tabla[0, columna]]}Ganador!");
                    Ganador = true;

                    

                    return;
                }
            }

            if (tabla[0, 0] == tabla[1, 1] &&

                tabla[0, 0] == tabla[2, 2] &&
                tabla[0, 0] != 0)
            {
                Ganador = true;
                Console.WriteLine($"{simbolo[tabla[0, 0]]} Ganador!");
                return;
            }

            // Verificar diagonal secundaria
            if (tabla[0, 2] == tabla[1, 1] &&
                tabla[0, 2] == tabla[2, 0] &&
                tabla[0, 2] != 0)
            {
                Ganador = true;

                Console.WriteLine($"¡{simbolo[tabla[0, 2]]} Ganador!");

                return;
            }
        }

        private static void moverXO()
        {
            jugadoractual = (jugadoractual == 'X') ? 'O' : 'X';
        }

        private static void usuario(char jugador)
        {
            Console.Write("Ingresa la fila deseada (1-3): ");
            int fila = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Ingresa la columna deseada (1-3): ");
            int columna = Convert.ToInt32(Console.ReadLine()) - 1;

            tabla[fila, columna] = (jugador == 'X') ? 1 : 2;
        }

        private static void pantalla()
        {
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.Write(simbolo[tabla[fila, columna]]);
                }
                Console.WriteLine();
            }
        }
    }
}
