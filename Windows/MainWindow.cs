using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Cryptography_Algorithms
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// This method run when window open
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method run when "DES" button click
        /// </summary>
        private void dESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desControl.BringToFront();
        }
        /// <summary>
        /// This method run when "RSA" button click
        /// </summary>
        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rsaControl.BringToFront();
        }
    }
}
