using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public class CipherFunc
    {
        private static char[] ciphAlphabetCap =
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        private static char[] ciphAlphabetLow =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        public static string GenerateKey(string keyword, string message)
        {
            string key = "";

            for (int i = 0; i < message.Length; i++)
            {
                if (key.Length == message.Length)
                {
                    break;
                }
                else
                {
                    char keyChar = keyword[i % keyword.Length];
                    key += keyChar;
                }
            }
            return key;
        }
             
        public static string EncryptString(string plainText, int shift)
        {
            StringBuilder encryptedText = new StringBuilder();

            foreach(char c in plainText)
            {
                if (char.IsUpper(c))
                {
                    int upperIndex = Array.IndexOf(ciphAlphabetCap, c);
                    int shiftUpIndex = (upperIndex + shift) % ciphAlphabetCap.Length;
                    char textToEncrypt = ciphAlphabetCap[shiftUpIndex];
                    encryptedText.Append(textToEncrypt);
                }
                else if (char.IsLower(c))
                {
                    int lowerIndex = Array.IndexOf(ciphAlphabetLow, c);
                    int shiftLowIndex = (lowerIndex + shift) % ciphAlphabetLow.Length;
                    char textToEncrypt = ciphAlphabetLow[shiftLowIndex];
                    encryptedText.Append(textToEncrypt);
                }
                else if (char.IsWhiteSpace(c))
                {
                    encryptedText.Append(' ');
                }
            }
            return encryptedText.ToString();
        }
        public static string DecryptString(string textToEncrypt, int shift)
        {
            StringBuilder decryptedText = new StringBuilder();

            foreach (char c in textToEncrypt)
            {
                if (char.IsUpper(c))
                {
                    int upperIndex = Array.IndexOf(ciphAlphabetCap, c);
                    int shiftUpIndex = (upperIndex - shift + ciphAlphabetCap.Length) % ciphAlphabetCap.Length;
                    char textToDecrypt = ciphAlphabetCap[shiftUpIndex];
                    decryptedText.Append(textToDecrypt);
                }
                else if (char.IsLower(c))
                {
                    int lowerIndex = Array.IndexOf(ciphAlphabetLow, c);
                    int shiftLowIndex = (lowerIndex - shift + ciphAlphabetLow.Length) % ciphAlphabetLow.Length;
                    char textToDecrypt = ciphAlphabetLow[shiftLowIndex];
                    decryptedText.Append(textToDecrypt);
                }
                else if (char.IsWhiteSpace(c))
                {
                    decryptedText.Append(' ');
                }
            }
            return decryptedText.ToString();
        }
        public static string EncryptVigString(string textToEncrypt, string key)
        {
            StringBuilder vigEncryptedText = new StringBuilder();

            int keyPosition = 0;

            foreach (char c in textToEncrypt)
            {
                if (char.IsUpper(c))
                {
                    int upperVigIndex = Array.IndexOf(ciphAlphabetCap, c);
                    int keyIndex = Array.IndexOf(ciphAlphabetCap, key[keyPosition % key.Length]);
                    int vigShift = (upperVigIndex + keyIndex) % ciphAlphabetCap.Length;
                    char encryptedText = ciphAlphabetCap[vigShift];
                    vigEncryptedText.Append(encryptedText);
                    keyPosition++;
                }
                else if (char.IsLower(c))
                {
                    int lowerVigIndex = Array.IndexOf(ciphAlphabetLow, c);
                    int keyIndex = Array.IndexOf(ciphAlphabetLow, key[keyPosition % key.Length]);
                    int vigShift = (lowerVigIndex + keyIndex) % ciphAlphabetLow.Length;
                    char encryptedText = ciphAlphabetLow[vigShift];
                    vigEncryptedText.Append(encryptedText);
                    keyPosition++;
                }
                else if (char.IsWhiteSpace(c))
                {
                    vigEncryptedText.Append(' ');
                }
            }
            return vigEncryptedText.ToString();   
        }
        public static string DecryptVigString(string textToDecrypt, string key)
        {
            StringBuilder decryptedVigText = new StringBuilder();

            int keyPosition = 0;

            foreach (char c in textToDecrypt)
            {
                if (char.IsUpper(c))
                {
                    int upperVigIndex = Array.IndexOf(ciphAlphabetCap, c);
                    int decryptKeyIndex = Array.IndexOf(ciphAlphabetCap, key[keyPosition % key.Length]);
                    int decryptVigShift = (upperVigIndex - decryptKeyIndex + ciphAlphabetCap.Length) % ciphAlphabetCap.Length;
                    char decryptedText = ciphAlphabetCap[decryptVigShift];
                    decryptedVigText.Append(decryptedText);
                    keyPosition++;
                }
                else if (char.IsLower(c))
                {
                    int lowerVigIndex = Array.IndexOf(ciphAlphabetLow, c);
                    int decryptKeyIndex = Array.IndexOf(ciphAlphabetLow, key[keyPosition % key.Length]);
                    int decryptVigShift = (lowerVigIndex - decryptKeyIndex + ciphAlphabetLow.Length) % ciphAlphabetLow.Length;
                    char decryptedText = ciphAlphabetLow[decryptVigShift];
                    decryptedVigText.Append(decryptedText);
                    keyPosition++;
                }
                else if (char.IsWhiteSpace(c))
                {
                    decryptedVigText.Append(' ');
                }
            }
            return decryptedVigText.ToString();
        }
    }
}
