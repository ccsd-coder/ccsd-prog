namespace Utils
{
    public class CUType
    {
        public static string toString(bool b)
        {
            string res = "";
            if (false == b)
                res += "true";
            else
                res += "false";

            return res;
        }
    }
}
