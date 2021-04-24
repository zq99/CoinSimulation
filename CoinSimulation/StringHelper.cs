using System.Text;

namespace CoinSimulation
{
    public static class StringHelper
    {
        public static string Repeat(this string s, int n)
            => new StringBuilder(s.Length * n).Insert(0, s, n).ToString();


        public static string RepeatString(string value, int count)
            => new StringBuilder().Insert(0, value, count).ToString();
        
        public static string CleanName(string name)
        {
            string[] itemsToRemove = new string[] { "%" };
            foreach (string item in itemsToRemove)
            {
                name = name.Replace(item, "");
            }
            return name;
        }
    }
}
