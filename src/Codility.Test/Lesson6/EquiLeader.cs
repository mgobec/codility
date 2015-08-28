namespace Codility.Test.Lesson6
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson6;

    [TestClass]
    public class EquiLeader
    {
        private main.EquiLeader leader = new main.EquiLeader();

        [TestMethod]
        public void SimpleTest()
        {
            var array = new int[] { 4, 3, 4, 4, 4, 2 };
            var result = leader.Solution(array);

            Assert.AreEqual(2, result);
        }
    }
}