using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcane.Claro.Utils
{
    public class Utils
    {
        private const string _template = "+{obj} {type}";

        public static string MakeHintText(string obj, string type)
        {
            return _template.Replace("{obj}", obj).Replace("{type}", type);
        }

        public static string ExtractNumber(string input)
        {
            return new String(input.Where(Char.IsDigit).ToArray());
        }
    }
}
