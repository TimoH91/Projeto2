namespace Forms
{
    partial class FormAvioes
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
            listBoxAvioes = new ListBox();
            btnRetirarAviao = new Button();
            btnAdicionarAviao = new Button();
            btnEditar = new Button();
            btnApagar = new Button();
            btnOk = new Button();
            pictureBox1 = new PictureBox();
            lblAeroportos = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxAvioes
            // 
            listBoxAvioes.Anchor = AnchorStyles.None;
            listBoxAvioes.FormattingEnabled = true;
            listBoxAvioes.Location = new Point(278, 319);
            listBoxAvioes.Margin = new Padding(5);
            listBoxAvioes.Name = "listBoxAvioes";
            listBoxAvioes.Size = new Size(677, 356);
            listBoxAvioes.TabIndex = 0;
            // 
            // btnRetirarAviao
            // 
            btnRetirarAviao.Anchor = AnchorStyles.None;
            btnRetirarAviao.Location = new Point(14, 6);
            btnRetirarAviao.Margin = new Padding(5);
            btnRetirarAviao.Name = "btnRetirarAviao";
            btnRetirarAviao.Size = new Size(143, 47);
            btnRetirarAviao.TabIndex = 2;
            btnRetirarAviao.Text = "Estado";
            btnRetirarAviao.UseVisualStyleBackColor = true;
            btnRetirarAviao.Click += btnRetirarAviao_Click;
            // 
            // btnAdicionarAviao
            // 
            btnAdicionarAviao.Anchor = AnchorStyles.None;
            btnAdicionarAviao.Location = new Point(469, 7);
            btnAdicionarAviao.Margin = new Padding(5);
            btnAdicionarAviao.Name = "btnAdicionarAviao";
            btnAdicionarAviao.Size = new Size(153, 47);
            btnAdicionarAviao.TabIndex = 3;
            btnAdicionarAviao.Text = "Adicionar";
            btnAdicionarAviao.UseVisualStyleBackColor = true;
            btnAdicionarAviao.Click += btnAdicionarAviao_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.Location = new Point(167, 7);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(143, 47);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar ";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Anchor = AnchorStyles.None;
            btnApagar.Location = new Point(318, 7);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(143, 47);
            btnApagar.TabIndex = 10;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.None;
            btnOk.Location = new Point(805, 825);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(150, 46);
            btnOk.TabIndex = 11;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo_background;
            pictureBox1.Location = new Point(227, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(782, 882);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // lblAeroportos
            // 
            lblAeroportos.Anchor = AnchorStyles.None;
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(278, 0);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(197, 72);
            lblAeroportos.TabIndex = 40;
            lblAeroportos.Text = "Aviões";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackgroundImage = Properties.Resources.background_patternb;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnAdicionarAviao);
            panel2.Controls.Add(btnApagar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnRetirarAviao);
            panel2.Location = new Point(298, 683);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 67);
            panel2.TabIndex = 41;
            // 
            // FormAvioes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(1236, 963);
            Controls.Add(panel2);
            Controls.Add(lblAeroportos);
            Controls.Add(btnOk);
            Controls.Add(listBoxAvioes);
            Controls.Add(pictureBox1);
            Margin = new Padding(5);
            Name = "FormAvioes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAvioes;
        private Button btnRetirarAviao;
        private Button btnAdicionarAviao;
        private Button btnEditar;
        private Button btnApagar;
        private Button btnOk;
        private PictureBox pictureBox1;
        private Label lblAeroportos;
        private Panel panel2;
    }
}