namespace AppStar
{
    public class PhoneNumberEntry
    {
        public string Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{LastName}, {FirstName} -- {Number}";
        }
    }
}
