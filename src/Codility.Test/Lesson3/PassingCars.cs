namespace Codility.Test.Lesson3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson3;

    [TestClass]
    public class PassingCars
    {
        private main.PassingCars cars = new main.PassingCars();

        [TestMethod]
        public void SimpleTest1()
        {
            var array = new int[] { 0, 1, 0, 1, 1 };
            var result = cars.Solution(array);

            Assert.AreEqual(5, result);
        }
    }
}