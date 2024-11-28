using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class ItemVendaDAO
    {

        private MySqlConnection conexao;

        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }


        #region Método que cadastra um item de venda
        public void cadastrarItem(ItemVenda obj)
        {
            try
            {

                //1 Passo - é criar o sql
                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal)
                                values (@venda_id, @produto_id, @qtd, @subtotal)";

                //2 Passo é organizar e executar o comando sql[
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.subtotal);


                //3 Passo - é abrir a conexao e executar o comando
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Item cadastrado com Sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }


        #endregion


        #region Método que lista todos os itens por venda
        public DataTable ListarItensPorVenda(int venda_id)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL
                DataTable tabelaItens = new DataTable();

                string sql = @"SELECT  i.id        as 'Código',
                                       p.descricao as 'Descrição',
                                       i.qtd       as 'Quantidade',
                                       p.preco     as 'Preço',
                                       i.subtotal  as 'SubTotal'  
       
                                       FROM tb_itensvendas as i join
                                       tb_produtos as p on (i.produto_id = p.id) WHERE venda_id = @venda_id";

                //2 Passo - Organizar e executar o comando sql
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
                executacmdsql.Parameters.AddWithValue("@venda_id", venda_id);
                

                conexao.Open();
                executacmdsql.ExecuteNonQuery();

                //3 Passo - Criar o MysqlDataAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabelaItens);

                return tabelaItens;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;

            }
        }

        #endregion
    }
}
