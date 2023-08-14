using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CaesarCipher
{
    public partial class CipherForm : Form
    {
        CaesarCipher.CipherFunc ciphfunc = new CaesarCipher.CipherFunc();
        public CipherForm()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ciphTextBox.Text))
            {
                if (Regex.IsMatch(ciphTextBox.Text, "^[A-Za-z\\s]+$"))
                {
                    string caesarInput = ciphTextBox.Text;
                    string caesarResult = CipherFunc.EncryptString(caesarInput, 5);
                    ciphTextBox.Text = caesarResult;
                }
                else
                {
                    MessageBox.Show("Only letters are allowed to be entered for encryption. Please remove any numbers or symbols.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter your message to encrypt.", "Encryption Attempt with No Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ciphTextBox.Text))
            {
                if (Regex.IsMatch(ciphTextBox.Text, "^[A-Za-z\\s]+$"))
                {
                    string caesarInput = ciphTextBox.Text;
                    string caesarResult = CipherFunc.DecryptString(caesarInput, 5);
                    ciphTextBox.Text = caesarResult;
                }
                else
                {
                    MessageBox.Show("Only letters are allowed to be entered for decryption. Please remove any number or symbols.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter your message to decrypt.", "Decryption Attempt with No Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VigEncryptButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(vigResTextBox.Text))
            {
                if (Regex.IsMatch(vigResTextBox.Text, "^[A-Za-z\\s]+$"))
                {
                    if (!string.IsNullOrEmpty(keywordTextBox.Text))
                    {
                        string keyResult = CipherFunc.GenerateKey(keywordTextBox.Text, vigResTextBox.Text);

                        if (keyResult != null)
                        {
                            string encryptedMessage = CipherFunc.EncryptVigString(vigResTextBox.Text, keyResult);
                            vigResTextBox.Text = encryptedMessage;
                        }
                        else
                        {
                            MessageBox.Show("Key not properly generated, please retype message or keyword.", "Corrupted Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please make sure the keyword textbox is filled.", "Encryption Attempt with No Keyword", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Only letters are allowed to be entered for encryption. Please remove any numbers or symbols.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a message for encryption.", "Encryption Attempt with No Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VigDecryptButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(vigResTextBox.Text))
            {
                if (Regex.IsMatch(vigResTextBox.Text, "^[A-Za-z\\s]+$"))
                {
                    if (!string.IsNullOrEmpty(keywordTextBox.Text))
                    {
                        string decryptedMessage = CipherFunc.DecryptVigString(vigResTextBox.Text, keywordTextBox.Text);
                        vigResTextBox.Text = decryptedMessage;
                    }
                    else
                    {
                        MessageBox.Show("Please make sure the keyword textbox is filled.", "Decryption Attempt with No Keyword", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Only letters are allowed to be entered for decryption. Please remove any numbers or symbols.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a message for decryption.", "Decryption Attempt with No Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}