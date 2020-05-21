using MorseCode;
using NUnit.Framework;

namespace MorseCodeTest
{
    [TestFixture]
    public class MorseTranslatorTest
    {
        /*
          * PO Test Cases:
          * [TestCase("", "")] DONE
          * [TestCase("E", ".")] DONE
             [TestCase("SOS", "...|---|...")] DONE
             [TestCase("SOS SOS", "...|---|... ...|---|...")] DONE
             [TestCase("ADERLIS Y EDWIN", ".-|-..|.|.-.|.-..|.|... -.-- .|-..|.--|.|-.")] DONE
             [TestCase("WILSON Y OMAR", ".--|..|.-..|...|---|-. -.-- ---|--|.-|.-.")] DONE
             [TestCase("JACKSON Y ROBERT", ".---|.-|-.-.|-.-|...|---|-. -.-- .-.|---|-...|.|.-.|-")] DONE
             [TestCase("SCRUM DEVELOPER", "...|-.-.|.-.|..-|-- -..|.|...-|.|.-..|---|.--.|.|.-.")] DONE
             [TestCase("ALOES PMS", ".-|.-..|---|.|... .--.|--|...")] DONE
          */

        [TestCase("","")]
        public void With_Empty_String_Returns_Empty_String(string message, string translation)
        {
            var translator = new MorseTranslator();

            string response = translator.Translate(message);

            Assert.That(response, Is.EqualTo(translation));
        }

        [TestCase("E",".")]
        public void With_Letter_E_Returns_Dot(string message, string translation)
        {
            var translator = new MorseTranslator();

            string response = translator.Translate(message);

            Assert.That(response, Is.EqualTo(translation));

        }

        [TestCase("SOS", "...|---|...")]
        [TestCase("SOS SOS", "...|---|... ...|---|...")]
        [TestCase("ADERLIS Y EDWIN", ".-|-..|.|.-.|.-..|..|... -.-- .|-..|.--|..|-.")]
        [TestCase("WILSON Y OMAR", ".--|..|.-..|...|---|-. -.-- ---|--|.-|.-.")]
        [TestCase("JACKSON Y ROBERT", ".---|.-|-.-.|-.-|...|---|-. -.-- .-.|---|-...|.|.-.|-")]
        [TestCase("SCRUM DEVELOPER", "...|-.-.|.-.|..-|-- -..|.|...-|.|.-..|---|.--.|.|.-.")]
        [TestCase("ALOES PMS", ".-|.-..|---|.|... .--.|--|...")]
        public void With_Values_Returns_Translation(string message, string translation)
        {
            var translator = new MorseTranslator();

            string response = translator.Translate(message);

            Assert.That(response, Is.EqualTo(translation));
        }

    }
}