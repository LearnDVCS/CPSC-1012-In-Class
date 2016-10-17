namespace EnumAndComposition
{
    public class Address
    {
        public string Street { get; private set; }
        public string Unit { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }

        public Address(string unit, string street, string city, string state,
                string zipCode)
        {
            this.Unit = unit;
            this.Street = street;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
        }
    }
}
