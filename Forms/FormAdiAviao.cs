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

namespace Forms
{
    public partial class FormAdiAviao : Form
    {
        private List<Aviao> _avioes;

        private List<Voo> _voos;

        private List<Bilhete> _bilhetesSemVoo;
        public FormAdiAviao(List<Aviao> avioes, List<Voo> voos, List<Bilhete> bilhetesSemVoo)
        {
            InitializeComponent();

            _avioes = avioes;
            _voos = voos;
            _bilhetesSemVoo = bilhetesSemVoo;

            IniciarLista();

        }
        //Atualizar a tela
        private void IniciarLista()
        {
            if (_avioes.Any())
            {
                txtBoxId.Text = Convert.ToString(_avioes.Max(Aviao => Aviao.Id) + 1);

            }
            else
            {
                txtBoxId.Text = Convert.ToString(1);

            }
        }

        //Adicinoar novo avião
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Aviao novoAviao;

            if (ValidaForm())
            {
                novoAviao = new Aviao
                {
                    Id = Convert.ToInt32(txtBoxId.Text),
                    Nome = txtBoxNome.Text,
                    Marca = txtBoxMarca.Text,
                    Filas = Convert.ToInt32(txtBoxFilas.Text),
                    AssentosPorFila = Convert.ToInt32(txtBoxAssentosFilas.Text),
                    Estado = Estado.ativo,
                    //Lugares = new int[Convert.ToInt32(txtBoxFilas.Text), Convert.ToInt32(txtBoxAssentosFilas.Text)],
                };

                _avioes.Add(novoAviao);

                FormAvioes formAvioes = new FormAvioes();
                formAvioes.Show();
                Close();
            }
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
            if (string.IsNullOrEmpty(txtBoxMarca.Text))
            {
                MessageBox.Show("Insira Marca", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txtBoxFilas.Text) || !int.TryParse(txtBoxFilas.Text, out _))
            {
                MessageBox.Show("Insira número de filas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if(Convert.ToInt32(txtBoxFilas.Text) > 70)
            {

                MessageBox.Show("Insira menos número de filas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;

            }
            if (string.IsNullOrEmpty(txtBoxAssentosFilas.Text) || !int.TryParse(txtBoxAssentosFilas.Text, out _))
            {
                MessageBox.Show("Insira número de assentos por fila", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToInt32(txtBoxAssentosFilas.Text) > 25)
            {

                MessageBox.Show("Insira menos número de assentos por fila", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
