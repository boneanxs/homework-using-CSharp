using System.Text.RegularExpressions;
namespace Login
{
    public class CplHelper
    {
        public static bool IsNull(string uncheckedStr)
        {
            if (uncheckedStr == null)
                return true;
            uncheckedStr = uncheckedStr.Trim();
            if (uncheckedStr == "")
                return true;
            return false;
        }
        public static bool IsEmail(string uncheckedStr)
        {
            if (uncheckedStr == null)
                return false;
            uncheckedStr = uncheckedStr.Trim();
            if (Regex.IsMatch(uncheckedStr, "^[a-z0-9]+@[a-z0-9]+.[a-z0-9]{2,5}$"))
                return true;
            return false;
        }
        public static bool IsQualityIDRight(string uncheckedStr)
        {
            if (uncheckedStr == null)
                return false;
            if (Regex.IsMatch(uncheckedStr, "^Q\\d{11}$"))
                return true;
            return false;
        }
        public static bool IsDecimal(string uncheckedStr)
        {
            if (uncheckedStr == null)
                return false;
            uncheckedStr = uncheckedStr.Trim();

            try
            {
                double temp = double.Parse(uncheckedStr);
                if (temp < 0)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsSpecLen(string uncheckedStr,int len)
        {
            if (uncheckedStr == null)
                return false;
            uncheckedStr = uncheckedStr.Trim();
            if (uncheckedStr.Length == len)
                return true;
            return false;
        }
        public static bool IsSexRight(string uncheckedStr)
        {
            if (uncheckedStr == null)
                return false;
            uncheckedStr = uncheckedStr.Trim();
            if (uncheckedStr == "男" || uncheckedStr == "女")
                return true;
            return false;
        }
        public static bool IsInt(string uncheckedStr)
        {
            if (uncheckedStr == null)
                return false;
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
            if (uncheckedStr == null)
                return false;
            uncheckedStr = uncheckedStr.Trim();
            if (Regex.IsMatch(uncheckedStr, "^B\\d{10}$"))
                return true;
            return false;
        }
        public static bool IsMemIdRight(string uncheckedStr)
        {
            if (uncheckedStr == null)
                return false;
            uncheckedStr = uncheckedStr.Trim();
            if (Regex.IsMatch(uncheckedStr, "^\\d{7}$"))
                return true;
            return false;
        }
    }
}
