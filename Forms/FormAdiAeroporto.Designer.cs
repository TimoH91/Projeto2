namespace Forms
{
    partial class FormAdiAeroporto
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
            btnGuardar = new Button();
            txtBoxCidade = new TextBox();
            txtBoxNome = new TextBox();
            txtBoxId = new TextBox();
            lblCidade = new Label();
            lblNome = new Label();
            lblId = new Label();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            lblAeroportos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.Location = new Point(683, 613);
            btnGuardar.Margin = new Padding(5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 46);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtBoxCidade
            // 
            txtBoxCidade.Anchor = AnchorStyles.None;
            txtBoxCidade.Location = new Point(368, 534);
            txtBoxCidade.Margin = new Padding(5);
            txtBoxCidade.Name = "txtBoxCidade";
            txtBoxCidade.Size = new Size(468, 39);
            txtBoxCidade.TabIndex = 17;
            // 
            // txtBoxNome
            // 
            txtBoxNome.Anchor = AnchorStyles.None;
            txtBoxNome.Location = new Point(368, 465);
            txtBoxNome.Margin = new Padding(5);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(468, 39);
            txtBoxNome.TabIndex = 16;
            // 
            // txtBoxId
            // 
            txtBoxId.Anchor = AnchorStyles.None;
            txtBoxId.Enabled = false;
            txtBoxId.Location = new Point(368, 395);
            txtBoxId.Margin = new Padding(5);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(133, 39);
            txtBoxId.TabIndex = 15;
            txtBoxId.Text = "1";
            // 
            // lblCidade
            // 
            lblCidade.Anchor = AnchorStyles.None;
            lblCidade.AutoSize = true;
            lblCidade.BackColor = Color.FromArgb(213, 211, 211);
            lblCidade.BorderStyle = BorderStyle.Fixed3D;
            lblCidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCidade.ForeColor = Color.FromArgb(62, 69, 72);
            lblCidade.Location = new Point(266, 534);
            lblCidade.Margin = new Padding(5, 0, 5, 0);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(94, 34);
            lblCidade.TabIndex = 13;
            lblCidade.Text = "Cidade";
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.None;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.FromArgb(213, 211, 211);
            lblNome.BorderStyle = BorderStyle.Fixed3D;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(62, 69, 72);
            lblNome.Location = new Point(275, 468);
            lblNome.Margin = new Padding(5, 0, 5, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(85, 34);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome";
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.BackColor = Color.FromArgb(213, 211, 211);
            lblId.BorderStyle = BorderStyle.Fixed3D;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(62, 69, 72);
            lblId.Location = new Point(318, 395);
            lblId.Margin = new Padding(5, 0, 5, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(42, 34);
            lblId.TabIndex = 11;
            lblId.Text = "ID";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(514, 613);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo_background;
            pictureBox1.Location = new Point(159, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(825, 636);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // lblAeroportos
            // 
            lblAeroportos.Anchor = AnchorStyles.None;
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(204, 41);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(318, 72);
            lblAeroportos.TabIndex = 24;
            lblAeroportos.Text = "Aeroportos";
            // 
            // FormAdiAeroporto
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(1120, 761);
            Controls.Add(lblAeroportos);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtBoxCidade);
            Controls.Add(txtBoxNome);
            Controls.Add(txtBoxId);
            Controls.Add(lblCidade);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(pictureBox1);
            Margin = new Padding(5);
            Name = "FormAdiAeroporto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtBoxCidade;
        private TextBox txtBoxNome;
        private TextBox txtBoxId;
        private Label lblCidade;
        private Label lblNome;
        private Label lblId;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private Label lblAeroportos;
    }
}