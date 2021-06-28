using System;

namespace LineComparisonComputation
{
    class Program
    {

        /// <summary>
        /// UC1 - Calculating the length of line based on points (x1,y1) (x2,y2)
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //creating object for Random class
            Random random = new Random();

            //assigning line points using randome Next() method 
            int x1 = random.Next(0, 10);
            int y1 = random.Next(0, 10);
            int x2 = random.Next(0, 10);
            int y2 = random.Next(0, 10);

            //calling static LineLength function
            double line1Length = Program.LineLength(x1, y1, x2, y2);

            Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("Length of the line= "+line1Length);
            Console.Read();
        }


        
            //Calculating length of the line using LineLength method
            public static double LineLength(int xPt1, int yPt1, int xPt2, int yPt2)
            {
                double length = (Math.Sqrt((xPt2 - xPt1) ^ 2 + (yPt2 - yPt1) ^ 2));
                return length;

            }

    }
}
