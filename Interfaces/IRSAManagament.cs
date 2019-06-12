using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Cryptography_Algorithms.Interfaces
{
    interface IRSAManagament
    {
        /// <summary>
        /// This method is used to encrypt with RSA algortithm
        /// </summary>
        /// <param name="text">Text to encrypt</param>
        /// <param name="RSAKey">RSA key</param>
        /// <param name="DoOAEPPadding">OAEPP Padding</param>
        /// <returns></returns>
        byte[] Encryption(byte[] text, RSAParameters RSAKey, bool DoOAEPPadding);
        /// <summary>
        /// This method is used to decrypt with RSA algortithm
        /// </summary>
        /// <param name="encryptedText">Encrypted text</param>
        /// <param name="RSAKey">RSA ket</param>
        /// <param name="DoOAEPPadding">OAEPP Padding</param>
        /// <returns></returns>
        byte[] Decryption(byte[] encryptedText, RSAParameters RSAKey, bool DoOAEPPadding);
    }
}
