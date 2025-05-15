namespace Forms
{
    partial class FormComprarBilhetes
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
            comboBoxOrigem = new ComboBox();
            comboBoxDestino = new ComboBox();
            dateTimePickerIda = new DateTimePicker();
            buttonComprar = new Button();
            buttonCancelar = new Button();
            comboBoxTarifa = new ComboBox();
            txtBoxId = new TextBox();
            comboBoxTipo = new ComboBox();
            btnAtualizar = new Button();
            txtBoxNome = new TextBox();
            txtBoxApelido = new TextBox();
            listBoxCesta = new ListBox();
            lblLugar = new Label();
            listBoxVoosRegresso = new ListBox();
            btnEscolherLugarRegresso = new Button();
            lblLugarDisplay = new Label();
            checkBoxRegresso = new CheckBox();
            dateTimePickerRegresso = new DateTimePicker();
            btnPesquisaRegresso = new Button();
            btnCestaRegresso = new Button();
            lblPrecoRegresso = new Label();
            txtBoxPrecoRegresso = new TextBox();
            listBoxVoos = new ListBox();
            pictureBox1 = new PictureBox();
            lblAeroportos = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            dataGridViewVoosIda = new DataGridView();
            dataGridViewVoosRegresso = new DataGridView();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            checkBoxDiretoRegresso = new CheckBox();
            panel2 = new Panel();
            checkBoxDireto = new CheckBox();
            btnLugar = new Button();
            btnCesta = new Button();
            labelPreco = new Label();
            textBoxPreco = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoosIda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoosRegresso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.Anchor = AnchorStyles.None;
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new Point(75, 608);
            comboBoxOrigem.Margin = new Padding(5);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new Size(687, 40);
            comboBoxOrigem.TabIndex = 0;
            comboBoxOrigem.Text = "Origem";
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.Anchor = AnchorStyles.None;
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(75, 660);
            comboBoxDestino.Margin = new Padding(5);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(687, 40);
            comboBoxDestino.TabIndex = 1;
            comboBoxDestino.Text = "Destino";
            // 
            // dateTimePickerIda
            // 
            dateTimePickerIda.Anchor = AnchorStyles.None;
            dateTimePickerIda.Location = new Point(190, 529);
            dateTimePickerIda.Margin = new Padding(5);
            dateTimePickerIda.Name = "dateTimePickerIda";
            dateTimePickerIda.Size = new Size(404, 39);
            dateTimePickerIda.TabIndex = 3;
            // 
            // buttonComprar
            // 
            buttonComprar.Anchor = AnchorStyles.None;
            buttonComprar.Location = new Point(661, 1067);
            buttonComprar.Margin = new Padding(5);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(128, 46);
            buttonComprar.TabIndex = 5;
            buttonComprar.Text = "Cesta";
            buttonComprar.UseVisualStyleBackColor = true;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.None;
            buttonCancelar.Location = new Point(498, 1067);
            buttonCancelar.Margin = new Padding(5);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(153, 46);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // comboBoxTarifa
            // 
            comboBoxTarifa.Anchor = AnchorStyles.None;
            comboBoxTarifa.FormattingEnabled = true;
            comboBoxTarifa.Location = new Point(75, 738);
            comboBoxTarifa.Margin = new Padding(5);
            comboBoxTarifa.Name = "comboBoxTarifa";
            comboBoxTarifa.Size = new Size(243, 40);
            comboBoxTarifa.TabIndex = 7;
            comboBoxTarifa.Text = "Tarifa";
            // 
            // txtBoxId
            // 
            txtBoxId.Anchor = AnchorStyles.None;
            txtBoxId.BackColor = Color.FromArgb(213, 211, 211);
            txtBoxId.Enabled = false;
            txtBoxId.Location = new Point(75, 531);
            txtBoxId.Margin = new Padding(5);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(43, 39);
            txtBoxId.TabIndex = 8;
            txtBoxId.Text = "1";
            txtBoxId.Visible = false;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.Anchor = AnchorStyles.None;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(351, 738);
            comboBoxTipo.Margin = new Padding(5);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(243, 40);
            comboBoxTipo.TabIndex = 9;
            comboBoxTipo.Text = "Adulto";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.None;
            btnAtualizar.Location = new Point(609, 524);
            btnAtualizar.Margin = new Padding(5);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(153, 46);
            btnAtualizar.TabIndex = 11;
            btnAtualizar.Text = "Pesquisa";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnPesquisa_Click;
            // 
            // txtBoxNome
            // 
            txtBoxNome.Anchor = AnchorStyles.None;
            txtBoxNome.Location = new Point(74, 796);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(243, 39);
            txtBoxNome.TabIndex = 14;
            txtBoxNome.Text = "Nome";
            // 
            // txtBoxApelido
            // 
            txtBoxApelido.Anchor = AnchorStyles.None;
            txtBoxApelido.Location = new Point(351, 796);
            txtBoxApelido.Name = "txtBoxApelido";
            txtBoxApelido.Size = new Size(243, 39);
            txtBoxApelido.TabIndex = 15;
            txtBoxApelido.Text = "Apelido";
            // 
            // listBoxCesta
            // 
            listBoxCesta.Anchor = AnchorStyles.None;
            listBoxCesta.FormattingEnabled = true;
            listBoxCesta.Location = new Point(74, 913);
            listBoxCesta.Margin = new Padding(5);
            listBoxCesta.Name = "listBoxCesta";
            listBoxCesta.Size = new Size(688, 132);
            listBoxCesta.TabIndex = 16;
            // 
            // lblLugar
            // 
            lblLugar.Anchor = AnchorStyles.None;
            lblLugar.AutoSize = true;
            lblLugar.BackColor = Color.FromArgb(213, 211, 211);
            lblLugar.Location = new Point(173, 855);
            lblLugar.Name = "lblLugar";
            lblLugar.Size = new Size(73, 32);
            lblLugar.TabIndex = 19;
            lblLugar.Text = "Lugar";
            // 
            // listBoxVoosRegresso
            // 
            listBoxVoosRegresso.Anchor = AnchorStyles.None;
            listBoxVoosRegresso.Enabled = false;
            listBoxVoosRegresso.FormattingEnabled = true;
            listBoxVoosRegresso.Location = new Point(2317, 843);
            listBoxVoosRegresso.Name = "listBoxVoosRegresso";
            listBoxVoosRegresso.Size = new Size(121, 260);
            listBoxVoosRegresso.TabIndex = 20;
            listBoxVoosRegresso.Visible = false;
            // 
            // btnEscolherLugarRegresso
            // 
            btnEscolherLugarRegresso.Anchor = AnchorStyles.None;
            btnEscolherLugarRegresso.Enabled = false;
            btnEscolherLugarRegresso.Location = new Point(38, 11);
            btnEscolherLugarRegresso.Name = "btnEscolherLugarRegresso";
            btnEscolherLugarRegresso.Size = new Size(133, 46);
            btnEscolherLugarRegresso.TabIndex = 22;
            btnEscolherLugarRegresso.Text = "Lugar";
            btnEscolherLugarRegresso.UseVisualStyleBackColor = true;
            btnEscolherLugarRegresso.Click += btnEscolherLugarRegresso_Click;
            // 
            // lblLugarDisplay
            // 
            lblLugarDisplay.Anchor = AnchorStyles.None;
            lblLugarDisplay.AutoSize = true;
            lblLugarDisplay.BackColor = Color.FromArgb(213, 211, 211);
            lblLugarDisplay.BorderStyle = BorderStyle.Fixed3D;
            lblLugarDisplay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLugarDisplay.Location = new Point(75, 855);
            lblLugarDisplay.Name = "lblLugarDisplay";
            lblLugarDisplay.Size = new Size(81, 34);
            lblLugarDisplay.TabIndex = 23;
            lblLugarDisplay.Text = "Lugar";
            // 
            // checkBoxRegresso
            // 
            checkBoxRegresso.Anchor = AnchorStyles.None;
            checkBoxRegresso.AutoSize = true;
            checkBoxRegresso.BackColor = Color.FromArgb(213, 211, 211);
            checkBoxRegresso.Enabled = false;
            checkBoxRegresso.Location = new Point(930, 1224);
            checkBoxRegresso.Name = "checkBoxRegresso";
            checkBoxRegresso.Size = new Size(141, 36);
            checkBoxRegresso.TabIndex = 24;
            checkBoxRegresso.Text = "Regresso";
            checkBoxRegresso.UseVisualStyleBackColor = false;
            checkBoxRegresso.CheckStateChanged += checkBoxRegresso_CheckStateChanged;
            checkBoxRegresso.Click += checkBoxRegresso_CheckStateChanged;
            // 
            // dateTimePickerRegresso
            // 
            dateTimePickerRegresso.Anchor = AnchorStyles.None;
            dateTimePickerRegresso.Enabled = false;
            dateTimePickerRegresso.Location = new Point(1352, 709);
            dateTimePickerRegresso.Name = "dateTimePickerRegresso";
            dateTimePickerRegresso.Size = new Size(400, 39);
            dateTimePickerRegresso.TabIndex = 25;
            // 
            // btnPesquisaRegresso
            // 
            btnPesquisaRegresso.Anchor = AnchorStyles.None;
            btnPesquisaRegresso.Enabled = false;
            btnPesquisaRegresso.Location = new Point(1758, 709);
            btnPesquisaRegresso.Name = "btnPesquisaRegresso";
            btnPesquisaRegresso.Size = new Size(159, 42);
            btnPesquisaRegresso.TabIndex = 26;
            btnPesquisaRegresso.Text = "Pesquisa";
            btnPesquisaRegresso.UseVisualStyleBackColor = true;
            btnPesquisaRegresso.Click += btnPesquisaRegresso_Click;
            // 
            // btnCestaRegresso
            // 
            btnCestaRegresso.Anchor = AnchorStyles.None;
            btnCestaRegresso.Enabled = false;
            btnCestaRegresso.Location = new Point(177, 11);
            btnCestaRegresso.Name = "btnCestaRegresso";
            btnCestaRegresso.Size = new Size(204, 46);
            btnCestaRegresso.TabIndex = 27;
            btnCestaRegresso.Text = "Adicionar a cesta";
            btnCestaRegresso.UseVisualStyleBackColor = true;
            btnCestaRegresso.Click += btnCestaRegresso_Click;
            // 
            // lblPrecoRegresso
            // 
            lblPrecoRegresso.Anchor = AnchorStyles.None;
            lblPrecoRegresso.AutoSize = true;
            lblPrecoRegresso.BackColor = Color.FromArgb(213, 211, 211);
            lblPrecoRegresso.BorderStyle = BorderStyle.Fixed3D;
            lblPrecoRegresso.Location = new Point(576, 16);
            lblPrecoRegresso.Margin = new Padding(5, 0, 5, 0);
            lblPrecoRegresso.Name = "lblPrecoRegresso";
            lblPrecoRegresso.Size = new Size(131, 34);
            lblPrecoRegresso.TabIndex = 28;
            lblPrecoRegresso.Text = "Preco Base";
            // 
            // txtBoxPrecoRegresso
            // 
            txtBoxPrecoRegresso.Anchor = AnchorStyles.None;
            txtBoxPrecoRegresso.Enabled = false;
            txtBoxPrecoRegresso.Location = new Point(732, 15);
            txtBoxPrecoRegresso.Margin = new Padding(5);
            txtBoxPrecoRegresso.Name = "txtBoxPrecoRegresso";
            txtBoxPrecoRegresso.Size = new Size(201, 39);
            txtBoxPrecoRegresso.TabIndex = 29;
            txtBoxPrecoRegresso.Text = "1";
            // 
            // listBoxVoos
            // 
            listBoxVoos.Anchor = AnchorStyles.None;
            listBoxVoos.FormattingEnabled = true;
            listBoxVoos.Location = new Point(2395, 92);
            listBoxVoos.Margin = new Padding(5);
            listBoxVoos.Name = "listBoxVoos";
            listBoxVoos.Size = new Size(80, 228);
            listBoxVoos.TabIndex = 2;
            listBoxVoos.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo_background;
            pictureBox1.Location = new Point(25, 214);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(809, 962);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // lblAeroportos
            // 
            lblAeroportos.Anchor = AnchorStyles.None;
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(74, 178);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(231, 72);
            lblAeroportos.TabIndex = 34;
            lblAeroportos.Text = "Bilhetes";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.background_patternb;
            pictureBox2.Location = new Point(859, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(986, 550);
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = Properties.Resources.background_patternb;
            pictureBox3.Location = new Point(859, 697);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(986, 590);
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            // 
            // dataGridViewVoosIda
            // 
            dataGridViewVoosIda.Anchor = AnchorStyles.None;
            dataGridViewVoosIda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVoosIda.Location = new Point(897, 123);
            dataGridViewVoosIda.Name = "dataGridViewVoosIda";
            dataGridViewVoosIda.RowHeadersWidth = 82;
            dataGridViewVoosIda.Size = new Size(1470, 404);
            dataGridViewVoosIda.TabIndex = 46;
            //dataGridViewVoosIda.CellContentClick += dataGridViewVoosIda_CellContentClick;
            // 
            // dataGridViewVoosRegresso
            // 
            dataGridViewVoosRegresso.Anchor = AnchorStyles.None;
            dataGridViewVoosRegresso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVoosRegresso.Enabled = false;
            dataGridViewVoosRegresso.Location = new Point(897, 763);
            dataGridViewVoosRegresso.Name = "dataGridViewVoosRegresso";
            dataGridViewVoosRegresso.RowHeadersWidth = 82;
            dataGridViewVoosRegresso.Size = new Size(1447, 442);
            dataGridViewVoosRegresso.TabIndex = 47;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(911, 27);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(246, 72);
            label2.TabIndex = 48;
            label2.Text = "Voos Ida";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = Properties.Resources.background_patternb;
            pictureBox4.Location = new Point(1422, 69);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(986, 550);
            pictureBox4.TabIndex = 49;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Image = Properties.Resources.background_patternb;
            pictureBox5.Location = new Point(1422, 697);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(986, 590);
            pictureBox5.TabIndex = 50;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(920, 661);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(394, 72);
            label3.TabIndex = 51;
            label3.Text = "Voos Regresso";
            // 
            // checkBoxDiretoRegresso
            // 
            checkBoxDiretoRegresso.Anchor = AnchorStyles.None;
            checkBoxDiretoRegresso.AutoSize = true;
            checkBoxDiretoRegresso.BackColor = Color.FromArgb(213, 211, 211);
            checkBoxDiretoRegresso.Enabled = false;
            checkBoxDiretoRegresso.Location = new Point(399, 14);
            checkBoxDiretoRegresso.Name = "checkBoxDiretoRegresso";
            checkBoxDiretoRegresso.Size = new Size(163, 36);
            checkBoxDiretoRegresso.TabIndex = 52;
            checkBoxDiretoRegresso.Text = "Sem Escala";
            checkBoxDiretoRegresso.UseVisualStyleBackColor = false;
            checkBoxDiretoRegresso.CheckStateChanged += checkBoxDiretoRegresso_CheckStateChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackgroundImage = Properties.Resources.background_patternb;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(checkBoxDireto);
            panel2.Controls.Add(btnLugar);
            panel2.Controls.Add(btnCesta);
            panel2.Controls.Add(labelPreco);
            panel2.Controls.Add(textBoxPreco);
            panel2.Location = new Point(1121, 533);
            panel2.Name = "panel2";
            panel2.Size = new Size(989, 67);
            panel2.TabIndex = 53;
            // 
            // checkBoxDireto
            // 
            checkBoxDireto.Anchor = AnchorStyles.None;
            checkBoxDireto.AutoSize = true;
            checkBoxDireto.BackColor = Color.FromArgb(213, 211, 211);
            checkBoxDireto.Location = new Point(430, 14);
            checkBoxDireto.Name = "checkBoxDireto";
            checkBoxDireto.Size = new Size(163, 36);
            checkBoxDireto.TabIndex = 35;
            checkBoxDireto.Text = "Sem Escala";
            checkBoxDireto.UseVisualStyleBackColor = false;
            checkBoxDireto.Click += checkBoxDireto_CheckStateChanged;
            // 
            // btnLugar
            // 
            btnLugar.Anchor = AnchorStyles.None;
            btnLugar.Location = new Point(41, 8);
            btnLugar.Name = "btnLugar";
            btnLugar.Size = new Size(141, 46);
            btnLugar.TabIndex = 34;
            btnLugar.Text = "Lugar";
            btnLugar.UseVisualStyleBackColor = true;
            btnLugar.Click += btnLugar_Click;
            // 
            // btnCesta
            // 
            btnCesta.Anchor = AnchorStyles.None;
            btnCesta.Location = new Point(188, 8);
            btnCesta.Name = "btnCesta";
            btnCesta.Size = new Size(223, 46);
            btnCesta.TabIndex = 33;
            btnCesta.Text = "Adicionar a cesta";
            btnCesta.UseVisualStyleBackColor = true;
            btnCesta.Click += btnCesta_Click;
            // 
            // labelPreco
            // 
            labelPreco.Anchor = AnchorStyles.None;
            labelPreco.AutoSize = true;
            labelPreco.BackColor = Color.FromArgb(213, 211, 211);
            labelPreco.BorderStyle = BorderStyle.Fixed3D;
            labelPreco.Location = new Point(601, 12);
            labelPreco.Margin = new Padding(5, 0, 5, 0);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(131, 34);
            labelPreco.TabIndex = 31;
            labelPreco.Text = "Preco Base";
            // 
            // textBoxPreco
            // 
            textBoxPreco.Anchor = AnchorStyles.None;
            textBoxPreco.Enabled = false;
            textBoxPreco.Location = new Point(742, 11);
            textBoxPreco.Margin = new Padding(5);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(201, 39);
            textBoxPreco.TabIndex = 32;
            textBoxPreco.Text = "1";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImage = Properties.Resources.background_patternb;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnEscolherLugarRegresso);
            panel1.Controls.Add(btnCestaRegresso);
            panel1.Controls.Add(checkBoxDiretoRegresso);
            panel1.Controls.Add(lblPrecoRegresso);
            panel1.Controls.Add(txtBoxPrecoRegresso);
            panel1.Location = new Point(1136, 1211);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 67);
            panel1.TabIndex = 54;
            // 
            // FormComprarBilhetes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(2513, 1352);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridViewVoosRegresso);
            Controls.Add(dataGridViewVoosIda);
            Controls.Add(lblAeroportos);
            Controls.Add(btnPesquisaRegresso);
            Controls.Add(dateTimePickerRegresso);
            Controls.Add(checkBoxRegresso);
            Controls.Add(lblLugarDisplay);
            Controls.Add(listBoxVoosRegresso);
            Controls.Add(lblLugar);
            Controls.Add(listBoxCesta);
            Controls.Add(txtBoxApelido);
            Controls.Add(txtBoxNome);
            Controls.Add(btnAtualizar);
            Controls.Add(comboBoxTipo);
            Controls.Add(txtBoxId);
            Controls.Add(comboBoxTarifa);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonComprar);
            Controls.Add(dateTimePickerIda);
            Controls.Add(listBoxVoos);
            Controls.Add(comboBoxDestino);
            Controls.Add(comboBoxOrigem);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Margin = new Padding(5);
            Name = "FormComprarBilhetes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoosIda).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoosRegresso).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxOrigem;
        private ComboBox comboBoxDestino;
        private DateTimePicker dateTimePickerIda;
        private Button buttonComprar;
        private Button buttonCancelar;
        private ComboBox comboBoxTarifa;
        private TextBox textBoxId;
        private TextBox txtBoxId;
        private ComboBox comboBoxTipo;
        private Button btnAtualizar;
        private Button btnUpdate;
        private TextBox txtBoxNome;
        private TextBox txtBoxApelido;
        private ListBox listBoxCesta;
        private Label lblLugar;
        private ListBox listBoxVoosRegresso;
        private Button btnEscolherLugarRegresso;
        private Label lblLugarDisplay;
        private CheckBox checkBoxRegresso;
        private DateTimePicker dateTimePickerRegresso;
        private Button btnPesquisaRegresso;
        private Button btnCestaRegresso;
        private Label lblPrecoRegresso;
        private TextBox txtBoxPrecoRegresso;
        private ListBox listBoxVoos;
        private PictureBox pictureBox1;
        private Label lblAeroportos;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private DataGridView dataGridViewVoosIda;
        private DataGridView dataGridViewVoosRegresso;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label3;
        private CheckBox checkBoxDiretoRegresso;
        private Panel panel2;
        private CheckBox checkBoxDireto;
        private Button btnLugar;
        private Button btnCesta;
        private Label labelPreco;
        private TextBox textBoxPreco;
        private Panel panel1;
    }
}