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
    public partial class Frmdetalhes : Form
    {
        int venda_id;
        public Frmdetalhes(int idvenda)
        {
            venda_id = idvenda;
            InitializeComponent();
        }

        private void Frmdetalhes_Load(object sender, EventArgs e)
        {
            //Carrega tela de Detalhes
            ItemVendaDAO dao = new ItemVendaDAO();
            tabelaDetalhes.DataSource = dao.ListarItensPorVenda(venda_id);
        }
    }
}
