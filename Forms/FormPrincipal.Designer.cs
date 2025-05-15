
namespace Forms
{
    partial class FormPrincipal
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
            btnVoos = new Button();
            btnBilhetes = new Button();
            btnAvioes = new Button();
            btnAeroporto = new Button();
            Logo = new PictureBox();
            panel1 = new Panel();
            pictureBoxIcon = new PictureBox();
            panel2 = new Panel();
            btnVenda = new Button();
            label1 = new Label();
            btnFocus = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoos
            // 
            btnVoos.Anchor = AnchorStyles.None;
            btnVoos.BackColor = Color.White;
            btnVoos.FlatStyle = FlatStyle.Flat;
            btnVoos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVoos.ForeColor = Color.FromArgb(62, 69, 72);
            btnVoos.Location = new Point(21, 203);
            btnVoos.Margin = new Padding(5);
            btnVoos.Name = "btnVoos";
            btnVoos.Size = new Size(153, 46);
            btnVoos.TabIndex = 0;
            btnVoos.Text = "Voos";
            btnVoos.UseVisualStyleBackColor = false;
            btnVoos.Click += btnVoos_Click;
            // 
            // btnBilhetes
            // 
            btnBilhetes.Anchor = AnchorStyles.None;
            btnBilhetes.BackColor = Color.White;
            btnBilhetes.FlatStyle = FlatStyle.Flat;
            btnBilhetes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBilhetes.ForeColor = Color.FromArgb(62, 69, 72);
            btnBilhetes.Location = new Point(21, 259);
            btnBilhetes.Margin = new Padding(5);
            btnBilhetes.Name = "btnBilhetes";
            btnBilhetes.Size = new Size(153, 46);
            btnBilhetes.TabIndex = 1;
            btnBilhetes.Text = "Bilhetes";
            btnBilhetes.UseVisualStyleBackColor = false;
            btnBilhetes.Click += btnBilhetes_Click;
            // 
            // btnAvioes
            // 
            btnAvioes.Anchor = AnchorStyles.None;
            btnAvioes.BackColor = Color.White;
            btnAvioes.FlatStyle = FlatStyle.Flat;
            btnAvioes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAvioes.ForeColor = Color.FromArgb(62, 69, 72);
            btnAvioes.Location = new Point(888, 730);
            btnAvioes.Margin = new Padding(5);
            btnAvioes.Name = "btnAvioes";
            btnAvioes.Size = new Size(153, 46);
            btnAvioes.TabIndex = 2;
            btnAvioes.Text = "Aviões";
            btnAvioes.UseVisualStyleBackColor = false;
            btnAvioes.Click += btnAvioes_Click;
            // 
            // btnAeroporto
            // 
            btnAeroporto.Anchor = AnchorStyles.None;
            btnAeroporto.BackColor = Color.White;
            btnAeroporto.FlatStyle = FlatStyle.Flat;
            btnAeroporto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAeroporto.ForeColor = Color.FromArgb(62, 69, 72);
            btnAeroporto.Location = new Point(21, 147);
            btnAeroporto.Margin = new Padding(5);
            btnAeroporto.Name = "btnAeroporto";
            btnAeroporto.Size = new Size(153, 46);
            btnAeroporto.TabIndex = 3;
            btnAeroporto.Text = "Aeroportos";
            btnAeroporto.UseVisualStyleBackColor = false;
            btnAeroporto.Click += btnAeroporto_Click;
            // 
            // Logo
            // 
            Logo.Anchor = AnchorStyles.None;
            Logo.BackColor = Color.White;
            Logo.Image = Properties.Resources.ChatGPT_Image_Apr_6__2025__09_08_00_PM;
            Logo.Location = new Point(105, 45);
            Logo.Name = "Logo";
            Logo.Size = new Size(1024, 1024);
            Logo.SizeMode = PictureBoxSizeMode.AutoSize;
            Logo.TabIndex = 5;
            Logo.TabStop = false;
            Logo.WaitOnLoad = true;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(72, 122, 167);
            panel1.Controls.Add(pictureBoxIcon);
            panel1.Controls.Add(btnAvioes);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(btnFocus);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1236, 1106);
            panel1.TabIndex = 6;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Anchor = AnchorStyles.None;
            pictureBoxIcon.BackColor = Color.White;
            pictureBoxIcon.Image = Properties.Resources.icons8_info_50;
            pictureBoxIcon.Location = new Point(138, 992);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(52, 52);
            pictureBoxIcon.TabIndex = 8;
            pictureBoxIcon.TabStop = false;
            pictureBoxIcon.Click += pictureBoxIcon_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackgroundImage = Properties.Resources.background_patternb;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnVenda);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAeroporto);
            panel2.Controls.Add(btnBilhetes);
            panel2.Controls.Add(btnVoos);
            panel2.Location = new Point(865, 637);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 388);
            panel2.TabIndex = 7;
            // 
            // btnVenda
            // 
            btnVenda.Anchor = AnchorStyles.None;
            btnVenda.BackColor = Color.White;
            btnVenda.FlatStyle = FlatStyle.Flat;
            btnVenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVenda.ForeColor = Color.FromArgb(62, 69, 72);
            btnVenda.Location = new Point(21, 315);
            btnVenda.Margin = new Padding(5);
            btnVenda.Name = "btnVenda";
            btnVenda.Size = new Size(153, 46);
            btnVenda.TabIndex = 6;
            btnVenda.Text = "Venda";
            btnVenda.UseVisualStyleBackColor = false;
            btnVenda.Click += btnVenda_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(213, 211, 211);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(143, 54);
            label1.TabIndex = 0;
            label1.Text = "MENU";
            // 
            // btnFocus
            // 
            btnFocus.Anchor = AnchorStyles.None;
            btnFocus.Location = new Point(134, 84);
            btnFocus.Name = "btnFocus";
            btnFocus.Size = new Size(150, 46);
            btnFocus.TabIndex = 9;
            btnFocus.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(1236, 1106);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "FormPrincipal";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoos;
        private Button btnBilhetes;
        private Button btnAvioes;
        private Button btnAeroporto;
        private PictureBox Logo;
        private Panel panel1;
        private Button btnVenda;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBoxIcon;
        private Button btnFocus;
    }
}
