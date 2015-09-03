namespace Codility.Test.Lesson1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson1;

    [TestClass]
    public class TapeEquilibrium
    {
        private main.TapeEquilibrium equilibrium = new main.TapeEquilibrium();

        [TestMethod]
        public void SimpleTest1()
        {
            var array = new int[] { 3, 1, 2, 4, 3 };
            var result = equilibrium.Solution(array);

            Assert.AreEqual(1, result);
        }
    }
}