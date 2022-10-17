using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class AbstractionShape
    {
        protected IColor color;
        public AbstractionShape(IColor color)
        {
            this.color = color;
        }
        public virtual void ShowName()
        {
            Console.WriteLine("Base Shape with color : " + color.GetColor());
        }
    }
}
