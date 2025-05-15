using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaAeronautica.Entities;
using BibliotecaAeronautica.Models;
using BibliotecaAeronautica.Services;
namespace Forms
{
    public partial class FormEditarAviao : Form
    {
        private Aviao _editado;
        private List<Aviao> _avioes;
        private List<Voo> _voos;
        private List<Voo> _voosFuturos;
        private List<Voo> _voosPasados;
        private List<Bilhete> _bilhetesSemVoo;
        private Voo _voo;
        private ApiService _apiService;

        public FormEditarAviao(Aviao editado)
        {
            InitializeComponent();
            //_voos = voos;
            //_avioes = avioes;
            _apiService = new ApiService();
            _editado = editado;
            //_bilhetesSemVoo = bilhetesSemVoo;
            LoadApi(_editado);



        }

        private async Task LoadApi(Aviao editado)
        {
            if (editado != null) 
            {
                var responseA = await _apiService.GetVoos("https://localhost:44328", $"/api/aviao/{editado.Id}/voos");

                //var responseE = await _apiService.GetBilhetes("https://localhost:44328", "/api/bilhetes");

                //List<VooResumoDto> voosLista = (List<VooResumoDto>)responseA.Result;

                _voos = (List<Voo>)responseA.Result;

                IniciarListaVoos();
            }
        }

        public void IniciarListaVoos()
        {
            SepararVoos();

            listBoxVoosFuturo.DataSource = null;
            listBoxVoosFuturo.DataSource = _voosFuturos;
            listBoxVoosFuturo.DisplayMember = "VooInfo";
            listBoxVoosPasado.DataSource = null;
            listBoxVoosPasado.DataSource = _voosPasados;
            listBoxVoosPasado.DisplayMember = "VooInfo";
        }

        public void SepararVoos()
        {
            _voosFuturos = new List<Voo>();
            _voosPasados = new List<Voo>();

            foreach (Voo voo in _voos)
            {
                if (voo.Data > DateTime.Now.Date)
                {
                    _voosFuturos.Add(voo);
                }
                else if (voo.Data == DateTime.Now.Date && voo.Hora > DateTime.Now.TimeOfDay)
                {
                    _voosFuturos.Add(voo);
                }
                else
                {
                    _voosPasados.Add(voo);
                }
            }

        }
        





        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (ValidaForm())
            //{

            //    _editado.Nome = txtBoxNome.Text;
            //    _editado.Marca = txtBoxMarca.Text;
            //    _editado.Filas = Convert.ToInt32(txtBoxFilas.Text);
            //    _editado.AssentosPorFila = Convert.ToInt32(txtBoxAssentosFilas.Text);
            //    //_editado.Lugares = new int[Convert.ToInt32(txtBoxFilas.Text), Convert.ToInt32(txtBoxAssentosFilas.Text)];
            //    List<Bilhete> bilhetesARemover = new List<Bilhete>();
            //    List<Bilhete> bilhetesBebesARemover = new List<Bilhete>();

            //    foreach (Voo voo in _editado.Voos)
            //    {
            //        //Check Voo date is in the future 

            //        if (voo.Data > DateTime.Now.Date)
            //        {
            //            //Gravar o atual plano de assentos


            //            string[,] atualPlanoAssentos = new string[voo.AssentosReservados.GetLength(0), voo.AssentosReservados.GetLength(1)];

            //            //Encher o matrix

            //            for (int i = 0; i < voo.AssentosReservados.GetLength(0); i++)
            //            {
            //                for (int j = 0; j < voo.AssentosReservados.GetLength(1); j++)
            //                {
            //                    if (voo.AssentosReservados[i, j] == "reservado")
            //                    {
            //                        atualPlanoAssentos[i, j] = "reservado";
            //                    }

            //                }
            //            }

            //            //Mudar tamanho de plano de assentos

            //            voo.AssentosReservados = new string[_editado.Filas, _editado.AssentosPorFila];

            //            //Encher novo matrix

            //            foreach (Bilhete bilhete in voo.BilhetesVendidos)
            //            {

            //                if (bilhete is BilheteAdulto || bilhete is BilheteCrianca)
            //                {
            //                    string lugar = bilhete.Lugar;

            //                    int coluna;
            //                    int linha;
            //                    int linhaNumero = 0;
            //                    char colunaLetra = lugar[0];

            //                    if (lugar.Length == 2)
            //                    {
            //                        linhaNumero = linhaNumero * 10 + (lugar[1] - '0');
            //                    }
            //                    else
            //                    {
            //                        for (int i = 1; i < lugar.Length; i++)
            //                        {
            //                            linhaNumero = linhaNumero * 10 + (lugar[i] - '0');
            //                        }

            //                    }

            //                    //linhaNumero = Convert.ToInt32(lugarMaisDe10);

            //                    linha = linhaNumero - 1;
            //                    coluna = colunaLetra - 'A';


            //                    if (linha < voo.AssentosReservados.GetLength(0) && coluna < voo.AssentosReservados.GetLength(1) && voo.AssentosReservados[linha, coluna] != "reservado")
            //                    {
            //                        voo.AssentosReservados[linha, coluna] = "reservado";
            //                    }
            //                    else
            //                    {
            //                        bool lugarEncontrado = false;

            //                        for (int i = 0; i < voo.AssentosReservados.GetLength(0); i++)
            //                        {
            //                            for (int j = 0; j < voo.AssentosReservados.GetLength(1); j++)
            //                            {
            //                                if (!lugarEncontrado && voo.AssentosReservados[i, j] == null)
            //                                {
            //                                    voo.AssentosReservados[i, j] = "reservado";
            //                                    lugarEncontrado = true;

            //                                    char[] letras = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            //                                    bilhete.Lugar = $"{letras[i]}{j + 1}";
            //                                }
            //                            }
            //                        }


            //                        if (lugarEncontrado == false)
            //                        {
            //                            bilhetesARemover.Add(bilhete);

            //                        }

            //                    }
            //                }
                            
            //            }



            //            if (bilhetesARemover.Count() > 0)
            //            {
            //                MessageBox.Show("Há bilhetes para reatribuir", "Erro");
            //            }



            //            if (voo.BilhetesVendidos.Any(b => b is BilheteBebe))
            //            {
            //                List<BilheteBebe> bilheteBebes = _voo.BilhetesVendidos.OfType<BilheteBebe>().ToList();

            //                foreach (BilheteBebe bil in bilheteBebes)
            //                {
            //                    foreach (Bilhete bilheteResponsavel in bilhetesARemover)
            //                    {
            //                        if (bil.Responsavel.Id == bilheteResponsavel.Id)
            //                        {
            //                            bilhetesBebesARemover.Add(bil);
            //                        }
            //                    }

            //                }
            //            }
                        
            //            //Remover bilhetes do voo previo

            //            foreach (Bilhete bilheteRem in bilhetesARemover)
            //            {
            //                bilheteRem.Voo = null;
            //                bilheteRem.Lugar = null;
            //                voo.BilhetesVendidos.Remove(bilheteRem);
            //                _bilhetesSemVoo.Add(bilheteRem);
            //            }
            //            foreach (Bilhete bilheteBebeRem in bilhetesBebesARemover)
            //            {
            //                bilheteBebeRem.Voo = null;
            //                bilheteBebeRem.Lugar = null;
            //                voo.BilhetesVendidos.Remove(bilheteBebeRem);
            //                _bilhetesSemVoo.Add(bilheteBebeRem);
            //            }

            //            Close();

            //        }
            //    }
            //}
            //Close();
        }
        //Atualizar a tela
        private void IniciarLista()
        {
            //(_voosPasados, _voosFuturos) = SepararVoos(_editado.Voos);
            listBoxVoosFuturo.DataSource = null;
            listBoxVoosFuturo.DataSource = _voosFuturos;
            listBoxVoosFuturo.DisplayMember = "BilheteInfo";
            listBoxVoosPasado.DataSource = null;
            listBoxVoosPasado.DataSource = _voosPasados;
            listBoxVoosPasado.DisplayMember = "BilheteInfo";
            txtBoxId.Text = Convert.ToString(_editado.Id);
            txtBoxNome.Text = _editado.Nome;
            txtBoxMarca.Text = _editado.Marca;
            txtBoxFilas.Text = Convert.ToString(_editado.Filas);
            txtBoxAssentosFilas.Text = Convert.ToString(_editado.AssentosPorFila);
            
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
            if (string.IsNullOrEmpty(txtBoxAssentosFilas.Text) || !int.TryParse(txtBoxAssentosFilas.Text, out _))
            {
                MessageBox.Show("Insira número de assentos por fila", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        //Separar voos passados e voos futuros
        private (List<Voo> VoosPasados, List<Voo> VoosFuturos) SepararVoos(List<Voo> voos)
        {
            List<Voo> _voosFuturos = new List<Voo>();
            List<Voo> _voosPasados = new List<Voo>();

            foreach (Voo voo in voos)
            {
                if (voo.Data < DateTime.Now.Date)
                {
                    _voosPasados.Add(voo);
                }
                else if (voo.Data == DateTime.Now.Date && voo.Hora <= DateTime.Now.TimeOfDay)
                {
                    _voosPasados.Add(voo);
                }
                else
                {
                    _voosFuturos.Add(voo);
                }

            }
            return (_voosPasados, _voosFuturos);
        }
        
        //Fechar form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Remover voo
        private void btnApagar_Click(object sender, EventArgs e)
        {

            if (listBoxVoosFuturo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um voo para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Voo escolhido = (Voo)listBoxVoosFuturo.SelectedItem;

                _voo = Validacoes.ValidarVoo(escolhido, _voos);

                DialogResult result = MessageBox.Show($"Tem certeza que pretende remover o voo {_voo.Id}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) 
                {

                    FormReatribuirAviao formReatribuirAviao = new FormReatribuirAviao(_voos, _avioes, _editado, _voo, _bilhetesSemVoo);
                    formReatribuirAviao.Show();
                    Close();

                }
                else 
                {
                    return;
                }
            }


        }
        //Fechar form
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
