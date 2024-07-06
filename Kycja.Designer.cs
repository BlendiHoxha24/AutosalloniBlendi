﻿namespace AutosalloniBlendi
{
    partial class Kycja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kycja));
            userLoginInput = new TextBox();
            passwordLoginInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginButton = new Button();
            kycuLabel = new Label();
            registerButton = new Button();
            closeButton = new Button();
            authorRightsButton = new Button();
            SuspendLayout();
            // 
            // userLoginInput
            // 
            userLoginInput.BackColor = Color.White;
            userLoginInput.Location = new Point(518, 212);
            userLoginInput.Name = "userLoginInput";
            userLoginInput.Size = new Size(164, 23);
            userLoginInput.TabIndex = 0;
            // 
            // passwordLoginInput
            // 
            passwordLoginInput.Location = new Point(518, 254);
            passwordLoginInput.Name = "passwordLoginInput";
            passwordLoginInput.Size = new Size(164, 23);
            passwordLoginInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(396, 212);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 2;
            label1.Text = "Perdoruesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(396, 249);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 3;
            label2.Text = "Fjalekalimi";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DarkOrange;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(518, 301);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(116, 36);
            loginButton.TabIndex = 4;
            loginButton.Text = "Kycu";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // kycuLabel
            // 
            kycuLabel.AutoSize = true;
            kycuLabel.BackColor = Color.Transparent;
            kycuLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            kycuLabel.ForeColor = Color.White;
            kycuLabel.Location = new Point(502, 108);
            kycuLabel.Name = "kycuLabel";
            kycuLabel.Size = new Size(135, 65);
            kycuLabel.TabIndex = 6;
            kycuLabel.Text = "Kycu";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.DarkOrange;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Location = new Point(12, 12);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(116, 36);
            registerButton.TabIndex = 7;
            registerButton.Text = "Regjistrohu";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.DarkOrange;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(12, 54);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(116, 36);
            closeButton.TabIndex = 8;
            closeButton.Text = "Mbylle";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // authorRightsButton
            // 
            authorRightsButton.BackColor = Color.DarkOrange;
            authorRightsButton.FlatStyle = FlatStyle.Flat;
            authorRightsButton.Location = new Point(12, 568);
            authorRightsButton.Name = "authorRightsButton";
            authorRightsButton.Size = new Size(116, 36);
            authorRightsButton.TabIndex = 9;
            authorRightsButton.Text = "Te Drejtat";
            authorRightsButton.UseVisualStyleBackColor = false;
            authorRightsButton.Click += authorRightsButton_Click;
            // 
            // Kycja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 616);
            Controls.Add(authorRightsButton);
            Controls.Add(closeButton);
            Controls.Add(registerButton);
            Controls.Add(kycuLabel);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordLoginInput);
            Controls.Add(userLoginInput);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Kycja";
            Text = "Kycja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userLoginInput;
        private TextBox passwordLoginInput;
        private Label label1;
        private Label label2;
        private Button loginButton;
        private Label kycuLabel;
        private Button registerButton;
        private Button closeButton;
        private Button authorRightsButton;
    }
}