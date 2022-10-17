using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Circle : AbstractionShape
    {
        float radius = 100;
        public Circle(IColor color) : base(color)
        {
        }
        public void ShowRadius()
        {
            Console.WriteLine(color.GetColor() + "Circle have Radius is : " + radius);
        }

        public void ShowPi()
        {
            Console.WriteLine("Pi is 3.14");
        }
        public override void ShowName()
        {
            Console.WriteLine("This is Circle with color " + color.GetColor());
        }
    }
}
