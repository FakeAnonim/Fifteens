using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Coordinates
    {
        public Coordinates(Int32 x, Int32 y)
        {
            X = x;
            Y = y;
        }

        public Int32 X { get; set; }
        public Int32 Y { get; set; }

        #region Overrides
        public override string ToString()
        {
            return String.Format("({0}:{1})", X, Y);
        }

        public override Boolean Equals(object obj)
        {
            Coordinates coordinates = obj as Coordinates;
            if (coordinates != null)
            {
                return coordinates.X == this.X && coordinates.Y == this.Y;
            }
            return false;
        }

        public override Int32 GetHashCode()
        {
            return (Int32)Math.Pow(this.X, this.Y);
        }
        #endregion //Overrides
    }

    enum EmptyFish
    {
        none,
        Left,
        Right,
        Up,
        Down
    }

    class Fish
    {
        public Fish(Int32 value, Int32 x, Int32 y)
        {
            Value = value;
            Location = new Coordinates(x, y);
            EmptyTo = EmptyFish.none;
        }

        public static Fish EmptyField;

        public Int32 Value { get; set; }
        public Coordinates Location { get; private set; }
        public EmptyFish EmptyTo { get; set; }

        public override string ToString()
        {
            return String.Format("{0}: Loc: {2}; EF: {3}", Value, Location.ToString(), EmptyTo.ToString());
        }
    }
}
