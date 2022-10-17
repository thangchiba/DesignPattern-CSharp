using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Square : AbstractionShape
    {
        public Square(IColor color) : base(color)
        {
        }
        public void ShowCorner()
        {
            Console.WriteLine(color.GetColor()+" Square have 4 same length corner");
        }

        public override void ShowName()
        {
            Console.WriteLine("This is Square with color " + color.GetColor());
        }
    }
}
