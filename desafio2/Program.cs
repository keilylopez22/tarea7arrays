using System;

namespace desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa la cantidad de cada uno de los montos gastados por cada usuario");
            int[] Compras = new int[5];
            int[,]prodcts = new int[5, 5];
            

           

            for (int filas = 0; filas < 5; filas++)
            {
                for (int columnas = 0; columnas < 5; columnas++)
                {
                    Console.Write("Ingresa el monto de las compras de cada uno de los clientes {0}: ", filas + 1);

                    prodcts[filas, columnas] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine();
            Console.WriteLine("los montos de las compras para cada cliente es de: ");
            for (int filas = 0; filas < 5; filas++)
            {
                int totalCli = 0;
                for (int columnas = 0; columnas < 5; columnas++)
                {
                    Console.Write("{0}\t", prodcts[filas, columnas]);

                    totalCli += prodcts[filas, columnas];
                }
                Compras[filas] = totalCli;

                Console.WriteLine("la sumatoria de loas compras fueron {0}: {1}", filas + 1, totalCli);
            }


            Console.WriteLine();

            Console.WriteLine("Descuento por clienre cliente: ");

            for (int fila = 0; fila < 5; fila++)
            {
                decimal descuento = 0;

                if (Compras[fila] >= 100 && Compras[fila] <= 1000)
                {
                    descuento = 0.1m;
                }
                else if (Compras[fila] > 1000)
                {
                    descuento = 0.2m;
                }
                Console.WriteLine("Cliente {0}: {1}%", fila + 1, descuento * 100);
            }

            Console.ReadKey();
        }
    }
}


