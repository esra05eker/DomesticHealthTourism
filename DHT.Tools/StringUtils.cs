using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHT.Tools
{
    public class StringUtils
    {
        public static string MD5(string input)
        {

            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                // strin byte dizisine gönüştürülüyor
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);

                // md5 hash değeri hesaplanıyor
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Byte dizisini hexadecimal string e dönüştürüyoruz
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }

        }

        public static bool IsNumeric(string str)
        {
            // long tipine çevrilebiliyorsa bu string numeriktir
            return long.TryParse(str, out long n); ;
        }
    }
}
