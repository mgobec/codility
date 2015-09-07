namespace Codility.Test.Lesson3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson3;

    [TestClass]
    public class MinAvgTwoSlice
    {
        private main.MinAvgTwoSlice slice = new main.MinAvgTwoSlice();

        [TestMethod]
        public void SimpleTest1()
        {
            var array = new int[] { 4, 2, 2, 5, 1, 5, 8 };
            var result = slice.Solution(array);

            Assert.AreEqual(1, result);
        }
    }
}