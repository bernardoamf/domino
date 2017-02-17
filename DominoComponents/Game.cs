using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoComponents
{
    class Game
    {
        public int gameId { get; set; }
        DominoSet dominoSet;
        List<Player> players {get; set;}

        public Game(int id, List<Player> playerList)
        {
            this.gameId = id;
            this.players = playerList;
            dominoSet = new DominoSet();
        }

        public void pickPieces(int firstPlayerToPick)
        {
            int currentPlayerPicking = firstPlayerToPick;
            for (int i = 0; i <= 3; i++)
            {
                players.ElementAt(currentPlayerPicking).pickPieces(dominoSet);
                currentPlayerPicking++;
                if (currentPlayerPicking == 4)
                    currentPlayerPicking = 0;
            }
        }

        public int play(int firstPlayertoPlay)
        {
            int currentPlayer = firstPlayertoPlay;
            while (!CheckPlayerWithoutPieces())
            {
                Debug.WriteLine("Turn: " + players.Find(a => a.id == firstPlayertoPlay).name);
                break;
            }
            return -1;
        }

        public int GetPlayerIdWithDoubleSix()
        {
            int playerWithDoubleSix = -1;
            foreach (Player p in players)
            {
                if (p.hasDoubleSix())
                {
                    playerWithDoubleSix = p.id;
                    break;
                }
            }
            return playerWithDoubleSix;
        }

        public bool CheckPlayerWithoutPieces()
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

         public string ToString()
        {
            string returnString = String.Empty;
            foreach (Player p in players)
            {
                returnString = returnString + p.ToString() + "\r\n";
            }
            return returnString;
        }

        
    }
}
