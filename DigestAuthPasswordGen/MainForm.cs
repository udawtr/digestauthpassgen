using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DigestAuthPasswordGen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            var username = textUsername.Text.Trim();
            var realm = textRealm.Text.Trim();
            var plainPass = textPlainPassword.Text.Trim();

            var sSourceData = String.Format("{0}:{1}:{2}", username, realm, plainPass);
            var tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
            var tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            var hashedPass = ByteArrayToString(tmpHash);
            textHashedPassword.Text = hashedPass;
        }

        static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("x2"));
            }
            return sOutput.ToString();
        }

        private void buttonGenId_Click(object sender, EventArgs e)
        {
            textUsername.Text = Guid.NewGuid().ToString();
        }
    }
}
