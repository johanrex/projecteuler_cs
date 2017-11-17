using System;

namespace Utilities
{
        public static class ExtensionsClass
        {
            public static string Reverse(this String strReverse)
            {
                var charArray = new char[strReverse.Length];
                var len = strReverse.Length - 1;

                for (int i = 0; i <= len; i++)
                {
                    charArray[i] = strReverse[len - i];
                }
                return new string(charArray);
            }
        }

}
