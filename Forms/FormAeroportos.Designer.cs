namespace Forms
{
    partial class FormAeroportos
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
            btnAdicionar = new Button();
            btnApagar = new Button();
            listBoxAeroportos = new ListBox();
            BtnEditar = new Button();
            btnOk = new Button();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblAeroportos = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.None;
            btnAdicionar.Location = new Point(370, 5);
            btnAdicionar.Margin = new Padding(5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(154, 48);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Anchor = AnchorStyles.None;
            btnApagar.Location = new Point(44, 5);
            btnApagar.Margin = new Padding(5);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(154, 47);
            btnApagar.TabIndex = 5;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagarAeroporto_Click;
            // 
            // listBoxAeroportos
            // 
            listBoxAeroportos.Anchor = AnchorStyles.None;
            listBoxAeroportos.FormattingEnabled = true;
            listBoxAeroportos.Location = new Point(262, 330);
            listBoxAeroportos.Margin = new Padding(5);
            listBoxAeroportos.Name = "listBoxAeroportos";
            listBoxAeroportos.Size = new Size(704, 356);
            listBoxAeroportos.TabIndex = 3;
            // 
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.None;
            BtnEditar.Location = new Point(206, 5);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(156, 48);
            BtnEditar.TabIndex = 6;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.None;
            btnOk.Location = new Point(816, 798);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(150, 46);
            btnOk.TabIndex = 7;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo_background;
            pictureBox1.Location = new Point(225, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(785, 828);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // lblAeroportos
            // 
            lblAeroportos.Anchor = AnchorStyles.None;
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(262, 10);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(318, 72);
            lblAeroportos.TabIndex = 4;
            lblAeroportos.Text = "Aeroportos";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackgroundImage = Properties.Resources.background_patternb;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnApagar);
            panel2.Controls.Add(BtnEditar);
            panel2.Controls.Add(btnAdicionar);
            panel2.Location = new Point(319, 694);
            panel2.Name = "panel2";
            panel2.Size = new Size(576, 67);
            panel2.TabIndex = 40;
            // 
            // FormAeroportos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(1229, 911);
            Controls.Add(panel2);
            Controls.Add(btnOk);
            Controls.Add(lblAeroportos);
            Controls.Add(listBoxAeroportos);
            Controls.Add(pictureBox1);
            Margin = new Padding(5);
            Name = "FormAeroportos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Button btnApagar;
        private ListBox listBoxAeroportos;
        private Button BtnEditar;
        private Button btnOk;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblAeroportos;
        private Panel panel2;
    }
}