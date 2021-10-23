using System;

namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            uint int_MaxValue = 2147483647;
            ulong long_MaxValue = 9223372036854775808;
            ushort short_MaxValue = 32768;

            ulong result = int_MaxValue + long_MaxValue + short_MaxValue;
        }
    }
}
