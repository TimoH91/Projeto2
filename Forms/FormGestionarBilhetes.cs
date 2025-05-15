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
using BibliotecaAeronautica.DTOs;
using BibliotecaAeronautica.Entities;
using BibliotecaAeronautica.Models;
using BibliotecaAeronautica.Services;

namespace Forms
{
    public partial class FormGestionarBilhetes : Form
    {
        private List<Voo> _voos;

        private List<Bilhete> _bilhetes;

        private ApiService _apiService;

        public FormGestionarBilhetes()
        {
            InitializeComponent();
            //_voos = voos;
            //_bilhetes = bilhetes;
            //IniciarListaVoos();
            _apiService = new ApiService();
            LoadApi();



        }

        private async Task LoadApi()
        {
            var responseA = await _apiService.GetVoos("https://localhost:44328", "/api/voo");

            //var responseE = await _apiService.GetBilhetes("https://localhost:44328", "/api/bilhetes");

            //List<VooResumoDto> voosLista = (List<VooResumoDto>)responseA.Result;

            _voos = (List<Voo>)responseA.Result;

            IniciarListaVoos();
        }

        private void IniciarListaVoos()
        {
            listBoxVoos.DataSource = null;
            listBoxVoos.DataSource = _voos;
            listBoxVoos.DisplayMember = "VooInfo";
        }



        //Mudar escolha de voo
        private void listBoxVoos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Validar Voo
            Voo vooAEscolher = (Voo)listBoxVoos.SelectedItem;

            if (vooAEscolher != null)
            {
                int id = vooAEscolher.Id;
                IniciarListaBilhetes(id);
            }
            //VooResumoDto vooEscolhido = Validacoes.ValidarVoo(vooAEscolher, _voos);
            //Atualiza lista dos bilhetes

        }

        //Mostrar voos e bilhetes do voo
        private void IniciarListaVoosOLD()
        {
            listBoxVoos.DataSource = null;
            listBoxVoos.DataSource = _voos;
            listBoxVoos.DisplayMember = "BilheteInfo";

            if (_voos.Any())
            {
                //Validar Voo
                Voo vooAEscolher = (Voo)listBoxVoos.SelectedItem;
                Voo vooEscolhido = Validacoes.ValidarVoo(vooAEscolher, _voos);

                //listBoxBilhetes.DataSource = vooEscolhido.BilhetesVendidos;
                //listBoxBilhetes.DisplayMember = "Info";
            }

        }
        //Mostrar bilhetes no voo
        private async Task IniciarListaBilhetes(int id)
        {
            var responseA = await _apiService.GetBilhetes("https://localhost:44328", $"/api/voo/{id}/bilhetes");

            List<Bilhete> bilsLista = (List<Bilhete>)responseA.Result;

            listBoxBilhetes.DataSource = null;
            listBoxBilhetes.DataSource = bilsLista;
            listBoxBilhetes.DisplayMember = "Info";
        }

        //Apagar bilhete
        public async Task ApagarBilhete(int id)
        {
            var responseA = await _apiService.DeleteBilhete("https://localhost:44328", $"/api/bilhetes/{id}");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            BilheteResumoDto bilAApagar = (BilheteResumoDto)listBoxBilhetes.SelectedItem;

            if (bilAApagar != null)
            {
                int id = bilAApagar.Id;
                ApagarBilhete(id);
            }
            



            //Validar Bilhete
            //Bilhete bilheteAEscolher = (Bilhete)listBoxBilhetes.SelectedItem;

            //Bilhete bilheteEscolhido = Validacoes.ValidarBilhete(bilheteAEscolher, _bilhetes);

            //Validar Voo
            //Voo vooAEscolher = (Voo)listBoxVoos.SelectedItem;

            //Voo vooEscolhido = Validacoes.ValidarVoo(vooAEscolher, _voos);

            //if (bilheteEscolhido != null && vooEscolhido != null)
            //{
            //    if (bilheteEscolhido.Voo.Data >= DateTime.Now.Date)
            //    {
            //        if (bilheteEscolhido.Voo.Data == DateTime.Now.Date && bilheteEscolhido.Voo.Hora > DateTime.Now.TimeOfDay || bilheteEscolhido.Voo.Data > DateTime.Now.Date)
            //        {//{

            //            DialogResult resposta;
            //            resposta = MessageBox.Show($"Tem a certeza que pretende apagar o bilhete?",
            //            "Apagar",
            //            MessageBoxButtons.OKCancel,
            //            MessageBoxIcon.Question);

            //            if (DialogResult.OK == resposta)
            //            {

            //                vooEscolhido.BilhetesVendidos.Remove(bilheteEscolhido);

            //                vooEscolhido.BilhetesVendidos.RemoveAll(b => b is BilheteBebe bilheteBebe && bilheteBebe.Responsavel.Id == bilheteEscolhido.Id);

            //                //Verificar reserva
            //                string lugar = bilheteEscolhido.Lugar;

            //                int coluna;
            //                int linha;
            //                int linhaNumero = 0;
            //                char colunaLetra = lugar[0];

            //                if (lugar.Length == 2)
            //                {
            //                    linhaNumero = linhaNumero * 10 + (lugar[1] - '0');
            //                }
            //                else
            //                {
            //                    for (int i = 1; i < lugar.Length; i++)
            //                    {
            //                        linhaNumero = linhaNumero * 10 + (lugar[i] - '0');
            //                    }

            //                }
            //                coluna = colunaLetra - 'A';
            //                linha = linhaNumero - 1;

            //                vooEscolhido.AssentosReservados[linha, coluna] = null;
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Náo é possível editar ou apagar bilhetes nos voos passados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }



            //        If Bilhete bebe exists also delete

            //    }
            //    else
            //    {
            //        MessageBox.Show("Náo é possível editar ou apagar bilhetes nos voos passados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //    IniciarListaBilhetes(vooEscolhido);
            //}
        }


        //Editar Bilhete
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            Bilhete bilheteAEditar = (Bilhete)listBoxBilhetes.SelectedItem;

            //TODO: Validate?? tipo if id does not equal the id in the database?

           // var responseA = await _apiService.GetAeroportoById("https://localhost:44328", $"/api/Aeroportos/{bilheteDto.AeroportoOrigemId}");
           // var responseB = await _apiService.GetAeroportoById("https://localhost:44328", $"/api/Aeroportos/{bilheteDto.AeroportoDestinoId}");
           // var responseC = await _apiService.GetVooById("https://localhost:44328", $"/api/Voo/{bilheteDto.VooId}");
           // var responseD = await _apiService.GetAssentoById("https://localhost:44328", $"/api/Assentos/{bilheteDto.AssentoId}");

           //Aeroporto aeroportoOrigem = (Aeroporto)responseA.Result;
           //Aeroporto aeroportoDestino = (Aeroporto)responseB.Result;
           //Voo voo = (Voo)responseC.Result;
           //Assento assento = (Assento)responseD.Result;
            //TODO: Map this object to an actual bilhete



            //choose from the list?




            //BilheteAdulto bilheteAEditar = new BilheteAdulto(
            //    bilheteDto.Id,
            //    bilheteDto.Nome,
            //    bilheteDto.Apelido,
            //    voo,
            //    (Tarifa)bilheteDto.Tarifa,
            //    assento
            //);

            //bilheteAEditar.Preco = (decimal)bilheteDto.Preco;
            //bilheteAEditar.Origem = aeroportoOrigem;
            //bilheteAEditar.Destino = aeroportoDestino;
            //bilheteAEditar.Pagamento = (Pagamento)bilheteDto.Pagamento;


            //var response = await _apiService.GetBilhetesResumo("https://localhost:44328", $"/api/Bilhetes/{bilheteDto.Id}");

            //List<BilheteResumoDto> bilAEditar = (List<BilheteResumoDto>)response.Result;

            //VooResumoDto voo = (VooResumoDto)listBoxVoos.SelectedItem;

            if (bilheteAEditar != null)
            {
                if (bilheteAEditar.Voo != null)
                {
                    if (bilheteAEditar.Voo.Data > DateTime.Now.Date || (bilheteAEditar.Voo.Data == DateTime.Now.Date && bilheteAEditar.Voo.Hora > DateTime.Now.TimeOfDay))
                    {
                        FormEditarBilhetes formEditarBilhetes = new FormEditarBilhetes(bilheteAEditar);
                        formEditarBilhetes.Show();
                    }
                    else
                    {
                        MessageBox.Show("Náo é possível editar ou apagar bilhetes nos voos passados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }



            ////Validar Bilhete
            //Bilhete bilheteAEscolher = (Bilhete)listBoxBilhetes.SelectedItem;

            //Bilhete bilheteEscolhido = Validacoes.ValidarBilhete(bilheteAEscolher, _bilhetes);

        //    //Validar Voo
        //    Voo vooAEscolher = (Voo)listBoxVoos.SelectedItem;

        //    Voo vooEscolhido = Validacoes.ValidarVoo(vooAEscolher, _voos);

        //    if (bilheteEscolhido != null && vooEscolhido != null)
        //    {
        //        if (bilheteEscolhido.Voo.Data >= DateTime.Now.Date)
        //        {
        //            if (bilheteEscolhido.Voo.Data == DateTime.Now.Date && bilheteEscolhido.Voo.Hora > DateTime.Now.TimeOfDay || bilheteEscolhido.Voo.Data > DateTime.Now.Date)
        //            {
        //                FormEditarBilhetes formEditarBilhetes = new FormEditarBilhetes(_bilhetes, _voos, bilheteEscolhido);
        //                formEditarBilhetes.Show();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Náo é possível editar ou apagar bilhetes nos voos passados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        //Atualizar lista dos bilhetes
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Validar Voo
            Voo vooAEscolher = (Voo)listBoxVoos.SelectedItem;

            Voo vooEscolhido = Validacoes.ValidarVoo(vooAEscolher, _voos);

            //IniciarListaBilhetes(vooEscolhido);
        }

    }
}

