
using System;
using System.Windows.Forms;

namespace Controle_de_chamados.Formularios.ControleDeUsuario
{
    public partial class MenuUsuario : UserControl
    {
        // Eventos de comunicação
        public event EventHandler AbrirNovosChamados;
        public event EventHandler AbrirMeusChamados;
        private Button botaoSelecionado;

        private void SelecionarBotao(Button novoBotao)
        {
            // Restaura a cor do botão anterior
            if (botaoSelecionado != null)
            {
                botaoSelecionado.BackColor = Color.White;
                botaoSelecionado.ForeColor = Color.SeaGreen;
            }

            // Altera a cor do novo botão
            novoBotao.BackColor = Color.SeaGreen;
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
            SelecionarBotao(btnMC);
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            SelecionarBotao(btnCA);
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            SelecionarBotao(btnCC);
        }

        private void tlpMenuUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuUsuario_Load(object sender, EventArgs e)
        {
            SelecionarBotao(btnMC);
        }
    }
}
