// adding so I can use my 'Point Class' which is in the 'PointsAndLines' folder
using PointAndLines;
    class EntryPoint
    {
        static void Main()
        {

        // going to make an 'instance' of the 'User Class'

          // giving values through the constructor
          // User user = new User(5,3);

        // ** giving values through the 'properties' **

          // going to make an 'instance' of the 'User Class'
        User user = new User();

        user.Username = "abcd";
        user.Password = 2;

        System.Console.WriteLine(user.Username);
        

      

        }
    }

