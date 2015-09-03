namespace Codility.Test.Lesson4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson4;

    [TestClass]
    public class NumberOfDiscIntersections
    {
        private main.NumberOfDiscIntersections intersections = new main.NumberOfDiscIntersections();

        [TestMethod]
        public void SimpleTest1()
        {
            var array = new int[] { 1, 5, 2, 1, 4, 0 };
            var result = intersections.Solution(array);

            Assert.AreEqual(11, result);
        }
    }
}