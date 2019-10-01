using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.TypeOFGames
{
    public class Miner : Game
    {
        string minerName;

        public Miner(string minerName)
        {
            this.minerName = minerName;
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
            return base.ToString()+"[miner name ="+minerName+"]";
        }
    }
}
