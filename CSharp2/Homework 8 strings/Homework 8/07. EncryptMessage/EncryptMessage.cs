using System;
using System.Text;
//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc.
//When the last key character is reached, the next is the first.
class EncryptMessage
{
    static void Main()
    {
        string message = "Calling all reptilians! Begin the invasion!";
        string key = "Iluminati90";

        Console.WriteLine("Original message: {0}", message);
        string encryptedMessage = EncryptDecrypt(message, key);
        Console.WriteLine("Encrypted message: {0}", encryptedMessage);
        string decryptedMessage = EncryptDecrypt(encryptedMessage, key);
        Console.WriteLine("Decrypted message: {0}", decryptedMessage);

        Console.WriteLine("\nGo back to sleep! Don't tell anyone what you read!");
    }

    static string EncryptDecrypt(string message, string key)
    {
        StringBuilder encryptedMessage = new StringBuilder(message.Length);
        for (int i = 0; i < message.Length; i++)
            encryptedMessage.Append((char)(message[i] ^ key[i % key.Length]));

        return encryptedMessage.ToString();
    }
}
