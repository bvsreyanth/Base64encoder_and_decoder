using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64encoder_and_decoder
{
    public class Base64Encoder
    {
        public string Encode(string plainText)
        {
            // Convert the plain text to bytes
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            // Use Convert.ToBase64String to encode the bytes to Base64
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
