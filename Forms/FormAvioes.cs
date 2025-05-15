using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure;
using BibliotecaAeronautica.Entities;
using BibliotecaAeronautica.Models;
using BibliotecaAeronautica.Services;

namespace Forms
{
    public partial class FormAvioes : Form
    {
        private List<Voo> _voos;
        private List<Aviao> _avioes;
        private ApiService _apiService;

        private List<Bilhete> _bilhetesSemVoo;
        public FormAvioes()
        {
            InitializeComponent();
            _apiService = new ApiService();
            LoadApi();            
        }


        private async Task LoadApi()
        {
            var response = await _apiService.GetAvioes("https://localhost:44328", "/api/avioes");

            _avioes = (List<Aviao>)response.Result;

            IniciarLista();
        }

        //Adicionar aviao
        private void btnAdicionarAviao_Click(object sender, EventArgs e)
        {
            //FormAdiAviao formAdiAviao = new FormAdiAviao(_avioes, _voos, _bilhetesSemVoo);
            //formAdiAviao.Show();
            //Close();
        }
        
        //Atualizar a tela
        public void IniciarLista()
        {         
            listBoxAvioes.DataSource = null;
            listBoxAvioes.DataSource = _avioes;
            listBoxAvioes.DisplayMember = "Info";
        }
        //Retirar aviao de serviço
        private void btnRetirarAviao_Click(object sender, EventArgs e)
        {

            //Aviao escolhido = (Aviao)listBoxAvioes.SelectedItem;

            //Aviao retirado = Validacoes.ValidarAviao(escolhido, _avioes);

            //List<Voo> voosFuturos = new List<Voo>();

            //    if (retirado != null && retirado.Estado == Estado.ativo)
            //    {
            //        foreach (Voo voo in retirado.Voos)
            //        {
            //            if (voo.Data > DateTime.Now.Date)
            //            {
            //                voosFuturos.Add(voo);
            //            }
            //            else if (voo.Data == DateTime.Now.Date && voo.Hora > DateTime.Now.TimeOfDay)
            //            {
            //                voosFuturos.Add(voo);
            //            }
            //        }
            //        if (voosFuturos.Any())
            //        {
            //            MessageBox.Show("Aviao ainda tem voos para cumprir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //    }
            //    if (retirado != null && retirado.Estado == Estado.ativo)
            //    {
            //        DialogResult resposta;
            //        resposta = MessageBox.Show($"Tem a certeza que pretende retirar o {retirado.Marca} {retirado.Nome} de serviço?",
            //        "Retirar",
            //        MessageBoxButtons.OKCancel,
            //        MessageBoxIcon.Question);

            //        if (DialogResult.OK == resposta)
            //        {
            //            retirado.Estado = Estado.inativo;
            //            IniciarLista();
            //        }
            //    }
            //    else if (retirado != null && retirado.Estado == Estado.inativo)
            //    {
            //        retirado.Estado = Estado.ativo;
            //        IniciarLista();
            //    }
            
        }

        //Editar aviao
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Aviao aviaoAEditar = (Aviao)listBoxAvioes.SelectedItem;

            //TODO: Validação necesario?
               
            if (aviaoAEditar != null)
            {
                FormEditarAviao formEditarAviao = new FormEditarAviao(aviaoAEditar);
                formEditarAviao.Show();
                this.Close();
            }


        }
        //Apagar aviao
        private void btnApagar_Click(object sender, EventArgs e)
        {
            bool aviaoUsado = false;

            Aviao escolhido = (Aviao)listBoxAvioes.SelectedItem;

            Aviao aviaoAApagar = Validacoes.ValidarAviao(escolhido, _avioes);

            if (aviaoAApagar != null)
            {
                //Nunca tiver sido usado em voos.

                foreach (Voo voo in _voos)
                {
                    if (aviaoAApagar.Id == voo.Aviao.Id)
                    {
                        aviaoUsado = true;
                    }
                }
            }

            if (aviaoUsado == false)
            {
                DialogResult resposta;
                resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {aviaoAApagar.Marca} {aviaoAApagar.Nome} de serviço?",
                "Apagar",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

                if (DialogResult.OK == resposta)
                {
                    _avioes.Remove(aviaoAApagar);
                    IniciarLista();
                }

            }
            else
            {
                MessageBox.Show("Aviao não pode ser apagado");
            }

            IniciarLista();

        }
        //Fechar form
        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


