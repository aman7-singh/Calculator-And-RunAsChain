using System;
using Calculator.ViewModel.Delegate;
using Calculator.ViewModel.MainViewModel.Standard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculator
{
    [TestClass]
    public class MainViewModelTest
    {
        //Singleton imlemented.
        // StandardViewModel Calculator = StandardViewModel.GetInstance();

        StandardViewModel Calculator = new StandardViewModel();
        public FetchResultDelegate FactchResult;
        public MainViewModelTest()
        {
            FactchResult = new FetchResultDelegate(OnFatchResult);
        }
        public void OnFatchResult(string abc)
        {
            Calculator.FactchResult(abc);
        }
        [TestMethod]
        public void FactchResultTest()
        {
            //var Calculator = new StandardViewModel();
            Calculator.Expression = "1+2";
            FactchResult("+");
            Assert.AreEqual(3, Calculator.CalcultedValue);
            Calculator.Expression = "3-1";
            FactchResult("-");
            Assert.AreEqual(2, Calculator.CalcultedValue);
            Calculator.Expression = "2*8";
            FactchResult("*");
            Assert.AreEqual(16, Calculator.CalcultedValue);
            Calculator.Expression = "16/2";
            FactchResult("/");
            Assert.AreEqual(8, Calculator.CalcultedValue);
            Calculator.Expression = "1+2-1*8/2+";
            Assert.AreEqual(8, Calculator.CalcultedValue);
        }
    }
}
