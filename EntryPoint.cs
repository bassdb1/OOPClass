// adding so I can use my 'Point Class' which is in the 'PointsAndLines' folder

using OOPClass;
using PointAndLines;
using System;
    class EntryPoint
    {
        static void Main()
        {

        // going to make an 'instance' of the 'User Class'
        // setting the 'username', and 'Race Type'  in the constructor
        User user = new User("David", Race.Earthling);
        System.Console.WriteLine("user ID = " + user.ID);

        //making another 'instance' of the 'User Class'
        User user2 = new User();
        System.Console.WriteLine("user2 ID = " + user2.ID);

       
        //Count How many 'Objects' have been made.
        System.Console.WriteLine("Total number of objects is " + User.currentID);

        // Use the ColorfulWriteLine Method, from our Utilities Static Class
        Utilities.ColorfulWriteLine(user.Username, ConsoleColor.Green);











        }
    }

