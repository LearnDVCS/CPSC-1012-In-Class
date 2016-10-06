namespace FlowControl
{
    public class MemoryAddress
    {
        // ushort is an un-signed short - only holds values 0 and above
        public ushort Base10Value { get; private set; }
        public string HexValue
        {
            get
            {
                string hex = "0x"; // common hex prefix for addresses
                // A ushort in hexadecimal will be at most 4 digits
                //      FFFF
                //      ||||
                //      |||- 16^0 =>    1
                //      ||-- 16^1 =>   16
                //      |--- 16^2 =>  256
                //      ---- 16^3 => 4096

                // Finish the calculation for the conversion
                int value = Base10Value;
                hex += GetHexDigit(value / 4096);
                value = value % 4096;
                hex += GetHexDigit(value / 256);
                value = value % 256;
                hex += GetHexDigit(value / 16);
                hex += GetHexDigit(value % 16);

                return hex;
            }
        }

        public MemoryAddress(ushort address)
        {
            Base10Value = address;
        }


        private static string GetHexDigit(int wholePortion)
        {
            string hex;
            switch(wholePortion)
            {
                case 10:
                    hex = "A";
                    break;
                case 11:
                    hex = "B";
                    break;
                case 12:
                    hex = "C";
                    break;
                case 13:
                    hex = "D";
                    break;
                case 14:
                    hex = "E";
                    break;
                case 15:
                    hex = "F";
                    break;
                default:
                    if (wholePortion <= 9)
                        hex = wholePortion.ToString();
                    else
                        hex = ""; // TODO: look for better way to handle invalid digit
                    break;
            }

            return hex;
        }

    } // end of class
} // end of namespace
