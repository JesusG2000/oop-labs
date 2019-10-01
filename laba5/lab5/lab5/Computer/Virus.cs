using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Computer
{
    public class Virus : PO
    {
        public override void close()
        {
            Console.WriteLine(this + " is closed");
        }

        public override void open()
        {
            Console.WriteLine(this + " is opend");
        }

        public void detect()
        {
            Console.WriteLine(this + " is detected");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
