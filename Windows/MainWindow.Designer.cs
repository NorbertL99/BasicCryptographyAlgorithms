namespace Basic_Cryptography_Algorithms
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cryptographyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rsaControl = new Basic_Cryptography_Algorithms.Windows.UserControls.RSAControl();
            this.desControl = new Basic_Cryptography_Algorithms.Windows.UserControls.DESControl();
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cryptographyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cryptographyToolStripMenuItem
            // 
            this.cryptographyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dESToolStripMenuItem,
            this.rSAToolStripMenuItem});
            this.cryptographyToolStripMenuItem.Name = "cryptographyToolStripMenuItem";
            this.cryptographyToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.cryptographyToolStripMenuItem.Text = "Cryptography";
            // 
            // dESToolStripMenuItem
            // 
            this.dESToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dESToolStripMenuItem.Name = "dESToolStripMenuItem";
            this.dESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dESToolStripMenuItem.Text = "DES";
            this.dESToolStripMenuItem.Click += new System.EventHandler(this.dESToolStripMenuItem_Click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rSAToolStripMenuItem.Text = "RSA";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.rSAToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.rsaControl);
            this.mainPanel.Controls.Add(this.desControl);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 438);
            this.mainPanel.TabIndex = 1;
            // 
            // rsaControl
            // 
            this.rsaControl.BackColor = System.Drawing.Color.Gray;
            this.rsaControl.Location = new System.Drawing.Point(0, 0);
            this.rsaControl.Name = "rsaControl";
            this.rsaControl.Size = new System.Drawing.Size(784, 438);
            this.rsaControl.TabIndex = 2;
            // 
            // desControl
            // 
            this.desControl.BackColor = System.Drawing.Color.Gray;
            this.desControl.Location = new System.Drawing.Point(0, 0);
            this.desControl.Name = "desControl";
            this.desControl.Size = new System.Drawing.Size(784, 438);
            this.desControl.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Basic Cryptography Algorithms";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cryptographyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private Windows.UserControls.RSAControl rsaControl;
        private Windows.UserControls.DESControl desControl;
    }
}

