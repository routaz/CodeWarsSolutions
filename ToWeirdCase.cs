using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class ToWeirdCase
    {
        public static string ChangeToWeirdCase(string s)
        {
            var words = s.Split(' ');
            var Myoutput = new List<string>();

            foreach (string word in words)
            {
                var letters = word.ToArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (i == 0) letters[i] = char.ToUpper(letters[i]); // make first letter capital
                        else letters[i] = char.ToUpper(letters[i]);
                    }
                    else
                    {
                        letters[i] = char.ToLower(letters[i]);
                    }
                }
                Myoutput.Add(new string(letters));
            }
            return string.Join(" ", Myoutput);
        }

        /*
        public static string ToWeirdCase(string s)
        {
            return string.Join(" ",
              s.Split(' ')
              .Select(w => string.Concat(
                w.Select((ch, i) => i % 2 == 0 ? char.ToUpper(ch) : char.ToLower(ch)
              ))));
        }
        */
    }
}
