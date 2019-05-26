using Calculator.ViewModel.Interfaces;
using Calculator.ViewModel.MainViewModel.Standard;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class StandardViewModel_Test
    {
        IStandardViewModel Istandard;
        [SetUp]
        public void Setup()
        {
            Istandard = new StandardViewModel();
        }

        [Test]
        public void AdditionTest()
        {
            Istandard.Expression = "1+2";
            Istandard.Summing("+");
            Assert.AreEqual(Istandard.CalcultedValue, 3);
        }
        [Test]
        public void Substraction_Test()
        {
            Istandard.Expression = "9-8";
            Istandard.Summing("+");
            Assert.AreEqual(Istandard.CalcultedValue, 1);
        }
        [Test]
        public void MultiplicationTest()
        {
            Istandard.Expression = "1*2";
            Istandard.Summing("+");
            Assert.AreEqual(Istandard.CalcultedValue, 2);
        }
        [Test]
        public void DivistionTest()
        {
            Istandard.Expression = "8/2";
            Istandard.Summing("+");
            Assert.AreEqual(Istandard.CalcultedValue, 4);
        }
        [Test]
        public void PowerTest()
        {
            Istandard.Expression = "2^4";
            Istandard.Summing("+");
            Assert.AreEqual(Istandard.CalcultedValue, 16);
        }
        [Test]
        public void SquareRootTest()
        {
            Istandard.Expression = "4\\2";
            Istandard.Summing("+");
            Assert.AreEqual(Istandard.CalcultedValue,2 );
        }
        [Test]
        public void LongExpression_Test()
        {
            Istandard.Expression = "1+2-1*2/2^3";
            Istandard.Summing("+");
            Assert.AreEqual(Istandard.CalcultedValue, 8);
        }
    }
}