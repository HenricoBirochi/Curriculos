using Curriculos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Curriculos.DAO
{
    public class CurriculoDAO
    {
        private SqlParameter[] CriaParametros(CurriculoViewModel curriculo)
        {
            SqlParameter[] parametros = new SqlParameter[18];
            parametros[0] = new SqlParameter("nome", curriculo.Nome);
            parametros[1] = new SqlParameter("CPF", curriculo.CPF);
            parametros[2] = new SqlParameter("endereco", curriculo.Endereco);
            parametros[3] = new SqlParameter("telefone", curriculo.Telefone);
            parametros[4] = new SqlParameter("email", curriculo.Email);
            parametros[5] = new SqlParameter("pretensaoSalarial", curriculo.PretensaoSalarial);
            parametros[6] = new SqlParameter("cargoPretendido", curriculo.CargoPretendido);
            parametros[7] = new SqlParameter("formacao1", curriculo.Formacao1);
            parametros[8] = (curriculo.Formacao2 == null) ? new SqlParameter("formacao2", DBNull.Value) : new SqlParameter("formacao2", curriculo.Formacao2);
            parametros[9] = (curriculo.Formacao3 == null) ? new SqlParameter("formacao3", DBNull.Value) : new SqlParameter("formacao3", curriculo.Formacao3);
            parametros[10] = (curriculo.Formacao4 == null) ? new SqlParameter("formacao4", DBNull.Value) : new SqlParameter("formacao4", curriculo.Formacao4);
            parametros[11] = (curriculo.Formacao5 == null) ? new SqlParameter("formacao5", DBNull.Value) : new SqlParameter("formacao5", curriculo.Formacao5);
            parametros[12] = (curriculo.Experiencia1 == null) ? new SqlParameter("experiencia1", DBNull.Value) : new SqlParameter("experiencia1", curriculo.Experiencia1);
            parametros[13] = (curriculo.Experiencia2 == null) ? new SqlParameter("experiencia2", DBNull.Value) : new SqlParameter("experiencia2", curriculo.Experiencia2);
            parametros[14] = (curriculo.Experiencia3 == null) ? new SqlParameter("experiencia3", DBNull.Value) : new SqlParameter("experiencia3", curriculo.Experiencia3);
            parametros[15] = new SqlParameter("idioma1", curriculo.Idioma1);
            parametros[16] = (curriculo.Idioma2 == null) ? new SqlParameter("idioma2", DBNull.Value) : new SqlParameter("idioma2", curriculo.Idioma2);
            parametros[17] = (curriculo.Idioma3 == null) ? new SqlParameter("idioma3", DBNull.Value) : new SqlParameter("idioma3", curriculo.Idioma3);
            return parametros;
        }
        public CurriculoViewModel MontaCurriculo(DataRow registro)
        {
            CurriculoViewModel c = new CurriculoViewModel();
            c.CurriculoId = Convert.ToInt32(registro["curriculoId"]);
            c.Nome = registro["nome"].ToString();
            c.CPF = registro["CPF"].ToString();
            c.Endereco = registro["endereco"].ToString();
            c.Telefone = registro["telefone"].ToString();
            c.Email = registro["email"].ToString();
            c.PretensaoSalarial = Convert.ToDouble(registro["pretensaoSalarial"]);
            c.CargoPretendido = registro["cargoPretendido"].ToString();
            c.Formacao1 = registro["formacao1"].ToString();
            if (registro["formacao2"] != DBNull.Value)
                c.Formacao2 = registro["formacao2"].ToString();
            if (registro["formacao3"] != DBNull.Value)
                c.Formacao3 = registro["formacao3"].ToString();
            if (registro["formacao4"] != DBNull.Value)
                c.Formacao4 = registro["formacao4"].ToString();
            if (registro["formacao5"] != DBNull.Value)
                c.Formacao5 = registro["formacao5"].ToString();
            if (registro["experiencia1"] != DBNull.Value)
                c.Experiencia1 = registro["experiencia1"].ToString();
            if (registro["experiencia2"] != DBNull.Value)
                c.Experiencia2 = registro["experiencia2"].ToString();
            if (registro["experiencia3"] != DBNull.Value)
                c.Experiencia3 = registro["experiencia3"].ToString();
            c.Idioma1 = registro["idioma1"].ToString();
            if (registro["idioma2"] != DBNull.Value)
                c.Idioma2 = registro["idioma2"].ToString();
            if (registro["idioma3"] != DBNull.Value)
                c.Idioma3 = registro["idioma3"].ToString();
            return c;
        }
        public void Post(CurriculoViewModel curriculo)
        {
            string sql = "INSERT INTO Curriculos (nome, CPF, endereco, telefone, email, pretensaoSalarial, cargoPretendido, formacao1, " +
                "formacao2, formacao3, formacao4, formacao5, experiencia1, experiencia2, experiencia3, idioma1, idioma2, idioma3) " +
                "VALUES(@nome, @CPF, @endereco, @telefone, @email, @pretensaoSalarial, @cargoPretendido, @formacao1, " +
                "@formacao2, @formacao3, @formacao4, @formacao5, @experiencia1, @experiencia2, @experiencia3, @idioma1, @idioma2, @idioma3)";
            HelperDAO.ExecutaSql(sql, CriaParametros(curriculo));
        }
        public void Put(CurriculoViewModel curriculo)
        {
            string sql = "UPDATE Curriculos SET nome = @nome, CPF = @CPF, endereco = @endereco, telefone = @telefone, email = @email, " +
                "pretensaoSalarial = @pretensaoSalarial, cargoPretendido = @cargoPretendido, formacao1 = @formacao1, formacao2 = @formacao2, " +
                "formacao3 = @formacao3, formacao4 = @formacao4, formacao5 = @formacao5, experiencia1 = @experiencia1, experiencia2 = @experiencia2, " +
                "experiencia3 = @experiencia3, idioma1 = @idioma1, idioma2 = @idioma2, idioma3 = @idioma3 WHERE curriculoId = " + curriculo.CurriculoId;
            HelperDAO.ExecutaSql(sql, CriaParametros(curriculo));
        }
        public void Delete(int CurriculoId)
        {
            string sql = "DELETE Curriculos WHERE CurriculoId = " + CurriculoId;
            HelperDAO.ExecutaSql(sql, null);
        }
        public CurriculoViewModel Get(int CurriculoId)
        {
            string sql = "SELECT * FROM Curriculos WHERE curriculoId = " + CurriculoId;
            DataTable table = HelperDAO.ExecutaSelect(sql, null);
            if (table.Rows.Count == 0)
                return null;
            else
                return MontaCurriculo(table.Rows[0]);
        }
        public List<CurriculoViewModel> GetAll()
        {
            List<CurriculoViewModel> list = new List<CurriculoViewModel>();
            string sql = "SELECT * FROM Curriculos";
            DataTable table = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in table.Rows)
                list.Add(MontaCurriculo(registro));
            return list;
        }
    }
}
