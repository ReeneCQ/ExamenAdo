using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosRegion
    {
        public void Insert(Region region)
        {
            using (var connection = private new SqlConnection(Coneccion.cadena))
            {

            connection.Open();
            SqlCommand command = new SqlCommand("USP_InsertRegion", connection);
            command.CommandType = CommandType.Stored Procedure;

            SqlParameter parameter = new SqlParameter("@RegionName", SqlDbType.VarChar, 50);
            parameter.Value = region.RegionName;
            command.Parameters.Add(parameter);

            command.ExecuteNonQuery();
            }
        }
    }
}
