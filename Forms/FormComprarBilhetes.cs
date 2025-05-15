using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaAeronautica.Entities;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Forms
{
    public partial class FormComprarBilhetes : Form
    {
        public enum TipoBilhete
        {
            adulto,
            crianca,
            bebe
        };

        private List<Bilhete> _bilhetes;

        private List<Aeroporto> _aeroportos;

        private List<Voo> _voosIda;

        private List<Voo> _voosIdaDisplay;

        private List<Voo> _voosRegresso = new List<Voo>();

        private string _lugar;

        private List<Bilhete> _bilhetesAGravar = new List<Bilhete>();

        private Voo _vooIda;

        private Voo _vooRegresso;
        
        //Para usar nos form escolher/editar lugar
        public string Lugar
        {
            get
            {
                return _lugar;
            }
            set
            {
                _lugar = value;
            }
        }

        //Para usar no form bebe responsavel
        public List<Bilhete> BilhetesAGravar
        {
            get
            {
                return _bilhetesAGravar;
            }
            set
            {
                _bilhetesAGravar = value;
            }
        }

        private string[,] _assentosCestaIda;

        private string[,] _assentosCestaRegresso;

        public FormComprarBilhetes(List<Bilhete> bilhetes, List<Voo> voos, List<Aeroporto> aeroportos)
        {
            InitializeComponent();

            _voosIda = voos;
            _bilhetes = bilhetes;
            _aeroportos = aeroportos;

            encherDataGrids();
            DataGridDadosIda(_voosIda);


            if (_bilhetes.Any())
            {
                txtBoxId.Text = Convert.ToString(_bilhetes.Max(Bilhete => Bilhete.Id) + 1);

            }
            else
            {
                txtBoxId.Text = Convert.ToString(1);
            }

            IniciarLista();
        }

        private void encherDataGrids()
        {
            dataGridViewVoosIda.Columns.Add("colId", "Id");
            dataGridViewVoosIda.Columns.Add("colOrigem", "Origem");
            dataGridViewVoosIda.Columns.Add("colDestino", "Destino");
            dataGridViewVoosIda.Columns.Add("colEscala", "Escala");
            dataGridViewVoosIda.Columns.Add("colData", "Data");
            dataGridViewVoosIda.Columns.Add("colHora", "Hora");
            dataGridViewVoosIda.Columns.Add("colDuracao", "Duração");
            dataGridViewVoosIda.Columns.Add("colPreço", "Preço base");

            dataGridViewVoosIda.AllowUserToAddRows = false;
            dataGridViewVoosIda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVoosIda.MultiSelect = false;

            dataGridViewVoosRegresso.Columns.Add("colId", "Id");
            dataGridViewVoosRegresso.Columns.Add("colOrigem", "Origem");
            dataGridViewVoosRegresso.Columns.Add("colDestino", "Destino");
            dataGridViewVoosRegresso.Columns.Add("colEscala", "Escala");
            dataGridViewVoosRegresso.Columns.Add("colData", "Data");
            dataGridViewVoosRegresso.Columns.Add("colHora", "Hora");
            dataGridViewVoosRegresso.Columns.Add("colDuracao", "Duração");
            dataGridViewVoosRegresso.Columns.Add("colPreço", "Preço base");

            dataGridViewVoosRegresso.AllowUserToAddRows = false;
            dataGridViewVoosRegresso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVoosRegresso.MultiSelect = false;
        }

        private void IniciarLista()
        {
            comboBoxOrigem.DataSource = _aeroportos.ToList();
            comboBoxOrigem.DisplayMember = "InfoGeral";
            comboBoxDestino.DataSource = _aeroportos.ToList();
            comboBoxDestino.DisplayMember = "InfoGeral";
            comboBoxTarifa.DataSource = Enum.GetValues(typeof(Tarifa));
            comboBoxTipo.DataSource = Enum.GetValues(typeof(TipoBilhete));
            lblLugar.Text = _lugar;
        }

        public void MostrarLugar()
        {
            lblLugar.Text = _lugar;
            dataGridViewVoosIda.Enabled = false;
            checkBoxDireto.Enabled = false;
            textBoxPreco.Text = Convert.ToString(_vooIda.PrecoAssentoBase);
            if (_vooRegresso != null) 

            {
                txtBoxPrecoRegresso.Text = Convert.ToString(_vooRegresso.PrecoAssentoBase);
            }

        }

        //Abrir a cesta para confirmar venda (FormBilhetePrecoSimlular)
        private void buttonComprar_Click(object sender, EventArgs e)
        {
            if (_bilhetesAGravar.Count > 0)
            {
                FormBilhetePrecoSimular formBilhetePrecoSimular = new FormBilhetePrecoSimular(_bilhetes, _voosIda, _bilhetesAGravar, _vooIda, _vooRegresso, _assentosCestaIda, _assentosCestaRegresso);
                formBilhetePrecoSimular.Show();
                Close();
            }
        }


        //Pesquisa voo data etc
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Aeroporto escolhidoOrigem = (Aeroporto)comboBoxOrigem.SelectedItem;
            Aeroporto origem = Validacoes.ValidarAeroporto(escolhidoOrigem, _aeroportos);

            Aeroporto escolhidoDestino = (Aeroporto)comboBoxDestino.SelectedItem;
            Aeroporto destino = Validacoes.ValidarAeroporto(escolhidoDestino, _aeroportos);

            DateTime data = dateTimePickerIda.Value.Date;

            _voosIdaDisplay = (List<Voo>)_voosIda.Where(X => X.Origem.Id == origem.Id && X.Destino.Id == destino.Id && data == X.Data).ToList();

            DataGridDadosIda(_voosIdaDisplay);

            checkBoxDireto.Checked = false;

        }

        //Adicionar ida bilhete
        private void btnCesta_Click(object sender, EventArgs e)
        {
            //Escolher voo

            Voo escolhido = new Voo();

            if (_vooIda != null)
            {
                escolhido = _vooIda;
            }
            else if (dataGridViewVoosIda.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaEscolhida = dataGridViewVoosIda.SelectedRows[0];

                int id = Convert.ToInt32(linhaEscolhida.Cells["colId"].Value);

                foreach (Voo vooIda in _voosIda)
                {
                    if (vooIda.Id == id)
                    {
                        escolhido = vooIda;
                    }
                }
            }

            //Verificar tipo de bilhete e criar bilhete

            if (escolhido != null)
            {
                _vooIda = escolhido;

                if (_lugar != null && (TipoBilhete)comboBoxTipo.SelectedItem != TipoBilhete.bebe)
                {
                    if ((TipoBilhete)comboBoxTipo.SelectedItem == TipoBilhete.adulto)
                    {
                        //Bilhete novoBilheteAdulto = new BilheteAdulto(

                        //    Convert.ToInt32(txtBoxId.Text),
                        //    txtBoxNome.Text,
                        //    txtBoxApelido.Text,
                        //    escolhido,
                        //    (Tarifa)comboBoxTarifa.SelectedItem,
                        //    _lugar);

                        //_bilhetesAGravar.Add(novoBilheteAdulto);

                        //List<Voo> listaComUmVoo = new List<Voo> { escolhido };

                        //CestaBilhetes(listaComUmVoo);
                    }
                    else if ((TipoBilhete)comboBoxTipo.SelectedItem == TipoBilhete.crianca)
                    {
                        //Bilhete novoBilheteCrianca = new BilheteCrianca(
                        //        Convert.ToInt32(txtBoxId.Text),        // Id
                        //        txtBoxNome.Text,
                        //        txtBoxApelido.Text,                          // Apelido
                        //        escolhido,          // Voo
                        //        (Tarifa)comboBoxTarifa.SelectedItem,    // Tarifa
                        //        _lugar);                                  // Lugar)

                        //_bilhetesAGravar.Add(novoBilheteCrianca);

                        //List<Voo> listaComUmVoo = new List<Voo> { escolhido };

                        //CestaBilhetes(listaComUmVoo);
                    }

                    checkBoxRegresso.Enabled = true;

                }
                else if (_lugar == null && (TipoBilhete)comboBoxTipo.SelectedItem == TipoBilhete.bebe)
                {
                    if (!_bilhetesAGravar.Any(b => b is BilheteAdulto))
                    {
                        MessageBox.Show("Bebe apenas podem voar com um adulto. Por favor insire bilhete adulto primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        List<BilheteAdulto> bilhetesAdultos = _bilhetesAGravar.OfType<BilheteAdulto>().ToList();

                        string[] bebeDados = new string[6];
                        bebeDados[0] = txtBoxId.Text;
                        bebeDados[1] = txtBoxNome.Text;
                        bebeDados[2] = txtBoxApelido.Text;
                        bebeDados[3] = Convert.ToString((Tarifa)comboBoxTarifa.SelectedItem);

                        List<Voo> listaComUmVoo = new List<Voo> { escolhido };

                        FormBebeResponsavel formBebeResponsavel = new FormBebeResponsavel(this, bebeDados, escolhido, bilhetesAdultos, listaComUmVoo);
                        formBebeResponsavel.Show();
                    }
                }
                else if (_lugar == null && (TipoBilhete)comboBoxTipo.SelectedItem != TipoBilhete.bebe)
                {
                    MessageBox.Show("Por favor, escolha lugar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Atualiza lugar para proximo bilhete
                int id = Convert.ToInt32(txtBoxId.Text);
                txtBoxId.Text = Convert.ToString(id + 1);
                _lugar = null;
                lblLugar.Text = _lugar;
 
                if (_bilhetesAGravar.Count > 0)
                {
                    listBoxVoos.Enabled = false;
                    dataGridViewVoosIda.Enabled = false;
                }
            }
        }



        //Mostrar bilhetes e atualizar butões e datagrids com voo escolhido
        public void CestaBilhetes(List<Voo> vooEscolhido)
        {
            listBoxCesta.DataSource = null;
            listBoxCesta.DataSource = _bilhetesAGravar;
            listBoxCesta.DisplayMember = $"Info";

            if (_voosRegresso.Count == 0)
            {
                DataGridDadosIda(vooEscolhido);
                
            }
            else
            {
                DataGridDadosRegresso(vooEscolhido);
            }
            comboBoxDestino.Enabled = false;
            comboBoxOrigem.Enabled = false;
            btnAtualizar.Enabled = false;
            checkBoxDireto.Enabled = false;

            //Atualiza cestaIda aqui?

        }


        //Escolher lugar para bilhetes ida
        private void btnLugar_Click(object sender, EventArgs e)
        {
            //Escolher voo

            Voo escolhido = new Voo();

            if (dataGridViewVoosIda.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaEscolhida = dataGridViewVoosIda.CurrentRow;

                object cellValue = linhaEscolhida.Cells["colId"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                {
                    foreach (Voo vooIda in _voosIda)
                    {
                        if (vooIda.Id == id)
                        {
                            escolhido = vooIda;
                        }
                    }
                }
            }

            //Guardar e atualizar voo  
            _vooIda = escolhido;

            //Validate voo é no futuro
            if (escolhido != null && escolhido.Data >= DateTime.Now.Date)
            {
                if (escolhido.Data == DateTime.Now.Date && escolhido.Hora < DateTime.Now.TimeOfDay)
                {
                    MessageBox.Show("Voo já saiu");
                    _vooIda = null;
                }
                else
                {
                    if (escolhido.Escala != null)
                    {
                        MessageBox.Show($"Voo tem escala em {escolhido.Escala.Nome}");
                    }

                    //started adjusting this method - would we call on the API here or do it within the app to check seats that are occupied??

                    _assentosCestaIda = new string[escolhido.Aviao.Filas, escolhido.Aviao.AssentosPorFila];

                    for (int i = 0; i < escolhido.Aviao.Filas; i++)
                    {
                        for (int j = 0; j < escolhido.Aviao.AssentosPorFila; j++)
                        {
                            //if (escolhido.AssentosReservados[i, j] == "reservado")
                            //{
                            //    _assentosCestaIda[i, j] = "reservado";
                            //}

                            //(escolhido.Assentos.Contains<Assento>(Where a => a.Fila = )???
    
                            //if voo has an assento where i = assento.Fila and j = assento.Coluna then change to reserved, but actually we might be able to skip this part of filling in reservations here                                    

                        }
                    }

                    //Encher assentos com reservas do voo
                    foreach (Bilhete bilhete in _bilhetesAGravar)
                    {
                        if (bilhete.Voo.Id == escolhido.Id)

                        {
                            //int coluna = 0;
                            //int linha = 0;
                            //int linhaNumero = 0;
                            //char colunaLetra = bilhete.Lugar[0];

                            //if (bilhete.Lugar.Length == 2)
                            //{
                            //    linhaNumero = linhaNumero * 10 + (bilhete.Lugar[1] - '0');
                            //}
                            //else
                            //{
                            //    for (int i = 1; i < bilhete.Lugar.Length; i++)
                            //    {
                            //        linhaNumero = linhaNumero * 10 + (bilhete.Lugar[i] - '0');
                            //    }

                            //}

                            //coluna = colunaLetra - 'A';
                            //linha = linhaNumero - 1;

                            //if (linha < _assentosCestaIda.GetLength(0) && coluna < _assentosCestaIda.GetLength(1))
                            //{

                            //    _assentosCestaIda[linha, coluna] = "reservado";
                            //}
                        }
                    }

                    //Abrir escolha do lugar
                    if ((TipoBilhete)comboBoxTipo.SelectedItem != TipoBilhete.bebe)
                    {
                        if (escolhido != null)
                        {
                            FormEscolherLugar formEscolherLugar = new FormEscolherLugar(this, _assentosCestaIda, escolhido);
                            formEscolherLugar.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bebe usa o mesmo assento que o responsavel", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            else
            {
                MessageBox.Show("Voo já saiu");
                _vooIda = null;
            }


        }

        //Escolher lugar nos bilhetes regresso
        private void btnEscolherLugarRegresso_Click(object sender, EventArgs e)
        {
            //Escolher Lugar

            Voo voo = new Voo();          

            if (dataGridViewVoosRegresso.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaEscolhida = dataGridViewVoosRegresso.CurrentRow;

                object cellValue = linhaEscolhida.Cells["colId"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                {
                    foreach (Voo vooReg in _voosIda)
                    {
                        if (vooReg.Id == id)
                        {
                            voo = vooReg;
                        }
                    }
                }

            }

            //Guardar e atulizar voo regresso 
            _vooRegresso = voo;

            //if (voo != null)
            //{
            //    //_assentosCestaRegresso = new string[voo.AssentosReservados.GetLength(0), voo.AssentosReservados.GetLength(1)];

                //for (int i = 0; i < voo.AssentosReservados.GetLength(0); i++)
                //{
                //    for (int j = 0; j < voo.AssentosReservados.GetLength(1); j++)
                //    {
                //        if (voo.AssentosReservados[i, j] == "reservado")
                //        {
                //            _assentosCestaRegresso[i, j] = "reservado";
                //        }

                //    }
                //}


                //encher assentos com reservas
            //    foreach (Bilhete bilhete in _bilhetesAGravar)
            //    {
            //        if (bilhete.Voo.Id == voo.Id)

            //        {
            //            int coluna = 0;
            //            int linha = 0;
            //            int linhaNumero = 0;
            //            char colunaLetra = bilhete.Lugar[0];

            //            if (bilhete.Lugar.Length == 2)
            //            {
            //                linhaNumero = linhaNumero * 10 + (bilhete.Lugar[1] - '0');
            //            }
            //            else
            //            {
            //                for (int i = 1; i < bilhete.Lugar.Length; i++)
            //                {
            //                    linhaNumero = linhaNumero * 10 + (bilhete.Lugar[i] - '0');
            //                }

            //            }

            //            coluna = colunaLetra - 'A';
            //            linha = linhaNumero - 1;

            //            if (linha < _assentosCestaRegresso.GetLength(0) && coluna < _assentosCestaRegresso.GetLength(1))
            //            {

            //                _assentosCestaRegresso[linha, coluna] = "reservado";
            //            }
            //        }
            //    }

            //    if ((TipoBilhete)comboBoxTipo.SelectedItem != TipoBilhete.bebe)
            //    {
            //        FormEscolherLugar formEscolherLugar = new FormEscolherLugar(this, _assentosCestaRegresso, voo);
            //        formEscolherLugar.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Bebe usa o mesmo assento que o responsavel", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

        }

        //Ativar opções de regresso
        private void checkBoxRegresso_CheckStateChanged(object sender, EventArgs e)
        {
            
            List<Voo> voosRegresso = new List<Voo>();

            if (_vooIda != null)
            {
                Aeroporto aeroportoOrigem = _vooIda.Origem;
                Aeroporto aeroportoDestino = _vooIda.Destino;

                //Guardar voos possíveis para o regresso
                foreach (Voo voo in _voosIda)
                {
                    if (voo.Origem.Id == aeroportoDestino.Id && voo.Destino.Id == aeroportoOrigem.Id && voo.Data.Date > DateTime.Now.Date && voo.Data > _vooIda.Data)
                    {
                        if (DateTime.Now.Date == voo.Data && DateTime.Now.TimeOfDay > voo.Hora || voo.Data.Date > DateTime.Now.Date)
                        {
                            voosRegresso.Add(voo);
                        }

                    }
                }
            }

            _voosRegresso = voosRegresso;
            DataGridDadosRegresso(_voosRegresso);

            if (checkBoxRegresso.Checked)
            {
                if (_vooIda != null)
                {
                    if (_vooIda.Data >= DateTime.Now.Date)
                    {
                        //listBoxVoosRegresso.Enabled = true;
                        dateTimePickerRegresso.Enabled = true;
                        btnPesquisaRegresso.Enabled = true;
                        btnEscolherLugarRegresso.Enabled = true;
                        dataGridViewVoosRegresso.Enabled = true;
                        btnCestaRegresso.Enabled = true;
                        checkBoxDiretoRegresso.Enabled = true;
                        dateTimePickerIda.Enabled = false;
                        btnCesta.Enabled = false;
                        btnLugar.Enabled = false;
                        _lugar = null;

                        MostrarLugar();

                    }
                    else
                    {
                        MessageBox.Show("Não há regresso para voos que já sairam", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (!checkBoxRegresso.Checked)
            {
                //Verificar se há bilhetes já para o regresso
                bool vooRegressoBilhete = false;

                foreach (Bilhete bilhete in _bilhetesAGravar)
                {
                    if (_vooRegresso != null)
                    {
                        if (bilhete.Voo.Id == _vooRegresso.Id)
                        {
                            vooRegressoBilhete = true;
                        }

                    }
                }

                
                if (vooRegressoBilhete != true)
                {
                    //Reativar possibilidade de adicionar mais bilhetes para a ida
                    btnCesta.Enabled = true;
                    btnLugar.Enabled = true;
                    dateTimePickerRegresso.Enabled = false;
                    btnPesquisaRegresso.Enabled = false;
                    btnEscolherLugarRegresso.Enabled = false;
                }

            }

        }

        //Confirmar todos bilhetes adicionar para voo ida
        private bool AvisoCesta()
        {
            bool output = false;

            DialogResult resposta;
            resposta = MessageBox.Show($"Antes de adicionar regressos, confirme que já adicionou todos os passageiros para a ida.",
            "Apagar",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);

            if (DialogResult.OK == resposta)
            {
                output = true;
            }

            return output;
        }


        //Pesquisar data para o regresso
        private void btnPesquisaRegresso_Click(object sender, EventArgs e)
        {
            List<Voo> voosRegresso = new List<Voo>();

            if (_vooIda != null)
            {
                Aeroporto aeroportoOrigem = _vooIda.Destino;
                Aeroporto aeroportoDestino = _vooIda.Origem;
                DateTime Data = dateTimePickerRegresso.Value.Date;

                foreach (Voo voo in _voosIda)
                {
                    if (voo.Origem.Id == aeroportoOrigem.Id && voo.Destino.Id == aeroportoDestino.Id && Data == voo.Data && _vooIda.Data < voo.Data)
                    {
                        voosRegresso.Add(voo);
                    }
                }
                _voosRegresso = voosRegresso;
            }

            if (_voosRegresso.Count == 0)
            {
                MessageBox.Show("Não há opção de regresso. Adiciona voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataGridDadosRegresso(_voosRegresso);
            btnEscolherLugarRegresso.Enabled = true;
        }

        //Adicionar bilhetes regresso a cesta 
        private void btnCestaRegresso_Click(object sender, EventArgs e)
        {
            //Verificar se já há bilhetes de regresso
            bool vooRegressoBilhete = false;

            foreach (Bilhete bilhete in _bilhetesAGravar)
            {
                if (_vooRegresso != null)
                {
                    if (bilhete.Voo.Id == _vooRegresso.Id)
                    {
                        vooRegressoBilhete = true;
                    }

                }
            }
            if (vooRegressoBilhete == false)
            {
                if (AvisoCesta())
                {
                    adicionarRegressoCesta();

                    btnCesta.Enabled = false;
                    btnLugar.Enabled = false;
                    dateTimePickerIda.Enabled = false;
                    dateTimePickerRegresso.Enabled = false;
                    btnPesquisaRegresso.Enabled = false;
                    checkBoxDireto.Enabled = false;
                    checkBoxDiretoRegresso.Enabled = false;

                    //Atualizar Datagrids
                    List<Voo> listaTemporaria = new List<Voo>();
                    listaTemporaria.Add(_vooIda);
                    DataGridDadosIda(listaTemporaria);

                    List<Voo> listaTemporariaRegresso = new List<Voo>();
                    listaTemporariaRegresso.Add(_vooRegresso);
                    DataGridDadosRegresso(listaTemporariaRegresso);

                }

            }
            //se já há bilhetes de regresso não precisa do aviso
            else
            {

                adicionarRegressoCesta();
                btnCesta.Enabled = false;
                btnLugar.Enabled = false;
                dateTimePickerIda.Enabled = false;
                dateTimePickerRegresso.Enabled = false;
                btnPesquisaRegresso.Enabled = false;
                checkBoxDireto.Enabled = false;
                checkBoxDiretoRegresso.Enabled = false;

                //Atualizar Datagrids
                List<Voo> listaTemporaria = new List<Voo>();
                listaTemporaria.Add(_vooIda);
                DataGridDadosIda(listaTemporaria);

                List<Voo> listaTemporariaRegresso = new List<Voo>();
                listaTemporariaRegresso.Add(_vooIda);
                DataGridDadosRegresso(listaTemporariaRegresso);
            }
        }

        //Metodo para criar bilhetes de regresso
        private void adicionarRegressoCesta()
        {
            //Voo escolhido = new Voo();

            //if (dataGridViewVoosRegresso.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow linhaEscolhida = dataGridViewVoosRegresso.SelectedRows[0];

            //    int num = Convert.ToInt32(linhaEscolhida.Cells["colId"].Value);

            //    foreach (Voo vooRegresso in _voosIda)
            //    {
            //        if (vooRegresso.Id == num)
            //        {
            //            escolhido = vooRegresso;
            //        }
            //    }

            //    _assentosCestaRegresso = escolhido.AssentosReservados;

            //    if (_lugar != null && (TipoBilhete)comboBoxTipo.SelectedItem != TipoBilhete.bebe)
            //    {


            //        if ((TipoBilhete)comboBoxTipo.SelectedItem == TipoBilhete.adulto)
            //        {
            //            Bilhete novoBilheteAdulto = new BilheteAdulto(

            //                Convert.ToInt32(txtBoxId.Text),
            //                txtBoxNome.Text,
            //                txtBoxApelido.Text,
            //                escolhido,
            //                (Tarifa)comboBoxTarifa.SelectedItem,
            //                _lugar);

            //            _bilhetesAGravar.Add(novoBilheteAdulto);

            //            List<Voo> listaComUmVoo = new List<Voo> { escolhido };

            //            //write a method
            //            CestaBilhetes(listaComUmVoo);
            //        }
            //        else if ((TipoBilhete)comboBoxTipo.SelectedItem == TipoBilhete.crianca)
            //        {
            //            Bilhete novoBilheteCrianca = new BilheteCrianca(
            //                    Convert.ToInt32(txtBoxId.Text),        // Id
            //                    txtBoxNome.Text,
            //                    txtBoxApelido.Text,                          // Apelido
            //                    escolhido,          // Voo
            //                    (Tarifa)comboBoxTarifa.SelectedItem,    // Tarifa
            //                    _lugar);                                  // Lugar)

            //            _bilhetesAGravar.Add(novoBilheteCrianca);

            //            List<Voo> listaComUmVoo = new List<Voo> { escolhido };

            //            CestaBilhetes(listaComUmVoo);
            //        }

            //        checkBoxRegresso.Enabled = true;

            //    }
            //    else if (_lugar == null && (TipoBilhete)comboBoxTipo.SelectedItem == TipoBilhete.bebe)
            //    {
            //        if (!_bilhetesAGravar.Any(b => b is BilheteAdulto))
            //        {
            //            MessageBox.Show("Bebe apenas podem voar com um adulto. Por favor insire bilhete adulto primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            List<BilheteAdulto> bilhetesAdultos = _bilhetesAGravar.OfType<BilheteAdulto>().ToList();

            //            List<BilheteAdulto> bilhetesAdultosRegresso = bilhetesAdultos.Where(b => b.Voo.Id == escolhido.Id).ToList();

            //            string[] bebeDados = new string[6];
            //            bebeDados[0] = txtBoxId.Text;
            //            bebeDados[1] = txtBoxNome.Text;
            //            bebeDados[2] = txtBoxApelido.Text;
            //            bebeDados[3] = Convert.ToString((Tarifa)comboBoxTarifa.SelectedItem);

            //            List<Voo> listaComUmVoo = new List<Voo> { escolhido };

            //            CestaBilhetes(listaComUmVoo);

            //            FormBebeResponsavel formBebeResponsavel = new FormBebeResponsavel(this, bebeDados, escolhido, bilhetesAdultosRegresso, listaComUmVoo);
            //            formBebeResponsavel.Show();
            //        }
            //    }
            //    else if (_lugar == null && (TipoBilhete)comboBoxTipo.SelectedItem != TipoBilhete.bebe)
            //    {
            //        MessageBox.Show("Por favor, escolha lugar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }
            //    int idVoo = Convert.ToInt32(txtBoxId.Text);
            //    txtBoxId.Text = Convert.ToString(idVoo + 1);
            //    _lugar = null;
            //    lblLugar.Text = _lugar;
            //    listBoxVoosRegresso.Enabled = false;
            //    checkBoxRegresso.Enabled = false;

            //}
        }

        //Fechar form
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Voo ida sem ou com Escala
        private void checkBoxDireto_CheckStateChanged(object sender, EventArgs e)
        {

            if (checkBoxDireto.Checked)
            {

                if (_vooIda == null)
                {
                    if (_voosIdaDisplay != null)
                    {
                        List<Voo> semEscalas = _voosIdaDisplay.Where(X => X.Escala == null).ToList();
                        DataGridDadosIda(semEscalas);
                    }
                    else
                    {
                        List<Voo> semEscalas = _voosIda.Where(X => X.Escala == null).ToList();
                        DataGridDadosIda(semEscalas);
                    }
                }
                else
                {
                    if (_vooIda.Escala == null)
                    {
                        DataGridDadosIda(_voosIdaDisplay);
                    }
                }
            }
            else
            {
                if (_vooIda == null)
                {
                    if (_voosIdaDisplay != null)
                    {
                        DataGridDadosIda(_voosIdaDisplay);
                    }
                    else
                    {
                        DataGridDadosIda(_voosIda);
                    }

                }
                else
                {
                    if (_vooIda.Escala == null)
                    {
                        DataGridDadosIda(_voosIdaDisplay);
                    }
                }
            }

        }

        //Encher data grid voos ida como dados
        private void DataGridDadosIda(List<Voo> voosDisplay)
        {
            List<Voo> voos = voosDisplay;

            if (voos != null)
            {
                int linha = 0;

                dataGridViewVoosIda.Rows.Clear();

                foreach (Voo voo in voos)
                {
                    DataGridViewRow registo = new DataGridViewRow();

                    dataGridViewVoosIda.Rows.Add(registo);

                    dataGridViewVoosIda.Rows[linha].Cells[0].Value = voo.Id;
                    dataGridViewVoosIda.Rows[linha].Cells[1].Value = voo.Origem.Nome;
                    dataGridViewVoosIda.Rows[linha].Cells[2].Value = voo.Destino.Nome;

                    if (voo.Escala != null)
                    {
                        dataGridViewVoosIda.Rows[linha].Cells[3].Value = voo.Escala.Nome;
                    }
                    else
                    {
                        dataGridViewVoosIda.Rows[linha].Cells[3].Value = "N/A";
                    }

                    dataGridViewVoosIda.Rows[linha].Cells[4].Value = voo.Data.ToString("dd/MM/yyyy");
                    dataGridViewVoosIda.Rows[linha].Cells[5].Value = voo.Hora.ToString(@"hh\:mm"); ;
                    dataGridViewVoosIda.Rows[linha].Cells[6].Value = voo.Duracao;
                    dataGridViewVoosIda.Rows[linha].Cells[7].Value = voo.PrecoAssentoBase;

                    linha++;
                }

                dataGridViewVoosIda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                dataGridViewVoosIda.Rows.Clear();
            }

        }

        //Encher data grid  voos regresso como dados
        private void DataGridDadosRegresso(List<Voo> voosDisplay)
        {
            List<Voo> voos = voosDisplay;

            if (voos.Count > 0)
            {
                int linha = 0;

                dataGridViewVoosRegresso.Rows.Clear();

                foreach (Voo voo in voos)
                {
                    DataGridViewRow registo = new DataGridViewRow();

                    dataGridViewVoosRegresso.Rows.Add(registo);

                    dataGridViewVoosRegresso.Rows[linha].Cells[0].Value = voo.Id;
                    dataGridViewVoosRegresso.Rows[linha].Cells[1].Value = voo.Origem.Nome;
                    dataGridViewVoosRegresso.Rows[linha].Cells[2].Value = voo.Destino.Nome;

                    if (voo.Escala != null)
                    {
                        dataGridViewVoosRegresso.Rows[linha].Cells[3].Value = voo.Escala.Nome;
                    }
                    else
                    {
                        dataGridViewVoosRegresso.Rows[linha].Cells[3].Value = "N/A";
                    }

                    dataGridViewVoosRegresso.Rows[linha].Cells[4].Value = voo.Data.ToString("dd/MM/yyyy");
                    dataGridViewVoosRegresso.Rows[linha].Cells[5].Value = voo.Hora.ToString(@"hh\:mm"); ;
                    dataGridViewVoosRegresso.Rows[linha].Cells[6].Value = voo.Duracao;
                    dataGridViewVoosRegresso.Rows[linha].Cells[7].Value = voo.PrecoAssentoBase;

                    linha++;
                }

                dataGridViewVoosRegresso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                dataGridViewVoosRegresso.Rows.Clear();
            }

        }

        //Voo regresso sem ou com Escala
        private void checkBoxDiretoRegresso_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxDiretoRegresso.Checked)
            {

                if (_vooRegresso == null)
                {
                    if (_voosRegresso != null)
                    {
                        List<Voo> semEscalas = _voosRegresso.Where(X => X.Escala == null).ToList();
                        DataGridDadosRegresso(semEscalas);
                    }
                    else
                    {
                        DataGridDadosRegresso(_voosRegresso);
                    }
                }
                else
                {
                    if (_vooRegresso.Escala == null)
                    {
                        DataGridDadosRegresso(_voosRegresso);
                    }
                }
            }
            else
            {
                if (_vooRegresso == null)
                {
                    if (_voosRegresso != null)
                    {
                        DataGridDadosRegresso(_voosRegresso);
                    }

                }
                else
                {
                    if (_vooRegresso.Escala == null)
                    {
                        DataGridDadosRegresso(_voosRegresso);
                    }

                }
            }
        }
    }
}






