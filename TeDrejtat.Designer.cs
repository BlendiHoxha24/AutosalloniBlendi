namespace AutosalloniBlendi
{
    partial class TeDrejtat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeDrejtat));
            closeButton = new Button();
            goBackButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.DarkOrange;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(1064, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(116, 36);
            closeButton.TabIndex = 11;
            closeButton.Text = "Mbylle";
            closeButton.UseVisualStyleBackColor = false;
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.DarkOrange;
            goBackButton.FlatStyle = FlatStyle.Flat;
            goBackButton.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goBackButton.Location = new Point(942, 12);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(116, 36);
            goBackButton.TabIndex = 10;
            goBackButton.Text = " Mbrapa";
            goBackButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(346, 24);
            label1.Name = "label1";
            label1.Size = new Size(441, 53);
            label1.TabIndex = 12;
            label1.Text = "Te Drejtat e Autorit ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 141);
            label2.Name = "label2";
            label2.Size = new Size(445, 294);
            label2.TabIndex = 13;
            label2.Text = resources.GetString("label2.Text");
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(479, 141);
            label3.Name = "label3";
            label3.Size = new Size(701, 294);
            label3.TabIndex = 14;
            label3.Text = resources.GetString("label3.Text");
            // 
            // TeDrejtat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 616);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(closeButton);
            Controls.Add(goBackButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TeDrejtat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeDrejtat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Button goBackButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}