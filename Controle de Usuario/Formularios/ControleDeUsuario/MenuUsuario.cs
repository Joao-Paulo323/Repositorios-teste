
using System;
using System.Windows.Forms;
using System.Drawing;
namespace Controle_de_chamados.Formularios.ControleDeUsuario
{
    public partial class MenuUsuario : UserControl
    {
        // Eventos de comunicação
        public event EventHandler AbrirNovosChamados;
        public event EventHandler AbrirMeusChamados;
        public event EventHandler AbrirChamadosEmAndamento;
        public event EventHandler AbrirChamadosConcluidos;
        private Button botaoSelecionado;

        private void SelecionarBotao(Button novoBotao)
        {
            // Restaura a cor do botão anterior
            if (botaoSelecionado != null)
            {
                botaoSelecionado.BackColor = Color.FromArgb(51,65,85);
                botaoSelecionado.ForeColor = Color.White;
            }

            // Altera a cor do novo botão
            novoBotao.BackColor = Color.FromArgb(13, 148, 136);
            novoBotao.ForeColor = Color.White;

            // Atualiza o botão selecionado
            botaoSelecionado = novoBotao;
        }

        public MenuUsuario()
        {
            InitializeComponent();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            AbrirNovosChamados?.Invoke(this, EventArgs.Empty);
            SelecionarBotao(btnNV);
        }


        private void btnMC_Click(object sender, EventArgs e)
        {
            AbrirMeusChamados?.Invoke(this, EventArgs.Empty);
            SelecionarBotao(btnMC);
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            AbrirChamadosEmAndamento?.Invoke(this, EventArgs.Empty);
            SelecionarBotao(btnCA);
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            AbrirChamadosConcluidos?.Invoke(this, EventArgs.Empty);
            SelecionarBotao(btnCC);
        }

        private void tlpMenuUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuUsuario_Load(object sender, EventArgs e)
        {

            SelecionarBotao(btnMC);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
