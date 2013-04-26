namespace DigestAuthPasswordGen
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textRealm = new System.Windows.Forms.TextBox();
            this.textPlainPassword = new System.Windows.Forms.TextBox();
            this.getButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textHashedPassword = new System.Windows.Forms.TextBox();
            this.buttonGenId = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "realm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "plain password:";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(149, 29);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(270, 22);
            this.textUsername.TabIndex = 3;
            // 
            // textRealm
            // 
            this.textRealm.Location = new System.Drawing.Point(149, 65);
            this.textRealm.Name = "textRealm";
            this.textRealm.Size = new System.Drawing.Size(270, 22);
            this.textRealm.TabIndex = 4;
            this.textRealm.Text = "APIAccess";
            // 
            // textPlainPassword
            // 
            this.textPlainPassword.Location = new System.Drawing.Point(149, 105);
            this.textPlainPassword.Name = "textPlainPassword";
            this.textPlainPassword.Size = new System.Drawing.Size(270, 22);
            this.textPlainPassword.TabIndex = 5;
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(149, 153);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(172, 23);
            this.getButton.TabIndex = 6;
            this.getButton.Text = "↓生成↓";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hashed Password:";
            // 
            // textHashedPassword
            // 
            this.textHashedPassword.Location = new System.Drawing.Point(149, 200);
            this.textHashedPassword.Name = "textHashedPassword";
            this.textHashedPassword.Size = new System.Drawing.Size(270, 22);
            this.textHashedPassword.TabIndex = 8;
            // 
            // buttonGenId
            // 
            this.buttonGenId.Location = new System.Drawing.Point(438, 28);
            this.buttonGenId.Name = "buttonGenId";
            this.buttonGenId.Size = new System.Drawing.Size(62, 23);
            this.buttonGenId.TabIndex = 9;
            this.buttonGenId.Text = "←生成";
            this.buttonGenId.UseVisualStyleBackColor = true;
            this.buttonGenId.Click += new System.EventHandler(this.buttonGenId_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 255);
            this.Controls.Add(this.buttonGenId);
            this.Controls.Add(this.textHashedPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.textPlainPassword);
            this.Controls.Add(this.textRealm);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ダイジェスト認証パスワード生成";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textRealm;
        private System.Windows.Forms.TextBox textPlainPassword;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textHashedPassword;
        private System.Windows.Forms.Button buttonGenId;
    }
}

