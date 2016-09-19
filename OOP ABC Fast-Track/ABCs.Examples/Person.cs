namespace ABCs.Examples
{
    public class Person
    {
        // Fields
        private string _FirstName;  // "backing store"
        private string _LastName;
        public int Age; // temporarily leave this as a public field

        // Properties
        // Explicitly implemented property
        public string FirstName
        {
            get // Getter method
            {
                return _FirstName; // send back the value inside of _FirstName
            }
            set // Setter method
            {
                // the value keyword only appears inside of property set
                _FirstName = value;
            }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string FullName
        {
            get
            {
                // String concatenation to build the full name
                return FirstName + " " + LastName;
            }
        }
    } // end of Person class
}
