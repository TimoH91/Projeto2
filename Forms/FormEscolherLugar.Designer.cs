namespace Forms
{
    partial class FormEscolherLugar
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
            assentosPosicao.Anchor = AnchorStyles.None;
            assentosPosicao.AutoSize = true;
            assentosPosicao.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            assentosPosicao.ColumnCount = 2;
            assentosPosicao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            assentosPosicao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            assentosPosicao.Location = new Point(354, 241);
            assentosPosicao.Name = "assentosPosicao";
            assentosPosicao.RowCount = 2;
            assentosPosicao.RowStyles.Add(new RowStyle(SizeType.Percent, 51.4588852F));
            assentosPosicao.RowStyles.Add(new RowStyle(SizeType.Percent, 48.5411148F));
            assentosPosicao.Size = new Size(0, 0);
            assentosPosicao.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.None;
            btnConfirmar.Location = new Point(1052, 850);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(150, 46);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Ok";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(896, 850);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panelAssentos
            // 
            panelAssentos.Anchor = AnchorStyles.None;
            panelAssentos.AutoScroll = true;
            panelAssentos.Controls.Add(assentosPosicao);
            panelAssentos.Location = new Point(207, 119);
            panelAssentos.Name = "panelAssentos";
            panelAssentos.Size = new Size(810, 678);
            panelAssentos.TabIndex = 3;
            // 
            // FormEscolherLugar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 122, 167);
            ClientSize = new Size(1225, 923);
            Controls.Add(panelAssentos);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Name = "FormEscolherLugar";
            //FormClosed += FormEscolherLugar_FormClosed;
            panelAssentos.ResumeLayout(false);
            panelAssentos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel assentosPosicao;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Panel panelAssentos;
    }
}