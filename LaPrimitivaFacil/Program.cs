using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPrimitivaFacil
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] combinacion = new int[6];
            Random r = new Random();
            int aux = r.Next(1, 49);

            for (int i = 0; i < combinacion.Length; i++)
            {
                for (int j = 0; j < combinacion.Length; j++)
                {
                    if (aux == combinacion[j])
                    {
                        aux = r.Next(1, 49);
                        j = -1;
                    }
                }
                combinacion[i] = aux;
                aux = r.Next(1, 49);
            }


            foreach (var i in combinacion)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
