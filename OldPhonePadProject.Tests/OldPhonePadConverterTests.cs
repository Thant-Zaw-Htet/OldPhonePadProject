using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OldPhonePadProject.Tests
{
    [TestClass]
    public class OldPhoneTests
    {
        [TestMethod]
        public void OldPhonePad_Input4433555_555666ReturnsHELLO()
        {

            string input = "4433555 555666#";
            string expectedResult = "HELLO";

            string acutalResult = OldPhone.OldPhonePad(input);
   
            Assert.AreEqual(expectedResult, acutalResult);
        }

        [TestMethod]
        public void OldPhonePad_Input227_BackspaceAnd2_ReturnsB()
        {
            string input = "227*#";
            string expectedResult = "B";

            string acutalResult = OldPhone.OldPhonePad(input);

            Assert.AreEqual(expectedResult, acutalResult);
        }



        [TestMethod]
        public void OldPhonePad_Input33_ReturnsE()
        {
            string input = "33#";
            string expectedResult = "E";

            string acutalResult = OldPhone.OldPhonePad(input);

            Assert.AreEqual(expectedResult, acutalResult);
        }

        [TestMethod]
        public void OldPhonePad_Input88777444666_664_ReturnsTURING()
        {
            string input = "8 88777444666*664#";
            string expectedResult = "TURING";

            string acutalResult = OldPhone.OldPhonePad(input);

            Assert.AreEqual(expectedResult, acutalResult);
        }


    }
}
