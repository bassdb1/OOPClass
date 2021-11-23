//Adding a 'Namespace' and the folder name that containes the class 'PoinrAndLines'
namespace PointAndLines
{
    // Adding a new class called User
    class User
    {
      // Static Variable - currentID
        public static int currentID;

        // Fields 
        public Race race;  // Using Race Class, new 'race' field, with data type 'Race'
        private string username;
        private int password;
        // public const int HEIGHT = 180; // const constant, using centimeters

        public readonly int HEIGHT; // Readonly constant, define in the constructor 
        public readonly int ID; // Readonly constant, define in the constructor 

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
            ID = currentID;
        }

        // Constructor
        public User (string username, Race race) // (arguments in the braces)
        {
            // Increment my Static Variable 'ID' whenever a new 'Instance' of the User class occurs
            // .. in my Contructor
            currentID++;
            ID = currentID;
            // Using (this.username = field value), (= username = argument value)
            this.username = username;
            // Using (this.race = field value), (= race = argument value)
            // .. we are getting the value from the argument, and then assigning to the field value)
            this.race = race;
            
            // use an if statement to set height of race by type
            if (this.race == Race.Martian)
            {
                HEIGHT = 100;
            }
            else if (this.race == Race.Earthling )
            {
                HEIGHT = 180;
            }
        }

    

    }
}

