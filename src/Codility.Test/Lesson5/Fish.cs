namespace Codility.Test.Lesson5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson5;

    [TestClass]
    public class Fish
    {
        private main.Fish fish = new main.Fish();

        [TestMethod]
        public void SimpleTest()
        {
            var arrayA = new int[] { 4, 3, 2, 1, 5 };
            var arrayB = new int[] { 0, 1, 0, 0, 0 };
            var result = fish.Solution(arrayA, arrayB);

            Assert.AreEqual(2, result);
        }
    }
}