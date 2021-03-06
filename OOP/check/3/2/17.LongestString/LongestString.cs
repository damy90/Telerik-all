﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_String
{
    using System.Linq;

    class LongestString
    {
        static void Main()
        {
            string[] someStrings = 
            {
                "qwerty",
                "asfd",
                "longeststring",
                "short",
                "bla"
            };

            var sorted =
                from strings in someStrings
                orderby strings.Length descending
                select strings;

            string longest = sorted.FirstOrDefault();

            Console.WriteLine(longest);

            //Console.WriteLine(GetLongestString(someStrings)); // another solution
        }

        public static string GetLongestString(string[] input) // another solution
        {
            var longest =
                from strings in input
                orderby strings.Length descending
                select strings;

            return longest.ToArray()[0];
        }
    }
}
