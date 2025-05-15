namespace Forms
{
    partial class FormAppInfo
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.background_patternb;
            pictureBox1.Location = new Point(131, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 267);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.FromArgb(213, 211, 211);
            textBox1.Enabled = false;
            textBox1.Location = new Point(180, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 39);
            textBox1.TabIndex = 2;
            textBox1.Text = "Brisa 97 Consulta de voos";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.FromArgb(213, 211, 211);
            textBox2.Enabled = false;
            textBox2.Location = new Point(180, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 39);
            textBox2.TabIndex = 3;
            textBox2.Text = "Version 1.0.0";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = Color.FromArgb(213, 211, 211);
            textBox3.Enabled = false;
            textBox3.Location = new Point(180, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(297, 39);
            textBox3.TabIndex = 4;
            textBox3.Text = "© 2025 Timothy Harris";
            // 
            // FormAppInfo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(668, 392);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "FormAppInfo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}