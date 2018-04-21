using System;
using System.Linq;

namespace WorkshopsEnterToSpecFlow.Helpers
{
    public class RandDataHelper
    {
        static Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static string RandomStringByLength(int length)
        {
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandMail()
        {
            return $"{RandomStringByLength(10)},@fake-maildomain-testfoo,com.pl";
        }
    }
}
