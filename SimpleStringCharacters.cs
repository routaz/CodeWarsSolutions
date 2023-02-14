
namespace CodeWarsSolutions
{
    public class SimpleStringCharacters
    {

        public static int[] solve(String s)
        {

            //This is soooo simple
            return new[]
            {
                s.Count(char.IsUpper),
                s.Count(char.IsLower),
                s.Count(char.IsDigit),
                s.Count(x => !char.IsLetterOrDigit(x))
            };

            /*
            int[] result = new int[4];
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    result[0]++;
                }
                else if (char.IsLower(s[i]))
                {
                    result[1]++;
                }
                else if (char.IsNumber(s[i]))
                {
                    result[2]++;
                }
                else if ((char.IsSymbol(s[i]) || char.IsPunctuation(s[i])))
                {
                    result[3]++;
                }

            }

            return result;
            */
        }
    }
}
