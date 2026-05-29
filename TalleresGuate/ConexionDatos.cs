using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalleresGuate
{
    public class ConexionDatos
    {
        private string CadenaConexion = ConfigurationManager.ConnectionStrings["CadenaBaseDatos"].ConnectionString;

        public SqlConnection MtdConexionBaseDatos()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
