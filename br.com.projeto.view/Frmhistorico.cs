using Projeto_Controle_Vendas.br.com.projeto.dao;
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
    public partial class Frmhistorico : Form
    {
        public Frmhistorico()
        {
            InitializeComponent();
            //tabelaHistorico.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void Btnpesquisar_Click(object sender, EventArgs e)
        {
            DateTime datainicio, datafim; 

            datainicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            datafim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            VendaDAO dao = new VendaDAO();

            tabelaHistorico.DataSource = dao.listarVendasPorPeriodo(datainicio, datafim);
            
        }

        private void Frmhistorico_Load(object sender, EventArgs e)
        {
            
            VendaDAO dao = new VendaDAO();

            tabelaHistorico.DataSource = dao.listarVendas();
            tabelaHistorico.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void tabelaHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1° Passo - Abrir um outro Formulario
           
            //Passando o id da venda
            int idvenda = int.Parse(tabelaHistorico.CurrentRow.Cells[0].Value.ToString());
            
            Frmdetalhes tela = new Frmdetalhes(idvenda);

            //Formatando a data
            DateTime dataVenda = Convert.ToDateTime(tabelaHistorico.CurrentRow.Cells[1].Value.ToString());


            tela.txtdata.Text = dataVenda.ToString("dd/MM/yyyy");
            tela.txtcliente.Text = tabelaHistorico.CurrentRow.Cells[2].Value.ToString();
            tela.txttotal.Text   = tabelaHistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtobs.Text     = tabelaHistorico.CurrentRow.Cells[4].Value.ToString();

            
            

            tela.ShowDialog();
        }
    }
}
