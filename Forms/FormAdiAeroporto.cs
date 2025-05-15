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
using BibliotecaAeronautica.Entities;
using BibliotecaAeronautica.Models;
using BibliotecaAeronautica.Services;

namespace Forms
{
    public partial class FormAdiAeroporto : Form
    {
        private List<Aeroporto> _aeroportos;

        private List<Voo> _voos;
        public FormAdiAeroporto(List<Aeroporto> aeroportos, List<Voo> voos)
        {
            InitializeComponent();
            _aeroportos = aeroportos;
            _voos = voos;

            if (_aeroportos.Any())
            {
                txtBoxId.Text = Convert.ToString(_aeroportos.Max(Aeroporto => Aeroporto.Id) + 1);

            }
            else
            {
                txtBoxId.Text = Convert.ToString(1);

            }
        }

        //Adicionar Aeroporto
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Aeroporto novoAeroporto;

            if (ValidaForm())
            {
                novoAeroporto = new Aeroporto
                {
                    Id = Convert.ToInt32(txtBoxId.Text),
                    Nome = txtBoxNome.Text,
                    Cidade = txtBoxCidade.Text,
                };

                _aeroportos.Add(novoAeroporto);

                FormAeroportos formAeroportos = new FormAeroportos(_aeroportos, _voos);
                formAeroportos.Show();
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

            if (string.IsNullOrEmpty(txtBoxCidade.Text))
            {
                MessageBox.Show("Insira Cidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
        //fechar form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
