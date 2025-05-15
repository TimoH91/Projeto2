using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaAeronautica.Entities;
using BibliotecaAeronautica.Models;
using BibliotecaAeronautica.Services;

namespace Forms
{
    public partial class FormEscolherLugar : Form
    {
        private Voo _voo;

        private Button _assentoEscolhido = null;

        private string _lugar;

        private string[,] _assentosCesta;

        private FormComprarBilhetes _formCB;

        private char[] _letras;

        private int _linha;

        private int _columna;


        public FormEscolherLugar(FormComprarBilhetes formCB, string[,] assentosCesta, Voo voo)
        {
            InitializeComponent();

            _voo = voo;
            _assentosCesta = assentosCesta;
            _formCB = formCB;
            _letras = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            CriarAssentosGrid();
        }

        //Criar assentos
        private void CriarAssentosGrid()
        {
            //Cirar assentos com matrix no voo (assentosReservados)

            int linhas = _assentosCesta.GetLength(0);
            int cols = _assentosCesta.GetLength(1);

            assentosPosicao.Controls.Clear();
            assentosPosicao.RowCount = linhas;
            assentosPosicao.ColumnCount = cols;
            assentosPosicao.RowStyles.Clear();
            assentosPosicao.ColumnStyles.Clear();

            for (int i = 0; i < linhas; i++)
            {
                assentosPosicao.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            }

            for (int i = 0; i < cols; i++)
            {
                assentosPosicao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / cols));
            }

            for (int linha = 0; linha < linhas; linha++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string assento = $"{_letras[col]}{linha + 1}";

                    Button assentoButao = new Button
                    {
                        Text = assento,
                        Dock = DockStyle.Fill,
                        Tag = assento
                    };

                    // Verificar se assento for "reservado"

                    if (!string.IsNullOrEmpty(_assentosCesta[linha, col]) && _assentosCesta[linha, col].ToLower() == "reservado")
                    {
                        assentoButao.BackColor = Color.Red;
                        assentoButao.Enabled = false;
                    }
                    else
                    {
                        assentoButao.BackColor = Color.LightGray;
                        assentoButao.Click += btnAssento_Click;
                    }

                    assentosPosicao.Controls.Add(assentoButao, col, linha);

                }
            }

            panelAssentos.Controls.Add(assentosPosicao);       
            this.Controls.Add(panelAssentos);
            assentosPosicao.Dock = DockStyle.Top; 
            assentosPosicao.AutoSize = true;
            assentosPosicao.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelAssentos.AutoScroll = true;
        }

        //Escolher assento
        private void btnAssento_Click(object sender, EventArgs e)
        {
            Button btnEscolhido = sender as Button;

            if (btnEscolhido != null)
            {
                if (_assentoEscolhido != null)
                {
                    _assentoEscolhido.BackColor = Color.LightGray;
                }

                MessageBox.Show($"Escolhou assento: {btnEscolhido.Tag}");
                btnEscolhido.BackColor = Color.Green;

                _lugar = Convert.ToString(btnEscolhido.Tag);

                int linhaNumero = 0;
                char colunaLetra = _lugar[0];

                if (_lugar.Length == 2)
                {
                    linhaNumero = linhaNumero * 10 + (_lugar[1] - '0');
                }
                else
                {
                    for (int i = 1; i < _lugar.Length; i++)
                    {
                        linhaNumero = linhaNumero * 10 + (_lugar[i] - '0');
                    }

                }
                _columna = colunaLetra - 'A';
                _linha = linhaNumero - 1;

                _assentoEscolhido = btnEscolhido;
            }
        }
        //Confirmar escolha
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_lugar))
            {
                _assentosCesta[_linha, _columna] = "reservado";
                _formCB.Lugar = _lugar;
                _formCB.MostrarLugar();
                Close();
            }
  
        }

        //Fechar form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
