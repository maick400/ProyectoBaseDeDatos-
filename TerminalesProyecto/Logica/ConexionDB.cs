using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TerminalesProyecto.Logica
{
    public class ConexionDB
    {

        SqlConnection cn = new SqlConnection("Server=mssql-58556-0.cloudclusters.net,17574;Database=Prueba;User Id=User001;Password=4006381Mm.;");

        public string abrirConexion()
        {
            try
            {
                cn.Open();
                return "Conexion exittoa";
              
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        public void cerrarConexion()
        {
            try
            {
                cn.Close();

            }
            catch (Exception ex)
            {
             

            }


        }

        public DataTable ListarProcAlmacenado(SqlCommand command)
        {
            DataTable dt = new DataTable();
            abrirConexion();
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            return dt;
            
        }


    }


    
}
