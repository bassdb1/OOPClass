﻿//Adding a 'Namespace' and the folder name that containes the class 'PoinrAndLines'
namespace PointAndLines
{
    // Adding a new class called User
    class User
    {
      // Fields 
        private string username;
        private int password;

        // Username Property
        public string Username
        {

            get
            {
                return "The username is " + username;            
            }

                         
        }

        // Password Property

        public int Password 
        {
           
            set
            {
                // Validation - only Set password if length is between 4 and 10 characters.

                if (value >= 4 && value <= 10)
                {
                    password = value;
                }
                else
                {
                    System.Console.WriteLine("Oops, this is not a valid password!  Please use a password with 4 to 10 characters");
                }
                password = value;
            }
        
        }

        // You can have multiple Constructors, this will create a new Point Ov=bject, without arguments
        public User()
        {

        }

        // Constructor
        public User (string username)
        {
            this.username = username;
            
        }

    

    }
}

