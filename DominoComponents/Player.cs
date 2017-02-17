﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoComponents
{
    class Player
    {
        string name { get; set; }
        public int id { get; set; }

        PieceCollection playerPieces;

        internal PieceCollection PlayerPieces
        {
            get { return playerPieces; }
            set { playerPieces = value; }
        }

        public Player(string playerName)
        {
            name = playerName;
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
            int returnValue = 0;
            foreach (Piece p in playerPieces)
            {
                if (!p.played)
                    returnValue++;
            }

            return returnValue;
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