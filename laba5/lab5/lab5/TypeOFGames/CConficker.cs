using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.TypeOFGames
{
    public class CConficker : Game
    {
       private int countOfTryes { set; get; }
       public CConficker(int countOfTryes)
        {
           this.countOfTryes = countOfTryes;
        }
        public override void start()
        {
            Console.WriteLine(this + " is start play");
        }

        public override void stop()
        {
            Console.WriteLine(this + " is stop play");
        }

        public override string ToString()
        {
            return base.ToString()+"[ count of tryes = "+countOfTryes+"]";
        }
    }
}
