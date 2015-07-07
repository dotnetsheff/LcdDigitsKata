namespace dotnetsheff.LcdDigitsKata
{  
    public class DigitConvertor
    {
        private static readonly string[] Digits =
        {
            "._.\n|.|\n|_|",
            "...\n..|\n..|",
            "._.\n._|\n|_."

            /*
._.   ...   ._.   ._.   ...   ._.   ._.   ._.   ._.   ._.
|.|   ..|   ._|   ._|   |_|   |_.   |_.   ..|   |_|   |_|
|_|   ..|   |_.   ._|   ..|   ._|   |_|   ..|   |_|   ..|

             */
        };

        public string Convert(int i)
        {
            var lines = new [] {"", "", ""};

            do
            {
                var digit = i%10;

                var digitString = ConvertSingleDigit(digit).Split('\n');
                lines[0] = digitString[0] + " " + lines[0];
                lines[1] = digitString[1] + " " + lines[1];
                lines[2] = digitString[2] + " " + lines[2];

                i = i/10;

            } while ( i > 0);

            return lines[0].Substring(0, lines[0].Length-1) + "\n" +
                   lines[1].Substring(0, lines[1].Length-1) + "\n" + 
                   lines[2].Substring(0, lines[2].Length-1);
        }


        private  string ConvertSingleDigit(int i)
        {
            return Digits[i];
        }
    }
}