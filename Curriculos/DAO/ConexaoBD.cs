using System.Data.SqlClient;

namespace Curriculos.DAO
{
    public class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=LOCALHOST;Initial Catalog=AulaDBCurriculos;User Id=sa;Password=123456;TrustServerCertificate=True;";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }
    }
}
