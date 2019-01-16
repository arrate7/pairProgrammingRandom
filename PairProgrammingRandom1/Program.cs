using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] alum1 =
                {"Mikel","Victor","Zohartze","Tirso","Lyrisse","Holly","Amaya","Iker Vázquez","Iker Rincón", "Daniel"};
            String[] alum2 =
                {"David","Rodrigo","Xabier","Iker Lougedo","Santiago","Aritz","Ibon","Maximiliano","Eduardo", "Ainara"};

            List<String> alumnos1 = new List<String>(alum1);
            List<String> alumnos2 = new List<String>(alum2);

            PairProgramming(alumnos1, alumnos2);

        }

        public static void PairProgramming(List<String> arr1, List<String> arr2)
        {
            Random rndm = new Random();
            int numRandom1 = 0, numRandom2 = 0;
            int capacidad = 10;
            while (capacidad > 0)
            {
                numRandom1 = rndm.Next(0, capacidad);
                numRandom2 = rndm.Next(0, capacidad);
                Console.WriteLine(arr1[numRandom1] + "\t\t" + arr2[numRandom2]);
                arr1.RemoveAt(numRandom1);
                //arr1.TrimExcess();
                arr2.RemoveAt(numRandom2);
                //arr2.TrimExcess();
                capacidad--;
                if (capacidad == 0)
                {
                    Console.WriteLine("******************** A CURRAR !! ***************************");
                }
                Console.ReadLine();
            }
          

        }
    }
}
