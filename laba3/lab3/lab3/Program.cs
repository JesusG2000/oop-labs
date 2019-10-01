using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{

   partial class Vector
    {
        private int[] array { get; set; }
        private int ID { get => GetHashCode(); }
        private int countOfElements { get; set; }
        private int stateVariable = 0;
        private string vectorName { get; set; }
        public static int countOfObjects = -1;
        private  const int PRIVATE_FIELD=0;

        public Vector(int[] array,  int countOfElements)
        {

            this.array = array;
            this.countOfElements = countOfElements;
            checkExeption(compare());
            countOfObjects++;

        }
        static Vector()
        {
            countOfObjects++;
        }
        private Vector(int[] array) {
            this.array = array;
            countOfElements = array.Length;
            countOfObjects++;
        }
        public static Vector getPrivateVector(int[] array)
        {
            return new Vector(array);
        }
        public Vector()
        {
            array = new int[10];
            countOfElements = 10;
            countOfObjects++;
        }

        private int compare()
        {
            if (array.Length > countOfElements || array.Length < countOfElements)
            {
                stateVariable = 101;
            }
            return stateVariable;
        }
        private void checkExeption(int stateVariable)
        {
            if (stateVariable == 101)
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void sum(ref int summator)
        {
             summator = 0;
            foreach(int mas in array){
                summator += mas;
            }
           
        }
        public void multiplue(out int summator)
        {
            summator = 1;
            foreach(int mas in array){
                summator *= mas;
            }
           
        }
       



        static void Main(string[] args)
        {
            try
            {
                Vector vector = new Vector(new int[10], 10);
                Vector vector1 = new Vector(new int[10], 10);
                Vector vector2 = getPrivateVector(new int[10]);
                Vector vector3 = new Vector { array = new int[10], countOfElements = 10 , vectorName="aa"};
                Vector vector4 = new Vector ();

                Vector[] vectors = new Vector[3];
                for (int i = 0; i < vectors.Length; i++)
                {
                    vectors[i] = new Vector(new int[] { i, i + 1, i + 2 }, 3);
                }

                int summator = 0;
                vector.sum(ref summator);
                int mul = 1;
                vector.multiplue(out mul);

                show(summator);
                show(mul);
                show(countOfObjects);
                show(vector.Equals(vector1));
                show(vector.GetHashCode());
                show(vector1.GetHashCode());
                show(vector);
                show(vector3);
                haveZero(vectors);
                lowestModule(vectors);




            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("count of elements does not equals array length(Error 101)");

            }
            var s = 16;
            show(s.GetType());

        }

        private static void lowestModule(Vector[] vectors)
        {
            int sum = 0;
            for(int i=0;i< vectors.Length; i++)
            {
                int summatorV1 = 0;
                vectors[i].sum(ref summatorV1);
                for (int y=0;y < vectors.Length; y++)
                {
                    int summatorV2 = 0;
                    vectors[y].sum(ref summatorV2);
                    if (Math.Abs(summatorV1) < Math.Abs(summatorV2))
                    {
                        object replace = vectors[i];
                        vectors[i] = vectors[y];
                        vectors[y] = (Vector)replace;
                        sum = summatorV1;
                    }
                }
            }
            for (int i=0;i< vectors.Length; i++)
            {
                int summator = 0;
                vectors[i].sum(ref summator);
                if (sum == summator)
                {
                    show(vectors[i]);
                }
               
            }
            
        }

        private static void haveZero(Vector[] vectors)
        {
           for(int i=0; i < vectors.Length; i++)
            {
                for(int y = 0; y < vectors[i].array.Length; y++)
                {
                    if (vectors[i].array[y] == 0)
                    {
                        show(vectors[i]);
                    }
                }
            }
        }

        private static void show<T>(T t)
        {
            Console.WriteLine(t);
        }

        public override bool Equals(object obj)
        {
            var vector = obj as Vector;
            return vector != null &&
                   EqualityComparer<int[]>.Default.Equals(array, vector.array) &&
                   countOfElements == vector.countOfElements &&
                   vectorName == vector.vectorName;
        }

        public override int GetHashCode()
        {
            var hashCode = -1089822341;
            hashCode = hashCode * -1521134295 + EqualityComparer<int[]>.Default.GetHashCode(array);
            hashCode = hashCode * -1521134295 + countOfElements.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(vectorName);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString()+"[ array = "+ string.Join(" ", array)+ " ID="+ID+ " countOfElements="+ countOfElements
                + " vectorName="+ vectorName;
        }
    }

}
