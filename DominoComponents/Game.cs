using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoComponents
{
    class Game
    {
        public int gameId { get; set; }
        List<Team> teams;
        DominoSet dominoSet;

        public Game(List<Team> teamList, int id)
        {
            this.gameId = id;
            teams = teamList;
            dominoSet = new DominoSet();
        }

        public void pickPieces(int firstPlayerToPick)
        {
            int currentPlayerPicking = firstPlayerToPick;
            for (int i = 0; i <= 3; i++)
            {
                if (currentPlayerPicking < 2)
                {
                    teams.ElementAt(0).getPlayerById(currentPlayerPicking).pickPieces(dominoSet);
                    //Console.WriteLine(teams.ElementAt(0).getPlayerById(currentPlayerPicking).PlayerPieces.ToString());
                }
                else
                {
                    teams.ElementAt(1).getPlayerById(currentPlayerPicking - 2).pickPieces(dominoSet);
                    //Console.WriteLine(teams.ElementAt(1).getPlayerById(currentPlayerPicking - 2).PlayerPieces.ToString());
                }
                currentPlayerPicking++;
                if (currentPlayerPicking == 4)
                    currentPlayerPicking = 0;
            }
        }

        public void play(int firstPlayertoPlay)
        {
            int currentPlayer = firstPlayertoPlay;
            Team currentTeam;
            while (!teams.ElementAt(0).checkPlayerWithNoPieces() && !teams.ElementAt(1).checkPlayerWithNoPieces())
            {
                if (currentPlayer < 2)
                    currentTeam = teams.ElementAt(0);
                else
                    currentTeam = teams.ElementAt(1);

            }
        }

        public int GetPlayerWithDoubleSix()
        {
            int playerWithDoubleSix = -1;
            foreach (Team t in teams)
            {
                playerWithDoubleSix = t.getPlayerWithDoubleSix();
                if (playerWithDoubleSix != -1)
                {
                    if (t.teamNumber == 1)
                        playerWithDoubleSix = playerWithDoubleSix + 2;
                    break;
                }
            }
            return playerWithDoubleSix;
        }

        public string ToString()
        {
            string returnString = String.Empty;
            foreach (Team t in teams)
            {
                returnString = returnString + t.ToString();
            }
            return returnString;
        }

        
    }
}
