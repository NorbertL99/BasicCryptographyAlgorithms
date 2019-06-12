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

namespace Basic_Cryptography_Algorithms.Windows.UserControls
{
    public partial class DESControl : UserControl
    {
        IDESManagament desManagament = new DESManagament();

        /// <summary>
        /// This method run when window open
        /// </summary>
        public DESControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method run when "Encrypt" button clicked
        /// </summary>
        private void encryptBT_Click(object sender, EventArgs e)
        {
            if(keyTB.Text.Length != 8 || ivTB.Text.Length != 8)
            {
                MessageBox.Show("KEY and IV must contain 8 chars !", "Length error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                effectRTB.Text = desManagament.Encryption(textRTB.Text, Encoding.ASCII.GetBytes(keyTB.Text), Encoding.ASCII.GetBytes(ivTB.Text));
            }
        }
        /// <summary>
        /// This method run when "Decrypt" button clicked
        /// </summary>
        private void decryptBT_Click(object sender, EventArgs e)
        {
            if (keyTB.Text.Length != 8 || ivTB.Text.Length != 8)
            {
                MessageBox.Show("KEY and IV must contain 8 chars !", "Length error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                effectRTB.Text = desManagament.Decryption(textRTB.Text, Encoding.ASCII.GetBytes(keyTB.Text), Encoding.ASCII.GetBytes(ivTB.Text));
            }
        }
        /// <summary>
        /// This method run when "Clear both" button clicked
        /// </summary>
        private void clearBT_Click(object sender, EventArgs e)
        {
            textRTB.Text = null;
            effectRTB.Text = null;
        }
        /// <summary>
        /// This method run when "Switch to decrypt" button clicked
        /// </summary>
        private void switchBT_Click(object sender, EventArgs e)
        {
            textRTB.Text = effectRTB.Text;
            effectRTB.Text = null;
        }
    }
}
