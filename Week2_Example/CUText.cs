
namespace Utils
{
    public class CUText
    {
        public static string CreateHyphenString(string inStr)
        {
            int size = inStr.Length;
            string output = "";
            for (int i = 0; i < size; i++)
            {
                output += "-"; 
            }
            return output;

        }
    }


}