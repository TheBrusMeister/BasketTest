using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ShoppingBasket.Helpers
{
    public class StringHelper
    {
        private static string GenerateUniqueStringToLength(int length)
        {
            string result = string.Empty;
            Random random = new Random((int)DateTime.Now.Ticks);
            List<string> characters = new List<string>() { };
            for (int i = 48; i < 58; i++)
            {
                characters.Add(((char)i).ToString());
            }
            for (int i = 65; i < 91; i++)
            {
                characters.Add(((char)i).ToString());
            }
            for (int i = 97; i < 123; i++)
            {
                characters.Add(((char)i).ToString());
            }
            for (int i = 0; i < length; i++)
            {
                result += characters[random.Next(0, characters.Count)];
                Thread.Sleep(1);
            }
            return result;
        }

        public static string GenerateVoucherCode()
        {
            return GenerateUniqueStringToLength(3) + "-" + GenerateUniqueStringToLength(3);
        }
    }
}
