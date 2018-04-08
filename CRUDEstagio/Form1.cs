using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//@AUTOR: THAILAN
//27.02.17


namespace CRUDEstagio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "Data/Hora e Botao Exit"
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            LbHora1.Text = "Data: " + dataHora.ToShortDateString() + " Hora: " + dataHora.ToLongTimeString();

        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region "Evento Cadastrar"
        private void toolStripCadastrar_Click(object sender, EventArgs e)
        {
            DbCrudThailan test = new DbCrudThailan();

            ArrayList arr = new ArrayList();
            try
            {
                // atribui ao array os campos de texto
                arr.Add(TbNome.Text);
                arr.Add(TbCodigoPeca.Text);
                arr.Add(TbCodigoBarras.Text);
                arr.Add(TbMarca.Text);
                arr.Add(TbDistribuidor.Text);
                arr.Add(TbCadPreco.Text);
                
                if (TbNome.Text != "" && TbCodigoPeca.Text != "" && TbCodigoBarras.Text != ""
                                 && TbMarca.Text != "" && TbDistribuidor.Text != "" && TbCadPreco.Text!="")
                                 //CONDIONAL para nao deixar campos em branco
                {
                        if (test.Insert(arr))
                        {
                            // se tudo aconteceu certo, exibe a mensagem de cadastro e limpa os campos
                            MessageBox.Show("Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TbNome.Clear();
                            TbCodigoPeca.Clear();
                            TbCodigoBarras.Clear();
                            TbMarca.Clear();
                            TbDistribuidor.Clear();
                            TbCadPreco.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Cadastrar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                else
                {
                    // mensagem de erro se houverem campos em branco
                    MessageBox.Show("Campos em Branco, Preecha-os por favor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }

        }
        #endregion


        #region "Evento Editar"
        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            DbCrudThailan test = new DbCrudThailan();

            ArrayList arr = new ArrayList();
            // checa se há campos em branco

            if (TbCodigoUnico.Text != "" && TbEditNome.Text != "" && TbEditCodPeca.Text != ""
                                && TbEditCodBarras.Text != "" && TbEditMarca.Text != ""
                                && TbEditDistribuidor.Text != "" && TbEditPreco.Text != "")
            {
               
                try // executa a leitura dos campos e insere no array
                {
                    arr.Add(int.Parse(TbCodigoUnico.Text));
                    arr.Add(TbEditNome.Text);
                    arr.Add(TbEditCodPeca.Text);
                    arr.Add(TbEditCodBarras.Text);
                    arr.Add(TbEditMarca.Text);
                    arr.Add(TbEditDistribuidor.Text);
                    arr.Add(TbEditPreco.Text);


                    if (test.Update(arr)) // chama o método da class DbCrudThailan
                    {
                        MessageBox.Show("Atualizado com Sucesso", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TbCodigoUnico.Clear();
                        TbEditNome.Clear();
                        TbEditCodPeca.Clear();
                        TbEditCodBarras.Clear();
                        TbEditMarca.Clear();
                        TbEditDistribuidor.Clear();
                        TbEditPreco.Clear();
                        tabPageEdit_Enter_1(e, e); //Atualiza a lista

                    }
                    else // TRATAMENTOS DE ERROS
                    {
                        MessageBox.Show("Erro ao Atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro + "Erro Ocorrido");
                }
            }
            
            else
            {
                MessageBox.Show("Erro ao Atualizar, Preencha os Campos em Branco", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

        

           
        }

        #endregion


        #region "Evento Deletar"

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            
            DbCrudThailan obj = new DbCrudThailan();
            if (TbExcluir.Text != "")
            {
                 if (obj.Delete(int.Parse(TbExcluir.Text)))
                {
                    MessageBox.Show("Excluido com Sucesso", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TbExcluir.Clear();
                    tabPageExcluir_Enter(e, e);
                }
                else
                {
                    MessageBox.Show("Erro ao Exlcuir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            else
            {
                MessageBox.Show("Erro ao Exlcuir, Campo em Branco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        #endregion


        #region "TabPages"

        private void tabPageExcluir_Enter(object sender, EventArgs e)
        {
            DbCrudThailan obj = new DbCrudThailan();
            DgExcluir.DataSource = obj.ListaTabela();
        }

        private void tabPageEdit_Enter_1(object sender, EventArgs e)
        {
            DbCrudThailan obj = new DbCrudThailan();
            DgEdit.DataSource = obj.ListaTabela();
        }

        #endregion


        #region Eventos de Pesquisa
        private void toolStripPesquisa_Click(object sender, EventArgs e)
        {
            DbCrudThailan obj = new DbCrudThailan();
            string sql;

            if (RbPorNome.Checked)
            {
                sql = "SELECT[ID_PECA] AS Codigo_Unico,[NOME],[CODIGOPECA],[CODIGODEBARRAS],[MARCA],[DISTRIBUIDOR],[PRECO] FROM CRUD_PECAS WHERE NOME LIKE @VALOR";
                DgPesquisa.DataSource = obj.Pesquisa(sql, "%" + TbPesquisa.Text + "%");
            }
            else
            {
                if (RbCodigoPeca.Checked) {
                    sql = "SELECT[ID_PECA] AS Codigo_Unico,[NOME],[CODIGOPECA],[CODIGODEBARRAS],[MARCA],[DISTRIBUIDOR],[PRECO] FROM CRUD_PECAS WHERE CODIGOPECA LIKE @VALOR";
                    DgPesquisa.DataSource = obj.Pesquisa(sql, TbPesquisa.Text);
                }

                else
                {
                    sql = "SELECT[ID_PECA] AS Codigo_Unico,[NOME],[CODIGOPECA],[CODIGODEBARRAS],[MARCA],[DISTRIBUIDOR],[PRECO] FROM CRUD_PECAS WHERE ID_PECA LIKE @VALOR";
                    DgPesquisa.DataSource = obj.Pesquisa(sql, TbPesquisa.Text);
                }
            }
            TbPesquisa.Clear();
          
        }

        #endregion

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }
    }

}
