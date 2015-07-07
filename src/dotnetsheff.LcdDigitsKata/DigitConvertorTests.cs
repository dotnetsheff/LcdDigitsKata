using Shouldly;

namespace dotnetsheff.LcdDigitsKata
{
    public class DigitConvertorTests
    {
        public void GivenAnZero_ThenAnZeroDigitIsReturned()
        {
            var digitConvertor = new DigitConvertor();
            var digit = digitConvertor.Convert(0);

            digit.ShouldBe("._.\n|.|\n|_|");
        }

        public void GivenAnOne_ThenAnOneDigitIsReturned()
        {
            var digitConvertor = new DigitConvertor();
            var digit = digitConvertor.Convert(1);

            digit.ShouldBe("...\n..|\n..|");
        }

        public void GivenAnTwo_ThenAnTwoDigitIsReturned()
        {
            var digitConvertor = new DigitConvertor();
            var digit = digitConvertor.Convert(2);

            digit.ShouldBe("._.\n._|\n|_.");
        }

        public void GivenATen_ThenAnTenDigitIsReturned()
        {
            var digitConvertor = new DigitConvertor();
            var digit = digitConvertor.Convert(10);

            digit.ShouldBe("... ._.\n..| |.|\n..| |_|");
        }

        public void GivenA11_ThenAn11DigitIsReturned()
        {
            var digitConvertor = new DigitConvertor();
            var digit = digitConvertor.Convert(11);

            digit.ShouldBe("... ...\n..| ..|\n..| ..|");
        }

        public void GivenA201_ThenAn201DigitIsReturned()
        {
            var digitConvertor = new DigitConvertor();
            var digit = digitConvertor.Convert(201);

            digit.ShouldBe( "._. ._. ...\n" +
                            "._| |.| ..|\n" +
                            "|_. |_| ..|");
        }
    }
}
  