using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoComponents
{
    class Team
    {
        public int teamNumber { get; set; }
        string teamName { get; set; }
        List<Player> players {get; set;}
        int totalPoints { get; set; }
        bool firstStart { get; set; }

        public Team(int tNumber, string tName, Player p1, Player p2)
        {
            this.teamNumber = tNumber;
            this.teamName = tName;
            p1.id = 0;
            p2.id = 1;
            this.players = new List<Player>();
            this.players.Add(p1);
            this.players.Add(p2);
            this.totalPoints = 0;
            this.firstStart = false;
        }

        public Player getPlayerById(int id)
        {
            return players.ElementAt(id);
        }

        public bool checkPlayerWithNoPieces()
        {
            bool returnValue = false;
            foreach (Player p in players)
            {
                if (p.getUnplayedPieceCount() == 0)
                {
                    returnValue = true;
                    break;
                }
            }
            return returnValue;
        }

        public int getPlayerWithDoubleSix()
        {
            int playerWithDoubleSix = -1;
            foreach (Player p in players)
            {
                if (p.hasDoubleSix())
                    playerWithDoubleSix = p.id;
            }
            return playerWithDoubleSix;
        }
        public string ToString()
        {
            string returnString = String.Empty;
            returnString = teamName + ": ";
            foreach (Player p in players)
            {
                returnString = returnString + p.ToString() + "\r\n";
            }
            return returnString + "\r\n";
        }
    }
}
