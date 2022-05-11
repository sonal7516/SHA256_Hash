using System;
using System.Security.Cryptography;
using System.Text;

namespace SHA256_Hash
{
    class Program
    {
        static string ComputeSHA256Hash(string password)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the password:");
            string input = Console.ReadLine();
            Console.WriteLine("Hashed string: "+ComputeSHA256Hash(input));
            Console.WriteLine("Hello World!");
        }
    }
}
