using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab5.Computer;
using lab5.TypeOFGames;

namespace lab5.Person
{
    public class Developer
    {
        Game[] games { get; set; }
        PO[] po { get; set; }



        public Developer(Game[] games, PO[] po)
        {
            this.games = games;
            this.po = po;
        }
    }
}
