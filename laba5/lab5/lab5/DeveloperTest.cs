using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab5.Computer;
using lab5.TypeOFGames;
using lab5.Person;
using lab5.NewClass;

namespace lab5
{
    class DeveloperTest
    {
        public static void Main(String []args)
        {
            Game []games = new Game[2];
            games[0] = new CConficker(3);
            games[1] = new Miner("Ivan");

            PO[] typesOfPO = new PO[3];

            typesOfPO[0] = new TextProcessor();
            typesOfPO[1] = new Virus();
            typesOfPO[2] = new Word();
           
            Developer developer = new Developer(games,typesOfPO);
            DeveloperLogic logic = new DeveloperLogic(developer);
            logic.playInGame(games[0]);
            logic.playInGame(games[1]);
            logic.openProgram(typesOfPO[0]);
            logic.openProgram(typesOfPO[1]);
            logic.openProgram(typesOfPO[2]);
            Console.WriteLine("\n");
            Printer printer = new Printer();
            printer.IamPrinting(typesOfPO);
           
           
        }
    }
}
