namespace Utilities
{
    public class TriangleNumbers
    {
        public static long GetAt(long pos)
        {
            long val = 0;

            for (long i = 1; i <= pos; i++)
            {
                val += i;
            }

            return val;
        }
    }
}
