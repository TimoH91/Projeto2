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
    public partial class FormReatribuirAviao : Form
    {
        private List<Voo> _voos;
        private List<Aviao> _avioes;
        private Aviao _editado;
        private Voo _voo;
        private List<Bilhete> _bilhetesSemVoo;
        public FormReatribuirAviao(List<Voo> voos, List<Aviao> avioes, Aviao editado, Voo voo, List<Bilhete> bilhetesSemVoo)
        {
            InitializeComponent();

            _voos = voos;
            _avioes = avioes;
            _editado = editado;
            _voo = voo;
            _bilhetesSemVoo = bilhetesSemVoo;

            IniciarLista();
        }

        //Atualizar a tela
        private void IniciarLista()
        {
            //txtBoxVoo.Text = _voo.BilheteInfo;
            //listBoxAvioesDisponiveis.DataSource = avioesDisponiveis();
            //listBoxAvioesDisponiveis.DisplayMember = "Info";
        }


        //Escolher novo aviao
        private void btnOk_Click(object sender, EventArgs e)
        {

            //if (listBoxAvioesDisponiveis.Items.Count > 0)
            //{
            //    _editado.Voos.Remove(_voo);

            //    //validate
            //    Aviao escolhido = (Aviao)listBoxAvioesDisponiveis.SelectedItem;

            //    Aviao aviaoAReatribuir = Validacoes.ValidarAviao(escolhido, _avioes);

            //    List<Bilhete> bilhetesARemover = new List<Bilhete>();

            //    if (_voo.Aviao.Estado == Estado.ativo)
            //    {
                    //_voo.Aviao = aviaoAReatribuir;
                    //_voo.Aviao.Voos.Add(_voo);
                    //_voo.AssentosReservados = new string[aviaoAReatribuir.Lugares.GetLength(0), aviaoAReatribuir.Lugares.GetLength(1)];

                    ////Encher assentosreservados

                    //foreach (Bilhete bilhete in _voo.BilhetesVendidos)
                    //{
                    //    if (bilhete is BilheteAdulto || bilhete is BilheteCrianca)
                    //    {
                    //        string lugar = bilhete.Lugar;

                    //        int coluna;
                    //        int linha;
                    //        int linhaNumero = 0;
                    //        char colunaLetra = lugar[0];

                    //        if (lugar.Length == 2)
                    //        {
                    //            linhaNumero = linhaNumero * 10 + (lugar[1] - '0');
                    //        }
                    //        else
                    //        {
                    //            for (int i = 1; i < lugar.Length; i++)
                    //            {
                    //                linhaNumero = linhaNumero * 10 + (lugar[i] - '0');
                    //            }

                    //        }

                    //        coluna = colunaLetra - 'A';
                    //        linha = linhaNumero - 1;

                    //        if (linha < _voo.AssentosReservados.GetLength(0) && coluna < _voo.AssentosReservados.GetLength(1) && _voo.AssentosReservados[linha, coluna] != "reservado")
                    //        {
                    //            _voo.AssentosReservados[linha, coluna] = "reservado";
                    //        }
                    //        else
                    //        {
                    //            //Verificar a disponibilidade de assentos e reserva-los

                    //            bool lugarEncontrado = false;

                    //            for (int i = 0; i < _voo.AssentosReservados.GetLength(0); i++)
                    //            {
                    //                for (int j = 0; j < _voo.AssentosReservados.GetLength(1); j++)
                    //                {
                    //                    if (!lugarEncontrado && _voo.AssentosReservados[i, j] == null)
                    //                    {
                    //                        _voo.AssentosReservados[i, j] = "reservado";
                    //                        lugarEncontrado = true;

                    //                        char[] letras = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

                    //                        bilhete.Lugar = $"{letras[i]}{j + 1}";
                    //                    }
                    //                }
                    //            }

                    //            //Se não houver assentos disponiveis no novo voo

                    //            if (lugarEncontrado == false)
                    //            {
                    //                bilhetesARemover.Add(bilhete);
                    //            }
                    //        }
                    //    }
            //        }

            //        if (bilhetesARemover.Count() > 0)
            //        {
            //            MessageBox.Show($"Há {bilhetesARemover.Count} bilhetes para reembolsar");
            //        }

            //        //Remover bilhete bebes
            //        List<BilheteBebe> bilheteBebes = _voo.BilhetesVendidos.OfType<BilheteBebe>().ToList();
            //        List<Bilhete> bilhetesBebesARemover = new List<Bilhete>();

            //        foreach (BilheteBebe bil in bilheteBebes)
            //        {
            //            foreach (Bilhete bilheteResponsavel in bilhetesARemover)
            //            {
            //                if (bil.Responsavel.Id == bilheteResponsavel.Id)
            //                {
            //                    bilhetesBebesARemover.Add(bil);
            //                }
            //            }

            //        }

            //        //Guardar bilhetes removidos
            //        foreach (Bilhete bilheteRem in bilhetesARemover)
            //        {
            //            bilheteRem.Voo = null;
            //            bilheteRem.Lugar = null;
            //            _voo.BilhetesVendidos.Remove(bilheteRem);
            //            _bilhetesSemVoo.Add(bilheteRem);
            //        }
            //        foreach (Bilhete bilheteBebeRem in bilhetesBebesARemover)
            //        {
            //            bilheteBebeRem.Voo = null;
            //            bilheteBebeRem.Lugar = null;
            //            _voo.BilhetesVendidos.Remove(bilheteBebeRem);
            //            _bilhetesSemVoo.Add(bilheteBebeRem);
            //        }

            //        Close();
            //    }
            //    else
            //    {
            //        //MessageBox.Show("");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Não existem aviões disponíveis para o voo. Por favor, registe um novo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //Close();


        }

        //Pesquisa avioes disponiveis
        private List<Aviao> avioesDisponiveis()
        {
            List<Aviao> AvioesDisponiveis = new List<Aviao>();

            //foreach (Aviao av in _avioes)
            //{
            //    if (av.Id != _editado.Id)
            //    {
            //        if (av.Voos.Count == 0 && av.Estado != Estado.inativo)
            //        {
            //            AvioesDisponiveis.Add(av);
            //        }
            //        else
            //        {
            //            foreach (Voo voo in av.Voos)
            //            {
            //                if (_voo.Data != voo.Data && av.Estado != Estado.inativo)

            //                    if (!AvioesDisponiveis.Contains(av))
            //                    {
            //                        AvioesDisponiveis.Add(av);
            //                    }

            //            }
            //        }
            //    }
            //}

            return AvioesDisponiveis;
        }
    }
}
    

