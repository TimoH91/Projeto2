namespace Forms
{
    partial class FormBebeResponsavel
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
            listBoxResponsaveis = new ListBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            lblAeroportos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxResponsaveis
            // 
            listBoxResponsaveis.Anchor = AnchorStyles.None;
            listBoxResponsaveis.FormattingEnabled = true;
            listBoxResponsaveis.Location = new Point(228, 404);
            listBoxResponsaveis.Name = "listBoxResponsaveis";
            listBoxResponsaveis.Size = new Size(695, 260);
            listBoxResponsaveis.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(773, 691);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(617, 691);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo_background;
            pictureBox1.Location = new Point(176, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(831, 740);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox1.Location = new Point(315, 339);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 39);
            textBox1.TabIndex = 8;
            textBox1.Text = "Por favor selecione o responsável do bebe";
            // 
            // lblAeroportos
            // 
            lblAeroportos.Anchor = AnchorStyles.None;
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(228, 2);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(231, 72);
            lblAeroportos.TabIndex = 15;
            lblAeroportos.Text = "Bilhetes";
            // 
            // FormBebeResponsavel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(1147, 823);
            Controls.Add(lblAeroportos);
            Controls.Add(textBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(listBoxResponsaveis);
            Controls.Add(pictureBox1);
            Name = "FormBebeResponsavel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxResponsaveis;
        private Button btnGuardar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label lblAeroportos;
    }
}