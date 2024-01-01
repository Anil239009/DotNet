using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GDI
{
    internal class Line:Shape
    {

        Point StartPoint { get; set; }
        Point EndPoint { get; set; }

        public Line(Point startPoint, Point endPoint,
                    int thickness, string style,  string color)
            :base(color, style, thickness)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public override void Draw()
        {
            Console.WriteLine(this.StartPoint + ","+ this.EndPoint+ " "+ base.ToString());
        }
    }
}
