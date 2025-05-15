namespace Forms
{
    partial class FormVoos
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
            btnAdicionarVoo = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            comboBoxOrigem = new ComboBox();
            comboBoxDestino = new ComboBox();
            lblOrigem = new Label();
            lblDestino = new Label();
            dateTimePickerIda = new DateTimePicker();
            btnDadosIda = new Button();
            btnPesquisa = new Button();
            checkBoxDireto = new CheckBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            lblAeroportos = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionarVoo
            // 
            btnAdicionarVoo.Anchor = AnchorStyles.None;
            btnAdicionarVoo.Location = new Point(1989, 662);
            btnAdicionarVoo.Margin = new Padding(5);
            btnAdicionarVoo.Name = "btnAdicionarVoo";
            btnAdicionarVoo.Size = new Size(163, 47);
            btnAdicionarVoo.TabIndex = 7;
            btnAdicionarVoo.Text = "Adicionar";
            btnAdicionarVoo.UseVisualStyleBackColor = true;
            btnAdicionarVoo.Click += btnAdicionarVoo_Click;
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.Anchor = AnchorStyles.None;
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new Point(249, 430);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new Size(612, 40);
            comboBoxOrigem.TabIndex = 10;
            //comboBoxOrigem.SelectedIndexChanged += comboBoxOrigem_SelectedIndexChanged;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.Anchor = AnchorStyles.None;
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(249, 504);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(612, 40);
            comboBoxDestino.TabIndex = 12;
            // 
            // lblOrigem
            // 
            lblOrigem.Anchor = AnchorStyles.None;
            lblOrigem.AutoSize = true;
            lblOrigem.BackColor = Color.FromArgb(213, 211, 211);
            lblOrigem.BorderStyle = BorderStyle.Fixed3D;
            lblOrigem.Location = new Point(134, 430);
            lblOrigem.Name = "lblOrigem";
            lblOrigem.Size = new Size(96, 34);
            lblOrigem.TabIndex = 13;
            lblOrigem.Text = "Origem";
            // 
            // lblDestino
            // 
            lblDestino.Anchor = AnchorStyles.None;
            lblDestino.AutoSize = true;
            lblDestino.BackColor = Color.FromArgb(213, 211, 211);
            lblDestino.BorderStyle = BorderStyle.Fixed3D;
            lblDestino.Location = new Point(132, 504);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(98, 34);
            lblDestino.TabIndex = 15;
            lblDestino.Text = "Destino";
            // 
            // dateTimePickerIda
            // 
            dateTimePickerIda.Anchor = AnchorStyles.None;
            dateTimePickerIda.Location = new Point(249, 571);
            dateTimePickerIda.Name = "dateTimePickerIda";
            dateTimePickerIda.Size = new Size(400, 39);
            dateTimePickerIda.TabIndex = 16;
            // 
            // btnDadosIda
            // 
            btnDadosIda.Anchor = AnchorStyles.None;
            btnDadosIda.Location = new Point(1831, 663);
            btnDadosIda.Name = "btnDadosIda";
            btnDadosIda.Size = new Size(150, 46);
            btnDadosIda.TabIndex = 21;
            btnDadosIda.Text = "Mais";
            btnDadosIda.UseVisualStyleBackColor = true;
            btnDadosIda.Click += btnDadosIda_Click;
            // 
            // btnPesquisa
            // 
            btnPesquisa.Anchor = AnchorStyles.None;
            btnPesquisa.Location = new Point(698, 564);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(150, 46);
            btnPesquisa.TabIndex = 23;
            btnPesquisa.Text = "Pesquisa";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // checkBoxDireto
            // 
            checkBoxDireto.Anchor = AnchorStyles.None;
            checkBoxDireto.AutoSize = true;
            checkBoxDireto.BackColor = Color.FromArgb(213, 211, 211);
            checkBoxDireto.Location = new Point(249, 638);
            checkBoxDireto.Name = "checkBoxDireto";
            checkBoxDireto.Size = new Size(163, 36);
            checkBoxDireto.TabIndex = 26;
            checkBoxDireto.Text = "Sem Escala";
            checkBoxDireto.UseVisualStyleBackColor = false;
            checkBoxDireto.CheckStateChanged += checkBoxDireto_CheckStateChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(950, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1202, 520);
            dataGridView1.TabIndex = 27;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo_background;
            pictureBox1.Location = new Point(117, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(765, 633);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // lblAeroportos
            // 
            lblAeroportos.Anchor = AnchorStyles.None;
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(168, 55);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(152, 72);
            lblAeroportos.TabIndex = 41;
            lblAeroportos.Text = "Voos";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.background_patternb;
            pictureBox2.Location = new Point(905, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(830, 633);
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = Properties.Resources.background_patternb;
            pictureBox3.Location = new Point(1350, 93);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(830, 633);
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // FormVoos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(2306, 810);
            Controls.Add(lblAeroportos);
            Controls.Add(dataGridView1);
            Controls.Add(checkBoxDireto);
            Controls.Add(btnPesquisa);
            Controls.Add(btnDadosIda);
            Controls.Add(dateTimePickerIda);
            Controls.Add(lblDestino);
            Controls.Add(lblOrigem);
            Controls.Add(comboBoxDestino);
            Controls.Add(comboBoxOrigem);
            Controls.Add(btnAdicionarVoo);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Margin = new Padding(5);
            Name = "FormVoos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionarVoo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboBoxOrigem;
        private ComboBox comboBoxDestino;
        private Label lblOrigem;
        private Label lblDestino;
        private DateTimePicker dateTimePickerIda;
        private Button btnDadosIda;
        private Button btnPesquisa;
        private CheckBox checkBoxDireto;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label lblAeroportos;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}