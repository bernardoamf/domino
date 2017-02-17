using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoComponents
{
    class Match
    {
        List<Team> teamList { get; set; }
        int firstStartPlayerid { get; set; }
        int currentStartPlayerid { get; set; }
        int gameNumber { get; set; }
        Game currentGame;

        public Match(Team t1, Team t2)
        {
            teamList = new List<Team>();
            this.teamList.Add(t1);
            this.teamList.Add(t2);
            gameNumber = 1;
            firstStartPlayerid = 0;
            currentStartPlayerid = 0;
        }

        public void startNewGame()
        {
            currentGame = new Game(teamList, gameNumber);
            currentGame.pickPieces(currentStartPlayerid);
            if (gameNumber == 1)
                currentStartPlayerid = currentGame.GetPlayerWithDoubleSix();
            //currentGame.play(currentStartPlayerid);
        }

        public Game getGame()
        {
            return currentGame;
        }

        
    }
}
