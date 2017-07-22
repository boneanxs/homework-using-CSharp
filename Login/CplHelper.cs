using System.Text.RegularExpressions;
namespace Login
{
    public class CplHelper
    {
        public static bool IsNull(string uncheckedStr)
        {
            uncheckedStr = uncheckedStr.Trim();
            if (uncheckedStr == "")
                return true;
            return false;
        }
        public static bool IsEmail(string uncheckedStr)
        {
            uncheckedStr = uncheckedStr.Trim();
            if (Regex.IsMatch(uncheckedStr, "^[a-z0-9]+@[a-z0-9]+.[a-z0-9]{2,5}$"))
                return true;
            return false;
        }
        public static bool IsDecimal(string uncheckedStr)
        {
            uncheckedStr = uncheckedStr.Trim();
            try
            {
                double.Parse(uncheckedStr);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsSpecLen(string uncheckedStr,int len)
        {
            uncheckedStr = uncheckedStr.Trim();
            if (uncheckedStr.Length == len)
                return true;
            return false;
        }
        public static bool IsSexRight(string uncheckedStr)
        {
            uncheckedStr = uncheckedStr.Trim();
            if (uncheckedStr == "男" || uncheckedStr == "女")
                return true;
            return false;
        }
        public static bool IsInt(string uncheckedStr)
        {
            uncheckedStr = uncheckedStr.Trim();
            try
            {
                int.Parse(uncheckedStr);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsGoodsIdRight(string uncheckedStr)
        {
            uncheckedStr = uncheckedStr.Trim();
            if (Regex.IsMatch(uncheckedStr, "^B\\d{10}$"))
                return true;
            return false;
        }
        public static bool IsMemIdRight(string uncheckedStr)
        {
            uncheckedStr = uncheckedStr.Trim();
            if (Regex.IsMatch(uncheckedStr, "^\\d{7}$"))
                return true;
            return false;
        }
    }
}
