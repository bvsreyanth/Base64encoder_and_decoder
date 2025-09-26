using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64encoder_and_decoder
{
    public class Base64Decoder
    {
        public string Decode(string base64Text)
        {
            // Use Convert.FromBase64String to decode the Base64 string to bytes
            byte[] decodedBytes = Convert.FromBase64String(base64Text);

            // Convert the bytes back to a string
            return Encoding.UTF8.GetString(decodedBytes);
        }
    }
}
