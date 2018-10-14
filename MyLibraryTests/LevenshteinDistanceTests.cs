    using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace MyLibraryTests
{
    [TestClass]
    public class LevenshteinDistanceTests
    {
        [TestMethod]
        public void XamarinAdnCamarin_ShouldReturn1()
        {
            //Arrange
            var cadena1 = "xamarin";
            var cadena2 = "camarin";
            int ExpectedResult = 1;
            LevenshteinDistance calculator = new LevenshteinDistance();

            //Act
            var result = calculator.Compute(cadena1, cadena2);

            //Assert
            Assert.AreEqual(ExpectedResult, result);
        }
    }
}
