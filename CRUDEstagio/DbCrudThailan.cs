using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


//@AUTOR: THAILAN
//27.02.17

namespace CRUDEstagio
{
    class DbCrudThailan
    {
        private const string _Strconexao = @"Data Source=DESKTOP-36HDB91\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        private string varsql = "";
        SqlConnection obCon = null;


        #region "Conexão com o banco"
        private bool conectar()
        {
            obCon = new SqlConnection(_Strconexao);
            try
            {
                obCon.Open();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        private bool desconectar()
        {
            if (obCon.State != ConnectionState.Closed)
            {
                obCon.Dispose();
                obCon.Close();
                return true;
            }
            else
            {
                obCon.Dispose();
                return false;   
            }

        }
        #endregion


        #region "Métodos de Inserir"
        public bool Insert(ArrayList v_arrInserir) //método de Inserção de dados
        {
            varsql = "INSERT INTO CRUD_PECAS ([NOME],[CODIGOPECA],[CODIGODEBARRAS],[MARCA],[DISTRIBUIDOR],[PRECO])"+
                "VALUES(@NOME,@CODIGOPECA,@CODIGODEBARRAS,@MARCA,@DISTRIBUIDOR,@PRECO)"; //insert sql

            SqlCommand comando = null;

            if (this.conectar()) // testa a conexão
            {
                try
                {
                    comando = new SqlCommand(varsql,obCon);
                    //INSERE OS DADOS VINDOS DO ARRAY
                    comando.Parameters.AddWithValue("@NOME", v_arrInserir[0]);
                    comando.Parameters.AddWithValue("@CODIGOPECA", v_arrInserir[1]);
                    comando.Parameters.AddWithValue("@CODIGODEBARRAS", v_arrInserir[2]);
                    comando.Parameters.AddWithValue("@MARCA", v_arrInserir[3]);
                    comando.Parameters.AddWithValue("@DISTRIBUIDOR", v_arrInserir[4]);
                    comando.Parameters.AddWithValue("@PRECO", v_arrInserir[5]);
                    
                    comando.ExecuteNonQuery();

                    return true;
                }
                catch(SqlException sqlerro)//tratamento de erros sql
                { 
                    throw sqlerro;
                }
                finally
                {
                    this.desconectar();//chama o método desconexão
                }
            }
            else
            {
                return false;
            }


        }

        #endregion


        #region "Método Editar"
        public bool Update(ArrayList v_arrAtualizar)
        {
            varsql = "UPDATE CRUD_PECAS SET [NOME] = @NOME,[CODIGOPECA] =@CODIGOPECA,[CODIGODEBARRAS] = @CODIGODEBARRAS, [MARCA] = @MARCA,[DISTRIBUIDOR] = @DISTRIBUIDOR,[PRECO] = @PRECO WHERE ID_PECA= @ID_PECA";

            SqlCommand comando = null;

            if (this.conectar()) // testa a conexão
            {
                try
                {
                    //atualiza os dados no banco
                    comando = new SqlCommand(varsql, obCon);
                    comando.Parameters.AddWithValue("@ID_PECA", v_arrAtualizar[0]);
                    comando.Parameters.AddWithValue("@NOME", v_arrAtualizar[1]);
                    comando.Parameters.AddWithValue("@CODIGOPECA", v_arrAtualizar[2]);
                    comando.Parameters.AddWithValue("@CODIGODEBARRAS", v_arrAtualizar[3]);
                    comando.Parameters.AddWithValue("@MARCA", v_arrAtualizar[4]);
                    comando.Parameters.AddWithValue("@DISTRIBUIDOR", v_arrAtualizar[5]);
                    comando.Parameters.AddWithValue("@PRECO", v_arrAtualizar[6]);

                    comando.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException sqlerro)//tratamento de erros sql
                {
                    throw sqlerro;
                }
                finally
                {
                    this.desconectar();//chama o método desconexão
                }
            }
            else
            {
                return false;
            }

        }
        #endregion


        #region "Método Deletar"
        public bool Delete(int id_peca) // Necessita do ID unico da peça para excluir
        {
            varsql = "DELETE FROM CRUD_PECAS WHERE ID_PECA = @ID_PECA"; //sql de Delete

            SqlCommand comando = null;

            if (this.conectar()) // testa a conexão
            {
                try
                {
                    comando = new SqlCommand(varsql, obCon);// faz a conexao com o banco
                    comando.Parameters.AddWithValue("@ID_PECA",id_peca); // busca o ID do Text Box
                    comando.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException sqlerro)//tratamento de erros sql
                {
                    throw sqlerro;
                }
                finally
                {
                    this.desconectar();//chama o método desconexão
                }
            }
            else
            {
                return false;
            }
        }
        #endregion



        #region "Listagem de tabelas"
        //#region "Metodos de Pesquisa e Listagem de tabelas"
        public DataTable ListaTabela()
        {
            // STRING SQL
                varsql = "SELECT [ID_PECA] AS Codigo_Unico,[NOME],[CODIGOPECA],[CODIGODEBARRAS],[MARCA],[DISTRIBUIDOR],[PRECO] FROM CRUD_PECAS";

            SqlCommand comando = null;

            if (this.conectar()) // testa a conexão
            {
                try
                {
                    comando = new SqlCommand(varsql, obCon); //CONEXÃO
                    SqlDataAdapter adpt = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable(); //nova tabela
                    adpt.Fill(dt); // exibição de tabelas
 
                    return dt ;
                }
                catch (SqlException sqlerro)//tratamento de erros sql
                {
                    throw sqlerro;
                }
                finally
                {
                    this.desconectar();//chama o método desconexão
                }
            }
            else
            {
                return null;
            }
        }
        #endregion


        #region "Método de Pesquisa"

        public DataTable Pesquisa(string sql, string param)
        {
            //IGUAL AO ANTERIOR POREM, DESTA VEZ É PASSADA A SQL QUE SE DESEJA PROCURAR.
            this.varsql = sql;

            SqlCommand comando = null;

            if (this.conectar()) // testa a conexão
            {
                try
                {
                    comando = new SqlCommand(varsql, obCon);
                    comando.Parameters.Add(new SqlParameter("@VALOR", param));
                    SqlDataAdapter adpt = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);

                    return dt;
                }
                catch (SqlException sqlerro)//tratamento de erros sql
                {
                    throw sqlerro;
                }
                finally
                {
                    this.desconectar();//chama o método desconexão
                }
            }
            else
            {
                return null;
            }
        }

        #endregion
    }

}

