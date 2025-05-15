namespace Forms
{
    partial class FormEditarBilhetes
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
            txtBoxApelido = new TextBox();
            txtBoxNome = new TextBox();
            comboBoxTipo = new ComboBox();
            comboBoxTarifa = new ComboBox();
            txtBoxVoo = new TextBox();
            btnAlterarLugar = new Button();
            lblLugar = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            lblAeroportos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxApelido
            // 
            txtBoxApelido.Location = new Point(696, 531);
            txtBoxApelido.Name = "txtBoxApelido";
            txtBoxApelido.Size = new Size(243, 39);
            txtBoxApelido.TabIndex = 19;
            txtBoxApelido.Text = "Apelido";
            // 
            // txtBoxNome
            // 
            txtBoxNome.Location = new Point(428, 531);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(243, 39);
            txtBoxNome.TabIndex = 18;
            txtBoxNome.Text = "Nome";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.Enabled = false;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(428, 471);
            comboBoxTipo.Margin = new Padding(5);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(243, 40);
            comboBoxTipo.TabIndex = 17;
            comboBoxTipo.Text = "Adulto";
            // 
            // comboBoxTarifa
            // 
            comboBoxTarifa.FormattingEnabled = true;
            comboBoxTarifa.Location = new Point(696, 471);
            comboBoxTarifa.Margin = new Padding(5);
            comboBoxTarifa.Name = "comboBoxTarifa";
            comboBoxTarifa.Size = new Size(243, 40);
            comboBoxTarifa.TabIndex = 16;
            comboBoxTarifa.Text = "Tarifa";
            // 
            // txtBoxVoo
            // 
            txtBoxVoo.Location = new Point(283, 157);
            txtBoxVoo.Name = "txtBoxVoo";
            txtBoxVoo.Size = new Size(844, 39);
            txtBoxVoo.TabIndex = 20;
            // 
            // btnAlterarLugar
            // 
            btnAlterarLugar.Location = new Point(428, 593);
            btnAlterarLugar.Name = "btnAlterarLugar";
            btnAlterarLugar.Size = new Size(179, 46);
            btnAlterarLugar.TabIndex = 21;
            btnAlterarLugar.Text = "Alterar Lugar";
            btnAlterarLugar.UseVisualStyleBackColor = true;
            btnAlterarLugar.Click += btnAlterarLugar_Click;
            // 
            // lblLugar
            // 
            lblLugar.AutoSize = true;
            lblLugar.BackColor = Color.FromArgb(213, 211, 211);
            lblLugar.Location = new Point(627, 600);
            lblLugar.Name = "lblLugar";
            lblLugar.Size = new Size(73, 32);
            lblLugar.TabIndex = 22;
            lblLugar.Text = "Lugar";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1014, 744);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(835, 744);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_background_bigger;
            pictureBox1.Location = new Point(186, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1042, 764);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // lblAeroportos
            // 
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(283, 38);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(231, 72);
            lblAeroportos.TabIndex = 26;
            lblAeroportos.Text = "Bilhetes";
            // 
            // FormEditarBilhetes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(1433, 903);
            Controls.Add(lblAeroportos);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblLugar);
            Controls.Add(btnAlterarLugar);
            Controls.Add(txtBoxVoo);
            Controls.Add(txtBoxApelido);
            Controls.Add(txtBoxNome);
            Controls.Add(comboBoxTipo);
            Controls.Add(comboBoxTarifa);
            Controls.Add(pictureBox1);
            Name = "FormEditarBilhetes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxApelido;
        private TextBox txtBoxNome;
        private ComboBox comboBoxTipo;
        private ComboBox comboBoxTarifa;
        private TextBox txtBoxVoo;
        private Button btnAlterarLugar;
        private Label lblLugar;
        private Button btnGuardar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private Label lblAeroportos;
    }
}