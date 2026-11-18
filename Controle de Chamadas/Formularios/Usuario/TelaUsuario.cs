
using System;
using System.Windows.Forms;
using Controle_de_chamados.Formularios.ControleDeUsuario;

namespace Controle_de_chamados.Formularios.Usuario
{
    public partial class TelaUsuario : Form
    {
        private MenuUsuario menu;
        private UserControl conteudoAtual;

        public TelaUsuario()
        {
            InitializeComponent();
        }

        private void TelaUsuario_Load(object sender, EventArgs e)
        {
            // Cria o menu lateral
            menu = new MenuUsuario();

            // Inscreve os eventos do menu
            menu.AbrirNovosChamados += (s, ev) =>
            {
                AbrirConteudo(new MeusChamados());
            };

            menu.AbrirMeusChamados += (s, ev) =>
            {
                AbrirConteudo(new MeusChamados());
            };

            // Adiciona o menu na primeira coluna
            tlpMainUser.Controls.Add(menu, 0, 0);
            menu.Dock = DockStyle.Fill;

            // Abre a tela inicial
            AbrirConteudo(new MeusChamados());
        }

        // Método responsável por trocar as telas
        private void AbrirConteudo(UserControl controle)
        {
            // Remove o conteúdo anterior
            if (conteudoAtual != null)
            {
                tlpMainUser.Controls.Remove(conteudoAtual);
                conteudoAtual.Dispose();
            }

            // Guarda o novo conteúdo
            conteudoAtual = controle;

            // Adiciona na segunda coluna
            tlpMainUser.Controls.Add(conteudoAtual, 1, 0);

            // Ocupa todo o espaço disponível
            conteudoAtual.Dock = DockStyle.Fill;
        }

        private void tlpMainUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
