using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex
{
    public static class StringExtension
    {

       

        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string[] Regex(cthis String str, string PatternRegex)
        {
            System.Text.RegularExpressions.Regex rx = new System.Text.RegularExpressions.Regex(PatternRegex, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            MatchCollection matches = rx.Matches(str);

            string[] result = new string[matches.Count];
            
            for (int i = 0; i < matches.Count; i++)
            {
                result[i] = matches[i].Value;
            }
                return result;
        }

        public static Dictionary<string, string> CampoFormulario(this String str, string Campo, int TamanhoCampo)
        {
            string PatternRegex = @"\b(" + Campo + ") (.{" + TamanhoCampo + "})";
            Dictionary<string, string> result = new Dictionary<string, string>();

            System.Text.RegularExpressions.Regex rx = new System.Text.RegularExpressions.Regex(PatternRegex, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            MatchCollection matches = rx.Matches(str);

            foreach (Match item in matches)
            {
                result.Add(item.Groups[0].Value, item.Groups[1].Value);
            }
           
            return result;
        }
    }
}
