using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD.NET_MySQL
{
    public partial class CRUD : Form
    {
        MySqlConnection conexao; // IP do servidor do Banco de Dados
        MySqlCommand comando; // Variável que chamará o MySQLCommand
        MySqlDataAdapter dataAdapter; // Manipulador de dados 
        MySqlDataReader dataReader; // Leitor de dados
        string strSQL; // comando em SQL

        public CRUD()
        {
            InitializeComponent();
        }

        // CRIAR \/ 
        private void button1_Click(object sender, EventArgs e)
        {
            // Nenhum campo, exceto o ID, pode estar vazio.
            if (!string.IsNullOrWhiteSpace(tb_nome.Text) && !string.IsNullOrWhiteSpace(tb_email.Text) && !string.IsNullOrWhiteSpace(tb_telefone.Text))
            {
                try
                {
                    conexao = new MySqlConnection("Server = localhost; Port = 3306; Database = bdgabrielcrud; Uid = root;");

                    strSQL = "INSERT INTO CAD_CLIENTES (NOME, EMAIL, TELEFONE) VALUES (@NOME, @EMAIL, @TELEFONE)";

                    comando = new MySqlCommand(strSQL, conexao);

                    // substituindo os @ pelo texto dentro das TextBox
                    comando.Parameters.AddWithValue("@NOME", tb_nome.Text);
                    comando.Parameters.AddWithValue("@EMAIL", tb_email.Text);
                    comando.Parameters.AddWithValue("@TELEFONE", tb_telefone.Text);
                    
                    // abre a conexão
                    conexao.Open();

                    // ExecuteNonQuery pois o CREATE não precisa retornar nenhum dado
                    comando.ExecuteNonQuery();
                    
                    // Mensagem de sucesso
                    MessageBox.Show(tb_nome.Text + " foi incluído com sucesso no banco de dados.", "Criar");

                    // Traz o foco para o TextBox ID
                    tb_id.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Limpa os campos
                    tb_id.Text = null;
                    tb_nome.Text = null;
                    tb_email.Text = null;
                    tb_telefone.Text = null;

                    // Fecha conexão e limpa variaveis
                    conexao.Close();
                    conexao = null;
                    comando = null;
                }
            }
            else
            {
                // Se algum campo estiver em branco não executa o comando.
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (tb_id.Text != "")
            {
                conexao = new MySqlConnection("Server = localhost; Port = 3306; Database = bdgabrielcrud; Uid = root;");
                strSQL = "SELECT * FROM CAD_CLIENTES WHERE ID = @ID";
                comando = new MySqlCommand(strSQL, conexao);

                conexao.Open();

                comando.Parameters.AddWithValue("@ID", tb_id.Text);

                // Diferente do ExecuteNonQuery, o ExecuteReader retorna valores
                dataReader = comando.ExecuteReader();

                // Verificando se foi retornado algum valor no comando SQL que enviamos
                bool existe = dataReader.HasRows;

                // Fecha conexão
                conexao.Close();

                // Se foi retornado algum valor no comando, executamos o bloco
                if (existe)
                {
                    try
                    {
                        conexao = new MySqlConnection("Server = localhost; Port = 3306; Database = bdgabrielcrud; Uid = root;");

                        strSQL = "SELECT * FROM CAD_CLIENTES WHERE ID = @ID;";

                        comando = new MySqlCommand(strSQL, conexao);

                        conexao.Open();

                        comando.Parameters.AddWithValue("@ID", tb_id.Text);

                        dataReader = comando.ExecuteReader();
                        while (dataReader.Read())
                        {
                            // Enquanto estivermos recebendo dados, o sistema vai inserir nas textBox os valores recebidos
                            tb_ids.Text = Convert.ToString(dataReader["id"]) + Environment.NewLine;
                            tb_nomes.Text = Convert.ToString(dataReader["nome"]) + Environment.NewLine;
                            tb_emails.Text = Convert.ToString(dataReader["email"]) + Environment.NewLine;
                            tb_telefones.Text = Convert.ToString(dataReader["telefone"]) + Environment.NewLine;

                        }
                        if (tb_nomes.Text != "")
                        {
                            // Se algo foi inserido dentro da TextBox Nomes é porque recebemos dados
                            MessageBox.Show("Consulta realizada com sucesso.");
                        }
                        else
                        {   // Se nada foi inserido, não recebemos dados.
                            throw new Exception("Não há registros com este ID.");
                        }
                        tb_id.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexao.Close();
                        conexao = null;
                        comando = null;
                    }
                } else
                {
                    MessageBox.Show("Nenhum registro encontrado com o ID " + tb_id.Text);
                }
            }
            else
            {
                try
                {
                    conexao = new MySqlConnection("Server = localhost; Port = 3306; Database = bdgabrielcrud; Uid = root;");

                    strSQL = "SELECT * FROM CAD_CLIENTES";

                    comando = new MySqlCommand(strSQL, conexao);

                    conexao.Open();

                    dataReader = comando.ExecuteReader();

                    tb_ids.Text = "";
                    tb_nomes.Text = "";
                    tb_emails.Text = "";
                    tb_telefones.Text = "";

                    while (dataReader.Read())
                    {
                        tb_ids.Text += Convert.ToString(dataReader["id"]) + Environment.NewLine;
                        tb_nomes.Text += Convert.ToString(dataReader["nome"]) + Environment.NewLine;
                        tb_emails.Text += Convert.ToString(dataReader["email"]) + Environment.NewLine;
                        tb_telefones.Text += Convert.ToString(dataReader["telefone"]) + Environment.NewLine;
                    }
                    if (tb_nomes.Text != "")
                    {
                        MessageBox.Show("Consulta realizada com sucesso.");
                    }
                    else
                    {
                        throw new Exception("Não há registros cadastrados.");
                    }
                    tb_id.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexao.Close();
                    conexao = null;
                    comando = null;
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection("Server = localhost; Port = 3306; Database = bdgabrielcrud; Uid = root;");
            strSQL = "SELECT * FROM CAD_CLIENTES WHERE ID = @ID";
            comando = new MySqlCommand(strSQL, conexao);

            conexao.Open();

            comando.Parameters.AddWithValue("@ID", tb_id.Text);

            dataReader = comando.ExecuteReader();

            bool existe = dataReader.HasRows;
            conexao.Close();

            if (existe)
            {
                if (!string.IsNullOrEmpty(tb_id.Text) && !string.IsNullOrWhiteSpace(tb_nome.Text) && !string.IsNullOrWhiteSpace(tb_email.Text) && !string.IsNullOrWhiteSpace(tb_telefone.Text))
                {
                    try
                    {
                        conexao = new MySqlConnection("Server = localhost; Port = 3306; Database = bdgabrielcrud; Uid = root;");
                        strSQL = "UPDATE CAD_CLIENTES SET NOME = @NOME, EMAIL = @EMAIL, TELEFONE = @TELEFONE WHERE ID = @ID";

                        comando = new MySqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@ID", tb_id.Text);
                        comando.Parameters.AddWithValue("@NOME", tb_nome.Text);
                        comando.Parameters.AddWithValue("@EMAIL", tb_email.Text);
                        comando.Parameters.AddWithValue("@TELEFONE", tb_telefone.Text);

                        conexao.Open();

                        comando.ExecuteNonQuery();


                        MessageBox.Show("ID " + tb_id.Text + " foi alterado com sucesso.", "Alterar");
                        tb_id.Focus();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tb_id.Text = null;
                        tb_nome.Text = null;
                        tb_email.Text = null;
                        tb_telefone.Text = null;
                        conexao.Close();
                        conexao = null;
                        comando = null;
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos.");
                }
            }
            else
            {
                MessageBox.Show("Não existem registros com ID " + tb_id.Text);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection("Server = localhost; Port = 3306; Database = bdgabrielcrud; Uid = root;");
            strSQL = "SELECT * FROM CAD_CLIENTES WHERE ID = @ID";
            comando = new MySqlCommand(strSQL, conexao);
            
            conexao.Open();

            comando.Parameters.AddWithValue("@ID", tb_id.Text);

            dataReader = comando.ExecuteReader();

            bool existe = dataReader.HasRows;
            conexao.Close();

            if (existe)
            {
                if (tb_id.Text != "")
                {
                    try
                    {
                        conexao = new MySqlConnection("Server = localhost; Port = 3306; Database = bdgabrielcrud; Uid = root;");

                        strSQL = "DELETE FROM CAD_CLIENTES WHERE ID = @ID";


                        comando = new MySqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@ID", tb_id.Text);

                        conexao.Open();

                        comando.ExecuteNonQuery();

                        MessageBox.Show("O ID " + tb_id.Text + " foi deletado com sucesso.");
                        tb_id.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tb_id.Text = null;
                        tb_nome.Text = null;
                        tb_email.Text = null;
                        tb_telefone.Text = null;
                        conexao.Close();
                        conexao = null;
                        comando = null;
                    }
                }
                else
                {
                    throw new Exception("Preencha o ID que deseja deletar.");
                }
            } else
            {
                MessageBox.Show("Não existem registros com ID " + tb_id.Text);
            }
        }

        private void btn_deletar_todos_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Port = 3306; Database = bdgabrielcrud; Uid = root;");

                strSQL = "DELETE FROM CAD_CLIENTES";


                comando = new MySqlCommand(strSQL, conexao);

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Todos os registros foram excluídos do banco de dados.");
                tb_id.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb_id.Text = null;
                tb_nome.Text = null;
                tb_email.Text = null;
                tb_telefone.Text = null;
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_ids.Text = null;
            tb_nomes.Text = null;
            tb_emails.Text = null;
            tb_telefones.Text = null;
            tb_id.Focus();
        }
    }
}