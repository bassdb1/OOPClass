// adding so I can use my 'Point Class' which is in the 'PointsAndLines' folder
using PointAndLines;
    class EntryPoint
    {
        static void Main()
        { 
        
        // going to make an 'instance' of the 'Point Class'

            Point point = new Point(5,3);

        // An Object without arguments
        Point pointTwo = new Point();

        // assigning values instead of using arguments
        pointTwo.X = 7;

            System.Console.WriteLine(point.X);

            System.Console.WriteLine(point.Y);

            System.Console.WriteLine(pointTwo.X);

      

        }
    }

