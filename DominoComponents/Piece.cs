using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoComponents
{
    class Piece
    {

        public int upperValue { get; set; }
        public int lowerValue { get; set; }
        public bool picked { get; set; }
        public bool played { get; set; }
        public int id { get; set; }

        public Piece (int uValue, int lValue, int pieceId)
        {
            this.upperValue = uValue;
            this.lowerValue = lValue;
            this.id = pieceId;
            this.picked = false;
            this.played = false;
        }

        public string ToString()
        {
            return upperValue.ToString() + "/" + lowerValue.ToString();
        }

        public bool isDobuleSix()
        {
            return (upperValue == 6 && lowerValue == 6);
        }

    }
}
