// -----------------------------------------------------------------------
// <copyright file="EazfuscatorUsing.cs" company="D">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Task1UsingEazfuscator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class EazfuscatorUsing
    {
        public static long EazfuscatorTest()
        {
            long first = 1;
            long second = 1;
            long result = 0;
            int count = 5;

            for (int i = 3; i <= count; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }

            return result;
        }
    }
}
