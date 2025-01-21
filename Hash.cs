using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetTwo
{
    public static class Hash
    {
        public static string VytvorHash(string heslo)
        {
            var sha256 = SHA256.Create();
            using(sha256)
            {
                var bajt = Encoding.UTF8.GetBytes(heslo);
                var hashBajt = sha256.ComputeHash(bajt);
                
                return Convert.ToBase64String(hashBajt);
            }
        }
    }
}
