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
    public partial class FormAeroportos : Form
    {
        private List<Aeroporto> _aeroportos;

        private List<Voo> _voos;

        public FormAeroportos(List<Aeroporto> aeroportos, List<Voo> voos)
        {
            InitializeComponent();
            _aeroportos = aeroportos;
            IniciarLista();
            _voos = voos;

        }

        //Adicionar Aeroporto
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormAdiAeroporto formAdiAeroporto = new FormAdiAeroporto(_aeroportos, _voos);
            formAdiAeroporto.Show();
            Close();
        }
        
        //Atualizar a tela
        public void IniciarLista()
        {
            listBoxAeroportos.DataSource = null;
            listBoxAeroportos.DataSource = _aeroportos;
            listBoxAeroportos.DisplayMember = "InfoGeral";

        }

        //Apagar Aeroporto
        private void btnApagarAeroporto_Click(object sender, EventArgs e)
        {          
            Aeroporto escolhido = (Aeroporto)listBoxAeroportos.SelectedItem;

            Aeroporto apagado = Validacoes.ValidarAeroporto(escolhido, _aeroportos);

            if (apagado != null)
            {
                foreach (Voo voo in _voos)
                {

                    if (voo.Origem.Id == apagado.Id || voo.Destino.Id == apagado.Id)
                    {
                        MessageBox.Show("Aeroporto não pode ser apagado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DialogResult resposta;
                resposta = MessageBox.Show($"Tem a certeza que pretende apagar o aeroporto {apagado.Nome} do registro?",
                "Apagar",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

                if (DialogResult.OK == resposta)
                {
                    _aeroportos.Remove(apagado);
                    IniciarLista();
                }


            }

        }
        //Editar Aeroport
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Aeroporto escolhido = (Aeroporto)listBoxAeroportos.SelectedItem;

            Aeroporto editado = Validacoes.ValidarAeroporto(escolhido, _aeroportos);

            if (editado != null)
            {
                foreach (Voo voo in _voos)
                {
                    //what about Escalas??
                    if (voo.Origem.Id == editado.Id || voo.Destino.Id == editado.Id)
                    {
                        MessageBox.Show("Aeroporto não pode ser editado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                FormEditarAeroporto formEditarAeroporto = new FormEditarAeroporto(_aeroportos, editado, _voos);
                formEditarAeroporto.Show();
                Close();
            }

        }
        //Fechar Form
        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

    }



}

     

