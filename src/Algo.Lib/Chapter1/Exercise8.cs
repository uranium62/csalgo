namespace Algo.Lib.Chapter1
{
    public class Exercise8
    {
        public static bool IsRotation(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                var tmp = str1 + str1;
                return tmp.Contains(str2);
            }
            return false;
        }
    }
}
