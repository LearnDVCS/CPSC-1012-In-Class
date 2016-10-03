namespace Selection
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
                converted += ToHexDigit(Red / 16) + ToHexDigit(Red % 16);
                converted += ToHexDigit(Blue / 16) + ToHexDigit(Blue % 16);
                converted += ToHexDigit(Green / 16) + ToHexDigit(Green % 16);
                return converted;
            }
        }

        public Color(byte red, byte blue, byte green)
        {
            Red = red;
            Blue = blue;
            Green = green;
        }

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
