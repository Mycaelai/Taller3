using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    class Player
    {
        string name;
        int score;
        float gamesWon;
        bool color;

        public Player(string name)
        {
            this.name = name;
            score = 0;
            gamesWon = 0;
        }

        public void SaveScore()
        {
            score = score + 100;
            gamesWon = gamesWon + 1;
            Console.WriteLine("Update\nPlayer name:\t" + name);
            Console.WriteLine("New Score:\t" + score);
            Console.WriteLine("Games Won:\t" + gamesWon);
        }

    }
}
