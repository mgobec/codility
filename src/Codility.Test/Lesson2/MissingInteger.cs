namespace Codility.Test.Lesson2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson2;

    [TestClass]
    public class MissingInteger
    {
        private main.MissingInteger missing = new main.MissingInteger();

        [TestMethod]
        public void SimpleTest1()
        {
            var array = new int[] { 1, 3, 6, 4, 1, 2 };
            var result = missing.Solution(array);

            Assert.AreEqual(5, result);
        }
    }
}