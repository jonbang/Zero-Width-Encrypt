namespace Zero_Width_Characters
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HidePage = new System.Windows.Forms.TabPage();
            this.RTEncode = new System.Windows.Forms.CheckBox();
            this.StegOut = new System.Windows.Forms.TextBox();
            this.PrivateMessageInput = new System.Windows.Forms.TextBox();
            this.PublicMessageInput = new System.Windows.Forms.TextBox();
            this.StegoText = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.PrivateMessageInputLabel = new System.Windows.Forms.Label();
            this.PublicMessageInputLabel = new System.Windows.Forms.Label();
            this.RevealPage = new System.Windows.Forms.TabPage();
            this.RevealMsg = new System.Windows.Forms.TextBox();
            this.PubMsgDecode = new System.Windows.Forms.TextBox();
            this.DecryptLabel = new System.Windows.Forms.Label();
            this.EncryptLabel = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.HidePage.SuspendLayout();
            this.RevealPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HidePage);
            this.tabControl1.Controls.Add(this.RevealPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1203, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // HidePage
            // 
            this.HidePage.BackColor = System.Drawing.Color.Azure;
            this.HidePage.Controls.Add(this.RTEncode);
            this.HidePage.Controls.Add(this.StegOut);
            this.HidePage.Controls.Add(this.PrivateMessageInput);
            this.HidePage.Controls.Add(this.PublicMessageInput);
            this.HidePage.Controls.Add(this.StegoText);
            this.HidePage.Controls.Add(this.EncryptButton);
            this.HidePage.Controls.Add(this.PrivateMessageInputLabel);
            this.HidePage.Controls.Add(this.PublicMessageInputLabel);
            this.HidePage.Location = new System.Drawing.Point(4, 29);
            this.HidePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HidePage.Name = "HidePage";
            this.HidePage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HidePage.Size = new System.Drawing.Size(1195, 659);
            this.HidePage.TabIndex = 0;
            this.HidePage.Text = "Hide";
            // 
            // RTEncode
            // 
            this.RTEncode.AutoSize = true;
            this.RTEncode.Checked = true;
            this.RTEncode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RTEncode.Location = new System.Drawing.Point(76, 602);
            this.RTEncode.Name = "RTEncode";
            this.RTEncode.Size = new System.Drawing.Size(188, 24);
            this.RTEncode.TabIndex = 10;
            this.RTEncode.Text = "Real-Time-Encoding?";
            this.RTEncode.UseVisualStyleBackColor = true;
            // 
            // StegOut
            // 
            this.StegOut.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StegOut.Location = new System.Drawing.Point(12, 409);
            this.StegOut.Multiline = true;
            this.StegOut.Name = "StegOut";
            this.StegOut.Size = new System.Drawing.Size(1162, 156);
            this.StegOut.TabIndex = 9;
            // 
            // PrivateMessageInput
            // 
            this.PrivateMessageInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PrivateMessageInput.Location = new System.Drawing.Point(12, 223);
            this.PrivateMessageInput.Multiline = true;
            this.PrivateMessageInput.Name = "PrivateMessageInput";
            this.PrivateMessageInput.Size = new System.Drawing.Size(1162, 156);
            this.PrivateMessageInput.TabIndex = 8;
            this.PrivateMessageInput.TextChanged += new System.EventHandler(this.PrivateMessageInput_TextChanged);
            // 
            // PublicMessageInput
            // 
            this.PublicMessageInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PublicMessageInput.Location = new System.Drawing.Point(12, 37);
            this.PublicMessageInput.Multiline = true;
            this.PublicMessageInput.Name = "PublicMessageInput";
            this.PublicMessageInput.Size = new System.Drawing.Size(1162, 156);
            this.PublicMessageInput.TabIndex = 7;
            this.PublicMessageInput.TextChanged += new System.EventHandler(this.PublicMessageInput_TextChanged);
            // 
            // StegoText
            // 
            this.StegoText.AutoSize = true;
            this.StegoText.Location = new System.Drawing.Point(9, 384);
            this.StegoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StegoText.Name = "StegoText";
            this.StegoText.Size = new System.Drawing.Size(178, 20);
            this.StegoText.TabIndex = 6;
            this.StegoText.Text = "Steganographized Text:";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(317, 585);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(578, 57);
            this.EncryptButton.TabIndex = 4;
            this.EncryptButton.Text = "Steganographize";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // PrivateMessageInputLabel
            // 
            this.PrivateMessageInputLabel.AutoSize = true;
            this.PrivateMessageInputLabel.Location = new System.Drawing.Point(9, 198);
            this.PrivateMessageInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrivateMessageInputLabel.Name = "PrivateMessageInputLabel";
            this.PrivateMessageInputLabel.Size = new System.Drawing.Size(130, 20);
            this.PrivateMessageInputLabel.TabIndex = 3;
            this.PrivateMessageInputLabel.Text = "Private Message:";
            // 
            // PublicMessageInputLabel
            // 
            this.PublicMessageInputLabel.AutoSize = true;
            this.PublicMessageInputLabel.Location = new System.Drawing.Point(14, 11);
            this.PublicMessageInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PublicMessageInputLabel.Name = "PublicMessageInputLabel";
            this.PublicMessageInputLabel.Size = new System.Drawing.Size(124, 20);
            this.PublicMessageInputLabel.TabIndex = 2;
            this.PublicMessageInputLabel.Text = "Public Message:";
            // 
            // RevealPage
            // 
            this.RevealPage.BackColor = System.Drawing.Color.Azure;
            this.RevealPage.Controls.Add(this.RevealMsg);
            this.RevealPage.Controls.Add(this.PubMsgDecode);
            this.RevealPage.Controls.Add(this.DecryptLabel);
            this.RevealPage.Controls.Add(this.EncryptLabel);
            this.RevealPage.Controls.Add(this.DecryptButton);
            this.RevealPage.Location = new System.Drawing.Point(4, 29);
            this.RevealPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RevealPage.Name = "RevealPage";
            this.RevealPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RevealPage.Size = new System.Drawing.Size(1195, 659);
            this.RevealPage.TabIndex = 1;
            this.RevealPage.Text = "Reveal";
            // 
            // RevealMsg
            // 
            this.RevealMsg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RevealMsg.Location = new System.Drawing.Point(18, 307);
            this.RevealMsg.Multiline = true;
            this.RevealMsg.Name = "RevealMsg";
            this.RevealMsg.Size = new System.Drawing.Size(1160, 235);
            this.RevealMsg.TabIndex = 6;
            // 
            // PubMsgDecode
            // 
            this.PubMsgDecode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PubMsgDecode.Location = new System.Drawing.Point(18, 35);
            this.PubMsgDecode.Multiline = true;
            this.PubMsgDecode.Name = "PubMsgDecode";
            this.PubMsgDecode.Size = new System.Drawing.Size(1160, 235);
            this.PubMsgDecode.TabIndex = 5;
            // 
            // DecryptLabel
            // 
            this.DecryptLabel.AutoSize = true;
            this.DecryptLabel.Location = new System.Drawing.Point(14, 284);
            this.DecryptLabel.Name = "DecryptLabel";
            this.DecryptLabel.Size = new System.Drawing.Size(155, 20);
            this.DecryptLabel.TabIndex = 4;
            this.DecryptLabel.Text = "Decrypted Message:";
            // 
            // EncryptLabel
            // 
            this.EncryptLabel.AutoSize = true;
            this.EncryptLabel.Location = new System.Drawing.Point(15, 12);
            this.EncryptLabel.Name = "EncryptLabel";
            this.EncryptLabel.Size = new System.Drawing.Size(154, 20);
            this.EncryptLabel.TabIndex = 3;
            this.EncryptLabel.Text = "Encrypted Message:";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(460, 559);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(322, 87);
            this.DecryptButton.TabIndex = 1;
            this.DecryptButton.Text = "De-Steganographize";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Zero-Width-Encrypter";
            this.tabControl1.ResumeLayout(false);
            this.HidePage.ResumeLayout(false);
            this.HidePage.PerformLayout();
            this.RevealPage.ResumeLayout(false);
            this.RevealPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HidePage;
        private System.Windows.Forms.TabPage RevealPage;
        private System.Windows.Forms.Label PublicMessageInputLabel;
        private System.Windows.Forms.Label PrivateMessageInputLabel;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label StegoText;
        private System.Windows.Forms.Label EncryptLabel;
        private System.Windows.Forms.Label DecryptLabel;
        private System.Windows.Forms.TextBox PubMsgDecode;
        private System.Windows.Forms.TextBox RevealMsg;
        private System.Windows.Forms.TextBox PublicMessageInput;
        private System.Windows.Forms.TextBox StegOut;
        private System.Windows.Forms.TextBox PrivateMessageInput;
        private System.Windows.Forms.CheckBox RTEncode;
    }
}

