using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Phobos.DAL
{
    public class Conexao
    {
        protected SqlConnection Conn;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        protected void AbrirConexao()
        {
            try
            {
                Conn = new SqlConnection(@"Data Source=ADBRÁSTANQUINHO\SQLSERVER;Initial Catalog=PhobosAnomaly;Integrated Security=True");
                Conn.Open();
            }
            catch (Exception ex)
            {

                throw new Exception ("Erro ao abrir conexão com o banco "+ex.Message);
            }
        }
        protected void FecharConexao()
        {
            try
            {
                Conn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao fechar conexão com o banco "+ex.Message);
            }
        }
    }
}
