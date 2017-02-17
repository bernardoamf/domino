using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoComponents
{
    class PieceCollection
    {
        List<Piece> pieces;

        public PieceCollection()
        {
            pieces = new List<Piece>();
        }

        public void addPiece(Piece p)
        {
            pieces.Add(p);
        }

        public Piece getPieceById(int id)
        {
            return pieces.ElementAt(id);
        }

        public int getCount()
        {
            return pieces.Count();
        }
        public int getPickedPiecesCount()
        {
            int i = 0;
            foreach (Piece p in pieces)
            {
                if (p.picked)
                    i++;
            }
            return i;
        }

        public PieceCollection getUnpickedPieces()
        {
            PieceCollection unassigned = new PieceCollection();
            foreach (Piece p in pieces)
            {
                if (!p.picked)
                {
                    unassigned.addPiece(p);
                }
            }
            return unassigned;
        }

        public void markPickedPiece(Piece p)
        {
            pieces.ElementAt(p.id).picked = true;
        }

        public bool hasDoubleSix()
        {
            bool returnValue;
            foreach (Piece p in pieces)
            {
                returnValue = p.isDobuleSix();
            }
            return returnValue;
        }
        public string ToString()
        {
            string returnString = String.Empty;
            foreach (Piece p in pieces)
                returnString = returnString + p.ToString() + " | ";
            return returnString;
        }


    }
}
