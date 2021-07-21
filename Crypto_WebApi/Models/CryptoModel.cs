using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crypto_WebApi.Models
{
    public class CryptoModel
    {
        public string Encrypt(string PasswordEncrypt) {
            
        string result = string.Empty;
        byte[] encryted = System.Text.Encoding.Unicode.GetBytes(PasswordEncrypt);
        result = Convert.ToBase64String(encryted);
        return result;

        }

        public string Decrypt(string PasswordDencrypt)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(PasswordDencrypt);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

}
}