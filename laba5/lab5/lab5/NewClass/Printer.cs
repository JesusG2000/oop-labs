using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab5.Computer;

namespace lab5.NewClass
{
    class Printer
    {
        public void IamPrinting(PO []po)
        {
            Console.WriteLine(po.ToString()+"\n");
            for(int i=0;i< po.Length; i++)
            {
                po[i].open();
                po[i].close();
                Console.WriteLine(po[i].ToString());
            }
            
        }
    }
}
