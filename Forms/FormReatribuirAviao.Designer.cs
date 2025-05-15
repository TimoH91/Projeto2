namespace Forms
{
    partial class FormReatribuirAviao
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
            txtBoxVoo = new TextBox();
            listBoxAvioesDisponiveis = new ListBox();
            btnOk = new Button();
            pictureBox1 = new PictureBox();
            lblAeroportos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxVoo
            // 
            txtBoxVoo.Anchor = AnchorStyles.None;
            txtBoxVoo.Location = new Point(248, 174);
            txtBoxVoo.Name = "txtBoxVoo";
            txtBoxVoo.Size = new Size(928, 39);
            txtBoxVoo.TabIndex = 0;
            txtBoxVoo.Text = "Voo";
            // 
            // listBoxAvioesDisponiveis
            // 
            listBoxAvioesDisponiveis.Anchor = AnchorStyles.None;
            listBoxAvioesDisponiveis.FormattingEnabled = true;
            listBoxAvioesDisponiveis.Location = new Point(248, 478);
            listBoxAvioesDisponiveis.Name = "listBoxAvioesDisponiveis";
            listBoxAvioesDisponiveis.Size = new Size(928, 356);
            listBoxAvioesDisponiveis.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.None;
            btnOk.Location = new Point(1026, 852);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(150, 46);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo_background_bigger;
            pictureBox1.Location = new Point(199, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1036, 844);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblAeroportos
            // 
            lblAeroportos.Anchor = AnchorStyles.None;
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(239, 36);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(197, 72);
            lblAeroportos.TabIndex = 17;
            lblAeroportos.Text = "Aviões";
            // 
            // FormReatribuirAviao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(1439, 981);
            Controls.Add(lblAeroportos);
            Controls.Add(btnOk);
            Controls.Add(listBoxAvioesDisponiveis);
            Controls.Add(txtBoxVoo);
            Controls.Add(pictureBox1);
            Name = "FormReatribuirAviao";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxVoo;
        private ListBox listBoxAvioesDisponiveis;
        private Button btnOk;
        private PictureBox pictureBox1;
        private Label lblAeroportos;
    }
}