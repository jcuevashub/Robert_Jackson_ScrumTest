using MorseCode;
using NUnit.Framework;
using System;

namespace MorseCodeTest
{
    /*
   * PO Test Cases:
   * [TestCase("", "")] DONE
   * [TestCase("E", ".")] DONE
      [TestCase("SOS", "...|---|...")]
      [TestCase("SOS SOS", "...|---|... ...|---|...")]
      [TestCase("ADERLIS Y EDWIN", ".-|-..|.|.-.|.-..|.|... -.-- .|-..|.--|.|-.")]
      [TestCase("WILSON Y OMAR", ".--|..|.-..|...|---|-. -.-- ---|--|.-|.-.")]
      [TestCase("JACKSON Y ROBERT", ".---|.-|-.-.|-.-|...|---|-. -.-- .-.|---|-...|.|.-.|-")]
      [TestCase("SCRUM DEVELOPER", "...|-.-.|.-.|..-|-- -..|.|...-|.|.-..|---|.--.|.|.-.")]
      [TestCase("ALOES PMS", ".-|.-..|---|.|... .--.|--|...")]
   */
    [TestFixture]
    public class MorseTranslatorTest
    {

        [TestCase("", "")]
        public void With_Empty_String_Returns_Empty_String(string message, string tranlation)
        {
            var translator = new MorseTranslator();

            string response = translator.Translate(message);

            Assert.That(response, Is.EqualTo(tranlation));
        }

        [TestCase("E", ".")]
        public void With_LetterE_Returns_Dot(string message, string tranlation)
        {
            var translator = new MorseTranslator();

            string response = translator.Translate(message);
            Assert.That(response, Is.EqualTo(tranlation));
        }

        [TestCase("SOS", "...|---|...")]
        [TestCase("SOS SOS", "...|---|... ...|---|...")]
        [TestCase("ADERLIS Y EDWIN", ".-|-..|.|.-.|.-..|..|... -.-- .|-..|.--|..|-.")]
        [TestCase("WILSON Y OMAR", ".--|..|.-..|...|---|-. -.-- ---|--|.-|.-.")]
        [TestCase("JACKSON Y ROBERT", ".---|.-|-.-.|-.-|...|---|-. -.-- .-.|---|-...|.|.-.|-")]
        [TestCase("SCRUM DEVELOPER", "...|-.-.|.-.|..-|-- -..|.|...-|.|.-..|---|.--.|.|.-.")]
        [TestCase("ALOES PMS", ".-|.-..|---|.|... .--.|--|...")]
        public void With_Values_Returns_Translation(string message, string tranlation)
        {
            var translator = new MorseTranslator();

            string response = translator.Translate(message);
            Assert.That(response, Is.EqualTo(tranlation));
        }

    }
}