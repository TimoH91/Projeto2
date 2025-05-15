namespace Forms
{
    partial class FormBilhetePrecoSimular
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
            btnConfirmar = new Button();
            btnCancelar = new Button();
            listBoxCesta = new ListBox();
            lblPreco = new Label();
            txtBoxPrecoTotal = new TextBox();
            lblEuros = new Label();
            pictureBox1 = new PictureBox();
            lblAeroportos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.None;
            btnConfirmar.Location = new Point(736, 906);
            btnConfirmar.Margin = new Padding(5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(153, 46);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(573, 906);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 46);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // listBoxCesta
            // 
            listBoxCesta.Anchor = AnchorStyles.None;
            listBoxCesta.FormattingEnabled = true;
            listBoxCesta.Location = new Point(162, 370);
            listBoxCesta.Name = "listBoxCesta";
            listBoxCesta.Size = new Size(728, 452);
            listBoxCesta.TabIndex = 3;
            // 
            // lblPreco
            // 
            lblPreco.Anchor = AnchorStyles.None;
            lblPreco.AutoSize = true;
            lblPreco.BackColor = Color.FromArgb(213, 211, 211);
            lblPreco.BorderStyle = BorderStyle.Fixed3D;
            lblPreco.Location = new Point(162, 839);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(130, 34);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço total";
            lblPreco.UseMnemonic = false;
            // 
            // txtBoxPrecoTotal
            // 
            txtBoxPrecoTotal.Anchor = AnchorStyles.None;
            txtBoxPrecoTotal.Enabled = false;
            txtBoxPrecoTotal.Location = new Point(340, 839);
            txtBoxPrecoTotal.Name = "txtBoxPrecoTotal";
            txtBoxPrecoTotal.Size = new Size(200, 39);
            txtBoxPrecoTotal.TabIndex = 5;
            // 
            // lblEuros
            // 
            lblEuros.Anchor = AnchorStyles.None;
            lblEuros.AutoSize = true;
            lblEuros.BackColor = Color.FromArgb(213, 211, 211);
            lblEuros.BorderStyle = BorderStyle.Fixed3D;
            lblEuros.Location = new Point(298, 839);
            lblEuros.Name = "lblEuros";
            lblEuros.Size = new Size(29, 34);
            lblEuros.TabIndex = 6;
            lblEuros.Text = "€";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo_background;
            pictureBox1.Location = new Point(129, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(809, 946);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblAeroportos
            // 
            lblAeroportos.Anchor = AnchorStyles.None;
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(178, 29);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(231, 72);
            lblAeroportos.TabIndex = 16;
            lblAeroportos.Text = "Bilhetes";
            // 
            // FormBilhetePrecoSimular
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(1090, 1033);
            Controls.Add(lblAeroportos);
            Controls.Add(lblEuros);
            Controls.Add(txtBoxPrecoTotal);
            Controls.Add(lblPreco);
            Controls.Add(listBoxCesta);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(pictureBox1);
            Margin = new Padding(5);
            Name = "FormBilhetePrecoSimular";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConfirmar;
        private Button btnCancelar;
        private ListBox listBoxCesta;
        private Label lblPreco;
        private TextBox txtBoxPrecoTotal;
        private Label lblEuros;
        private PictureBox pictureBox1;
        private Label lblAeroportos;
    }
}