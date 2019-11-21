using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Data.SqlClient;

namespace GestionDatos
{
    public class ActividadDat
    {

        private SqlDataAdapter dat;
        private SqlCommand cmd;
        SqlConnection sqlc = new SqlConnection(ConexionBD.CadenaConexion);

        public int InserActividad(Actividad objActividad)
        {
            cmd = new SqlCommand("sp_InsertActividad", sqlc);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descrip ", objActividad.VDESC_ACTIVIDAD);
            cmd.Parameters.AddWithValue("@fecha ", objActividad.DFEC_ACTIVIDAD);
            
            sqlc.Open();
            cmd.ExecuteNonQuery();
            sqlc.Close();
            return 1;
        }




        public bool SelectActividad(Actividad objActividad)
        {
            string select = "SELECT * FROM TBL_ACTIVIDADES WHERE ICOD_ACTIVIDAD = '" + objActividad.ICOD_ACTIVIDAD + "'";

            SqlCommand unComando = new SqlCommand(select, sqlc);

            sqlc.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objActividad.ICOD_ACTIVIDAD = (int)reader[0];
                objActividad.VDESC_ACTIVIDAD = (string)reader[1];
                objActividad.DFEC_ACTIVIDAD = (DateTime)reader[2];
                
            }
            else
              
            sqlc.Close();
            return hayRegistros;
        }

        public DataSet SelectActividadds()
        {
            DataSet dsActividad = new DataSet();

            string select = "SELECT * FROM TBL_ACTIVIDADES";
            SqlDataAdapter unComando = new SqlDataAdapter(select, sqlc);

            unComando.Fill(dsActividad, "ACTIVIDADDS");
            return dsActividad;
        }



    }
}
