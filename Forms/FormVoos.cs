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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Forms
{
    public partial class FormVoos : Form
    {
        private List<Aviao> _avioes;

        private List<Voo> _voos;

        private List<Aeroporto> _aeroportos;

        private List<Voo> _voosIda = new List<Voo>();

        private List<Voo> _voosRegresso = new List<Voo>();

        public FormVoos(List<Aviao> avioes, List<Voo> voos, List<Aeroporto> aeroportos)
        {
            InitializeComponent();
            _avioes = avioes;
            _voos = voos;
            _aeroportos = aeroportos;

            _voosIda = voos;

            comboBoxOrigem.DataSource = new List<Aeroporto>(_aeroportos);
            comboBoxOrigem.DisplayMember = "InfoGeral";
            comboBoxDestino.DataSource = new List<Aeroporto>(_aeroportos);
            comboBoxDestino.DisplayMember = "InfoGeral";

            encherDadaGrid();
            DataGridDados(_voosIda);
        }

        private void encherDadaGrid()
        {
            dataGridView1.Columns.Add("colId", "Id");
            dataGridView1.Columns.Add("colOrigem", "Origem");
            dataGridView1.Columns.Add("colDestino", "Destino");
            dataGridView1.Columns.Add("colEscala", "Escala");
            dataGridView1.Columns.Add("colData", "Data");
            dataGridView1.Columns.Add("colHora", "Hora");
            dataGridView1.Columns.Add("colDuracao", "Duração");
            dataGridView1.Columns.Add("colPreço", "Preço base");

            dataGridView1.AllowUserToAddRows = false;
        }

        //Encher dataGrid com dados
        private void DataGridDados(List<Voo> voosDisplay)
        {
            List<Voo> voos = voosDisplay;
            //GridView

            if (voos.Count > 0)
            {
                int linha = 0;

                dataGridView1.Rows.Clear();

                foreach (Voo voo in voos)
                {
                    DataGridViewRow registo = new DataGridViewRow();

                    dataGridView1.Rows.Add(registo);

                    dataGridView1.Rows[linha].Cells[0].Value = voo.Id;
                    dataGridView1.Rows[linha].Cells[1].Value = voo.Origem.Nome;
                    dataGridView1.Rows[linha].Cells[2].Value = voo.Destino.Nome;

                    if (voo.Escala != null)
                    {
                        dataGridView1.Rows[linha].Cells[3].Value = voo.Escala.Nome;
                    }
                    else
                    {
                        dataGridView1.Rows[linha].Cells[3].Value = "N/A";
                    }

                    dataGridView1.Rows[linha].Cells[4].Value = voo.Data.ToString("dd/MM/yyyy");
                    dataGridView1.Rows[linha].Cells[5].Value = voo.Hora.ToString(@"hh\:mm"); ;
                    dataGridView1.Rows[linha].Cells[6].Value = voo.Duracao;
                    dataGridView1.Rows[linha].Cells[7].Value = voo.PrecoAssentoBase;

                    linha++;
                }

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                dataGridView1.Rows.Clear(); 
            }

        }
        //Adicionar novo voo
        private void btnAdicionarVoo_Click(object sender, EventArgs e)
        {
            FormAdiVoo formAdiVoo = new FormAdiVoo(_avioes, _voos, _aeroportos);
            formAdiVoo.Show();
            Close();
        }

        public void IniciarLista()
        {
            DataGridDados(_voosIda);
        }

        //Refinar pesquisa dos voo
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            List<Voo> voosIda = new List<Voo>();

            Aeroporto escolhidoOrigem = (Aeroporto)comboBoxOrigem.SelectedItem;
            Aeroporto aeroportoOrigem = Validacoes.ValidarAeroporto(escolhidoOrigem, _aeroportos);


            Aeroporto escolhidoDestino = (Aeroporto)comboBoxDestino.SelectedItem;
            Aeroporto aeroportoDestino = Validacoes.ValidarAeroporto(escolhidoDestino, _aeroportos);

            DateTime Data = dateTimePickerIda.Value.Date;

            //Validar
            foreach (Voo voo in _voos)
            {
                if (voo.Origem.Id == aeroportoOrigem.Id && voo.Destino.Id == aeroportoDestino.Id && Data == voo.Data)
                {
                    voosIda.Add(voo);
                }
            }
            _voosIda = voosIda;
            IniciarLista();
        }

        //Ver dados do voo e editar se for preciso
        private void btnDadosIda_Click(object sender, EventArgs e)
        {
            Voo editado = new Voo();

            //Associar voo com datagrid seleção
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaEscolhida = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(linhaEscolhida.Cells["colId"].Value);

                foreach (Voo voo in _voosIda)
                {
                    if (voo.Id == id)
                    {
                        editado = voo;
                    }
                }

                if (editado != null)
                {
                    FormVooMais formVooMais = new FormVooMais(_voos, _aeroportos, _avioes, editado);
                    formVooMais.Show();
                    Close();
                }
            }
        }
        //Mostrar voos com ou sem escalas
        private void checkBoxDireto_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxDireto.Checked)
            {
                if (_voosIda != null)
                {
                    List<Voo> semEscalas = _voosIda.Where(X => X.Escala == null).ToList();
                    DataGridDados(semEscalas);
                }
            }
            else
            {
                if (_voosIda != null)
                {
                    DataGridDados(_voosIda);
                }

            }
        }

    }
}
