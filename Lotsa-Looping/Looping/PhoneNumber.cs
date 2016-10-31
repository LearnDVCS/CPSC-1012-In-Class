namespace Looping
{
    public class PhoneNumber
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Number { get; private set; }

        public PhoneNumber(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = phoneNumber;
        }
    }
}
