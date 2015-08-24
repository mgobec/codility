﻿namespace Codility.Lesson1
{
    using System;

    /// <summary>
    /// A zero-indexed array A consisting of N different integers is given.The array contains integers in the range[1..(N + 1)], which means that exactly one element is missing.
    /// 
    /// Your goal is to find that missing element.
    /// 
    /// Write a function:
    /// 
    /// class Solution { public int solution(int[] A); }
    /// 
    /// 
    ///     that, given a zero-indexed array A, returns the value of the missing element.
    /// 
    ///     For example, given array A such that:
    /// 
    ///   A[0] = 2
    ///   A[1] = 3
    ///   A[2] = 1
    ///   A[3] = 5
    /// 
    /// the function should return 4, as it is the missing element.
    /// 
    /// Assume that:
    /// 
    /// •N is an integer within the range[0..100, 000];
    /// •the elements of A are all distinct;
    /// •each element of array A is an integer within the range[1..(N + 1)].
    /// 
    /// Complexity:
    /// 
    /// •expected worst-case time complexity is O(N);
    /// •expected worst-case space complexity is O(1), beyond input storage(not counting the storage required for input arguments).
    /// 
    /// Elements of input arrays can be modified.
    /// 
    /// Copyright 2009–2015 by Codility Limited.All Rights Reserved.Unauthorized copying, publication or disclosure prohibited.
    /// </summary>
    public class PermMissingElem
    {
        public int Solution(int[] array)
        {
            var len = array.Length;
            if (len == 0) return 1;

            Array.Sort(array);

            if (array[0] != 1) return 1;
            if (array[len - 1] != len + 1) return len + 1;

            for (var i = 0; i < len; i++)
            {
                if (i + 1 == len) continue;

                var val = array[i];
                var next = array[i + 1];

                if (val + 1 != next) return val + 1;
            }

            return 0;
        }
    }
}