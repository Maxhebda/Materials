using System; 

namespace CStestInVS
{
    class Program
    {
        static void Main(string[] args)
        {
            // bit XOR (albo) ^
            // 1010
            // 0010
            // ----
            // 1000
            Console.WriteLine(10 ^ 2);

            // bit NEG (negacja) ~
            // 00001010  = 010
            // 11110101  = 245
            byte a = 10;
            Console.WriteLine((byte)~a);

            // bit << >> (przesuniecie)
            // 0010 << 2 = 1000
            Console.WriteLine(2 << 2);  // o 2;

            // 0010 >> 1 = 0001
            Console.WriteLine(2 >> 1);  // o 1

            //case switch
            string name = "ala ma kota";
            name = "ddd";
            switch (name)
            {
                case "q":
                    Console.WriteLine("skoczek lub q");
                    break;
                case "ala ma kota":
                    Console.WriteLine("ala");
                    goto case "q";
                default:
                    Console.WriteLine("inne");
                    goto case "ala ma kota";
            }
            Console.WriteLine("--------------------------");

            // tablica jednowymiarowa
            int[] tab = { 1, 2, 3, 4 };
            foreach (int uuu in tab)
            {
                Console.WriteLine(uuu);
            }

            // tablica wielowymarowa
            string[,] ulala = {
                                    { "ala", "ma" },
                                    { "kota", "!!!" }
                              };
            int[,] tab2 = new int[3, 2];
            int[,] tab3;
            tab3 = new int[3, 2];
            tab3[0, 0] = 1;
            tab3[2, 0] = 2;
            string[,] tabString = new string[2, 2];
            tabString[0, 0] = "ala ";
            tabString[0, 1] = "ma ";
            tabString[1, 0] = "kota ";
            tabString[1, 1] = "! ";
            for (int ii = 0; ii < 2; ii++)
                for (int jj = 0; jj < 2; jj++)
                    Console.Write(tabString[ii, jj]);

            // tablice wyszczerbione
            Console.WriteLine("\n\nTablice wyszczerbione");
            int[][] jaggeArray = new int[3][];  //nie znamy wielkosci tablicy w tablicy 3 elementowej
            jaggeArray[0] = new int[2] { 1, 2 };
            jaggeArray[1] = new int[4] { 4, 5, 6, 7 };
            jaggeArray[2] = new int[1] { 1 };
            for (int ii = 0; ii < jaggeArray.Length; ii++)
            {
                for (int jj = 0; jj < jaggeArray[ii].Length; jj++)
                    Console.Write(jaggeArray[ii][jj]);
                Console.WriteLine("\n-----");
            }

            //inna deklaracja:
            int[][] tabWyszcz = new int[][]
            {
                new int[] {1,2,3},
                new int[] {1,2}
             };
            for (int ii = 0; ii < tabWyszcz.Length; ii++)
            {
                for (int jj = 0; jj < tabWyszcz[ii].Length; jj++)
                    Console.Write(tabWyszcz[ii][jj]);
                Console.WriteLine();
            }

            // tab wiew argumenty
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            // zmienna var
            var hehe = 934029.23434;

            // 

            Console.WriteLine(hehe);

            Console.ReadLine();
        }
    }
}
