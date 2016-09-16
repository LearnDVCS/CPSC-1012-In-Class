namespace ABCs.Examples
{
    public class Person
    {
        // Fields
        private string _FirstName;
        private string _LastName;
        public int Age; // temporarily leave this as a public field

        // Properties
        public string FullName
        {
            get
            {
                // String concatenation to build the full name
                return FirstName + " " + LastName;
            }
        }

        public string FirstName
        {
            get // Getter method
            {
                return _FirstName;
            }
            set // Setter method
            {
                _FirstName = value; // Notice that value is a keyword inside the set method
            }
        }

        public string LastName
        {
            get // Getter method
            {
                return _LastName;
            }
            set // Setter method
            {
                _LastName = value; // Notice that value is a keyword inside the set method
            }
        }
    }
}
