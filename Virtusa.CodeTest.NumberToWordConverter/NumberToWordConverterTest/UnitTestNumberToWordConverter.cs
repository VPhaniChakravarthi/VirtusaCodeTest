using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Virtusa.CodeTest.NumberToWordConverter;

namespace NumberToWordConverterTest
{
    [TestClass]
    public class UnitTestNumberToWordConverter
    {
        [TestMethod]
        public void TestWordConverter()
        {
            string strNumberWord = NumberToWordConverter.Convert(984);
            Assert.AreEqual(strNumberWord,"nine hundred and eighty four ");
        }
    }
}
