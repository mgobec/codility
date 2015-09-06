namespace Codility.Test.Lesson3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson3;

    [TestClass]
    public class CountDiv
    {
        private main.CountDiv count = new main.CountDiv();

        [TestMethod]
        public void SimpleTest1()
        {
            var result = count.Solution(6, 11, 2);

            Assert.AreEqual(3, result);
        }
    }
}