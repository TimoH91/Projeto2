using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using BibliotecaAeronautica.Entities;
using BibliotecaAeronautica.Models;
using BibliotecaAeronautica.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class FormPrincipal : Form
    {
        private ApiService _apiService { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
            Point ecraPos = pictureBoxIcon.PointToScreen(Point.Empty);
            pictureBoxIcon.Parent = Logo;
            pictureBoxIcon.Location = Logo.PointToClient(ecraPos);
            pictureBoxIcon.BackColor = Color.Transparent;
            _apiService = new ApiService();
            //LoadApi();

        }


        private async Task LoadApi()
        {
            //var response = await _apiService.GetAeroportos("https://localhost:44328", "/api/aeroportos");
            //var responseB = await _apiService.GetAvioes("https://localhost:44328", "/api/avioes");
            //var responseC = await _apiService.GetVoos("https://localhost:44328", "/api/voo");
            //var responseD = await _apiService.GetAssentos("https://localhost:44328", "/api/assentos");
            //var responseE = await _apiService.GetBilhetes("https://localhost:44328", "/api/bilhete");

            //_aeroportos = (List<Aeroporto>)response.Result;
            //_avioes = (List<Aviao>)responseB.Result;
            //_voos = (List<Voo>)responseC.Result;
            //_assentos = (List<Assento>)responseD.Result;
            //_bilhetes = (List<Bilhete>)responseE.Result;
        }


        //Form Bilhetes
        private void btnBilhetes_Click(object sender, EventArgs e)
        {
            FormGestionarBilhetes formGestionarBilhetes = new FormGestionarBilhetes();
            formGestionarBilhetes.Show();
        }

        //Form Avioes
        private void btnAvioes_Click(object sender, EventArgs e)
        {
            FormAvioes formAvioes = new FormAvioes();
            formAvioes.Show();

        }
        //Form Voos
        private void btnVoos_Click(object sender, EventArgs e)
        {
            //FormVoos formVoos = new FormVoos(_avioes, _voos, _aeroportos);
            //formVoos.Show();
        }
        //Form Aeroportos
        private void btnAeroporto_Click(object sender, EventArgs e)
        {
            //FormAeroportos formAeroportos = new FormAeroportos(_aeroportos, _voos);
            //formAeroportos.Show();
        }
        //Gravar todos os ficheiros
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        //Form info load
        private void pictureBoxIcon_Click(object sender, EventArgs e)
        {
            FormAppInfo formAppInfo = new FormAppInfo();
            formAppInfo.Show();
        }

        //Form vender bilhetes
        private void btnVenda_Click(object sender, EventArgs e)
        {
            //FormComprarBilhetes formComprarBilhetes = new FormComprarBilhetes(_bilhetes, _voos, _aeroportos);
            //formComprarBilhetes.Show();
        }

        //Form load tirar focus
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //btnFocus.Focus();

            //foreach (Control ctrl in this.Controls)
            //{
            //    if (ctrl is Button)
            //    {
            //        ctrl.Invalidate();
            //    }
            //}
            //this.Refresh();
        }


    }

}
