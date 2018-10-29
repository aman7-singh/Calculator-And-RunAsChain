using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Run_As_Chain.Model;

namespace Run_As_Chain_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string xmlPath = @"D:\VisualStudio\Calculator-And-RunAsChain\Run_As_Chain\Resource\RunAsChain1.xml";
            ModelObjectBuilder Mobj = new ModelObjectBuilder();
            Mobj.XmlToObject(xmlPath);

        }
    }
}
