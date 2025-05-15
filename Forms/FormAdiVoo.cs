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
    public partial class FormAdiVoo : Form
    {
        private List<Aviao> _avioes;

        private List<Voo> _voos;

        private List<Aeroporto> _aeroportos;

        public FormAdiVoo(List<Aviao> avioes, List<Voo> voos, List<Aeroporto> aeroportos)
        {
            InitializeComponent();
            _avioes = avioes;
            _voos = voos;
            _aeroportos = aeroportos;

            IniciarLista();

        }

        //Atualizar a tela
        private void IniciarLista()
        {
            comboBoxDestino.DataSource = _aeroportos.ToList();
            comboBoxDestino.DisplayMember = "InfoGeral";
            comboBoxOrigem.DataSource = _aeroportos.ToList();
            comboBoxOrigem.DisplayMember = "InfoGeral";
            comboBoxEscala.DataSource = _aeroportos.ToList();
            comboBoxEscala.DisplayMember = "InfoGeral";
            dateTimePickerDuracao.Text = "00:00:00";

            if (_voos.Any())
            {
                txtBoxId.Text = Convert.ToString(_voos.Max(Voo => Voo.Id) + 1);

            }
            else
            {
                txtBoxId.Text = Convert.ToString(1);

            }
        }
        //mostrar voos Disponiveis
        private void btnVer_Click(object sender, EventArgs e)
        {
            listBoxAvioes.DataSource = avioesDisponiveis();
            listBoxAvioes.DisplayMember = "Info";

        }

        //Validar os aviões  que não têm outros voos na data do novo voo
        private List<Aviao> avioesDisponiveis()
        {
            DateTime Data = dateTimePicker.Value.Date;

            List<Aviao> AvioesDisponiveis = new List<Aviao>();

            //foreach (Aviao av in _avioes)
            //{
            //    if (av.Voos.Count != 0)
            //    {
            //        foreach (Voo voo in av.Voos)
            //        {
            //            if (voo.Data != Data && av.Estado != Estado.inativo)

            //                if (!AvioesDisponiveis.Contains(av))
            //                {
            //                    AvioesDisponiveis.Add(av);
            //                }
            //        }
            //    }

            //    else if (av.Estado != Estado.inativo)
            //    {
            //        if (!AvioesDisponiveis.Contains(av))
            //        {
            //            AvioesDisponiveis.Add(av);
            //        }
            //    }
            //}
            return AvioesDisponiveis;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Aeroporto Escala = new Aeroporto();

            if (comboBoxEscala.Enabled == true)
            {
                Escala = (Aeroporto)comboBoxEscala.SelectedItem;
            }
            else
            {
                Escala = null;
            }

            if (ValidaForm())
            {
                Aviao aviaoAdd = (Aviao)listBoxAvioes.SelectedItem;

                Aviao aviaoAAdicionar = null;

                if (aviaoAdd != null)
                {
                    foreach (Aviao av in _avioes)
                    {
                        if (aviaoAdd.Id == av.Id)
                        {
                            aviaoAAdicionar = av;
                        }
                    }
                }

                Voo novoVoo;

                novoVoo = new Voo
                {
                    Id = Convert.ToInt32(txtBoxId.Text),
                    Data = dateTimePicker.Value.Date,
                    Hora = dateTimePickerHora.Value.TimeOfDay,
                    Duracao = 0,
                    PrecoAssentoBase = Convert.ToDecimal(txtBoxPreco.Text),


                    Aviao = aviaoAAdicionar,
                    Origem = (Aeroporto)comboBoxOrigem.SelectedItem,
                    Escala = Escala,
                    Destino = (Aeroporto)comboBoxDestino.SelectedItem,

                    //AssentosReservados = new string[aviaoAAdicionar.Filas, aviaoAAdicionar.AssentosPorFila],
                };

                _voos.Add(novoVoo);

                //aviaoAAdicionar.Voos.Add(novoVoo);

                FormVoos formVoos = new FormVoos(_avioes, _voos, _aeroportos);
                formVoos.Show();
                Close();
            }

        }

        //Validar os inputs
        private bool ValidaForm()
        {
            bool output = true;
            Aeroporto Escala = null;

            Aeroporto Origem = (Aeroporto)comboBoxOrigem.SelectedItem;
            Aeroporto Destino = (Aeroporto)comboBoxDestino.SelectedItem;

            if (checkBoxEscala.Checked)
            {
                Escala = (Aeroporto)comboBoxEscala.SelectedItem;
            }

            Aviao aviaoEscolhido = (Aviao)listBoxAvioes.SelectedItem;

            if (Escala != null)
            {
                if (Escala.Id == Origem.Id || Escala.Id == Destino.Id)
                {
                    MessageBox.Show("Escala deve ser diferente ao destino e origem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    output = false;
                }
            }

            if (Origem.Id == Destino.Id)
            {
                MessageBox.Show("Origem e destino devem ser diferente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }


            if (!DateTime.TryParse(dateTimePicker.Text, out DateTime date))
            {
                MessageBox.Show("Escolhe data", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else
            {
                TimeSpan.TryParse(dateTimePickerHora.Text, out TimeSpan horaVoo);

                if (date < DateTime.Now.Date || date == DateTime.Now.Date && horaVoo <= DateTime.Now.TimeOfDay )
                {
                    MessageBox.Show("Escolhe data no futuro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    output = false;
                }
            }
            if (!TimeSpan.TryParse(dateTimePickerDuracao.Text, out TimeSpan duracao))
            {
                MessageBox.Show("Formato de duração inválido (use hh:mm)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (duracao == TimeSpan.Zero)
            {
                MessageBox.Show("Insira uma duração maior que zero (horas e minutos)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtBoxPreco.Text) || !decimal.TryParse(txtBoxPreco.Text, out _))
            {
                MessageBox.Show("Insira preço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (aviaoEscolhido == null)
            {
                MessageBox.Show("Escolha um avião", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
        //Escolher com ou sem Escala
        private void checkBoxEscala_CheckStateChanged(object sender, EventArgs e)
        {
            if (comboBoxEscala.Enabled == false)
            {
                comboBoxEscala.Enabled = true;
            }
            else
            {
                comboBoxEscala.Enabled = false;
            }
        }

        //Fechar form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
