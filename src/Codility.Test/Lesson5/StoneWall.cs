namespace Codility.Test.Lesson5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson5;

    [TestClass]
    public class StoneWall
    {
        private main.StoneWall stoneWall = new main.StoneWall();

        [TestMethod]
        public void SimpleTest()
        {
            var array = new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 };
            var result = stoneWall.Solution(array);

            Assert.AreEqual(7, result);
        }
    }
}