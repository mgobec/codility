namespace Codility.Test.Lesson2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson2;

    [TestClass]
    public class FrogRiverOne
    {
        private main.FrogRiverOne frog = new main.FrogRiverOne();

        [TestMethod]
        public void SimpleTest1()
        {
            var array = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
            var result = frog.Solution(5, array);

            Assert.AreEqual(6, result);
        }
    }
}