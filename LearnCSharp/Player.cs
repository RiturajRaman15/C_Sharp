using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    internal class Player
    {
        public string name = "Rituraj Raman";
        public int score = 10;

        public void changeScore(int score)
        {
            this.score = score;
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player New Score: " + score);
        }
    }
}
