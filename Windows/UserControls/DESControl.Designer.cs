namespace Basic_Cryptography_Algorithms.Windows.UserControls
{
    partial class DESControl
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.keyTB = new System.Windows.Forms.TextBox();
            this.ivTB = new System.Windows.Forms.TextBox();
            this.clearBT = new System.Windows.Forms.Button();
            this.switchBT = new System.Windows.Forms.Button();
            this.decryptBT = new System.Windows.Forms.Button();
            this.encryptBT = new System.Windows.Forms.Button();
            this.effectRTB = new System.Windows.Forms.RichTextBox();
            this.textRTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(3, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "DES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(56, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(65, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "IV";
            // 
            // keyTB
            // 
            this.keyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keyTB.Location = new System.Drawing.Point(29, 181);
            this.keyTB.Name = "keyTB";
            this.keyTB.Size = new System.Drawing.Size(112, 24);
            this.keyTB.TabIndex = 4;
            // 
            // ivTB
            // 
            this.ivTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ivTB.Location = new System.Drawing.Point(29, 122);
            this.ivTB.Name = "ivTB";
            this.ivTB.Size = new System.Drawing.Size(112, 24);
            this.ivTB.TabIndex = 5;
            // 
            // clearBT
            // 
            this.clearBT.Location = new System.Drawing.Point(449, 330);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(100, 23);
            this.clearBT.TabIndex = 16;
            this.clearBT.Text = "Clear both";
            this.clearBT.UseVisualStyleBackColor = true;
            this.clearBT.Click += new System.EventHandler(this.clearBT_Click);
            // 
            // switchBT
            // 
            this.switchBT.Location = new System.Drawing.Point(575, 330);
            this.switchBT.Name = "switchBT";
            this.switchBT.Size = new System.Drawing.Size(133, 23);
            this.switchBT.TabIndex = 15;
            this.switchBT.Text = "Switch to decrypt";
            this.switchBT.UseVisualStyleBackColor = true;
            this.switchBT.Click += new System.EventHandler(this.switchBT_Click);
            // 
            // decryptBT
            // 
            this.decryptBT.Location = new System.Drawing.Point(312, 330);
            this.decryptBT.Name = "decryptBT";
            this.decryptBT.Size = new System.Drawing.Size(94, 23);
            this.decryptBT.TabIndex = 14;
            this.decryptBT.Text = "Decrypt";
            this.decryptBT.UseVisualStyleBackColor = true;
            this.decryptBT.Click += new System.EventHandler(this.decryptBT_Click);
            // 
            // encryptBT
            // 
            this.encryptBT.Location = new System.Drawing.Point(147, 330);
            this.encryptBT.Name = "encryptBT";
            this.encryptBT.Size = new System.Drawing.Size(94, 23);
            this.encryptBT.TabIndex = 13;
            this.encryptBT.Text = "Encrypt";
            this.encryptBT.UseVisualStyleBackColor = true;
            this.encryptBT.Click += new System.EventHandler(this.encryptBT_Click);
            // 
            // effectRTB
            // 
            this.effectRTB.Location = new System.Drawing.Point(449, 122);
            this.effectRTB.Name = "effectRTB";
            this.effectRTB.ReadOnly = true;
            this.effectRTB.Size = new System.Drawing.Size(259, 202);
            this.effectRTB.TabIndex = 12;
            this.effectRTB.Text = "";
            // 
            // textRTB
            // 
            this.textRTB.Location = new System.Drawing.Point(147, 122);
            this.textRTB.Name = "textRTB";
            this.textRTB.Size = new System.Drawing.Size(259, 202);
            this.textRTB.TabIndex = 11;
            this.textRTB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(548, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Effect";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(243, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Text";
            // 
            // DESControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.clearBT);
            this.Controls.Add(this.switchBT);
            this.Controls.Add(this.decryptBT);
            this.Controls.Add(this.encryptBT);
            this.Controls.Add(this.effectRTB);
            this.Controls.Add(this.textRTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ivTB);
            this.Controls.Add(this.keyTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DESControl";
            this.Size = new System.Drawing.Size(784, 438);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyTB;
        private System.Windows.Forms.TextBox ivTB;
        private System.Windows.Forms.Button clearBT;
        private System.Windows.Forms.Button switchBT;
        private System.Windows.Forms.Button decryptBT;
        private System.Windows.Forms.Button encryptBT;
        private System.Windows.Forms.RichTextBox effectRTB;
        private System.Windows.Forms.RichTextBox textRTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
