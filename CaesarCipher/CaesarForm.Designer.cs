namespace CaesarCipher
{
    partial class CipherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CipherForm));
            this.CaesarCiLabel = new System.Windows.Forms.Label();
            this.ciphDescLabel = new System.Windows.Forms.Label();
            this.ciphTextBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.cipherTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.vigEncryptDecryptLabel = new System.Windows.Forms.Label();
            this.vigResTextBox = new System.Windows.Forms.TextBox();
            this.keywordLabel = new System.Windows.Forms.Label();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.vigDecryptButton = new System.Windows.Forms.Button();
            this.vigEncryptButton = new System.Windows.Forms.Button();
            this.vigenereDesc = new System.Windows.Forms.Label();
            this.vigenereLabel = new System.Windows.Forms.Label();
            this.cipherTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CaesarCiLabel
            // 
            this.CaesarCiLabel.AutoSize = true;
            this.CaesarCiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CaesarCiLabel.Location = new System.Drawing.Point(271, 23);
            this.CaesarCiLabel.Name = "CaesarCiLabel";
            this.CaesarCiLabel.Size = new System.Drawing.Size(223, 37);
            this.CaesarCiLabel.TabIndex = 0;
            this.CaesarCiLabel.Text = "Caesar Cipher";
            // 
            // ciphDescLabel
            // 
            this.ciphDescLabel.AutoSize = true;
            this.ciphDescLabel.Location = new System.Drawing.Point(97, 79);
            this.ciphDescLabel.Name = "ciphDescLabel";
            this.ciphDescLabel.Size = new System.Drawing.Size(550, 80);
            this.ciphDescLabel.TabIndex = 1;
            this.ciphDescLabel.Text = resources.GetString("ciphDescLabel.Text");
            // 
            // ciphTextBox
            // 
            this.ciphTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ciphTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ciphTextBox.Location = new System.Drawing.Point(242, 208);
            this.ciphTextBox.Multiline = true;
            this.ciphTextBox.Name = "ciphTextBox";
            this.ciphTextBox.Size = new System.Drawing.Size(273, 41);
            this.ciphTextBox.TabIndex = 2;
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.encryptButton.Location = new System.Drawing.Point(242, 265);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(110, 38);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.decryptButton.Location = new System.Drawing.Point(405, 265);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(110, 38);
            this.decryptButton.TabIndex = 4;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // cipherTab
            // 
            this.cipherTab.Controls.Add(this.tabPage1);
            this.cipherTab.Controls.Add(this.tabPage2);
            this.cipherTab.Location = new System.Drawing.Point(3, 1);
            this.cipherTab.Name = "cipherTab";
            this.cipherTab.SelectedIndex = 0;
            this.cipherTab.Size = new System.Drawing.Size(800, 452);
            this.cipherTab.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.decryptButton);
            this.tabPage1.Controls.Add(this.CaesarCiLabel);
            this.tabPage1.Controls.Add(this.encryptButton);
            this.tabPage1.Controls.Add(this.ciphDescLabel);
            this.tabPage1.Controls.Add(this.ciphTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Caesar Cipher";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.vigEncryptDecryptLabel);
            this.tabPage2.Controls.Add(this.vigResTextBox);
            this.tabPage2.Controls.Add(this.keywordLabel);
            this.tabPage2.Controls.Add(this.keywordTextBox);
            this.tabPage2.Controls.Add(this.vigDecryptButton);
            this.tabPage2.Controls.Add(this.vigEncryptButton);
            this.tabPage2.Controls.Add(this.vigenereDesc);
            this.tabPage2.Controls.Add(this.vigenereLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vigenère Cipher";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // vigEncryptDecryptLabel
            // 
            this.vigEncryptDecryptLabel.AutoSize = true;
            this.vigEncryptDecryptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vigEncryptDecryptLabel.Location = new System.Drawing.Point(433, 223);
            this.vigEncryptDecryptLabel.Name = "vigEncryptDecryptLabel";
            this.vigEncryptDecryptLabel.Size = new System.Drawing.Size(335, 25);
            this.vigEncryptDecryptLabel.TabIndex = 11;
            this.vigEncryptDecryptLabel.Text = "Message to be Encrypted/Decrypted:";
            // 
            // vigResTextBox
            // 
            this.vigResTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vigResTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.vigResTextBox.Location = new System.Drawing.Point(447, 251);
            this.vigResTextBox.Multiline = true;
            this.vigResTextBox.Name = "vigResTextBox";
            this.vigResTextBox.Size = new System.Drawing.Size(301, 35);
            this.vigResTextBox.TabIndex = 9;
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keywordLabel.Location = new System.Drawing.Point(48, 223);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(230, 25);
            this.keywordLabel.TabIndex = 7;
            this.keywordLabel.Text = "Input your Keyword here:";
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keywordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.keywordTextBox.Location = new System.Drawing.Point(36, 251);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(257, 35);
            this.keywordTextBox.TabIndex = 5;
            // 
            // vigDecryptButton
            // 
            this.vigDecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vigDecryptButton.Location = new System.Drawing.Point(635, 292);
            this.vigDecryptButton.Name = "vigDecryptButton";
            this.vigDecryptButton.Size = new System.Drawing.Size(103, 45);
            this.vigDecryptButton.TabIndex = 4;
            this.vigDecryptButton.Text = "Decrypt";
            this.vigDecryptButton.UseVisualStyleBackColor = true;
            this.vigDecryptButton.Click += new System.EventHandler(this.VigDecryptButton_Click);
            // 
            // vigEncryptButton
            // 
            this.vigEncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vigEncryptButton.Location = new System.Drawing.Point(463, 292);
            this.vigEncryptButton.Name = "vigEncryptButton";
            this.vigEncryptButton.Size = new System.Drawing.Size(110, 45);
            this.vigEncryptButton.TabIndex = 3;
            this.vigEncryptButton.Text = "Encrypt";
            this.vigEncryptButton.UseVisualStyleBackColor = true;
            this.vigEncryptButton.Click += new System.EventHandler(this.VigEncryptButton_Click);
            // 
            // vigenereDesc
            // 
            this.vigenereDesc.AutoSize = true;
            this.vigenereDesc.Location = new System.Drawing.Point(78, 66);
            this.vigenereDesc.Name = "vigenereDesc";
            this.vigenereDesc.Size = new System.Drawing.Size(582, 100);
            this.vigenereDesc.TabIndex = 1;
            this.vigenereDesc.Text = resources.GetString("vigenereDesc.Text");
            // 
            // vigenereLabel
            // 
            this.vigenereLabel.AutoSize = true;
            this.vigenereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.vigenereLabel.Location = new System.Drawing.Point(254, 20);
            this.vigenereLabel.Name = "vigenereLabel";
            this.vigenereLabel.Size = new System.Drawing.Size(247, 37);
            this.vigenereLabel.TabIndex = 0;
            this.vigenereLabel.Text = "Vigenère Cipher";
            // 
            // CipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cipherTab);
            this.Name = "CipherForm";
            this.Text = "Encryption Ciphers";
            this.cipherTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CaesarCiLabel;
        private System.Windows.Forms.Label ciphDescLabel;
        private System.Windows.Forms.TextBox ciphTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TabControl cipherTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label vigenereLabel;
        private System.Windows.Forms.Label vigenereDesc;
        private System.Windows.Forms.Button vigEncryptButton;
        private System.Windows.Forms.Button vigDecryptButton;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Label keywordLabel;
        private System.Windows.Forms.TextBox vigResTextBox;
        private System.Windows.Forms.Label vigEncryptDecryptLabel;
    }
}

