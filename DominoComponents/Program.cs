using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoComponents
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));

            testMatchCreation();
            Console.Read(); 
        }

        static void testMatchCreation()
        {
            Player p1 = new Player(1, "Bernardo",1);
            Player p2 = new Player(2, "Alejandro",1);
            Player p3 = new Player(3, "Jose",2);
            Player p4 = new Player(4, "Xan",2);
            Match m = new Match(p1, p2, p3, p4);
            m.startNewGame();
            Game g = m.getGame();
            Debug.WriteLine(g.ToString());
            //Console.Read();
            Debug.WriteLine(g.GetPlayerIdWithDoubleSix());
            m.playCurrentGame();
            Console.Read();
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
