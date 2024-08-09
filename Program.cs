namespace CptCrunch
{
    internal class Program
    {

        public static string Encode(string input, int shift)
        {
            // Helper function to encode a single character
            char EncodeChar(char c, int shiftAmount)
            {
                if (c >= 'a' && c <= 'z')
                {
                    return (char)((c - 'a' + shiftAmount + 26) % 26 + 'a');
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    return (char)((c - 'A' + shiftAmount + 26) % 26 + 'A');
                }
                else
                {
                    return c; // Return the character unchanged if it's not a letter
                }
            }

            // Use a char array to build the encoded string
            char[] encodedChars = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                encodedChars[i] = EncodeChar(input[i], shift);
            }

            return new string(encodedChars);
        }

        static void Main()
        {
            string inputString = "Hello World";
            string encodedString = Encode(inputString, 13);
            Console.WriteLine(encodedString);  // Outputs: Uryyb Jbeyq

            
            string decodedString = Encode(encodedString, -13);
            Console.WriteLine(decodedString);  // Outputs: Hello World
        }
    }
}

