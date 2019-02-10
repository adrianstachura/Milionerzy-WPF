using Microsoft.VisualStudio.TestTools.UnitTesting;
using MilionerzyLibrary;

namespace MilionerzyLibraryTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void kolaTest()
        {
      
            int n = 8;
            int odp1 = 4;          
            int fifty = 0;
            int ph1 = 47;
            string t = string.Empty;
            string expected = ("Wydaje mi siê, ¿e jest to odpowiedŸ " + Questions.Quest[n, odp1]);
            kola test = new kola();
            test.phone(n, fifty, ph1,out t);
            Assert.AreEqual(expected, t);
        }
      [TestMethod]
        public void ShowCurrentTest()
        {
            int n = 5;
            string t = string.Empty;
            string expected = "Aktualnie posiadasz: \r\n 10 000 pln";
            Rewards test = new Rewards();
            test.showCurrent(n, out t);
            Assert.AreEqual(expected, t);
        }
        [TestMethod]
        public void ShowNextTest()
        {
            int n = 7;
            string t = string.Empty;
            string expected = "Aktualnie grasz o: \r\n 75 000 pln";
            Rewards test = new Rewards();
            test.showNext(n, out t);
            Assert.AreEqual(expected, t);
        }
    }
}


