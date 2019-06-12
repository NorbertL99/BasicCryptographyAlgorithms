// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Basic_Cryptography_Algorithms.Interfaces;
using Basic_Cryptography_Algorithms.Classes;
using System.Security.Cryptography;

namespace Basic_Cryptography_Algorithms.Windows.UserControls
{
    public partial class RSAControl : UserControl
    {
        IRSAManagament rsaManagament = new RSAManagament();

        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        UnicodeEncoding ByteConverter = new UnicodeEncoding();

        byte[] encryptedText;
        byte[] decryptedText;
        /// <summary>
        /// This method run when window open
        /// </summary>
        public RSAControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method run when "Encrypt" button clicked
        /// </summary>
        private void encryptBT_Click(object sender, EventArgs e)
        {
            encryptedText = rsaManagament.Encryption(ByteConverter.GetBytes(textRTB.Text), RSA.ExportParameters(false), false);
            effectRTB.Text = ByteConverter.GetString(encryptedText);
        }
        /// <summary>
        /// This method run when "Decrypt" button clicked
        /// </summary>
        private void decryptBT_Click(object sender, EventArgs e)
        {
            decryptedText = rsaManagament.Decryption(encryptedText, RSA.ExportParameters(true), false);
            effectRTB.Text = ByteConverter.GetString(decryptedText);
        }
        /// <summary>
        /// This method run when "Switch to decrypt" button clicked
        /// </summary>
        private void switchBT_Click(object sender, EventArgs e)
        {
            textRTB.Text = effectRTB.Text;
            effectRTB.Text = null;
        }
        /// <summary>
        /// This method run when "Clear both" button clicked
        /// </summary>
        private void clearBT_Click(object sender, EventArgs e)
        {
            textRTB.Text = null;
            effectRTB.Text = null;
        }
    }
}
