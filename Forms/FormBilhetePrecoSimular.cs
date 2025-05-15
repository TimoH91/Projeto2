using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaAeronautica.Entities;
using BibliotecaAeronautica.Models;
using BibliotecaAeronautica.Services;

namespace Forms
{
    public partial class FormBilhetePrecoSimular : Form
    {
        private List<Bilhete> _bilhetes;

        private List<Voo> _voos;

        private List<Bilhete> _bilhetesCesta;

        private Voo _vooIda;

        private Voo _vooRegresso;

        private string[,] _assentosCestaIda;

        private string[,] _assentosCestaRegresso;

        public FormBilhetePrecoSimular(List<Bilhete> bilhetes, List<Voo> voos, List<Bilhete> bilhetesCesta, Voo vooIda, Voo vooRegresso, string[,] assentosReservadosIda, string[,] assentosReservadosRegresso)
        {
            InitializeComponent();
            _bilhetes = bilhetes;
            _bilhetesCesta = bilhetesCesta;
            _voos = voos;
            _vooIda = vooIda;
            _vooRegresso = vooRegresso;
            _assentosCestaIda = assentosReservadosIda;
            _assentosCestaRegresso = assentosReservadosRegresso;

            IniciarLista();
            
        }
        //Atualizar a tela
        private void IniciarLista()
        {
            listBoxCesta.DataSource = null;
            listBoxCesta.DataSource = _bilhetesCesta;
            listBoxCesta.DisplayMember = "Info";
            txtBoxPrecoTotal.Text = Convert.ToString(PrecoTotal(_bilhetesCesta));
        }

        //Confirmar compra
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //if (_bilhetesCesta.Count > 0)
            //{
            //    foreach (Bilhete bilhete in _bilhetesCesta)
            //    {
            //        if (bilhete.Voo.Id == _vooIda.Id)
            //        {
            //            _bilhetes.Add(bilhete);
            //            _vooIda.BilhetesVendidos.Add(bilhete);
            //        }
            //        else
            //        {
            //            _bilhetes.Add(bilhete);
            //            _vooRegresso.BilhetesVendidos.Add(bilhete);
            //        }

            //    }
            //    _vooIda.AssentosReservados = _assentosCestaIda;

            //    if (_assentosCestaRegresso != null)
            //    {
            //        _vooRegresso.AssentosReservados = _assentosCestaRegresso;
            //    }
            //    Close();
            //}
        }
        

        //Calcular preco cesta
        private decimal PrecoTotal(List<Bilhete> _bilhetesCesta)
        {
            decimal total = 0;

            //foreach (Bilhete bilhetes  in _bilhetesCesta)
            //{
            //    total += bilhetes.Preco();
            //}

            return total;
        }

        //Fechar form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }



    
    }
}
