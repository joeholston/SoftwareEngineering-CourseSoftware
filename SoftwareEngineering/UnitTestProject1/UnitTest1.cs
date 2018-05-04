using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareEngineering;

namespace SoftwareEngineeringTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodBoolArrayToString1()
        {
            //Setup
            Search s = new Search(1);
            bool[] test1 = {true,false,true,false};
            string expected = "1010";

            //Act
            string actual = s.boolArrayToString(test1);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodBoolArrayToString2()
        {
            //Setup
            Search s = new Search(1);
            bool[] test1 = {};
            string expected = null;

            //Act
            string actual = s.boolArrayToString(test1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodBoolArrayToString3()
        {
            //Setup
            Search s = new Search(1);
            bool[] test1 = { false};
            string expected = "0";

            //Act
            string actual = s.boolArrayToString(test1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodBoolArrayToString4()
        {
            //Setup
            Search s = new Search(1);
            bool[] test1 = {false,};
            string expected = "0";

            //Act
            string actual = s.boolArrayToString(test1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodBoolArrayToString5()
        {
            //Setup
            Search s = new Search(1);
            bool[] test1 = new bool[5];
            test1[1] = true;
            string expected = "01000";

            //Act
            string actual = s.boolArrayToString(test1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
//xunit
//mstest