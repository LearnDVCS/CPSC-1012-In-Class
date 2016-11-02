using System;
namespace Looping
{
    public class PhoneBook
    {
        private const int MAX_RECORDS = 1000;
        private PhoneNumber[] Number { get; set; }

        public int Count { get; private set; } // Manage my Logical Size

        public PhoneBook()
        {
            // Create an array capable of holding MAX_RECORDS
            Number = new PhoneNumber[MAX_RECORDS];
        }

        public void AddPhoneNumber(PhoneNumber entry)
        {
            // Validation
            if (entry == null)
                throw new Exception("The phone number entry cannot be null");
            if (Count == MAX_RECORDS)
                throw new Exception("This phone book cannot hold any more phone numbers");

            // Append entry to the end of the array
            Number[Count] = entry; // put into the next available spot
            Count++; // increment the logical size
        }

        public PhoneNumber GetPhoneNumber(int index)
        {
            if (index >= Count) // || index < 0
                throw new Exception("Invalid index position in this phone book");
            return Number[index];
        }

        public PhoneNumber FindPhoneNumber(string telephoneNumber)
        {
            PhoneNumber found = null; // because it might not exist

            int foundIndex = -1;
            for(int index = 0; index < Count; index++)
            {
                if(Number[index].Number.Equals(telephoneNumber))
                {
                    foundIndex = index; // I found the location of the number
                    break; // I can exit the loop early
                }
            }

            if (foundIndex >= 0)
                found = Number[foundIndex];

            return found;
        }
    }
}
