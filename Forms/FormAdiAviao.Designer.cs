namespace Forms
{
    partial class FormAdiAviao
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
            lblId = new Label();
            lblMarca = new Label();
            Nome = new Label();
            lblFilas = new Label();
            txtBoxId = new TextBox();
            txtBoxMarca = new TextBox();
            txtBoxNome = new TextBox();
            txtBoxFilas = new TextBox();
            lblAssentosFila = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtBoxAssentosFilas = new TextBox();
            pictureBox2 = new PictureBox();
            lblAeroportos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.BackColor = Color.FromArgb(213, 211, 211);
            lblId.BorderStyle = BorderStyle.Fixed3D;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(62, 69, 72);
            lblId.Location = new Point(323, 370);
            lblId.Margin = new Padding(5, 0, 5, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(42, 34);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblMarca
            // 
            lblMarca.Anchor = AnchorStyles.None;
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.FromArgb(213, 211, 211);
            lblMarca.BorderStyle = BorderStyle.Fixed3D;
            lblMarca.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMarca.ForeColor = Color.FromArgb(62, 69, 72);
            lblMarca.Location = new Point(276, 440);
            lblMarca.Margin = new Padding(5, 0, 5, 0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(87, 34);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // Nome
            // 
            Nome.Anchor = AnchorStyles.None;
            Nome.AutoSize = true;
            Nome.BackColor = Color.FromArgb(213, 211, 211);
            Nome.BorderStyle = BorderStyle.Fixed3D;
            Nome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Nome.ForeColor = Color.FromArgb(62, 69, 72);
            Nome.Location = new Point(276, 507);
            Nome.Margin = new Padding(5, 0, 5, 0);
            Nome.Name = "Nome";
            Nome.Size = new Size(85, 34);
            Nome.TabIndex = 2;
            Nome.Text = "Nome";
            // 
            // lblFilas
            // 
            lblFilas.Anchor = AnchorStyles.None;
            lblFilas.AutoSize = true;
            lblFilas.BackColor = Color.FromArgb(213, 211, 211);
            lblFilas.BorderStyle = BorderStyle.Fixed3D;
            lblFilas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFilas.ForeColor = Color.FromArgb(62, 69, 72);
            lblFilas.Location = new Point(166, 572);
            lblFilas.Margin = new Padding(5, 0, 5, 0);
            lblFilas.Name = "lblFilas";
            lblFilas.Size = new Size(199, 34);
            lblFilas.TabIndex = 3;
            lblFilas.Text = "Número de filas";
            // 
            // txtBoxId
            // 
            txtBoxId.Anchor = AnchorStyles.None;
            txtBoxId.Enabled = false;
            txtBoxId.Location = new Point(373, 370);
            txtBoxId.Margin = new Padding(5);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(201, 39);
            txtBoxId.TabIndex = 4;
            txtBoxId.Text = "1";
            // 
            // txtBoxMarca
            // 
            txtBoxMarca.Anchor = AnchorStyles.None;
            txtBoxMarca.Location = new Point(373, 440);
            txtBoxMarca.Margin = new Padding(5);
            txtBoxMarca.Name = "txtBoxMarca";
            txtBoxMarca.Size = new Size(489, 39);
            txtBoxMarca.TabIndex = 5;
            // 
            // txtBoxNome
            // 
            txtBoxNome.Anchor = AnchorStyles.None;
            txtBoxNome.Location = new Point(373, 507);
            txtBoxNome.Margin = new Padding(5);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(489, 39);
            txtBoxNome.TabIndex = 6;
            // 
            // txtBoxFilas
            // 
            txtBoxFilas.Anchor = AnchorStyles.None;
            txtBoxFilas.Location = new Point(373, 572);
            txtBoxFilas.Margin = new Padding(5);
            txtBoxFilas.Name = "txtBoxFilas";
            txtBoxFilas.Size = new Size(201, 39);
            txtBoxFilas.TabIndex = 7;
            // 
            // lblAssentosFila
            // 
            lblAssentosFila.Anchor = AnchorStyles.None;
            lblAssentosFila.AutoSize = true;
            lblAssentosFila.BackColor = Color.FromArgb(213, 211, 211);
            lblAssentosFila.BorderStyle = BorderStyle.Fixed3D;
            lblAssentosFila.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAssentosFila.ForeColor = Color.FromArgb(62, 69, 72);
            lblAssentosFila.Location = new Point(157, 636);
            lblAssentosFila.Margin = new Padding(5, 0, 5, 0);
            lblAssentosFila.Name = "lblAssentosFila";
            lblAssentosFila.Size = new Size(208, 34);
            lblAssentosFila.TabIndex = 8;
            lblAssentosFila.Text = "Assentos por fila";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(62, 69, 72);
            btnCancelar.Location = new Point(569, 792);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.FromArgb(62, 69, 72);
            btnGuardar.Location = new Point(736, 792);
            btnGuardar.Margin = new Padding(5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 46);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtBoxAssentosFilas
            // 
            txtBoxAssentosFilas.Anchor = AnchorStyles.None;
            txtBoxAssentosFilas.Location = new Point(373, 636);
            txtBoxAssentosFilas.Margin = new Padding(5);
            txtBoxAssentosFilas.Name = "txtBoxAssentosFilas";
            txtBoxAssentosFilas.Size = new Size(201, 39);
            txtBoxAssentosFilas.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.logo_background;
            pictureBox2.Location = new Point(128, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(783, 840);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // lblAeroportos
            // 
            lblAeroportos.Anchor = AnchorStyles.None;
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(166, 5);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(197, 72);
            lblAeroportos.TabIndex = 14;
            lblAeroportos.Text = "Aviões";
            // 
            // FormAdiAviao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(1030, 900);
            Controls.Add(lblAeroportos);
            Controls.Add(txtBoxAssentosFilas);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtBoxFilas);
            Controls.Add(lblAssentosFila);
            Controls.Add(lblId);
            Controls.Add(lblMarca);
            Controls.Add(txtBoxNome);
            Controls.Add(Nome);
            Controls.Add(txtBoxMarca);
            Controls.Add(lblFilas);
            Controls.Add(txtBoxId);
            Controls.Add(pictureBox2);
            Margin = new Padding(5);
            Name = "FormAdiAviao";
            //Load += FormAdiAviao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblId;
        private Label lblMarca;
        private Label Nome;
        private Label lblFilas;
        private TextBox txtBoxId;
        private TextBox txtBoxMarca;
        private TextBox txtBoxNome;
        private TextBox txtBoxFilas;
        private Label lblAssentosFila;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtBoxAssentosFilas;
        private PictureBox pictureBox2;
        private Label lblAeroportos;
    }
}