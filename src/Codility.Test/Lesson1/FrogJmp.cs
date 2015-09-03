namespace Codility.Test.Lesson1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson1;

    [TestClass]
    public class FrogJmp
    {
        private main.FrogJmp frog = new main.FrogJmp();

        [TestMethod]
        public void SimpleTest1()
        {
            var result = frog.Solution(10, 85, 30);

            Assert.AreEqual(3, result);
        }
    }
}