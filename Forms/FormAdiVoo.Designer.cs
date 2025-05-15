namespace Forms
{
    partial class FormAdiVoo
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
            Hora = new Label();
            txtBoxId = new TextBox();
            lblData = new Label();
            lblDestion = new Label();
            lblId = new Label();
            lblOrigem = new Label();
            btnVer = new Button();
            listBoxAvioes = new ListBox();
            dateTimePicker = new DateTimePicker();
            comboBoxDestino = new ComboBox();
            comboBoxOrigem = new ComboBox();
            comboBoxEscala = new ComboBox();
            dateTimePickerHora = new DateTimePicker();
            txtBoxPreco = new TextBox();
            lblDuracao = new Label();
            dateTimePickerDuracao = new DateTimePicker();
            checkBoxEscala = new CheckBox();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblAeroportos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.FromArgb(62, 69, 72);
            btnGuardar.Location = new Point(761, 861);
            btnGuardar.Margin = new Padding(5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 46);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Hora
            // 
            Hora.AutoSize = true;
            Hora.BackColor = Color.FromArgb(213, 211, 211);
            Hora.BorderStyle = BorderStyle.Fixed3D;
            Hora.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Hora.ForeColor = Color.FromArgb(62, 69, 72);
            Hora.Location = new Point(204, 718);
            Hora.Margin = new Padding(5, 0, 5, 0);
            Hora.Name = "Hora";
            Hora.Size = new Size(72, 34);
            Hora.TabIndex = 19;
            Hora.Text = "Hora";
            // 
            // txtBoxId
            // 
            txtBoxId.Enabled = false;
            txtBoxId.Location = new Point(279, 334);
            txtBoxId.Margin = new Padding(5);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(201, 39);
            txtBoxId.TabIndex = 15;
            txtBoxId.Text = "1";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.BackColor = Color.FromArgb(213, 211, 211);
            lblData.BorderStyle = BorderStyle.Fixed3D;
            lblData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblData.ForeColor = Color.FromArgb(62, 69, 72);
            lblData.Location = new Point(207, 657);
            lblData.Margin = new Padding(5, 0, 5, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(69, 34);
            lblData.TabIndex = 14;
            lblData.Text = "Data";
            // 
            // lblDestion
            // 
            lblDestion.AutoSize = true;
            lblDestion.BackColor = Color.FromArgb(213, 211, 211);
            lblDestion.BorderStyle = BorderStyle.Fixed3D;
            lblDestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDestion.ForeColor = Color.FromArgb(62, 69, 72);
            lblDestion.Location = new Point(172, 535);
            lblDestion.Margin = new Padding(5, 0, 5, 0);
            lblDestion.Name = "lblDestion";
            lblDestion.Size = new Size(104, 34);
            lblDestion.TabIndex = 13;
            lblDestion.Text = "Destino";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.FromArgb(213, 211, 211);
            lblId.BorderStyle = BorderStyle.Fixed3D;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(62, 69, 72);
            lblId.Location = new Point(229, 337);
            lblId.Margin = new Padding(5, 0, 5, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(42, 34);
            lblId.TabIndex = 11;
            lblId.Text = "ID";
            // 
            // lblOrigem
            // 
            lblOrigem.AutoSize = true;
            lblOrigem.BackColor = Color.FromArgb(213, 211, 211);
            lblOrigem.BorderStyle = BorderStyle.Fixed3D;
            lblOrigem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOrigem.ForeColor = Color.FromArgb(62, 69, 72);
            lblOrigem.Location = new Point(175, 402);
            lblOrigem.Margin = new Padding(5, 0, 5, 0);
            lblOrigem.Name = "lblOrigem";
            lblOrigem.Size = new Size(101, 34);
            lblOrigem.TabIndex = 12;
            lblOrigem.Text = "Origem";
            // 
            // btnVer
            // 
            btnVer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVer.ForeColor = Color.FromArgb(62, 69, 72);
            btnVer.Location = new Point(1196, 860);
            btnVer.Margin = new Padding(5);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(306, 46);
            btnVer.TabIndex = 24;
            btnVer.Text = "Ver Aviões Disponivéis ";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // listBoxAvioes
            // 
            listBoxAvioes.FormattingEnabled = true;
            listBoxAvioes.Location = new Point(1021, 78);
            listBoxAvioes.Margin = new Padding(5);
            listBoxAvioes.Name = "listBoxAvioes";
            listBoxAvioes.Size = new Size(644, 740);
            listBoxAvioes.TabIndex = 25;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(280, 657);
            dateTimePicker.Margin = new Padding(5);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(404, 39);
            dateTimePicker.TabIndex = 27;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(280, 532);
            comboBoxDestino.Margin = new Padding(5);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(634, 40);
            comboBoxDestino.TabIndex = 29;
            comboBoxDestino.Text = "Destino";
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new Point(279, 402);
            comboBoxOrigem.Margin = new Padding(5);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new Size(634, 40);
            comboBoxOrigem.TabIndex = 28;
            comboBoxOrigem.Text = "Origem";
            // 
            // comboBoxEscala
            // 
            comboBoxEscala.Enabled = false;
            comboBoxEscala.FormattingEnabled = true;
            comboBoxEscala.Location = new Point(279, 468);
            comboBoxEscala.Margin = new Padding(5);
            comboBoxEscala.Name = "comboBoxEscala";
            comboBoxEscala.Size = new Size(634, 40);
            comboBoxEscala.TabIndex = 30;
            comboBoxEscala.Text = "Escala";
            // 
            // dateTimePickerHora
            // 
            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.Location = new Point(280, 718);
            dateTimePickerHora.Margin = new Padding(5);
            dateTimePickerHora.Name = "dateTimePickerHora";
            dateTimePickerHora.ShowUpDown = true;
            dateTimePickerHora.Size = new Size(404, 39);
            dateTimePickerHora.TabIndex = 31;
            // 
            // txtBoxPreco
            // 
            txtBoxPreco.Location = new Point(280, 779);
            txtBoxPreco.Margin = new Padding(5);
            txtBoxPreco.Name = "txtBoxPreco";
            txtBoxPreco.Size = new Size(201, 39);
            txtBoxPreco.TabIndex = 32;
            txtBoxPreco.Text = "Preço Base";
            // 
            // lblDuracao
            // 
            lblDuracao.AutoSize = true;
            lblDuracao.BackColor = Color.FromArgb(213, 211, 211);
            lblDuracao.BorderStyle = BorderStyle.Fixed3D;
            lblDuracao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDuracao.ForeColor = Color.FromArgb(62, 69, 72);
            lblDuracao.Location = new Point(164, 599);
            lblDuracao.Margin = new Padding(5, 0, 5, 0);
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(112, 34);
            lblDuracao.TabIndex = 34;
            lblDuracao.Text = "Duração";
            // 
            // dateTimePickerDuracao
            // 
            dateTimePickerDuracao.Format = DateTimePickerFormat.Time;
            dateTimePickerDuracao.Location = new Point(280, 599);
            dateTimePickerDuracao.Name = "dateTimePickerDuracao";
            dateTimePickerDuracao.ShowUpDown = true;
            dateTimePickerDuracao.Size = new Size(400, 39);
            dateTimePickerDuracao.TabIndex = 35;
            // 
            // checkBoxEscala
            // 
            checkBoxEscala.AutoSize = true;
            checkBoxEscala.BackColor = Color.FromArgb(213, 211, 211);
            checkBoxEscala.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBoxEscala.Location = new Point(161, 468);
            checkBoxEscala.Name = "checkBoxEscala";
            checkBoxEscala.Size = new Size(115, 36);
            checkBoxEscala.TabIndex = 36;
            checkBoxEscala.Text = "Escala";
            checkBoxEscala.UseVisualStyleBackColor = false;
            checkBoxEscala.CheckStateChanged += checkBoxEscala_CheckStateChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(62, 69, 72);
            btnCancelar.Location = new Point(599, 861);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_background;
            pictureBox1.Location = new Point(148, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(785, 897);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.background_patternb;
            pictureBox2.Location = new Point(967, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(761, 626);
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.background_patternb;
            pictureBox3.Location = new Point(967, 599);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(761, 326);
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            // 
            // lblAeroportos
            // 
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(204, -8);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(152, 72);
            lblAeroportos.TabIndex = 41;
            lblAeroportos.Text = "Voos";
            // 
            // FormAdiVoo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(1901, 953);
            Controls.Add(lblAeroportos);
            Controls.Add(btnCancelar);
            Controls.Add(checkBoxEscala);
            Controls.Add(dateTimePickerDuracao);
            Controls.Add(lblDuracao);
            Controls.Add(txtBoxPreco);
            Controls.Add(dateTimePickerHora);
            Controls.Add(comboBoxEscala);
            Controls.Add(comboBoxDestino);
            Controls.Add(comboBoxOrigem);
            Controls.Add(dateTimePicker);
            Controls.Add(listBoxAvioes);
            Controls.Add(btnVer);
            Controls.Add(btnGuardar);
            Controls.Add(Hora);
            Controls.Add(txtBoxId);
            Controls.Add(lblData);
            Controls.Add(lblDestion);
            Controls.Add(lblOrigem);
            Controls.Add(lblId);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Margin = new Padding(5);
            Name = "FormAdiVoo";
            //Load += FormAdiVoo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label Hora;
        private TextBox txtBoxId;
        private Label lblData;
        private Label lblDestion;
        private Label lblId;
        private Label lblOrigem;
        private Button btnVer;
        private ListBox listBoxAvioes;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxDestino;
        private ComboBox comboBoxOrigem;
        private ComboBox comboBoxEscala;
        private DateTimePicker dateTimePickerHora;
        private TextBox txtBoxPreco;
        private Label lblDuracao;
        private DateTimePicker dateTimePickerDuracao;
        private CheckBox checkBoxEscala;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblAeroportos;
    }
}