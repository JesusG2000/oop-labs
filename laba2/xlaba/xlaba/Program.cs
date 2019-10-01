using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace xlaba
{
    class Program
    {
        static void Main(string[] args)
        {

            first();
            //second();
            //third();
            //four();
            //show(five(new int[] { 1, 2, 3, 4, 55, 66, 9 }, "azimov"));
        }

        private static (int max, int min, int sum, string leter) five(int[] mas, string str)
        {
            int min = mas[0];
            int max = mas[0];
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                min = Math.Min(min, mas[i]);
                max = Math.Max(max, mas[i]);
                sum += mas[i];
            }
            return (max, min, sum, str.Substring(0, 1));
        }

        private static void four()
        {
            var kor1 = (1, "ss", 'h', "str", 242534535UL);
            var kor2 = (1, "ss", 'h', "str", 242534535UL);
            show(kor1);
            show(kor1.Item1);
            show(kor1.Item3);
            show(kor1.Item4);
            (int one, string two, char c, string three, ulong u) = kor1;
            show(kor1 == kor2);
        }

        private static void third()
        {
            int[,] mas = new int[3, 3];
            mas[0, 0] = 1;
            show(mas);

            int[][] mas1 = new int[3][];
            for (int i = 0; i < mas1.Length; i++)
            {
                int rows = 0;
                switch (i)
                {
                    case 0: { rows = 2; break; }
                    case 1: { rows = 3; break; }
                    case 2: { rows = 4; break; }
                }
                mas1[i] = new int[rows];
                for (int y = 0; y < rows; y++)
                {
                    mas1[i][y] = Convert.ToInt32(Console.ReadLine()); 
                }
            }
            show(mas1);


            string[] strMas = new string[] { "hi", "mark", "lul" };
            show(strMas);

            Console.Write(" Write position: ");
            int pos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write value: ");
            string value = Console.ReadLine();
            strMas[pos] = value;
            show(strMas);

            var unType1 = "ssss";
            var unType2 = new int[3];
        }

        private static void second()
        {
            char a = 'a';
            char b = 'b';
            show(a < b ? true : false);

            string str1 = "hi mark";
            string str2 = "me";
            string str3 = "no";
            char[] forcpy = new char[5];
            str1.CopyTo(0, forcpy, 0, 4);
            show(str1 + str2);
            show(forcpy);
            show(str1.Substring(0, 3));
            show(str1.Split(' '));
            show(str1.Insert(2, str2));
            show(str1.Remove(str1.IndexOf("hi"), "hi".Length));
            //string nSTR = null;
            //if (nSTR == null)
            //{
            //    throw new Exception();
            //}

            StringBuilder sb = new StringBuilder("hi mark");
            sb.Remove(0, 1);
            sb.Remove(sb.Length - 1, 1);
            sb.Insert(0, 'h');
            sb.Insert(sb.Length, 'k');
            show(sb);
        }

        private static void first()
        {
            int i = 1;
            uint ui = 2;
            float f = 3.3f;
            double d = 4.4d;
            long l = 5;
            short s = 127;
            byte b = 4;
            char c = 'a';
            string str = "sdf";

            int changeI = c;
            float changeF = i;
            double changeD = i;
            int changeI1 = s;
            short changeB = b;

            int fromL = (int)l;
            int fromD = (int)d;
            int fromF = (int)f;
            char fromI = (char)i;
            short  fromL1 = (short)f;

            int convert = 123;
            Object o = convert;
            int unconvert = (int)o;
            
           

            var one = 1;
            var two = "ss";
            show(one + two);

            int? k=5;
            Nullable<int> k1 = 5;
            show(k1);
            show(k1.Value);

           

        }

        private static void show<T>(T t)
        {
            Console.WriteLine(t);
        }
        private static void show<T>(T[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write(t[i]);
            }
            Console.WriteLine();
        }
        private static void show<T>(T[,] t)
        {
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int y = 0; y < t.GetLength(1); y++)
                {
                    Console.Write(t[i, y]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        private static void show<T>(T[][] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                for (int y = 0; y < t[i].Length; y++)
                {
                    Console.Write(t[i][y]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
