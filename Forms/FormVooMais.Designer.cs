namespace Forms
{
    partial class FormVooMais
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
            listBoxBilhetesVoo = new ListBox();
            lblNumero = new Label();
            lblData = new Label();
            lblHora = new Label();
            lblDuração = new Label();
            lblPrecoBase = new Label();
            lblAviao = new Label();
            lblOrigem = new Label();
            lblDestino = new Label();
            labelLugaresDisponíveis = new Label();
            labelLugaresOcupados = new Label();
            textBoxNum = new TextBox();
            textBoxPrecoBase = new TextBox();
            textBoxLugaresD = new TextBox();
            textBoxLugaresO = new TextBox();
            comboBoxAviao = new ComboBox();
            comboBoxOrigem = new ComboBox();
            comboBoxDestino = new ComboBox();
            comboBoxEscala = new ComboBox();
            dateTimePickerData = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            checkBoxEscala = new CheckBox();
            lblNumAdultos = new Label();
            lblNumCrianca = new Label();
            lblNumBebes = new Label();
            txtBoxAdultos = new TextBox();
            txtBoxCriancas = new TextBox();
            txtBoxBebes = new TextBox();
            dateTimePickerDuracao = new DateTimePicker();
            dateTimePickerHora = new DateTimePicker();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblAeroportos = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBoxBilhetesVoo
            // 
            listBoxBilhetesVoo.Anchor = AnchorStyles.None;
            listBoxBilhetesVoo.FormattingEnabled = true;
            listBoxBilhetesVoo.Location = new Point(950, 285);
            listBoxBilhetesVoo.Name = "listBoxBilhetesVoo";
            listBoxBilhetesVoo.Size = new Size(954, 484);
            listBoxBilhetesVoo.TabIndex = 0;
            // 
            // lblNumero
            // 
            lblNumero.Anchor = AnchorStyles.None;
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.FromArgb(213, 211, 211);
            lblNumero.BorderStyle = BorderStyle.Fixed3D;
            lblNumero.Cursor = Cursors.IBeam;
            lblNumero.Location = new Point(175, 351);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(104, 34);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero";
            // 
            // lblData
            // 
            lblData.Anchor = AnchorStyles.None;
            lblData.AutoSize = true;
            lblData.BackColor = Color.FromArgb(213, 211, 211);
            lblData.BorderStyle = BorderStyle.Fixed3D;
            lblData.Cursor = Cursors.IBeam;
            lblData.Location = new Point(212, 420);
            lblData.Name = "lblData";
            lblData.Size = new Size(65, 34);
            lblData.TabIndex = 2;
            lblData.Text = "Data";
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.None;
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.FromArgb(213, 211, 211);
            lblHora.BorderStyle = BorderStyle.Fixed3D;
            lblHora.Cursor = Cursors.IBeam;
            lblHora.Location = new Point(206, 482);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(67, 34);
            lblHora.TabIndex = 3;
            lblHora.Text = "Hora";
            // 
            // lblDuração
            // 
            lblDuração.Anchor = AnchorStyles.None;
            lblDuração.AutoSize = true;
            lblDuração.BackColor = Color.FromArgb(213, 211, 211);
            lblDuração.BorderStyle = BorderStyle.Fixed3D;
            lblDuração.Cursor = Cursors.IBeam;
            lblDuração.Location = new Point(175, 538);
            lblDuração.Name = "lblDuração";
            lblDuração.Size = new Size(104, 34);
            lblDuração.TabIndex = 4;
            lblDuração.Text = "Duração";
            // 
            // lblPrecoBase
            // 
            lblPrecoBase.Anchor = AnchorStyles.None;
            lblPrecoBase.AutoSize = true;
            lblPrecoBase.BackColor = Color.FromArgb(213, 211, 211);
            lblPrecoBase.BorderStyle = BorderStyle.Fixed3D;
            lblPrecoBase.Cursor = Cursors.IBeam;
            lblPrecoBase.Location = new Point(148, 601);
            lblPrecoBase.Name = "lblPrecoBase";
            lblPrecoBase.Size = new Size(131, 34);
            lblPrecoBase.TabIndex = 5;
            lblPrecoBase.Text = "Preço base";
            // 
            // lblAviao
            // 
            lblAviao.Anchor = AnchorStyles.None;
            lblAviao.AutoSize = true;
            lblAviao.BackColor = Color.FromArgb(213, 211, 211);
            lblAviao.BorderStyle = BorderStyle.Fixed3D;
            lblAviao.Cursor = Cursors.IBeam;
            lblAviao.Location = new Point(206, 658);
            lblAviao.Name = "lblAviao";
            lblAviao.Size = new Size(75, 34);
            lblAviao.TabIndex = 6;
            lblAviao.Text = "Aviao";
            // 
            // lblOrigem
            // 
            lblOrigem.Anchor = AnchorStyles.None;
            lblOrigem.AutoSize = true;
            lblOrigem.BackColor = Color.FromArgb(213, 211, 211);
            lblOrigem.BorderStyle = BorderStyle.Fixed3D;
            lblOrigem.Cursor = Cursors.IBeam;
            lblOrigem.Location = new Point(183, 709);
            lblOrigem.Name = "lblOrigem";
            lblOrigem.Size = new Size(96, 34);
            lblOrigem.TabIndex = 7;
            lblOrigem.Text = "Origem";
            // 
            // lblDestino
            // 
            lblDestino.Anchor = AnchorStyles.None;
            lblDestino.AutoSize = true;
            lblDestino.BackColor = Color.FromArgb(213, 211, 211);
            lblDestino.BorderStyle = BorderStyle.Fixed3D;
            lblDestino.Cursor = Cursors.IBeam;
            lblDestino.Location = new Point(183, 764);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(98, 34);
            lblDestino.TabIndex = 8;
            lblDestino.Text = "Destino";
            // 
            // labelLugaresDisponíveis
            // 
            labelLugaresDisponíveis.Anchor = AnchorStyles.None;
            labelLugaresDisponíveis.AutoSize = true;
            labelLugaresDisponíveis.BackColor = Color.FromArgb(213, 211, 211);
            labelLugaresDisponíveis.BorderStyle = BorderStyle.Fixed3D;
            labelLugaresDisponíveis.Cursor = Cursors.IBeam;
            labelLugaresDisponíveis.Location = new Point(140, 886);
            labelLugaresDisponíveis.Name = "labelLugaresDisponíveis";
            labelLugaresDisponíveis.Size = new Size(227, 34);
            labelLugaresDisponíveis.TabIndex = 10;
            labelLugaresDisponíveis.Text = "Lugares Disponíveis";
            // 
            // labelLugaresOcupados
            // 
            labelLugaresOcupados.Anchor = AnchorStyles.None;
            labelLugaresOcupados.AutoSize = true;
            labelLugaresOcupados.BackColor = Color.FromArgb(213, 211, 211);
            labelLugaresOcupados.BorderStyle = BorderStyle.Fixed3D;
            labelLugaresOcupados.Cursor = Cursors.IBeam;
            labelLugaresOcupados.Location = new Point(155, 931);
            labelLugaresOcupados.Name = "labelLugaresOcupados";
            labelLugaresOcupados.Size = new Size(212, 34);
            labelLugaresOcupados.TabIndex = 11;
            labelLugaresOcupados.Text = "Lugares Ocupados";
            // 
            // textBoxNum
            // 
            textBoxNum.Anchor = AnchorStyles.None;
            textBoxNum.Enabled = false;
            textBoxNum.Location = new Point(285, 351);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(200, 39);
            textBoxNum.TabIndex = 12;
            // 
            // textBoxPrecoBase
            // 
            textBoxPrecoBase.Anchor = AnchorStyles.None;
            textBoxPrecoBase.Location = new Point(285, 601);
            textBoxPrecoBase.Name = "textBoxPrecoBase";
            textBoxPrecoBase.Size = new Size(200, 39);
            textBoxPrecoBase.TabIndex = 16;
            // 
            // textBoxLugaresD
            // 
            textBoxLugaresD.Anchor = AnchorStyles.None;
            textBoxLugaresD.Enabled = false;
            textBoxLugaresD.Location = new Point(373, 886);
            textBoxLugaresD.Name = "textBoxLugaresD";
            textBoxLugaresD.Size = new Size(200, 39);
            textBoxLugaresD.TabIndex = 18;
            // 
            // textBoxLugaresO
            // 
            textBoxLugaresO.Anchor = AnchorStyles.None;
            textBoxLugaresO.Enabled = false;
            textBoxLugaresO.Location = new Point(373, 931);
            textBoxLugaresO.Name = "textBoxLugaresO";
            textBoxLugaresO.Size = new Size(200, 39);
            textBoxLugaresO.TabIndex = 19;
            // 
            // comboBoxAviao
            // 
            comboBoxAviao.Anchor = AnchorStyles.None;
            comboBoxAviao.Enabled = false;
            comboBoxAviao.FormattingEnabled = true;
            comboBoxAviao.Location = new Point(283, 658);
            comboBoxAviao.Name = "comboBoxAviao";
            comboBoxAviao.Size = new Size(417, 40);
            comboBoxAviao.TabIndex = 20;
            //comboBoxAviao.SelectedIndexChanged += comboBoxAviao_SelectedIndexChanged;
            comboBoxAviao.MouseClick += comboBoxAviao_MouseClick;
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.Anchor = AnchorStyles.None;
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new Point(283, 709);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new Size(417, 40);
            comboBoxOrigem.TabIndex = 21;
            comboBoxOrigem.MouseClick += comboBoxOrigem_MouseClick;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.Anchor = AnchorStyles.None;
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(283, 764);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(417, 40);
            comboBoxDestino.TabIndex = 22;
            comboBoxDestino.MouseClick += comboBoxDestino_MouseClick;
            // 
            // comboBoxEscala
            // 
            comboBoxEscala.Anchor = AnchorStyles.None;
            comboBoxEscala.Enabled = false;
            comboBoxEscala.FormattingEnabled = true;
            comboBoxEscala.Location = new Point(283, 824);
            comboBoxEscala.Name = "comboBoxEscala";
            comboBoxEscala.Size = new Size(417, 40);
            comboBoxEscala.TabIndex = 23;
            comboBoxEscala.MouseClick += comboBoxEscala_MouseClick;
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Anchor = AnchorStyles.None;
            dateTimePickerData.Location = new Point(283, 420);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(400, 39);
            dateTimePickerData.TabIndex = 24;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(1754, 787);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(1586, 787);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // checkBoxEscala
            // 
            checkBoxEscala.Anchor = AnchorStyles.None;
            checkBoxEscala.AutoSize = true;
            checkBoxEscala.BackColor = Color.FromArgb(224, 224, 224);
            checkBoxEscala.Location = new Point(245, 831);
            checkBoxEscala.Name = "checkBoxEscala";
            checkBoxEscala.Size = new Size(28, 27);
            checkBoxEscala.TabIndex = 28;
            checkBoxEscala.UseVisualStyleBackColor = false;
            checkBoxEscala.CheckStateChanged += checkBoxEscala_CheckStateChanged;
            // 
            // lblNumAdultos
            // 
            lblNumAdultos.Anchor = AnchorStyles.None;
            lblNumAdultos.AutoSize = true;
            lblNumAdultos.BackColor = Color.FromArgb(213, 211, 211);
            lblNumAdultos.BorderStyle = BorderStyle.Fixed3D;
            lblNumAdultos.Location = new Point(1274, 240);
            lblNumAdultos.Name = "lblNumAdultos";
            lblNumAdultos.Size = new Size(97, 34);
            lblNumAdultos.TabIndex = 30;
            lblNumAdultos.Text = "Adultos";
            // 
            // lblNumCrianca
            // 
            lblNumCrianca.Anchor = AnchorStyles.None;
            lblNumCrianca.AutoSize = true;
            lblNumCrianca.BackColor = Color.FromArgb(213, 211, 211);
            lblNumCrianca.BorderStyle = BorderStyle.Fixed3D;
            lblNumCrianca.Location = new Point(1472, 239);
            lblNumCrianca.Name = "lblNumCrianca";
            lblNumCrianca.Size = new Size(104, 34);
            lblNumCrianca.TabIndex = 31;
            lblNumCrianca.Text = "Crianças";
            // 
            // lblNumBebes
            // 
            lblNumBebes.Anchor = AnchorStyles.None;
            lblNumBebes.AutoSize = true;
            lblNumBebes.BackColor = Color.FromArgb(213, 211, 211);
            lblNumBebes.BorderStyle = BorderStyle.Fixed3D;
            lblNumBebes.Location = new Point(1695, 238);
            lblNumBebes.Name = "lblNumBebes";
            lblNumBebes.Size = new Size(80, 34);
            lblNumBebes.TabIndex = 32;
            lblNumBebes.Text = "Bebes";
            // 
            // txtBoxAdultos
            // 
            txtBoxAdultos.Anchor = AnchorStyles.None;
            txtBoxAdultos.Enabled = false;
            txtBoxAdultos.Location = new Point(1375, 237);
            txtBoxAdultos.Name = "txtBoxAdultos";
            txtBoxAdultos.Size = new Size(91, 39);
            txtBoxAdultos.TabIndex = 33;
            // 
            // txtBoxCriancas
            // 
            txtBoxCriancas.Anchor = AnchorStyles.None;
            txtBoxCriancas.Enabled = false;
            txtBoxCriancas.Location = new Point(1586, 236);
            txtBoxCriancas.Name = "txtBoxCriancas";
            txtBoxCriancas.Size = new Size(91, 39);
            txtBoxCriancas.TabIndex = 34;
            // 
            // txtBoxBebes
            // 
            txtBoxBebes.Anchor = AnchorStyles.None;
            txtBoxBebes.Enabled = false;
            txtBoxBebes.Location = new Point(1788, 238);
            txtBoxBebes.Name = "txtBoxBebes";
            txtBoxBebes.Size = new Size(91, 39);
            txtBoxBebes.TabIndex = 35;
            // 
            // dateTimePickerDuracao
            // 
            dateTimePickerDuracao.Anchor = AnchorStyles.None;
            dateTimePickerDuracao.Format = DateTimePickerFormat.Time;
            dateTimePickerDuracao.Location = new Point(283, 538);
            dateTimePickerDuracao.Name = "dateTimePickerDuracao";
            dateTimePickerDuracao.Size = new Size(400, 39);
            dateTimePickerDuracao.TabIndex = 36;
            // 
            // dateTimePickerHora
            // 
            dateTimePickerHora.Anchor = AnchorStyles.None;
            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.Location = new Point(279, 482);
            dateTimePickerHora.Name = "dateTimePickerHora";
            dateTimePickerHora.Size = new Size(400, 39);
            dateTimePickerHora.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo_background;
            pictureBox1.Location = new Point(120, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(756, 955);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.background_patternb;
            pictureBox2.Location = new Point(922, 214);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1004, 955);
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // lblAeroportos
            // 
            lblAeroportos.Anchor = AnchorStyles.None;
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(159, 32);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(152, 72);
            lblAeroportos.TabIndex = 40;
            lblAeroportos.Text = "Voos";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(950, 178);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 72);
            label1.TabIndex = 41;
            label1.Text = "Bilhetes";
            // 
            // FormVooMais
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(2039, 1051);
            Controls.Add(label1);
            Controls.Add(lblAeroportos);
            Controls.Add(dateTimePickerHora);
            Controls.Add(dateTimePickerDuracao);
            Controls.Add(txtBoxBebes);
            Controls.Add(txtBoxCriancas);
            Controls.Add(txtBoxAdultos);
            Controls.Add(lblNumBebes);
            Controls.Add(lblNumCrianca);
            Controls.Add(lblNumAdultos);
            Controls.Add(checkBoxEscala);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dateTimePickerData);
            Controls.Add(comboBoxEscala);
            Controls.Add(comboBoxDestino);
            Controls.Add(comboBoxOrigem);
            Controls.Add(comboBoxAviao);
            Controls.Add(textBoxLugaresO);
            Controls.Add(textBoxLugaresD);
            Controls.Add(textBoxPrecoBase);
            Controls.Add(textBoxNum);
            Controls.Add(labelLugaresOcupados);
            Controls.Add(labelLugaresDisponíveis);
            Controls.Add(lblDestino);
            Controls.Add(lblOrigem);
            Controls.Add(lblAviao);
            Controls.Add(lblPrecoBase);
            Controls.Add(lblDuração);
            Controls.Add(lblHora);
            Controls.Add(lblData);
            Controls.Add(lblNumero);
            Controls.Add(listBoxBilhetesVoo);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "FormVooMais";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBilhetesVoo;
        private Label lblNumero;
        private Label lblData;
        private Label lblHora;
        private Label lblDuração;
        private Label lblPrecoBase;
        private Label lblAviao;
        private Label lblOrigem;
        private Label lblDestino;
        private Label labelLugaresDisponíveis;
        private Label labelLugaresOcupados;
        private TextBox textBoxNum;
        private TextBox textBoxPrecoBase;
        private TextBox textBoxLugaresD;
        private TextBox textBoxLugaresO;
        private ComboBox comboBoxAviao;
        private ComboBox comboBoxOrigem;
        private ComboBox comboBoxDestino;
        private ComboBox comboBoxEscala;
        private DateTimePicker dateTimePickerData;
        private Button btnGuardar;
        private Button btnCancelar;
        private CheckBox checkBoxEscala;
        private Label lblNumAdultos;
        private Label lblNumCrianca;
        private Label lblNumBebes;
        private TextBox txtBoxAdultos;
        private TextBox txtBoxCriancas;
        private TextBox txtBoxBebes;
        private DateTimePicker dateTimePickerDuracao;
        private DateTimePicker dateTimePickerHora;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblAeroportos;
        private Label label1;
    }
}