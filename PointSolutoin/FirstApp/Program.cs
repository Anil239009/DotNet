
using Maths;

Point p1 = new Point(34, 45);

Point p2 = new Point(77, 56);


Line l = new Line(p1,p2, 3, "dash", "red");
Shape shape = l;
shape.Draw();

