using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoComponents
{
    class Program
    {
        static void Main(string[] args)
        {

            testMatchCreation();
            Console.Read(); 
        }

        static void testMatchCreation()
        {
            Team t1 = new Team(1, "Bichos", new Player("Bernardo"), new Player("Alejandro"));
            Team t2 = new Team(1, "Tipos", new Player("Jose"), new Player("Xan"));
            Match m = new Match(t1, t2);
            m.startNewGame();
            Game g = m.getGame();
            Console.WriteLine(g.ToString());
            Console.Read();
            Console.WriteLine(g.GetPlayerWithDoubleSix());
        }

        static void testSetCreation()
        {
            DominoSet set = new DominoSet();
            PieceCollection pieces = set.getPieces();
            Console.WriteLine("Total Pieces {0}", pieces.getCount());
            Console.WriteLine(pieces.ToString());
        }
    }
}
