namespace ConsoleApp3
{
	internal class Program
	{
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
            new Rectangle("Piros", 4, 6),
            new Square("Kék", 5),
            new CircleR("Zöld", 3),
            new Rectangle("Sárga", 2, 8),
            new Square("Lila", 7)
            };

            foreach (var shape in shapes)
                Console.WriteLine(shape);

            Console.WriteLine("\nLyukasztás, ha terület nagyobb, mint kerület:");
            foreach (var shape in shapes)
                MakeHoleyIfAreaBiggerThanPerimeter(shape);

            foreach (var shape in shapes)
                Console.WriteLine(shape);

            Console.WriteLine("\nLegnagyobb területű alakzat:");
            Console.WriteLine(FindLargestShape(shapes));
        }

        static void MakeHoleyIfAreaBiggerThanPerimeter(Shape shape)
        {
            if (shape.Area3() > shape.Perimeter2())
            {
                shape.MakeHoley();
            }
        }

        static Shape CreateRectangleOrSquare(string color, double side1, double side2)
        {
            return side1 == side2 ? new Square(color, side1) : new Rectangle(color, side1, side2);
        }

        static Shape FindLargestShape(Shape[] shapes)
        {
            return shapes.OrderByDescending(s => s.Area3()).FirstOrDefault();
        }
    }
}
