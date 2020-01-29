using System;
using System.Linq;

namespace Encryption.Models
{
    class Program
    {
        static void Main(string[] args)
        {

            ///BINARY CONVERTER CODE
            
            Console.WriteLine("\n***********************Binary Conversion***********************\n");

            /// TAKE INPUT FROM THE USER

            Console.WriteLine("Enter your any Text:");   
            string str = Console.ReadLine();


            /// DISPLAY THE TEXT GIVEN
            Console.WriteLine("\nThe Given Text is " + str + '\n');

         
            BinarytoASCII binaryConverter = new BinarytoASCII();
            string binaryValue = binaryConverter.ConvertTo(str);
            
            Console.WriteLine($"{str} as Binary:- {binaryValue}");


            Console.WriteLine($"\n{binaryValue} :- from Binary to ASCII: {binaryConverter.ConvertBinaryToString(binaryValue)}");



            ///HEXADECIMAL CONVERTER CODE
            

            Console.WriteLine("\n\n***********************HexaDecimal Conversion***********************\n");

            /// TAKE INPUT FROM THE USER
            Console.WriteLine("Enter your any Text:");
            string str1 = Console.ReadLine();


            /// DISPLAY THE TEXT GIVEN
            Console.WriteLine("\nThe Given Text is " + str1 + '\n');


            
            ASCIItoHexadecimal hexadecimalConverter = new ASCIItoHexadecimal();
            string hexadecimalValue = hexadecimalConverter.ConvertTo(str1);

            Console.WriteLine($"{str1} as Hexadecimal:- {hexadecimalValue}");

            Console.WriteLine($"\n{hexadecimalValue} :- from Hexadecimal to ASCII: {hexadecimalConverter.ConveryFromHexToASCII(hexadecimalValue)}");


            ///Base64 CONVERTER CODE


            Console.WriteLine("\n\n***********************Base64 Conversion***********************\n");

            /// TAKE INPUT FROM THE USER
            Console.WriteLine("Enter your any Text:");
            string mydata = Console.ReadLine();


            /// DISPLAY THE TEXT GIVEN
            Console.WriteLine("\nThe Given Text is " + mydata + '\n');

          

            string myDataEncoded = Base64.EncodeTo64(mydata);
            Console.WriteLine($"{mydata} as Base64:- {myDataEncoded}");


            string myDataUnencoded = Base64.DecodeFrom64(myDataEncoded);
            Console.WriteLine($"\n{myDataEncoded} :- from Base64 to ASCII: {myDataUnencoded}");


            ///DeepEncryptwithcipher

            Console.WriteLine("\n\n***********************DeepEncryptwithCipher Conversion***********************\n");

            /// TAKE INPUT FROM THE USER
            Console.WriteLine("Enter your any Text:");
            string name = Console.ReadLine();


            /// DISPLAY THE TEXT GIVEN
            Console.WriteLine("\nThe Given Text is " + name + '\n');

            int[] cipher = new[] { 1, 1, 2, 3, 5, 8, 13 }; //Fibonacci Sequence
            string cipherasString = String.Join(",", cipher.Select(x => x.ToString())); //FOr display

            int encryptionDepth = 20;

            Encrypter encrypter = new Encrypter(name, cipher, encryptionDepth);

            //Deep Encrytion
            string nameDeepEncryptWithCipher = Encrypter.DeepEncryptWithCipher(name, cipher, encryptionDepth);
            Console.WriteLine($"Deep Encrypted {encryptionDepth} times using the cipher {{{cipherasString}}} Encypted name :- {nameDeepEncryptWithCipher}");

            string nameDeepDecryptWithCipher = Encrypter.DeepDecryptWithCipher(nameDeepEncryptWithCipher, cipher, encryptionDepth);
            Console.WriteLine($"\nDeep Decrypted {encryptionDepth} times using the cipher {{{cipherasString}}} Original name :- {nameDeepDecryptWithCipher}");
        }
    }
}
