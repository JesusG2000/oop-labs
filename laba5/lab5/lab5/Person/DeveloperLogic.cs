using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab5.Computer;
using lab5.TypeOFGames;

namespace lab5.Person
{
    public class DeveloperLogic
    {
        Developer developer;

        public DeveloperLogic(Developer developer)
        {
            this.developer = developer;
        }
        public void playInGame(Game game)
        {
            if (game is CConficker)
            {
                CConficker cconficker = game as CConficker;
                cconficker.start();
                cconficker.stop();
            }
            if (game is Miner)
            {
                Miner miner = game as Miner;
                miner.start();
                miner.stop();
            }
        }

        public void openProgram(PO po)
        {
            if (po is TextProcessor)
            {
                TextProcessor text = po as TextProcessor;
                text.open();
                text.showText();
                text.close();
            }
            if (po is Word)
            {
                Word word = po as Word;
                word.open();
                word.showText();
                word.close();

            }
            if (po is Virus)
            {
                Virus virus = po as Virus;
                virus.open();
                virus.detect();
                virus.close();
            }

        }
    }
}
