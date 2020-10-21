using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProjetoLL.Controller;

namespace ProjetoLL.Model
{
    class ClsLicoesAprendidas
    {

        private int mID_Licao;

        public int ID_Licao
        {
            get { return mID_Licao; }
            set { mID_Licao = value; }
        }

        private string mDS_Licao;

        public string DS_Licao
        {
            get { return mDS_Licao; }
            set { mDS_Licao = value; }
        }

        private string mDS_Abrev;

        public string DS_Abrev
        {
            get { return mDS_Abrev; }
            set { mDS_Abrev = value; }
        }

        private int mID_Fun_Cadastro;

        public int ID_Fun_Cadastro
        {
            get { return mID_Fun_Cadastro; }
            set { mID_Fun_Cadastro = value; }
        }

        private int mID_Fun_Validacao;

        public int ID_Fun_Validacao
        {
            get { return mID_Fun_Validacao; }
            set { mID_Fun_Validacao = value; }
        }

        private int mID_Status;

        public int ID_Status
        {
            get { return mID_Status; }
            set { mID_Status = value; }
        }

        private DateTime mDT_Cadastro;

        public DateTime DT_Cadastro
        {
            get { return mDT_Cadastro; }
            set { mDT_Cadastro = value; }
        }

        private DateTime mDT_Validacao;

        public DateTime DT_Validacao
        {
            get { return mDT_Validacao; }
            set { mDT_Validacao = value; }
        }
        private int mID_Projeto;

        public int ID_Projeto
        {
            get { return mID_Projeto; }
            set { mID_Projeto = value; }
        }

        public ClsLicoesAprendidas() { }
        public ClsLicoesAprendidas(int ID_Licao, string DS_Licao, string DS_Abrev, int ID_Fun_Cadastro,
                                   int ID_Fun_Validacao, int ID_Status, DateTime DT_Cadastro, DateTime DT_Validacao, int ID_Projeto) 
        {
            mID_Licao = ID_Licao;
            mDS_Licao = DS_Licao;
            mDS_Abrev = DS_Abrev;
            mID_Fun_Cadastro = ID_Fun_Cadastro;
            mID_Fun_Validacao = ID_Fun_Validacao;
            mID_Status = ID_Status;
            mDT_Cadastro = DT_Cadastro;
            mDT_Validacao = DT_Validacao;
            mID_Projeto = ID_Projeto;

        }

        public void inserir()
        {
            ClsConexao.getInstance();
            ClsConexao.conectar();

            SqlCommand cmd;


            try
            {
                cmd = new SqlCommand("sp_Inserir_LL", ClsConexao.conexao);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DS_Licao",mDS_Licao);
                cmd.Parameters.AddWithValue("@DS_Abrev",mDS_Abrev);
                cmd.Parameters.AddWithValue("@ID_Fun_Cadastro",mID_Fun_Cadastro);
                //cmd.Parameters.AddWithValue("@ID_Fun_Validacao",mID_Fun_Validacao);
                cmd.Parameters.AddWithValue("@ID_Status",mID_Status);
                cmd.Parameters.AddWithValue("@DT_Cadastro",mDT_Cadastro);
                cmd.Parameters.AddWithValue("@ID_Projeto", mID_Projeto);
                //cmd.Parameters.AddWithValue("@DT_Validacao",mDT_Validacao);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha na operação: " + ex.Message);
            }
            finally
            {
                ClsConexao.desconectar();
            }
        }




    }
}
