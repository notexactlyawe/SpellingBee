using System.Security.Cryptography;

namespace Spelling_Bee
{
    class Password
    {
        /// <summary>
        ///     Returns a SHA-256 hash as a string
        /// </summary>
        /// <param name="pass">The string to be hashed</param>
        /// <returns>A SHA-256 hash as a string</returns>
        public static string hashAsString(string pass)
        {
            // Handles the hashing bit
            SHA256 hash = new SHA256CryptoServiceProvider();
            // Converts the password to a byte[] in preparation for hashing
            byte[] hashPrep = new byte[pass.Length];
            for (int i = 0; i < pass.Length; i++)
            {
                hashPrep[i] = (byte)pass[i];
            }
            // Puts the hash in a string for storing in the db
            hash.ComputeHash(hashPrep);
            byte[] hashed = hash.Hash;
            string strHash = "";
            for (int i = 0; i < hashed.Length; i++)
            {
                strHash += hashed[i];
                strHash += " ";
            }
            return strHash;
        }
    }
}
