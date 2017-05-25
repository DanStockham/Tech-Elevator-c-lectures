using Lecture.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardGame bg = new BoardGame(4);

            bg.PlayGame();
        }
    }
}
