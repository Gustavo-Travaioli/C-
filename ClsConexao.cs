using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoLL.Controller
{
    public class ClsConexao
    {
        public static SqlConnection conexao = new SqlConnection();

        //singleton
        private static ClsConexao instancia;

        //singleton
        public static ClsConexao getInstance()
        {
            if (instancia == null)
            {
                instancia = new ClsConexao();

            }
            return (instancia);

        }

        public static void conectar()
        {

            conexao.ConnectionString = @"Server=localhost;Database=BD_SCRUM;Trusted_Connection=true";


            conexao.Open();

        }
        public static void desconectar()
        {
            conexao.Close();

        }


    }
}
