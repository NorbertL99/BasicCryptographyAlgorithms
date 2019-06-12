using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Basic_Cryptography_Algorithms.Interfaces;

namespace Basic_Cryptography_Algorithms.Classes
{
    class RSAManagament : IRSAManagament
    {
        /// <summary>
        /// This method is used to decrypt with RSA algortithm
        /// </summary>
        /// <param name="encryptedText">Encrypted text</param>
        /// <param name="RSAKey">RSA ket</param>
        /// <param name="DoOAEPPadding">OAEPP Padding</param>
        /// <returns>Decrypted value or if something went wrong null</returns>
        public byte[] Decryption(byte[] encryptedText, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(encryptedText, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException)
            {
                return null;
            }
        }
        /// <summary>
        /// This method is used to encrypt with RSA algortithm
        /// </summary>
        /// <param name="text">Text to encrypt</param>
        /// <param name="RSAKey">RSA key</param>
        /// <param name="DoOAEPPadding">OAEPP Padding</param>
        /// <returns>Encrypted value or if something went wrong null</returns>
        public byte[] Encryption(byte[] text, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(text, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException)
            {
                return null;
            }
        }
    }
}
