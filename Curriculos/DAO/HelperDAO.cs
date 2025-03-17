using System.Data;
using System.Data.SqlClient;

namespace Curriculos.DAO
{
    public static class HelperDAO
    {
        public static void ExecutaSql(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection connection = ConexaoBD.GetConexao())
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parametros != null)
                        command.Parameters.AddRange(parametros);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection connection = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    return tabela;
                }
            }
        }
    }
}
