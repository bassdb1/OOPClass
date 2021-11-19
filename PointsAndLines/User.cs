//Adding a 'Namespace' and the folder name that containes the class 'PoinrAndLines'
namespace PointAndLines
{
    // Adding a new class called User
    class User
    {
      // Static Variable - currentID
        public static int currentID;

      // Fields 
        private string username;
        private int password;
        public const int HEIGHT = 180; // const constant, using centimeters
        public readonly int ID; // Readonly constant 

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
            // Increment my Static Variable 'ID' whenever a new 'Instance' of the User class occurs
            // .. in my Property
            currentID++;
            id = currentID;
        }

        // Constructor
        public User (string username)
        {
            // Increment my Static Variable 'ID' whenever a new 'Instance' of the User class occurs
            // .. in my Contructor
            currentID++;
            id = currentID;
            this.username = username;
            
        }

    

    }
}

