namespace Forms
{
    partial class FormEditarAeroporto
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
            btnGuardar.Location = new Point(767, 638);
            btnGuardar.Margin = new Padding(5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 46);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtBoxCidade
            // 
            txtBoxCidade.Anchor = AnchorStyles.None;
            txtBoxCidade.Location = new Point(397, 524);
            txtBoxCidade.Margin = new Padding(5);
            txtBoxCidade.Name = "txtBoxCidade";
            txtBoxCidade.Size = new Size(462, 39);
            txtBoxCidade.TabIndex = 27;
            // 
            // txtBoxNome
            // 
            txtBoxNome.Anchor = AnchorStyles.None;
            txtBoxNome.Location = new Point(397, 433);
            txtBoxNome.Margin = new Padding(5);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(462, 39);
            txtBoxNome.TabIndex = 26;
            // 
            // txtBoxId
            // 
            txtBoxId.Anchor = AnchorStyles.None;
            txtBoxId.Enabled = false;
            txtBoxId.Location = new Point(397, 363);
            txtBoxId.Margin = new Padding(5);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(201, 39);
            txtBoxId.TabIndex = 25;
            txtBoxId.Text = "1";
            // 
            // lblCidade
            // 
            lblCidade.Anchor = AnchorStyles.None;
            lblCidade.AutoSize = true;
            lblCidade.BackColor = Color.FromArgb(213, 211, 211);
            lblCidade.BorderStyle = BorderStyle.Fixed3D;
            lblCidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCidade.Location = new Point(295, 527);
            lblCidade.Margin = new Padding(5, 0, 5, 0);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(94, 34);
            lblCidade.TabIndex = 24;
            lblCidade.Text = "Cidade";
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.None;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.FromArgb(213, 211, 211);
            lblNome.BorderStyle = BorderStyle.Fixed3D;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.Location = new Point(304, 440);
            lblNome.Margin = new Padding(5, 0, 5, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(85, 34);
            lblNome.TabIndex = 23;
            lblNome.Text = "Nome";
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.BackColor = Color.FromArgb(213, 211, 211);
            lblId.BorderStyle = BorderStyle.Fixed3D;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(347, 366);
            lblId.Margin = new Padding(5, 0, 5, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(42, 34);
            lblId.TabIndex = 22;
            lblId.Text = "ID";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(600, 638);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo_background;
            pictureBox1.Location = new Point(157, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(790, 648);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // lblAeroportos
            // 
            lblAeroportos.Anchor = AnchorStyles.None;
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(191, 20);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(318, 72);
            lblAeroportos.TabIndex = 31;
            lblAeroportos.Text = "Aeroportos";
            // 
            // FormEditarAeroporto
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(1105, 788);
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
            Name = "FormEditarAeroporto";
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