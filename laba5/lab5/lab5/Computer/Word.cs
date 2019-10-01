using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Computer
{
    public class Word : PO, WorkWithText
    {
        public override void close()
        {
            Console.WriteLine(this + " is closed");
        }

        public override void open()
        {
            Console.WriteLine(this + " is opend");
        }
        public void showText()
        {
            Console.WriteLine(this + " is showing text");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
