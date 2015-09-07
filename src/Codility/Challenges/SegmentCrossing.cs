namespace Codility.Challenges
{
    public class SegmentCrossing
    {
        public int Solution(int[] A)
        {
            var len = A.Length;
            if (len < 4) return 0;

            for (var i = 3; i < len; i++)
            {
                var current = A[i];
                var one = A[i - 1];
                var two = A[i - 2];
                var three = A[i - 3];
                var four = i - 4 < 0 ? 0 : A[i - 4];
                var five = i - 5 < 0 ? 0 : A[i - 5];

                // Previous step has to be less or equal to last parallel step
                if (one > three) continue;

                if (current >= two)
                {
                    // Current step is longer than last parallel one which guarantees crossing
                    return i + 1;
                }
                else if (current >= two - four &&
                        two >= four &&
                        one >= (three - five))
                {
                    // In this case current step crosses the step from five steps ago (corner case)
                    return i + 1;
                }
            }

            return 0;
        }
    }
}