using System;
using System.Collections.Generic;
using System.Text;

namespace Struct
{
   public class Dot
    {
        public int X { get; set; }
        public int Y { get; set; }

        //Default constructor
        public Dot(int x,int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"{X},{Y}";
        }


        public void SetOrigin()
        {
            this.X = 5;
            this.Y = 4;
        }
        public void Change()
        {
            var temp = this.X;
            this.X = this.Y;
            this.Y = temp;
        }

    }
}
