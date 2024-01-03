using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI
{
    internal  abstract class Shape
    {
        protected string color;
        protected string style;
        protected int thickness;
        public  Shape(string color, string style, int thickness)
        {       this.color = color;this.
                style = style;
                this.thickness = thickness;

        }
        public abstract void Draw();

        public override string ToString()
        {
            return  " Style="+ this.style +" , Thickness="+
                    this.thickness+", Color="+this.color;
        }
    }
}
