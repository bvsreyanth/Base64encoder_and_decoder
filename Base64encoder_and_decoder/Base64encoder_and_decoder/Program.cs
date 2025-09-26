using Base64encoder_and_decoder;
using System.Security.Cryptography;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Text Encoder/Decoder!");

        string continueChoice;
        do
        {
           
            Console.Write("Do you want to encode (E), decode (D), or exit (X)? (Enter 'E', 'D', or 'X'): ");
            string userChoice = Console.ReadLine();

            string result = userChoice.ToUpper() switch
            {
                "E" => EncodeText(),
                "D" => DecodeBase64(),
                "X" => "Exiting the Text Encoder/Decoder. Goodbye!",
                _ => "Invalid choice. Please enter 'E' for encoding, 'D' for decoding, or 'X' to exit."
            };

            Console.WriteLine(result);

            Console.Write("Do you want to perform another operation? (Y/N): ");
            continueChoice = Console.ReadLine().ToUpper();
        } while (continueChoice == "Y");

        Console.WriteLine("Thank you for using the Text Encoder/Decoder!");
    }

    static string EncodeText()
    {
        Console.WriteLine("Enter the text you want to encode:");
        string userInput = Console.ReadLine();

        Base64Encoder encoder = new Base64Encoder();

        string encodedText = encoder.Encode(userInput);
        return $"Encoded: {encodedText}";
    }

    static string DecodeBase64()
    {
        Console.WriteLine("Enter the Base64 string to decode:");
        string base64Input = Console.ReadLine();

        Base64Decoder decoder = new Base64Decoder();

        // Decode the Base64 string
        string decodedText = decoder.Decode(base64Input);
        return $"Decoded: {decodedText}";
    }
}

