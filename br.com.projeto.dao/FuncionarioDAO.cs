using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using Projeto_Controle_Vendas.br.com.projeto.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }


        #region Método Cadastrar Funcionario
        public void cadastrarFuncionario(Funcionario obj)
        {
            try
            {
                //1 passo - Criar o comando sql
                string sql = "insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)" +
                             " values (@nome,@rg,@cpf,@email,@senha,@cargo,@nivel,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                //2 passo - Organizar e executar o comando sql              
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);

                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel", obj.nivel_acesso);

                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);


                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso!");
                //Fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }



        #endregion

        #region Método Alterar Funcionario
        public void alterarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = "update tb_funcionarios set nome=@nome,rg=@rg,cpf=@cpf,email=@email,senha=@senha,cargo=@cargo,nivel_acesso=@nivel," +
                                "telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,numero=@numero," +
                                "complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado where id = @codigo";


                //2 passo - Organizar e executar o comando sql              
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);

                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel", obj.nivel_acesso);

                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);


                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário alterado com sucesso!");
                //Fechar a conexao
                conexao.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }


        #endregion

        #region Método Excluir Funcionario
        public void deletarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = "delete from tb_funcionarios where id = @codigo";
                //2 passo - Organizar e executar o comando sql              
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);

                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluido com sucesso!");
                //Fechar a conexao
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }

        #endregion


        #region Método ListarFuncionarios
        public DataTable listarFuncionarios()
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios";

                //2 passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable;
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                //Fechar a conexao
                conexao.Close();

                return tabelafuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }
        #endregion

        #region Método BuscaFuncionariosPorNome por Nome
        public DataTable BuscaFuncionariosPorNome(string nome)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome = @nome";

                //2 passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable;
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                //Fechar a conexao
                conexao.Close();

                return tabelafuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion

        #region Método que ListaFuncionariosPorNome
        public DataTable listarFuncionariosPorNome(string nome)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome like @nome";

                //2 passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable;
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);

                //Fechar a conexao
                conexao.Close();

                return tabelafuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion

        #region Método que Efetua Login
        public bool EfetuarLogin(string email, string senha)
        {
            try
            {
                //1 Passo é criar o comando sql
                string sql = @"select * from tb_funcionarios 
                                     where email = @email and senha = @senha";

                //2 passo - Organizar e executar o comando sql              
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                if (reader.Read())
                {
                    //Que o login foi realizado com sucesso!
                    
                    string nivel = reader.GetString("nivel_acesso");
                    string nome = reader.GetString("nome");

                    MessageBox.Show("Seja bem vindo ao sistema, " + nome);

                    //Abrir a tela menu principal
                    FrmMenu telamenu = new FrmMenu();

                    telamenu.txtusuario.Text = nome;

                    //Se o nivel for Administrador
                    if (nivel.Equals("Administrador"))
                    {
                        
                        telamenu.Show();
                    }

                    else if (nivel.Equals("Vendedor"))
                    {
                        //Personalizar o que o vendedor vai ter acesso
                        telamenu.menuProdutos.Visible = false;
                        telamenu.menuHistorico.Enabled = false;
                        telamenu.Show();
                    }


                   


                    return true;
                }

                else
                {
                    //A senha ou o email foi digitado errado
                    MessageBox.Show("Email ou senha incorreto!");
                    return false;
                }
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return false;
            }

        }
       
        #endregion



    }
}
