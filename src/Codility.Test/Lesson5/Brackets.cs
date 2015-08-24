namespace Codility.Test.Lesson5
{
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using main = Codility.Lesson5;

    [TestClass]
    public class Brackets
    {
        private main.Brackets brackets = new main.Brackets();

        [TestMethod]
        public void SimpleTest1()
        {
            var result = brackets.Solution("{[()()]}");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SimpleTest2()
        {
            var result = brackets.Solution("([)()]");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Large2()
        {
            var sb = new StringBuilder(20005);

            for (var i = 0; i < 10001; i++) sb.Append('(');
            for (var i = 0; i < 10000; i++) sb.Append(')');
            sb.Append(')');
            sb.Append('(');
            sb.Append('(');
            sb.Append(')');

            var result = brackets.Solution(sb.ToString());

            Assert.AreEqual(0, result);
        }
    }
}