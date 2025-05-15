namespace Forms
{
    partial class FormEditarLugar
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
            assentosPosicao = new TableLayoutPanel();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            panelAssentos = new Panel();
            panelAssentos.SuspendLayout();
            SuspendLayout();
            // 
            // assentosPosicao
            // 
            assentosPosicao.ColumnCount = 2;
            assentosPosicao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            assentosPosicao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            assentosPosicao.ForeColor = Color.Black;
            assentosPosicao.Location = new Point(131, 129);
            assentosPosicao.Name = "assentosPosicao";
            assentosPosicao.RowCount = 2;
            assentosPosicao.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            assentosPosicao.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            assentosPosicao.Size = new Size(400, 200);
            assentosPosicao.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.None;
            btnConfirmar.ForeColor = Color.Black;
            btnConfirmar.Location = new Point(1032, 764);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(150, 46);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Ok";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(876, 764);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panelAssentos
            // 
            panelAssentos.Anchor = AnchorStyles.None;
            panelAssentos.Controls.Add(assentosPosicao);
            panelAssentos.Location = new Point(211, 112);
            panelAssentos.Name = "panelAssentos";
            panelAssentos.Size = new Size(815, 628);
            panelAssentos.TabIndex = 4;
            // 
            // FormEditarLugar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(1219, 841);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(panelAssentos);
            ForeColor = Color.CornflowerBlue;
            Name = "FormEditarLugar";
            //Load += FormEditarLugar_Load;
            panelAssentos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel assentosPosicao;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Panel panelAssentos;
    }
}