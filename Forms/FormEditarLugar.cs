using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaAeronautica.DTOs;
using BibliotecaAeronautica.Entities;
using BibliotecaAeronautica.Models;
using BibliotecaAeronautica.Services;

namespace Forms
{
    public partial class FormEditarLugar : Form
    {
        private VooResumoDto _voo;

        private Bilhete _bilhete;

        private int _fila;

        private int _coluna;

        private List<Assento> _assentos;

        //private List<AssentoResumoDto> _assentosDto;

        private ApiService _apiService;

        private Button _assentoEscolhido = null;

        private string _lugar;

        private string[,] _assentosAEditar;

        private FormEditarBilhetes _formEB;

        private string _lugarAtual;

        private char[] _letras;
        public FormEditarLugar(FormEditarBilhetes formEB, Bilhete bilhete)
        {
            InitializeComponent();
            //_lugarAtual = lugarAtual;
            //_voo = voo;
            _bilhete = bilhete;
            _apiService = new ApiService();
            _formEB = formEB;
            //_assentosAEditar = assentosAEditar;
            _letras = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            LoadApi();
            
        }

        private async Task LoadApi()
        {
            var responseA = await _apiService.GetAssentos("https://localhost:44328", $"/api/voo/{_bilhete.Voo.Id}/assentos");

            //var responseE = await _apiService.GetBilhetes("https://localhost:44328", "/api/bilhetes");

            _assentos = (List<Assento>)responseA.Result;

            CriarAssentosGrid();

            //listBoxVoos.DataSource = null;
            //listBoxVoos.DataSource = voosLista;
            //listBoxVoos.DisplayMember = "VooInfo";
        }


        //Criar assentos
        private void CriarAssentosGrid()
        {
            if (_assentos != null && _assentos.Any())
            {
                int filas = _assentos.Max(a => a.Fila);
                int cols = _assentos.Max(a => a.Coluna);

                assentosPosicao.Controls.Clear();
                assentosPosicao.RowCount = filas;
                assentosPosicao.ColumnCount = cols;
                assentosPosicao.RowStyles.Clear();
                assentosPosicao.ColumnStyles.Clear();

                for (int i = 0; i < filas; i++)
                {
                    assentosPosicao.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                }

                for (int i = 0; i < cols; i++)
                {
                    assentosPosicao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / cols));
                }

                //Adicionar butões ao grid
                for (int row = 1; row <= filas; row++)
                {
                    for (int col = 1; col <= cols; col++)
                    {
                        if (col -1 < _letras.Length)
                        {
                            string assento = $"{row}{_letras[col - 1]}";

                            Button assentoButao = new Button
                            {
                                Text = assento,
                                Dock = DockStyle.Fill,
                                Tag = $"{row},{col}"
                            };

                            // Verificar "reservado"

                            Assento assentoOcu = _assentos.FirstOrDefault(a => a.Fila == row && a.Coluna == col);

                            if (assentoOcu != null)
                            {
                                if (assentoOcu.Ocupado == true)
                                {
                                    assentoButao.BackColor = Color.Red;
                                    assentoButao.Enabled = false;
                                }
                                else if (assentoOcu.Ocupado == false)
                                {
                                    assentoButao.BackColor = Color.LightGray;
                                    assentoButao.Click += btnAssento_Click;
                                }
                            }


                            assentosPosicao.Controls.Add(assentoButao, col - 1, row - 1);

                        }
                    }

                    panelAssentos.Controls.Add(assentosPosicao);
                    this.Controls.Add(panelAssentos);

                    assentosPosicao.Dock = DockStyle.Top;
                    assentosPosicao.AutoSize = true;
                    assentosPosicao.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    panelAssentos.AutoScroll = true;
                }
            }                    
        }

        //Escolher assento com butão
        private void btnAssento_Click(object sender, EventArgs e)
        {
            Button btnEscolhido = sender as Button;

            if (btnEscolhido != null)
            {
                if (_assentoEscolhido != null)
                {
                    _assentoEscolhido.BackColor = Color.LightGray;
                }

                MessageBox.Show($"Escolhou assento: {btnEscolhido.Text}");
                btnEscolhido.BackColor = Color.Green;

                string[] tagFilaEColuna = btnEscolhido.Tag.ToString().Split(',');

                _lugar = btnEscolhido.Text;   
                _fila = int.Parse(tagFilaEColuna[0]); 
                _coluna = int.Parse(tagFilaEColuna[1]); 

                _assentoEscolhido = btnEscolhido;
            }
        }

        //Atualizar lugar em form EditarBilhete
        private void FormEscolherLugar_FormClosed(object sender, FormClosedEventArgs e)
        {
            _lugar = null;
            _formEB.MostrarLugar();
        }

        //Guardar alteração
        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_lugar))
            {
                _formEB.Lugar = _lugar;
                _formEB.MostrarLugar();
                //_bilhete.Assento.Fila = _fila;
                //_bilhete.Assento.Coluna = _coluna;

                _bilhete.Assento = _assentos.FirstOrDefault(a => a.Fila == _fila && a.Coluna == _coluna);

                Close();
            }
        }
        //Fechar form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ConverterAssentoLugar()
        {

        }

    }

}
    

