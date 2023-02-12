using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class SplitStrings
    {
        public static string[] Solution(string str)
        {
            str = Regex.Replace(str, @"\s", "");
            str.Trim();

            str = (str.Length % 2 == 0) ? str : str + "_";

            List<String> strings = new List<string>();

            for (int i = 0; i < str.Length; i+=2)
            {
   
                    var myString = str.Substring(i, 2);
                    strings.Add(myString);
 
            }

            return strings.ToArray();
        }

    }
}