namespace Codility.Test.Lesson2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;
    using main = Codility.Lesson2;

    [TestClass]
    public class MaxCounters
    {
        private main.MaxCounters max = new main.MaxCounters();

        [TestMethod]
        public void SimpleTest1()
        {
            var array = new int[] { 3, 4, 4, 6, 1, 4, 4 };
            var expected = new int[] { 3, 2, 2, 4, 2 };
            var result = max.Solution(5, array);

            Assert.IsTrue(Enumerable.SequenceEqual(expected, result));
        }
    }
}