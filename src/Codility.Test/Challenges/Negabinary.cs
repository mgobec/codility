namespace Codility.Test.Challenges
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;
    using main = Codility.Challenges;

    [TestClass]
    public class Negabinary
    {
        private main.Negabinary negabinary = new main.Negabinary();

        [TestMethod]
        public void SimpleTest1()
        {
            var array = new int[] { 1, 0, 0, 1, 1 };
            var expected = new int[] { 1, 1, 0, 1 };

            var result = negabinary.Solution(array);

            Assert.IsTrue(Enumerable.SequenceEqual(expected, result));
        }

        [TestMethod]
        public void SimpleTest2()
        {
            var array = new int[] { 1, 0, 0, 1, 1, 1 };
            var expected = new int[] { 1, 1, 0, 1, 0, 1, 1 };

            var result = negabinary.Solution(array);

            Assert.IsTrue(Enumerable.SequenceEqual(expected, result));
        }
    }
}