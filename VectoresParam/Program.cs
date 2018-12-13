using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresParam
{
    class Program
    {
        const int MAX = 10;
        static void Main(string[] args)
        {
            int[] x = new int[MAX];
            string[] nombres = new string[MAX];
            leer(x);
            imprimir(x);
            ordenar(x);
            Console.WriteLine("\nVector ordenado ");
            imprimir(x);
            if (buscar(x, 15) == true)
                Console.WriteLine("\n15 Encontrado");
            else
                Console.WriteLine("\n15 No existe");
            if (buscar2(x, 15) == true)
                Console.WriteLine("\n10 Encontrado");
            else
                Console.WriteLine("\n10 No existe");

            //TRABAJANDO CON EL VECTOR DE CADENA DE CARACTERES
            Console.WriteLine("\nINGRESE LOS NOMBRES");
            leernombres(nombres);
            imprimirnombres(nombres);
            
            Console.ReadKey();

        }

        public static void ordenar (int[] x)
        {
            int aux = 0;
            for(int i = 0; i < x.Length; i++)
            {
                for(int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }
                }
            }
        }

        public static void leer(int[] x)
        {
            for(int i=0; i < MAX; i++)
            {
                Console.WriteLine("\nIngrese el elemento {0}", i + 1);
                x[i] = Int32.Parse(Console.ReadLine());
            }
           
        }

        public static void leernombres(string[] x)
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("\nIngrese el nombre {0}", i + 1);
                x[i] = (Console.ReadLine());
            }

        }

        public static void imprimir(int[] x)
        {
            foreach(int num in x)
            {
                Console.WriteLine("\nElemento {0}", num);
            }
        }

        public static void imprimirnombres(string[] x)
        {
            foreach (string num in x)
            {
                Console.WriteLine("\nElemento {0}", num);
            }
        }
        public static bool buscar(int[] x, int y)
        {
            bool encontrado = false;
            foreach (int num in x)
            {
                if (num == y)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
        }

        public static bool buscar2(int[] x,int y)
        {
            bool encontrado = false;
            int i= 0;
            while(i<MAX && encontrado == false)
            {
                if (x[i] == y)
                    encontrado = true;
                i++;
            }
            return encontrado;
        }
            
        

    }
}
