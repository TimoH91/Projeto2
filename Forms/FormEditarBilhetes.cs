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
using static Forms.FormComprarBilhetes;

namespace Forms
{
    public partial class FormEditarBilhetes : Form
    {
        private List<Bilhete> _bilhetes;

        private List<Voo> _voos;

        private Bilhete _bilheteEditado;

        private VooResumoDto _voo;

        private ApiService _apiService;

        private string[,] _assentosAEditar;

        public string Lugar;

        public FormEditarBilhetes(Bilhete bilheteEditado)
        {
            InitializeComponent();
            //_voos = voos;
            _bilheteEditado = bilheteEditado;
            _apiService = new ApiService();
            //_voo = voo;
            //_bilhetes = bilhetes;
            IniciarLista();
        }
        //Atualizar a tela
        private void IniciarLista()
        {
            //Lugar = _bilheteEditado.Lugar;
            //_assentosAEditar = new string[Convert.ToInt32(_bilheteEditado.Voo.Aviao.Filas), Convert.ToInt32(_bilheteEditado.Voo.Aviao.AssentosPorFila)];
            comboBoxTarifa.DataSource = Enum.GetValues(typeof(Tarifa));
            comboBoxTipo.DataSource = Enum.GetValues(typeof(TipoBilhete));
            txtBoxNome.Text = _bilheteEditado.Nome;
            txtBoxApelido.Text = _bilheteEditado.Apelido;
            txtBoxVoo.Text = _bilheteEditado.Voo.VooInfo;
            //lblLugar.Text = _bilheteEditado.Assento;

        }

        public void LugarConversao()
        {
            var letras = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            //string fila = _bilheteEditado.Assento[0];

            //Lugar[0] = _bilheteEditado.Assento[0];


        }


        //Escolher novo lugar 
        private void btnAlterarLugar_Click(object sender, EventArgs e)
        {
            if (_bilheteEditado.Tipo != "Bebe")
            {
                FormEditarLugar formEditarLugar = new FormEditarLugar(this, _bilheteEditado);
                formEditarLugar.Show();
            }
            else
            {
                MessageBox.Show("Bilhetes de tipo Bebe não podem alterar o lugar");
            }

        }

        //Mostrar lugar escholido
        public void MostrarLugar()
        {
            lblLugar.Text = Lugar;
        }

        //Guardar alterações
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ValidaForm())
            {
                //Atualizar dados no bilhete
               
                _bilheteEditado.Nome = txtBoxNome.Text;
                _bilheteEditado.Apelido = txtBoxApelido.Text;
                _bilheteEditado.Tarifa = (Tarifa)comboBoxTarifa.SelectedItem;
                //Assento já está atualizado

                PutBilhete(_bilheteEditado);
                


                // NEED TO POST AT THIS POINT - CHECK ASSENTO AUTOMATICALLY GOES TO OCUPADO


                //Remover lugar previa dos assentos reservados

                //string lugarAtual = _bilheteEditado.Lugar;

                //int coluna;
                //int linha;
                //int linhaNumero = 0;
                //char colunaLetra = lugarAtual[0];

                //if (lugarAtual.Length == 2)
                //{
                //    linhaNumero = linhaNumero * 10 + (lugarAtual[1] - '0');
                //}
                //else
                //{
                //    for (int i = 1; i < lugarAtual.Length; i++)
                //    {
                //        linhaNumero = linhaNumero * 10 + (lugarAtual[i] - '0');
                //    }

                //}

                //coluna = colunaLetra - 'A';
                //linha = linhaNumero - 1;

                ////_bilheteEditado.Voo.AssentosReservados[linha, coluna] = null;

                ////Adicionar lugar novo aos assentos reservados

                //int linhaNumeroNovo = 0;
                //char colunaLetraNovo = Lugar[0];


                //if (Lugar.Length == 2)
                //{
                //    linhaNumeroNovo = linhaNumeroNovo * 10 + (Lugar[1] - '0');
                //}
                //else
                //{
                //    for (int i = 1; i < Lugar.Length; i++)
                //    {
                //        linhaNumeroNovo = linhaNumeroNovo * 10 + (Lugar[i] - '0');
                //    }

                //}

                //coluna = colunaLetraNovo - 'A';
                //linha = linhaNumeroNovo - 1;


                //_bilheteEditado.Voo.AssentosReservados[linha, coluna] = "reservado";




                ////Atualizar bilhetesBebe que têm o mesmo lugar se este bilhete for responsavel
                //_bilheteEditado.Voo.BilhetesVendidos.OfType<BilheteBebe>().Where(bebe => bebe.Lugar == lugarAtual).ToList().ForEach(bebe => bebe.Lugar = Lugar);

                //Atualizar dados no bilhete
                //_bilheteEditado.Lugar = Lugar;
                //_bilheteEditado.Nome = txtBoxNome.Text;
                //_bilheteEditado.Apelido = txtBoxApelido.Text;
                //_bilheteEditado.Tarifa = (Tarifa)comboBoxTarifa.SelectedItem;

                //Close();
            }

        }


        private async Task PutBilhete(Bilhete bilheteEditado)
        {
            var responseA = await _apiService.PutBilhete("https://localhost:44328", $"/api/Bilhetes/{bilheteEditado.Id}", bilheteEditado);

            Bilhete bil = (Bilhete)responseA.Result;
        }

        //Validar os inputs
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txtBoxNome.Text))
            {
                MessageBox.Show("Insira Nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtBoxApelido.Text))
            {
                MessageBox.Show("Insira Apelido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
        //Fechar form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
