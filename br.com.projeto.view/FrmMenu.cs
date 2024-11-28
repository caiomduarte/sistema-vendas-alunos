using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Abre a tela de Funcionarios
            Frmfuncionarios tela = new Frmfuncionarios();
            tela.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //Pegando a data atual
            txtdata.Text = DateTime.Now.ToShortDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Programação dtentro do timer
            //Pegando a hora
            txthora.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir a tela de clientes
            Frmclientes tela = new Frmclientes();
            
            tela.ShowDialog();
        }

        private void consultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir a tela de clientes com a aba de consulta aberto
            Frmclientes tela = new Frmclientes();
            tela.tabClientes.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
              
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Abrir tela de consulta de funcionarios
            Frmfuncionarios tela = new Frmfuncionarios();
            tela.tabFuncionario.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void cadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfornecedores tela = new Frmfornecedores();
            tela.ShowDialog();
        }

        private void consultaDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfornecedores tela = new Frmfornecedores();
            tela.tabFornecedor.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuCadastroProdutos_Click(object sender, EventArgs e)
        {
            Frmprodutos tela = new Frmprodutos();
            tela.ShowDialog();
        }

        private void consultaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmprodutos tela = new Frmprodutos();
            tela.tabProdutos.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmvendas tela = new Frmvendas();
            tela.ShowDialog();
        }

        private void menuHistorico_Click(object sender, EventArgs e)
        {
            Frmhistorico tela = new Frmhistorico();
            tela.ShowDialog();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Fechar a aplicação
            DialogResult result = MessageBox.Show("Você deseja Sair?", "ATENÇÂO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                //Apertou no YES (SIM)
                Application.Exit();
            }
                      
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Trocar de usuário
            DialogResult result = MessageBox.Show("Você deseja Trocar de usuário?", "ATENÇÂO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //Apertou no YES (SIM)
                new Frmlogin().Show();
                this.Dispose();
            }
        }
    }
}
