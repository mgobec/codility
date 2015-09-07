namespace Codility.Test.Stage2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Stage2;

    [TestClass]
    public class Task1
    {
        private main.Task1 task = new main.Task1();

        [TestMethod]
        public void SimpleTest1()
        {
            var result = task.Solution(100);

            Assert.AreEqual("100", result);
        }

        [TestMethod]
        public void SimpleTest2()
        {
            var result = task.Solution(10000);

            Assert.AreEqual("10,000", result);
        }

        [TestMethod]
        public void SimpleTest3()
        {
            var result = task.Solution(0);

            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void SimpleTest4()
        {
            var result = task.Solution(1000000);

            Assert.AreEqual("1,000,000", result);
        }

        [TestMethod]
        public void SimpleTest5()
        {
            var result = task.Solution(1);

            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void SimpleTest6()
        {
            var result = task.Solution(1000000000);

            Assert.AreEqual("1,000,000,000", result);
        }

        [TestMethod]
        public void SimpleTest7()
        {
            var result = task.Solution(10);

            Assert.AreEqual("10", result);
        }
    }
}