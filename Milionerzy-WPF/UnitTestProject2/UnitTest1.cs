using Microsoft.VisualStudio.TestTools.UnitTesting;
using MilionerzyLibrary;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void phoneTest()
        {
            kola test = new kola();
            string tekst = string.Empty;
            test.phone(5, 0, 91, out tekst);
            Console.WriteLine(tekst);
            Console.ReadKey();
        }
    }
}
