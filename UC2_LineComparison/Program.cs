using System;

namespace UC2_LineComparison
{
    class LineComparison
    {
        static void Main(string[] args)
        {
            LineComparison.getCartesian();
        }
        static void getCartesian()
        {
            double x1, x2, y1, y2;
            double length = 0;
            Console.WriteLine("Lenth of first Line is: Line1");
            Console.WriteLine("Lenth of second Line is: Line2");
            length = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            if (line1 == line2)
            {
                Console.WriteLine("The Two Lines are equal:");
            }
            else
                Console.WriteLine("Two Lines are not Equal:");
        }
    }
}
