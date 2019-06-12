// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Cryptography_Algorithms.Interfaces
{
    interface IDESManagament
    {
        /// <summary>
        /// This method is used to encrypt with DES algortithm
        /// </summary>
        /// <param name="text">Text to encrypt</param>
        /// <param name="keyBytes">Key in bytes</param>
        /// <param name="ivBytes">IV in bytes</param>
        /// <returns></returns>
        string Encryption(string text, byte[] keyBytes, byte[] ivBytes);
        /// <summary>
        /// This method is used to decrypt with DES algortithm
        /// </summary>
        /// <param name="encryptedText">Encrypted text</param>
        /// <param name="keyBytes">Key in bytes</param>
        /// <param name="ivBytes">IV in bytes</param>
        /// <returns></returns>
        string Decryption(string encryptedText, byte[] keyBytes, byte[] ivBytes);
    }
}
