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

    public partial class FormEditarAeroporto : Form
    {

        private List<Aeroporto> _aeroportos;

        private List<Voo> _voos;

        private Aeroporto _editado;
        public FormEditarAeroporto(List<Aeroporto> aeroportos, Aeroporto editado, List<Voo> voos)
        {
            InitializeComponent();
            _editado = editado;
            _aeroportos = aeroportos;
            _voos = voos;
            IniciarLista();

        }
        //Atualizar a tela
        private void IniciarLista()
        {
            txtBoxId.Text = Convert.ToString(_editado.Id);
            txtBoxNome.Text = _editado.Nome;
            txtBoxCidade.Text = _editado.Cidade;
        }

        //Guardar alterações
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                _editado.Nome = txtBoxNome.Text;
                _editado.Cidade = txtBoxCidade.Text;
                FormAeroportos formAeroportos = new FormAeroportos(_aeroportos, _voos);
                formAeroportos.Show();
                Close();


            }
        }

        //Validar os inpits
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txtBoxNome.Text))
            {
                MessageBox.Show("Insira Nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtBoxCidade.Text))
            {
                MessageBox.Show("Insira Cidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
