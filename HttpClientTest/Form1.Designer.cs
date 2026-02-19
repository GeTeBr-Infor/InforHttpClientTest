namespace HttpClientTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            call = new Button();
            useCookiesCheckBox = new CheckBox();
            requestTextBox = new TextBox();
            responseTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // call
            // 
            call.Location = new Point(259, 68);
            call.Name = "call";
            call.Size = new Size(75, 23);
            call.TabIndex = 0;
            call.Text = "Call";
            call.UseVisualStyleBackColor = true;
            call.Click += button1_Click;
            // 
            // useCookiesCheckBox
            // 
            useCookiesCheckBox.AutoSize = true;
            useCookiesCheckBox.Location = new Point(44, 68);
            useCookiesCheckBox.Name = "useCookiesCheckBox";
            useCookiesCheckBox.Size = new Size(87, 19);
            useCookiesCheckBox.TabIndex = 1;
            useCookiesCheckBox.Text = "UseCookies";
            useCookiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // requestTextBox
            // 
            requestTextBox.Location = new Point(0, 136);
            requestTextBox.Name = "requestTextBox";
            requestTextBox.Size = new Size(800, 23);
            requestTextBox.TabIndex = 2;
            requestTextBox.Text = "https://Server.com:24108/m3api-rest/execute/MRS001MI/LstPrograms;metadata=true;maxrecs=100;excludempty=false?";
            // 
            // responseTextBox
            // 
            responseTextBox.Dock = DockStyle.Bottom;
            responseTextBox.Location = new Point(0, 198);
            responseTextBox.Multiline = true;
            responseTextBox.Name = "responseTextBox";
            responseTextBox.Size = new Size(800, 252);
            responseTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(436, 32);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(100, 23);
            usernameTextBox.TabIndex = 4;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(436, 61);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(responseTextBox);
            Controls.Add(requestTextBox);
            Controls.Add(useCookiesCheckBox);
            Controls.Add(call);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button call;
        private CheckBox useCookiesCheckBox;
        private TextBox requestTextBox;
        private TextBox responseTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
    }
}