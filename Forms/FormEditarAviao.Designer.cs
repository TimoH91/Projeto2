namespace Forms
{
    partial class FormEditarAviao
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
            txtBoxAssentosFilas = new TextBox();
            lblAssentosFila = new Label();
            txtBoxFilas = new TextBox();
            txtBoxNome = new TextBox();
            txtBoxMarca = new TextBox();
            txtBoxId = new TextBox();
            lblFilas = new Label();
            Nome = new Label();
            lblMarca = new Label();
            lblId = new Label();
            listBoxVoosFuturo = new ListBox();
            lblVoosFuturo = new Label();
            lblVoosPasado = new Label();
            listBoxVoosPasado = new ListBox();
            btnApagar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblAeroportos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(2046, 865);
            btnGuardar.Margin = new Padding(5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 46);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtBoxAssentosFilas
            // 
            txtBoxAssentosFilas.Anchor = AnchorStyles.None;
            txtBoxAssentosFilas.Location = new Point(494, 823);
            txtBoxAssentosFilas.Margin = new Padding(5);
            txtBoxAssentosFilas.Name = "txtBoxAssentosFilas";
            txtBoxAssentosFilas.Size = new Size(201, 39);
            txtBoxAssentosFilas.TabIndex = 20;
            // 
            // lblAssentosFila
            // 
            lblAssentosFila.Anchor = AnchorStyles.None;
            lblAssentosFila.AutoSize = true;
            lblAssentosFila.BackColor = Color.FromArgb(213, 211, 211);
            lblAssentosFila.BorderStyle = BorderStyle.Fixed3D;
            lblAssentosFila.Location = new Point(294, 823);
            lblAssentosFila.Margin = new Padding(5, 0, 5, 0);
            lblAssentosFila.Name = "lblAssentosFila";
            lblAssentosFila.Size = new Size(192, 34);
            lblAssentosFila.TabIndex = 19;
            lblAssentosFila.Text = "Assentos por fila";
            // 
            // txtBoxFilas
            // 
            txtBoxFilas.Anchor = AnchorStyles.None;
            txtBoxFilas.Location = new Point(494, 743);
            txtBoxFilas.Margin = new Padding(5);
            txtBoxFilas.Name = "txtBoxFilas";
            txtBoxFilas.Size = new Size(201, 39);
            txtBoxFilas.TabIndex = 18;
            // 
            // txtBoxNome
            // 
            txtBoxNome.Anchor = AnchorStyles.None;
            txtBoxNome.Location = new Point(494, 655);
            txtBoxNome.Margin = new Padding(5);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(201, 39);
            txtBoxNome.TabIndex = 17;
            // 
            // txtBoxMarca
            // 
            txtBoxMarca.Anchor = AnchorStyles.None;
            txtBoxMarca.Location = new Point(494, 564);
            txtBoxMarca.Margin = new Padding(5);
            txtBoxMarca.Name = "txtBoxMarca";
            txtBoxMarca.Size = new Size(201, 39);
            txtBoxMarca.TabIndex = 16;
            // 
            // txtBoxId
            // 
            txtBoxId.Anchor = AnchorStyles.None;
            txtBoxId.Enabled = false;
            txtBoxId.Location = new Point(494, 494);
            txtBoxId.Margin = new Padding(5);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(201, 39);
            txtBoxId.TabIndex = 15;
            txtBoxId.Text = "1";
            // 
            // lblFilas
            // 
            lblFilas.Anchor = AnchorStyles.None;
            lblFilas.AutoSize = true;
            lblFilas.BackColor = Color.FromArgb(213, 211, 211);
            lblFilas.BorderStyle = BorderStyle.Fixed3D;
            lblFilas.Location = new Point(299, 743);
            lblFilas.Margin = new Padding(5, 0, 5, 0);
            lblFilas.Name = "lblFilas";
            lblFilas.Size = new Size(187, 34);
            lblFilas.TabIndex = 14;
            lblFilas.Text = "Número de filas";
            // 
            // Nome
            // 
            Nome.Anchor = AnchorStyles.None;
            Nome.AutoSize = true;
            Nome.BackColor = Color.FromArgb(213, 211, 211);
            Nome.BorderStyle = BorderStyle.Fixed3D;
            Nome.Location = new Point(401, 655);
            Nome.Margin = new Padding(5, 0, 5, 0);
            Nome.Name = "Nome";
            Nome.Size = new Size(82, 34);
            Nome.TabIndex = 13;
            Nome.Text = "Nome";
            // 
            // lblMarca
            // 
            lblMarca.Anchor = AnchorStyles.None;
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.FromArgb(213, 211, 211);
            lblMarca.BorderStyle = BorderStyle.Fixed3D;
            lblMarca.Location = new Point(397, 560);
            lblMarca.Margin = new Padding(5, 0, 5, 0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(81, 34);
            lblMarca.TabIndex = 12;
            lblMarca.Text = "Marca";
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.BackColor = Color.FromArgb(213, 211, 211);
            lblId.BorderStyle = BorderStyle.Fixed3D;
            lblId.Location = new Point(439, 493);
            lblId.Margin = new Padding(5, 0, 5, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(39, 34);
            lblId.TabIndex = 11;
            lblId.Text = "ID";
            // 
            // listBoxVoosFuturo
            // 
            listBoxVoosFuturo.Anchor = AnchorStyles.None;
            listBoxVoosFuturo.FormattingEnabled = true;
            listBoxVoosFuturo.Location = new Point(1013, 201);
            listBoxVoosFuturo.Margin = new Padding(5);
            listBoxVoosFuturo.Name = "listBoxVoosFuturo";
            listBoxVoosFuturo.Size = new Size(1186, 260);
            listBoxVoosFuturo.TabIndex = 22;
            // 
            // lblVoosFuturo
            // 
            lblVoosFuturo.Anchor = AnchorStyles.None;
            lblVoosFuturo.AutoSize = true;
            lblVoosFuturo.BackColor = Color.FromArgb(213, 211, 211);
            lblVoosFuturo.BorderStyle = BorderStyle.Fixed3D;
            lblVoosFuturo.Location = new Point(1013, 162);
            lblVoosFuturo.Name = "lblVoosFuturo";
            lblVoosFuturo.Size = new Size(154, 34);
            lblVoosFuturo.TabIndex = 23;
            lblVoosFuturo.Text = "Voos (futuro)";
            // 
            // lblVoosPasado
            // 
            lblVoosPasado.Anchor = AnchorStyles.None;
            lblVoosPasado.AutoSize = true;
            lblVoosPasado.BackColor = Color.FromArgb(213, 211, 211);
            lblVoosPasado.BorderStyle = BorderStyle.Fixed3D;
            lblVoosPasado.Location = new Point(1013, 533);
            lblVoosPasado.Name = "lblVoosPasado";
            lblVoosPasado.Size = new Size(164, 34);
            lblVoosPasado.TabIndex = 24;
            lblVoosPasado.Text = "Voos (pasado)";
            // 
            // listBoxVoosPasado
            // 
            listBoxVoosPasado.Anchor = AnchorStyles.None;
            listBoxVoosPasado.FormattingEnabled = true;
            listBoxVoosPasado.Location = new Point(1013, 581);
            listBoxVoosPasado.Margin = new Padding(5);
            listBoxVoosPasado.Name = "listBoxVoosPasado";
            listBoxVoosPasado.Size = new Size(1186, 260);
            listBoxVoosPasado.TabIndex = 25;
            // 
            // btnApagar
            // 
            btnApagar.Anchor = AnchorStyles.None;
            btnApagar.Location = new Point(2049, 494);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(150, 46);
            btnApagar.TabIndex = 26;
            btnApagar.Text = "Remover Voo";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(1888, 865);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.background_patternb;
            pictureBox1.Location = new Point(962, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1017, 648);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.background_patternb;
            pictureBox2.Location = new Point(1258, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1017, 648);
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = Properties.Resources.background_patternb;
            pictureBox3.Location = new Point(1258, 302);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1017, 648);
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = Properties.Resources.background_patternb;
            pictureBox4.Location = new Point(962, 302);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1017, 648);
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackColor = Color.White;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Image = Properties.Resources.logo_background;
            pictureBox5.Location = new Point(153, 132);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(784, 804);
            pictureBox5.TabIndex = 32;
            pictureBox5.TabStop = false;
            // 
            // lblAeroportos
            // 
            lblAeroportos.Anchor = AnchorStyles.None;
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(209, 100);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(197, 72);
            lblAeroportos.TabIndex = 33;
            lblAeroportos.Text = "Aviões";
            // 
            // FormEditarAviao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(2416, 1091);
            Controls.Add(lblAeroportos);
            Controls.Add(btnCancelar);
            Controls.Add(btnApagar);
            Controls.Add(listBoxVoosPasado);
            Controls.Add(lblVoosPasado);
            Controls.Add(lblVoosFuturo);
            Controls.Add(listBoxVoosFuturo);
            Controls.Add(btnGuardar);
            Controls.Add(txtBoxAssentosFilas);
            Controls.Add(lblAssentosFila);
            Controls.Add(txtBoxFilas);
            Controls.Add(txtBoxNome);
            Controls.Add(txtBoxMarca);
            Controls.Add(txtBoxId);
            Controls.Add(lblFilas);
            Controls.Add(Nome);
            Controls.Add(lblMarca);
            Controls.Add(lblId);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(5);
            Name = "FormEditarAviao";
            //FormClosing += FormEditarAviao_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtBoxAssentosFilas;
        private Label lblAssentosFila;
        private TextBox txtBoxFilas;
        private TextBox txtBoxNome;
        private TextBox txtBoxMarca;
        private TextBox txtBoxId;
        private Label lblFilas;
        private Label Nome;
        private Label lblMarca;
        private Label lblId;
        private ListBox listBoxVoosFuturo;
        private Label lblVoosFuturo;
        private Label lblVoosPasado;
        private ListBox listBoxVoosPasado;
        private Button btnApagar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lblAeroportos;
    }
}