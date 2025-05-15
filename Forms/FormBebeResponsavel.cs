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
    public partial class FormBebeResponsavel : Form
    {
        private Voo _voo;

        private List<BilheteAdulto> _bilhetesAdultos;

        private List<Voo> _listaComUmvoo;

        private string[] _bebeDados;

        private FormComprarBilhetes _formCB;
        public FormBebeResponsavel(FormComprarBilhetes formCB, string[] bebeDados, Voo voo, List<BilheteAdulto> bilhetesAdultos, List<Voo> listaComUmvoo)
        {
            InitializeComponent();
            _formCB = formCB;
            _voo = voo;
            _bilhetesAdultos = bilhetesAdultos;
            _bebeDados = bebeDados;
            _listaComUmvoo = listaComUmvoo;

            IniciarLista();
        }
        //Atualizar a tela
        private void IniciarLista()
        {
            listBoxResponsaveis.DataSource = _bilhetesAdultos;
            listBoxResponsaveis.DisplayMember = "Info";
        }
        //Guardar responsavel no bilhete do bebe
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ////Validar
            //BilheteAdulto escolhido = (BilheteAdulto)listBoxResponsaveis.SelectedItem;

            //BilheteAdulto responsavelAGuardar = Validacoes.ValidarBilheteResponsavel(escolhido, _bilhetesAdultos);

            //Bilhete novoBebe = new BilheteBebe(Convert.ToInt32(_bebeDados[0]), _bebeDados[1], _bebeDados[2], _voo, (Tarifa)Enum.Parse(typeof(Tarifa), _bebeDados[3], true), responsavelAGuardar, responsavelAGuardar.Lugar);

            //_formCB.BilhetesAGravar.Add(novoBebe); 
            //_formCB.CestaBilhetes(_listaComUmvoo);
        
            //Close();
        }
    }
}
