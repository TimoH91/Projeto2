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
    public partial class FormVooMais : Form
    {
        private List<Voo> _voos;

        private List<Aeroporto> _aeroportos;

        private List<Aviao> _avioes;

        private Voo _editado;

        public FormVooMais(List<Voo> voos, List<Aeroporto> aeroportos, List<Aviao> avioes, Voo editado)
        {
            InitializeComponent();
            _voos = voos;
            _aeroportos = aeroportos;
            _avioes = avioes;
            _editado = editado;

            VooDados();
        }

        //Encher form com dados
        private void VooDados()
        {
            textBoxNum.Text = Convert.ToString(_editado.Id);
            dateTimePickerDuracao.Text = Convert.ToString(_editado.Duracao);
            //textBoxLugaresD.Text = Convert.ToString(_editado.TotalLugaresDisponiveis());
            //textBoxLugaresO.Text = Convert.ToString(_editado.BilhetesVendidos.Count);
            textBoxPrecoBase.Text = Convert.ToString(_editado.PrecoAssentoBase);
            dateTimePickerData.Value = _editado.Data;
            dateTimePickerHora.Value = DateTime.Today.Add(_editado.Hora);
            comboBoxOrigem.Text = Convert.ToString(_editado.Origem.InfoGeral);
            comboBoxAviao.Text = (_editado.Aviao.Info);
            comboBoxDestino.Text = Convert.ToString(_editado.Destino.InfoGeral);
            //txtBoxAdultos.Text = _editado.BilhetesVendidos.Count(b => b is BilheteAdulto).ToString();
            //txtBoxCriancas.Text = _editado.BilhetesVendidos.Count(b => b is BilheteCrianca).ToString();
            //txtBoxBebes.Text = _editado.BilhetesVendidos.Count(b => b is BilheteBebe).ToString();


            //if (_editado.Escalas != null)
            //{
            //    checkBoxEscala.Checked = true;
            //    comboBoxEscala.Enabled = true;
            //    comboBoxEscala.Text = Convert.ToString(_editado.Escalas.InfoGeral);
            //}
            
            //if (_editado.BilhetesVendidos.Count > 0)
            //{
            //    comboBoxOrigem.Text = Convert.ToString(_editado.Origem.InfoGeral);
            //    listBoxBilhetesVoo.DataSource = _editado.BilhetesVendidos;
            //    listBoxBilhetesVoo.DisplayMember = "Info";
            //}
        }

        //Gravar alterações 
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DialogResult resposta;
            resposta = MessageBox.Show($"Tem a certeza que pretende guardar os alterações?",
            "Alterar",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);

            if (DialogResult.OK == resposta)
            {
                Aeroporto escala = null;
                    
                if (checkBoxEscala.Checked)
                {
                   escala = (Aeroporto)comboBoxEscala.SelectedItem;
                }         
                
                Aeroporto origem = (Aeroporto)comboBoxOrigem.SelectedItem;

                if (origem == null) 
                { 
                    origem = _editado.Origem;
                }
                Aeroporto destino = (Aeroporto)comboBoxDestino.SelectedItem;

                if (destino == null)
                {
                    destino = _editado.Destino;
                }
                DateTime Data = dateTimePickerData.Value.Date;
                TimeSpan Hora = dateTimePickerHora.Value.TimeOfDay;
                int Duracao = 0;
                

                if (!String.IsNullOrEmpty(textBoxPrecoBase.Text))
                {
                    _editado.PrecoAssentoBase = Convert.ToDecimal(textBoxPrecoBase.Text);
                }
                
                if (Data != null && Data > DateTime.Now.Date)
                {
                    _editado.Data = Data;
                }
                else
                {
                    MessageBox.Show("Data deve ser no futuro");
                }

                if (Hora != null)
                {
                    _editado.Hora = Hora;
                }

                if (Duracao != null)
                {
                    _editado.Duracao = Duracao;
                }

                if (origem != null && origem != destino)
                {
                    _editado.Origem = origem;
                }
                else
                {
                    MessageBox.Show("Origem deve ser diferente do destino");
                }

                if (destino != null && destino != origem)
                {
                    _editado.Destino = destino;
                }
                else
                {
                    MessageBox.Show("Destino deve ser diferente do origem");
                }

                if (escala != null)
                {
                    if (origem != null && destino != null)
                    {
                        if (escala.Id != origem.Id && escala.Id != destino.Id)
                        {
                            _editado.Escala = escala;
                        }
                        else
                        {
                            MessageBox.Show("Escala deve ser diferente do origem e destino");
                        }

                    }
                    else
                    {
                        if (escala.Id != _editado.Origem.Id && escala.Id != _editado.Destino.Id)
                        {
                            _editado.Escala = escala;
                        }
                        else
                        {
                            MessageBox.Show("Escala deve ser diferente do origem e destino");
                        }
                    }
                }
            }

            Close();
        }

        //Metodos para mostrar aeroportos e avioes depois de clicar no UI
        private void comboBoxAviao_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxAviao.DataSource = _avioes;
            comboBoxAviao.DisplayMember = "Info";
        }

        private void comboBoxOrigem_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxOrigem.DataSource = _aeroportos.ToList();
            comboBoxOrigem.DisplayMember = "InfoGeral";
        }

        private void comboBoxDestino_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxDestino.DataSource = _aeroportos.ToList();
            comboBoxDestino.DisplayMember = "InfoGeral";
        }

        private void comboBoxEscala_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxEscala.DataSource = _aeroportos.ToList();
            comboBoxEscala.DisplayMember = "InfoGeral";
        }

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
