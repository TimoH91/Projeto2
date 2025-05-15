namespace Forms
{
    partial class FormGestionarBilhetes
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
            listBoxVoos = new ListBox();
            listBoxBilhetes = new ListBox();
            btnApagar = new Button();
            btnEditar = new Button();
            btnAtualizar = new Button();
            lblAeroportos = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxVoos
            // 
            listBoxVoos.Anchor = AnchorStyles.None;
            listBoxVoos.FormattingEnabled = true;
            listBoxVoos.Location = new Point(153, 177);
            listBoxVoos.Margin = new Padding(5);
            listBoxVoos.Name = "listBoxVoos";
            listBoxVoos.Size = new Size(948, 516);
            listBoxVoos.TabIndex = 0;
            listBoxVoos.SelectedIndexChanged += listBoxVoos_SelectedIndexChanged;
            // 
            // listBoxBilhetes
            // 
            listBoxBilhetes.Anchor = AnchorStyles.None;
            listBoxBilhetes.FormattingEnabled = true;
            listBoxBilhetes.Location = new Point(1223, 177);
            listBoxBilhetes.Margin = new Padding(5);
            listBoxBilhetes.Name = "listBoxBilhetes";
            listBoxBilhetes.Size = new Size(946, 516);
            listBoxBilhetes.TabIndex = 1;
            // 
            // btnApagar
            // 
            btnApagar.Anchor = AnchorStyles.None;
            btnApagar.Location = new Point(16, 6);
            btnApagar.Margin = new Padding(5);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(153, 46);
            btnApagar.TabIndex = 4;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.Location = new Point(179, 6);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(153, 46);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.None;
            btnAtualizar.Location = new Point(340, 6);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(150, 46);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // lblAeroportos
            // 
            lblAeroportos.Anchor = AnchorStyles.None;
            lblAeroportos.AutoSize = true;
            lblAeroportos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAeroportos.Location = new Point(153, 81);
            lblAeroportos.Margin = new Padding(5, 0, 5, 0);
            lblAeroportos.Name = "lblAeroportos";
            lblAeroportos.Size = new Size(152, 72);
            lblAeroportos.TabIndex = 7;
            lblAeroportos.Text = "Voos";
            //lblAeroportos.Click += lblAeroportos_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(1223, 81);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(231, 72);
            label3.TabIndex = 8;
            label3.Text = "Bilhetes";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.background_patternb;
            pictureBox1.Location = new Point(127, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1029, 653);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.background_patternb;
            pictureBox2.Location = new Point(1200, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1029, 653);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackgroundImage = Properties.Resources.background_patternb;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnApagar);
            panel2.Controls.Add(btnAtualizar);
            panel2.Location = new Point(1422, 701);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 63);
            panel2.TabIndex = 41;
            // 
            // FormGestionarBilhetes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(2348, 903);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(lblAeroportos);
            Controls.Add(listBoxBilhetes);
            Controls.Add(listBoxVoos);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Margin = new Padding(5);
            Name = "FormGestionarBilhetes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxVoos;
        private ListBox listBoxBilhetes;
        private Button btnApagar;
        private Button btnEditar;
        private Button btnAtualizar;
        private Label lblAeroportos;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
    }
}