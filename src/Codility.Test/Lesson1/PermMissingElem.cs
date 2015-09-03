namespace Codility.Test.Lesson1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson1;

    [TestClass]
    public class PermMissingElem
    {
        private main.PermMissingElem perm = new main.PermMissingElem();

        [TestMethod]
        public void SimpleTest1()
        {
            var array = new int[] { 2, 3, 1, 5 };
            var result = perm.Solution(array);

            Assert.AreEqual(4, result);
        }
    }
}