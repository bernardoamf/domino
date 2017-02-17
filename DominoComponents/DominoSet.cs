using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoComponents
{
    class DominoSet
    {
        PieceCollection pieces;

        public DominoSet()
        {
            pieces = new PieceCollection();
            int pieceId = 0;
            //Create the pieces
            for (int upperValue = 0; upperValue < 7; upperValue++)
            {
                for (int lowerValue = upperValue; lowerValue < 7; lowerValue++)
                {
                    pieces.addPiece(new Piece(upperValue, lowerValue, pieceId));
                    pieceId++;
                }
            }
        }

        public PieceCollection getPieces()
        {
            return pieces;
        }

        public Piece getPieceById(int id)
        {
            return pieces.getPieceById(id);
        }

        public int getPickedPiecesCount()
        {
            return pieces.getPickedPiecesCount();
        }

        public PieceCollection getUnpickedPieces()
        {
            return pieces.getUnpickedPieces();
        }

        public void markPickedPiece(Piece p)
        {
            pieces.markPickedPiece(p);
        }
    }
}
