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
                throw new Exception("Invalid index position in this Phone Book");
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

        public PhoneNumber[] FindPhoneNumbersByLastname(string lastName)
        {
            PhoneNumber[] found = new PhoneNumber[Count];
            // Find the numbers
            int foundCounter = 0; // Logical size of the found results
            for(int index = 0; index < Count; index++)
            {
                PhoneNumber item = Number[index]; // Get a reference to the item
                if(item.LastName.Equals(lastName))
                {
                    found[foundCounter] = item; // append the item to the found array
                    foundCounter++; // increment logical size
                }
            }

            // Trim the array
            PhoneNumber[] foundTrimmed = new PhoneNumber[foundCounter];
            for (int index = 0; index < foundCounter; index++)
                foundTrimmed[index] = found[index]; // copy over item

            return foundTrimmed;
        }
    }
}
