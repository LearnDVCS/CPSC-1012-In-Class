using System;
using System.Collections.Generic;

namespace AppStar
{
    public class PhoneBookFileIO : CSVFileIO<PhoneNumberEntry>
    {
        public PhoneBookFileIO(string filePath) : base(filePath)
        {
        }

        protected override PhoneNumberEntry ParseLine(string line)
        {
            string[] parts = line.Split(',');
            return new PhoneNumberEntry()
            {
                FirstName = parts[2],
                LastName = parts[1],
                Number = parts[0]
            };
        }

        protected override string ToCsvString(PhoneNumberEntry item)
        {
            return $"{item.Number},{item.LastName},{item.FirstName}";
        }
    }
}
