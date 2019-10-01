using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
   public static class StatisticOperation
    {
        public static int sum(int []mas)
        {
            int sum = 0;
            for(int i=0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            return sum;
        }

        public static int differenceBetweenMaxAndMin(int[] mas)
        {
            int max = mas[0];
            int min = mas[0];

            for(int i=0; i< mas.Length; i++)
            {
                max = Math.Max(max, mas[i]);
                min = Math.Min(min, mas[i]);
            }
            return max - min;
        }

        public static int size(int []mas)
        {
            return mas.Length;
        }

        public static bool isThisLetter(this string str , char letter)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == letter)
                {
                    return true;
                }
            }
            return false;
        }

        public static int getMax(this int[] mas)
        {
            int max = mas[0];
            for(int i= 0; i< mas.Length; i++)
            {
                max = Math.Max(max, mas[i]);
            }
            return max;
        }

        public static int[] deleteMinus(this int[] mas)
        {
            for(int i=0; i < mas.Length; i++)
            {
                if (mas[i] < 0)
                {
                    mas[i] = 0;
                }
            }
            return mas;
        }
    }
    public class Owner
    {
        
        public int ID { get; set; }
        public string name { get; set; }
        public int creatorOrganization { get; set; }
    }
    public class Array
    {

        private class Date
        {
            public int day { get; set; }
            public int month { get; set; }
            public int year { get; set; }
        }
        Owner owner = new Owner { ID = 0, name = "Ivan", creatorOrganization = 123 };
        Date date = new Date { day = 10, month = 10, year = 2010 };
        static Array(){
            show(1);
            }
        private int size { get; set; }

        private int[] array { get; set; }

        public void fillElement(int index, int value)
        {

            array[index] = value;
        }

        public Array(int size)
        {
            this.size = size;
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                IndexOutOfRangeException(index);
                return array[index];
            }
            set
            {
                IndexOutOfRangeException(index);
                array[index] = value;
            }
        }

        public static Array operator *(Array a1, Array a2)
        {
            checkImplementedException(a1.size, a2.size);
            Array newAr = new Array(a1.size);
            for (int i = 0; i < a1.size; i++)
            {
                newAr[i] = a1[i] * a2[i];
            }
            return newAr;
        }

        public static bool operator true(Array a)
        {
            for (int i = 0; i < a.size; i++)
            {
                if (a[i] < 0)
                {
                    return false;
                }
            }
            return true;

        }

        public static bool operator false(Array a)
        {
            for (int i = 0; i < a.size; i++)
            {
                if (a[i] < 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static explicit operator int(Array v)
        {
            return v.size;
        }

        public static bool operator ==(Array a1 ,Array a2)
        {
            checkImplementedException(a1.size, a2.size);
            for (int i=0;i< a1.size; i++)
            {
                if (a1[i] != a2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(Array a1 ,Array a2)
        {
            checkImplementedException(a1.size, a2.size);
            for (int i=0;i< a1.size; i++)
            {
                if (a1[i] != a2[i])
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator> (Array a1, Array a2)
        {
            if (a1.size != a2.size)
            {
                return a1.size > a2.size;
            }
            else
            {
                int sum1 = 0;
                int sum2 = 0;
                for(int i=0;i < a1.size; i++)
                {
                    sum1 += a1[i];
                    sum2 += a2[i];
                }
                return sum1 > sum2;
            }
        }

        public static bool operator< (Array a1, Array a2)
        {
            if (a1.size != a2.size)
            {
                return a1.size < a2.size;
            }
            else
            {
                int sum1 = 0;
                int sum2 = 0;
                for(int i=0;i < a1.size; i++)
                {
                    sum1 += a1[i];
                    sum2 += a2[i];
                }
                return sum1 < sum2;
            }
        }

        private static void checkImplementedException(int size1, int size2)
        {
            if (size1 != size2)
            {
                throw new NotImplementedException();
            }
        }

        private void IndexOutOfRangeException(int index)
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public static void Main(string[] args)
        {
            show(2);
            try
            {
               
                Array mas1 = new Array(10);
                Array mas2 = new Array(10);

                for (int i = 0; i < mas1.size; i++)
                {
                    mas1[i] = i;
                    mas2[i] = i+1 ;
                }
                Array mas3 = mas1 * mas2;
                for (int i = 0; i < mas1.size; i++)
                {
                    show(mas3[i]);
                }
                if (mas1)
                {
                    show(1);
                }
                if (mas2)
                {
                    show(2);
                }

                int mas1Size = (int)mas1;
                show(mas1Size);
                show(mas1 == mas2);
                show(mas1 != mas2);
                show(mas1 < mas2);
                show(mas1 > mas2);

                string str = "abc";
                

                show(str.isThisLetter('a'));
                show(mas1.array.getMax());
                show(mas1.array.deleteMinus());

             


            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of bounds");
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Different size of arrays");
            }
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
