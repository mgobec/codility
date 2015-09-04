namespace Codility.Challenges
{
    using System;
    using System.Collections.Generic;

    public class Negabinary
    {
        public int[] Solution(int[] A)
        {
            var len = A.Length;
            if (len == 0) return new[] { 0 };

            int number = 0;

            for (var i = 0; i < len; i++)
            {
                number += A[i] * (int)Math.Pow(-2, i);
            }

            var result = new List<int>();
            var value = number * -1;
            while (value != 0)
            {
                int remainder = value % -2;
                value = value / -2;

                if (remainder == -1)
                {
                    remainder = 1;
                    value += 1;
                }

                result.Add(remainder);
            }

            return result.ToArray();
        }
    }
}