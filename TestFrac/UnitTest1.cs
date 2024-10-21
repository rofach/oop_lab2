using Fraction;

namespace TestFrac
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            string ecpected = "(1/2)";
            string actual = MyFrac.ToStringWithIntPart(new MyFrac(6, 12));
            Assert.AreEqual(ecpected, actual);
        }

        [TestMethod]
        public void TestN1()
        {
            string ecpected = "-(1/2)";
            string actual = MyFrac.ToStringWithIntPart(new MyFrac(-6, 12));
            Assert.AreEqual(ecpected, actual);
        }

        [TestMethod]
        public void TestN2()
        {
            string ecpected = "-(1/2)";
            string actual = MyFrac.ToStringWithIntPart(new MyFrac(6, -12));
            Assert.AreEqual(ecpected, actual);
        }


        [TestMethod]
        public void Test3()
        {
            string ecpected = "(1/2)";
            string actual = MyFrac.ToStringWithIntPart(new MyFrac(-6, -12));
            Assert.AreEqual(ecpected, actual);
        }


        [TestMethod]
        public void TestDiv()
        {
            string ecpected = "(19+3/10)";
            string actual = MyFrac.ToStringWithIntPart(new MyFrac(579, 30));
            Assert.AreEqual(ecpected, actual);
        }

        [TestMethod]
        public void TestNDiv()
        {
            string ecpected = "-(19+3/10)";
            string actual = MyFrac.ToStringWithIntPart(new MyFrac(579, -30));
            Assert.AreEqual(ecpected, actual);
        }

        [TestMethod]
        public void TestInt()
        {
            string ecpected = "(4)";
            string actual = MyFrac.ToStringWithIntPart(new MyFrac(16, 4));
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void TestNInt()
        {
            string ecpected = "-(4)";
            string actual = MyFrac.ToStringWithIntPart(new MyFrac(-16, 4));
            Assert.AreEqual(ecpected, actual);
        }
    }
}