namespace Codility.Lesson2
{
    using System;

    /// <summary>
    /// Write a function:
    /// 
    ///     class Solution { public int solution(int[] A); }
    /// 
    /// that, given a non-empty zero-indexed array A of N integers, returns the minimal positive integer(greater than 0) that does not occur in A.
    /// 
    /// For example, given:
    /// 
    ///   A[0] = 1
    ///   A[1] = 3
    ///   A[2] = 6
    ///   A[3] = 4
    ///   A[4] = 1
    ///   A[5] = 2
    /// 
    /// the function should return 5.
    /// 
    /// Assume that:
    /// 
    /// •N is an integer within the range[1..100, 000];
    /// •each element of array A is an integer within the range[−2, 147, 483, 648..2, 147, 483, 647].
    /// 
    /// Complexity:
    /// 
    /// •expected worst-case time complexity is O(N);
    /// •expected worst-case space complexity is O(N), beyond input storage(not counting the storage required for input arguments).
    /// 
    /// Elements of input arrays can be modified.
    /// 
    /// Copyright 2009–2015 by Codility Limited.All Rights Reserved.Unauthorized copying, publication or disclosure prohibited.
    /// </summary>
    public class MissingInteger
    {
        public int Solution(int[] array)
        {
            Array.Sort(array);

            if (array[0] > 1) return 1;

            var result = 1;
            for (var i = 0; i < array.Length; i++)
            {
                var val = array[i];

                if (val < 1) continue;
                else if (val > result) return result;
                else if (val == result) result += 1;
            }

            return result;
        }
    }
}