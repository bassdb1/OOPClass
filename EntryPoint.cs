// adding so I can use my 'Point Class' which is in the 'PointsAndLines' folder
using PointAndLines;
    class EntryPoint
    {
        static void Main()
        {

        // going to make an 'instance' of the 'User Class'
        // setting the 'username' in the constructor
        User user = new User("David");

        //making another 'instance' of the 'User Class'
        User user2 = new User();

        // Printing out the Static Variable 'ID'
        System.Console.WriteLine(User.ID);






        // user.Password = 4;

        // System.Console.WriteLine(user.Username);
               

      

        }
    }

