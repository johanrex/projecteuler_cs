using System.Numerics;

namespace Utilities
{
    public static class BigIntegerExtensions
    {
        public static BigInteger Factorial(this BigInteger fact)
        {
            BigInteger answer = new BigInteger(1);

            for (BigInteger i = fact; i >= 1; i--)
			{
                answer = answer * i;
			}

            return answer;
        }
    }
}
