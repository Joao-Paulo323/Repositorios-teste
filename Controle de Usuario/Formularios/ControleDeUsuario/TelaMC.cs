using System;
using System.Drawing;
using System.Windows.Forms;

namespace Controle_de_chamados.Formularios.ControleDeUsuario
{
    public partial class TelaMC : UserControl
    {
        // A tela principal escolhe o que abrir quando o usuário clica em Voltar.
        public event EventHandler? VoltarSolicitado;

        public TelaMC()
        {
            InitializeComponent();
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            // Impede o usuário de alterar os dados diretamente no grid.
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;

            // Cabeçalhos provisórios: os registros serão conectados ao banco depois.
            if (dataGridView1.Columns.Count == 0 && dataGridView1.DataSource == null)
            {
                dataGridView1.Columns.Add("Numero", "Nº");
                dataGridView1.Columns.Add("Assunto", "Assunto");
                dataGridView1.Columns.Add("Status", "Status");
                dataGridView1.Columns.Add("Data", "Abertura");
            }

            // Nenhum dado fictício é apresentado como chamado verdadeiro.
            lblTTN.Text = "0";
            lblAndN.Text = "0";
            lblCCN.Text = "0";
            label1.Text = "Meus Chamados";

            btnIVoltar.Cursor = Cursors.Hand;
            btnIVoltar.Click += (sender, args) =>
                VoltarSolicitado?.Invoke(this, EventArgs.Empty);

            // Corrige o excesso de linhas em porcentagem no layout do Designer.
            // Mantém as seções existentes: título, indicadores e tabela.
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 83));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        }

        // Deixe este evento disponível para o Designer do Visual Studio.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
