namespace Codility.Test.Lesson2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson2;

    [TestClass]
    public class PermCheck
    {
        private main.PermCheck perm = new main.PermCheck();

        [TestMethod]
        public void SimpleTest1()
        {
            var array = new int[] { 4, 1, 3, 2 };
            var result = perm.Solution(array);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SimpleTest2()
        {
            var array = new int[] { 4, 1, 3 };
            var result = perm.Solution(array);

            Assert.AreEqual(0, result);
        }
    }
}