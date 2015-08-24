namespace Codility.Lesson5
{
    using System.Collections.Generic;


    /// <summary>
    /// A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:
    /// 
    /// S is empty;
    /// S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
    /// S has the form "VW" where V and W are properly nested strings.
    /// For example, the string "{[()()]}" is properly nested but "([)()]" is not.
    /// 
    /// Write a function:
    /// 
    /// class Solution { public int solution(string S); }
    /// 
    ///     that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.
    /// 
    ///     For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0, as explained above.
    /// 
    ///     Assume that:
    /// 
    ///     N is an integer within the range[0..200, 000];
    ///     string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".
    /// Complexity:
    /// 
    /// expected worst-case time complexity is O(N);
    ///     expected worst-case space complexity is O(N) (not counting the storage required for input arguments).
    /// 
    /// Copyright 2009–2015 by Codility Limited.All Rights Reserved.Unauthorized copying, publication or disclosure prohibited.
    /// </summary>
    public class Brackets
    {
        public int Solution(string someString)
        {
            var chars = someString.ToCharArray();
            var len = chars.Length;
            if (len < 0) return 0;

            var stack = new Stack<char>();
            var brackets = new Dictionary<char, char>();
            brackets.Add('(', ')');
            brackets.Add('[', ']');
            brackets.Add('{', '}');

            for (var i = 0; i < len; i++)
            {
                var current = chars[i];

                if (brackets.ContainsKey(current))
                {
                    stack.Push(current);
                    continue;
                }

                if (stack.Count == 0) return 0;

                var last = stack.Peek();

                if (brackets[last] != current) return 0;

                stack.Pop();
            }

            return stack.Count != 0 ? 0 : 1;
        }
    }
}