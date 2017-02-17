using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoComponents
{
    class Match
    {
        List<Player> playerList { get; set; }
        int[] teamPoints {get; set;}
        int firstStartPlayerid { get; set; }
        int currentStartPlayerid { get; set; }
        int gameNumber { get; set; }
        Game currentGame;


        public Match(Player p1, Player p2, Player p3, Player p4)
        {
            this.playerList = new List<Player>();
            this.playerList.Add(p1);
            this.playerList.Add(p2);
            this.playerList.Add(p3);
            this.playerList.Add(p4);
            gameNumber = 1;
            firstStartPlayerid = 0;
            teamPoints = new int[2] { 0, 0 };
            currentStartPlayerid = 0;
        }


        public void startNewGame()
        {
            currentGame = new Game(gameNumber, playerList);
            currentGame.pickPieces(currentStartPlayerid);
            if (gameNumber == 1)
                currentStartPlayerid = currentGame.GetPlayerIdWithDoubleSix();
            //currentGame.play(currentStartPlayerid);
        }

        public void playCurrentGame()
        {
            int winningTeamNumber = currentGame.play(currentStartPlayerid);
        }
        public Game getGame()
        {
            return currentGame;
        }

        
    }
}
