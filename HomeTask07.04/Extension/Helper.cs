using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask07._04.Extension
{
    static class Helper
    {
        public static bool IsOdd(this int value)
        {
            if (value % 2 == 1) { return true; }
            else { return false; }
        }
        public static bool IsEven(this int value)
        {
            if (value % 2 == 0) { return true; }
            else { return false; }

        }
        public static bool HasDigit(this string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c)) { return true; }

            }
            return false;
        }
        public static bool CheckPassword(this string pasword)
        {
            foreach (char c in pasword)
            {
                if (char.IsDigit(c) && pasword.Length >= 8 && char.IsUpper(c) && char.IsLower(c))
                {
                    return true;
                }

            }
                return false;
        }

        public static string Capitalize(this string name)
        {
            return name.Substring(0,1).ToUpper()+name.Substring(1).ToLower();
        }
    }
}


