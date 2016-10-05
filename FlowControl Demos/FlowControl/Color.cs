namespace FlowControl
{
    public class Color
    {
        public byte Red { get; private set; }
        public byte Blue { get; private set; }
        public byte Green { get; private set; }

        public string Hex
        {
            get
            {
                string converted = "#";
                converted += GetHexDigit(Red / 16)
                           + GetHexDigit(Red % 16)
                           + GetHexDigit(Blue / 16)
                           + GetHexDigit(Blue % 16)
                           + GetHexDigit(Green / 16)
                           + GetHexDigit(Green % 16);
                return converted;
            }
        }

        public Color(byte red, byte blue, byte green)
        {
            Red = red;
            Blue = blue;
            Green = green;
        }

        private static string GetHexDigit(int wholePortion)
        {
            string hex;
            if (wholePortion <= 9)
                hex = wholePortion.ToString();
            else if (wholePortion == 10)
                hex = "A";
            else if (wholePortion == 11)
                hex = "B";
            else if (wholePortion == 12)
                hex = "C";
            else if (wholePortion == 13)
                hex = "D";
            else if (wholePortion == 14)
                hex = "E";
            else if (wholePortion == 15)
                hex = "F";
            else
                hex = ""; // TODO: look for better way to handle invalid digit

            return hex;
        }
    }
}
