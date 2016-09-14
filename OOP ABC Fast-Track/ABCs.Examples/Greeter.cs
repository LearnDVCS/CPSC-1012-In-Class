namespace ABCs.Examples
{
    public class Greeter
    {
        // Fields (to hold information)
        private string _WelcomeMessage;
        private string _FarewellMessage;

        // Constructor (to set up the data for objects)
        public Greeter(string welcomeMsg, string farewellMsg)
        {
            // The job of a constructor is to make sure that
            // all the fields/properties have "meaningful" values
            this._WelcomeMessage = welcomeMsg;
            this._FarewellMessage = farewellMsg;
        }

        // Methods
        public string SayHello()
        {
            return _WelcomeMessage;
        }

        public string SayGoodbye()
        {
            return _FarewellMessage;
        }
    }
}
