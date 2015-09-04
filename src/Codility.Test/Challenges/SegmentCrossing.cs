namespace Codility.Test.Challenges
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Challenges;

    [TestClass]
    public class SegmentCrossing
    {
        private main.SegmentCrossing crossing = new main.SegmentCrossing();

        //int a[] = { 1, 1, 1, 2 }; // 4
        //int b[] = { 1, 1, 2, 1, 1 }; // 5
        //int c[] = { 1, 3, 2, 5, 4, 4, 6, 3, 2 }; // 7
        //int d[] = { 4, 4, 5, 7, 8, 6, 5 }; // 7
        //int e[] = { 1, 1, 2, 2, 4, 2, 1, 1, 2, 5, 10 }; // 9
        //int f[] = { 1, 1, 5, 3, 3, 2, 2, 1, 1, 3 }; // 10

        [TestMethod]
        public void SimpleTest1()
        {
            var array = new int[] { 1, 3, 2, 5, 4, 4, 6, 3, 2 };
            var result = crossing.Solution(array);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void SimpleTest2()
        {
            var array = new int[] { 1, 1, 1, 2 };
            var result = crossing.Solution(array);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void SimpleTest3()
        {
            var array = new int[] { 1, 1, 2, 1, 1 };
            var result = crossing.Solution(array);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SimpleTest4()
        {
            var array = new int[] { 4, 4, 5, 7, 8, 6, 5 };
            var result = crossing.Solution(array);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void SimpleTest5()
        {
            var array = new int[] { 1, 1, 2, 2, 4, 2, 1, 1, 2, 5, 10 };
            var result = crossing.Solution(array);

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void SimpleTest6()
        {
            var array = new int[] { 1, 1, 5, 3, 3, 2, 2, 1, 1, 3 };
            var result = crossing.Solution(array);

            Assert.AreEqual(10, result);
        }
    }
}