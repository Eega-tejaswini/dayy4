using SampleDemo;

namespace TestProjectMs
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            MathOp mth = new MathOp();
            int res = mth.Add(30, 30);
            Assert.AreEqual(60,res);
        }

        [TestMethod]
        public void TestMethodSub()
        {
            //test for Add method
            MathOp mth = new MathOp();
            int res = mth.Sub(50, 20);
            Assert.AreEqual(res, 40);
        }

        [TestMethod]


        public void TestMethodProd()
        {
            MathOp mth = new MathOp();
            int res = mth.Mul(5, 4);
            Assert.AreEqual(res, 20);
        }
    }
}
