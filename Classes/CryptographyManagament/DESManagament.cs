// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Basic_Cryptography_Algorithms.Interfaces;

namespace Basic_Cryptography_Algorithms.Classes
{
    class DESManagament : IDESManagament
    {
        /// <summary>
        /// This method is used to decrypt with DES algortithm
        /// </summary>
        /// <param name="encryptedText">Encrypted text</param>
        /// <param name="keyBytes">Key in bytes</param>
        /// <param name="ivBytes">IV in bytes</param>
        /// <returns>Decrypted value or if something went wrong null</returns>
        public string Decryption(string encryptedText, byte[] keyBytes, byte[] ivBytes)
        {
            try
            {
                string finalDecryption = string.Empty;
                byte[] encryptedPlainTextBytes = Encoding.ASCII.GetBytes(encryptedText);

                using (DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider())
                {
                    cryptoServiceProvider.KeySize = 64;
                    cryptoServiceProvider.BlockSize = 64;

                    MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(encryptedText));
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoServiceProvider.CreateDecryptor(keyBytes, ivBytes), CryptoStreamMode.Read))
                    {
                        StreamReader streamReader = new StreamReader(cryptoStream);
                        finalDecryption = streamReader.ReadToEnd();
                    }
                }
                return finalDecryption;
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// This method is used to encrypt with DES algortithm
        /// </summary>
        /// <param name="text">Text to encrypt</param>
        /// <param name="keyBytes">Key in bytes</param>
        /// <param name="ivBytes">IV in bytes</param>
        /// <returns>Encrypted value or if something went wrong null</returns>
        public string Encryption(string text, byte[] keyBytes, byte[] ivBytes)
        {
            try
            {
                string finalEncryption = string.Empty;
                byte[] textBytes = Encoding.ASCII.GetBytes(text);

                using (DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider())
                {
                    cryptoServiceProvider.KeySize = 64;
                    cryptoServiceProvider.BlockSize = 64;

                    MemoryStream memoryStream = new MemoryStream();
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoServiceProvider.CreateEncryptor(keyBytes, ivBytes), CryptoStreamMode.Write))
                    {
                        StreamWriter streamWriter = new StreamWriter(cryptoStream);
                        streamWriter.Write(text);
                        streamWriter.Flush();
                        cryptoStream.FlushFinalBlock();
                        finalEncryption = Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
                    }
                }
                return finalEncryption;
            }
            catch (Exception)
            {
                return null; 
            }
        }
    }
}
