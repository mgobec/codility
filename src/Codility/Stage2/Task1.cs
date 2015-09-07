namespace Codility.Stage2
{
    public class Task1
    {
        public string Solution(int number)
        {
            char group = ',';

            var chars = number.ToString().ToCharArray();
            var len = chars.Length;
            var remainder = len % 3;
            var result = string.Empty;

            for (var i = 0; i < len; i++)
            {
                if (i < remainder)
                {
                    result += chars[i];
                    continue;
                }

                if ((i - remainder) % 3 == 0 && i > 0)
                {
                    result += group;
                }

                result += chars[i];
            }

            return result;
        }
    }
}