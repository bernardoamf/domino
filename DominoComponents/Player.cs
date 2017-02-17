using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoComponents
{
    class Player
    {
        public string name { get; set; }
        public int id { get; set; }
        public int teamId { get; set; }

        PieceCollection playerPieces;

        internal PieceCollection PlayerPieces
        {
            get { return playerPieces; }
            set { playerPieces = value; }
        }

        public Player(int id, string playerName, int teamId)
        {
            this.id = id;
            this.name = playerName;
            this.teamId = teamId;
            playerPieces = new PieceCollection();
        }

        public void addPiece(Piece p)
        {
            playerPieces.addPiece(p);
        }

        public void pickPieces(DominoSet dominoSet)
        {
            Random rnd = new Random();
            int pickedPieces = 0;
            PieceCollection availablePieces = dominoSet.getUnpickedPieces();

            // there is a special case for when there are 7 pieces left
            if (availablePieces.getCount() == 7)
                playerPieces = availablePieces;
            else
            {
                while (pickedPieces < 7)
                {
                    Piece pickedPiece = availablePieces.getPieceById(rnd.Next(0, availablePieces.getCount()));
                    if (!pickedPiece.picked)
                    {
                        playerPieces.addPiece(pickedPiece);
                        pickedPieces++;
                        dominoSet.markPickedPiece(pickedPiece);
                    }
                }
            }
        }

        public int getUnplayedPieceCount()
        {
            return playerPieces.getUnplayedPieceCount();
        }

        public bool hasDoubleSix()
        {
            return playerPieces.hasDoubleSix();
        }

        public string ToString()
        {
            string returnString = this.name + ": ";
            returnString = returnString + playerPieces.ToString();
            return returnString;
        }
    }
}
