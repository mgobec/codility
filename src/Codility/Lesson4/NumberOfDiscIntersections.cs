namespace Codility.Lesson4
{
    using System;

    /// <summary>

    /// We draw N discs on a plane.The discs are numbered from 0 to N − 1. A zero-indexed array A of N non-negative integers, specifying the radiuses of the discs, is given.The J-th disc is drawn with its center at(J, 0) and radius A[J].
    /// 
    /// We say that the J-th disc and K-th disc intersect if J ≠ K and the J-th and K-th discs have at least one common point(assuming that the discs contain their borders).
    /// 
    /// The figure below shows discs drawn for N = 6 and A as follows:
    /// 
    ///   A[0] = 1
    ///   A[1] = 5
    ///   A[2] = 2
    ///   A[3] = 1
    ///   A[4] = 4
    ///   A[5] = 0
    /// 
    /// There are eleven(unordered) pairs of discs that intersect, namely:
    /// 
    /// •discs 1 and 4 intersect, and both intersect with all the other discs;
    /// •disc 2 also intersects with discs 0 and 3.
    /// 
    /// Write a function:
    /// 
    ///     class Solution { public int solution(int[] A); }
    /// 
    /// that, given an array A describing N discs as explained above, returns the number of(unordered) pairs of intersecting discs.The function should return −1 if the number of intersecting pairs exceeds 10,000,000.
    /// 
    /// Given array A shown above, the function should return 11, as explained above.
    /// 
    /// Assume that:
    /// 
    ///     •N is an integer within the range[0..100, 000];
    ///     •each element of array A is an integer within the range[0..2, 147, 483, 647].
    /// 
    /// Complexity:
    /// 
    ///     •expected worst-case time complexity is O(N* log(N));
    ///     •expected worst-case space complexity is O(N), beyond input storage(not counting the storage required for input arguments).
    /// 
    /// Elements of input arrays can be modified.
    /// 
    /// Copyright 2009–2015 by Codility Limited.All Rights Reserved.Unauthorized copying, publication or disclosure prohibited.
    /// </summary>
    public class NumberOfDiscIntersections
    {
        public int Solution(int[] A)
        {
            int l = A.Length;

            long[] A1 = new long[l];
            long[] A2 = new long[l];

            for (int i = 0; i < l; i++)
            {
                A1[i] = (long)A[i] + i;
                A2[i] = -((long)A[i] - i);
            }

            Array.Sort(A1);
            Array.Sort(A2);

            long cnt = 0;

            for (int i = A.Length - 1; i >= 0; i--)
            {
                int pos = Array.BinarySearch(A2, A1[i]);
                if (pos >= 0)
                {
                    while (pos < A.Length && A2[pos] == A1[i])
                    {
                        pos++;
                    }
                    cnt += pos;
                }
                else
                { // element not there
                    int insertionPoint = -(pos + 1);
                    cnt += insertionPoint;
                }

            }

            long sub = (long)l * ((long)l + 1) / 2;
            cnt = cnt - sub;

            if (cnt > 1e7) return -1;

            return (int)cnt;
        }
    }
}