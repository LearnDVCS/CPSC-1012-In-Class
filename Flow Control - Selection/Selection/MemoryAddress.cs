namespace Selection
{
    public class MemoryAddress
    {
        #region Public API of my class
        // Property
        // An unsigned-short, or ushort, holds a value from 0 to 65,535
        public ushort Base10Value { get; private set; }

        // Constructor
        public MemoryAddress(ushort address)
        {
            Base10Value = address;
        }

        // Property - calculated
        public string HexValue
        {
            get
            {
                string hex = "0x"; // prefix for hex value
                // An unsigned-short in hexadecimal
                // will be at most 4 digits
                //      FFFF
                //      ||||
                //      |||- 16^0 =>     1
                //      ||-- 16^1 =>    16
                //      |--- 16^2 =>   256
                //      ---- 16^3 =>  4096

                int temp = Base10Value; // make a copy
                // Get the 16^3 position
                int portion = temp / 4096;
                hex += ToHexDigit(portion);
                temp -= portion * 4096;

                // Get the 16^2 position
                portion = temp / 256;
                hex += ToHexDigit(portion);
                temp -= portion * 256;

                // Get the 16^1 position
                portion = temp / 16;
                hex += ToHexDigit(portion);

                // get the 16^0 position
                portion = temp % 16; // Modulus - remainder
                hex += ToHexDigit(portion);

                return hex;
            }
        }
        #endregion

        #region Private "helper" methods
        private string ToHexDigit(int number)
        {
            string result;
            if (number < 10)
                result = number.ToString();
            else if (number == 10)
                result = "A";
            else if (number == 11)
                result = "B";
            else if (number == 12)
                result = "C";
            else if (number == 13)
                result = "D";
            else if (number == 14)
                result = "E";
            else if (number == 15)
                result = "F";
            else
                result = "";
            return result;
        }
        #endregion
    }
}
