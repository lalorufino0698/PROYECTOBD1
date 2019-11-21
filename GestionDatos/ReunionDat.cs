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

    public class ReunionDat
    {
        private SqlDataAdapter dat;
    private SqlCommand cmd;
    SqlConnection sqlc = new SqlConnection(ConexionBD.CadenaConexion);



        public int InserReunion(Reunion objReunion)
        {
            cmd = new SqlCommand("sp_InsertReunion", sqlc);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dfec", objReunion.DFEC_REUNION);
            cmd.Parameters.AddWithValue("@dhent", objReunion.DHENT_REUNION);
            cmd.Parameters.AddWithValue("@dhsal", objReunion.DHSAL_REUNION);
            cmd.Parameters.AddWithValue("@lugar", objReunion.VLUGAR_REUNION);
            cmd.Parameters.AddWithValue("@codigodocente",objReunion.FK_ICOD_DOCENTE);
            sqlc.Open();
            cmd.ExecuteNonQuery();
            sqlc.Close();
            return 1;
        }

        public void UpdateReunion(Reunion objReunion)
        {
            string update = "UPDATE TBL_REUNIONES SET DFEC_REUNION  =  '" + objReunion.DFEC_REUNION + "'," + " DHENT_REUNION  = '" + objReunion.DHENT_REUNION + "'," +
                "DHSAL_REUNION  = '" + objReunion.DHSAL_REUNION + "'," + " VLUGAR_REUNION  = '" + objReunion.VLUGAR_REUNION +"'," + " FK_ICOD_DOCENTE = '"+objReunion.FK_ICOD_DOCENTE+"',"+ "' WHERE ICOD_REUNION  = '" + objReunion.ICOD_REUNION + "'";
            SqlCommand unComando = new SqlCommand(update, sqlc);
            sqlc.Open();
            unComando.ExecuteNonQuery();
            sqlc.Close();


        }
        public void DeleteReunion(Reunion objReunion)
        {
            string delete = "DELETE TBL_REUNIONES WHERE  ICOD_REUNION  = '" + objReunion.ICOD_REUNION + "'";

            SqlCommand unComando = new SqlCommand(delete, sqlc);

            sqlc.Open();
            unComando.ExecuteNonQuery();
            sqlc.Close();
        }

        public bool SelectReunion(Reunion objReunion)
        {
            string select = "SELECT * FROM TBL_REUNIONES WHERE ICOD_REUNION = '" + objReunion.ICOD_REUNION + "'";

            SqlCommand unComando = new SqlCommand(select, sqlc);

            sqlc.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
               
                objReunion.DFEC_REUNION= (DateTime)reader[1];
                objReunion.DHENT_REUNION = (DateTime)reader[2];
                objReunion.DHSAL_REUNION = (DateTime)reader[3];
                objReunion.VLUGAR_REUNION = (string)reader[4];
                objReunion.FK_ICOD_DOCENTE = (int)reader[5];
                objReunion.estado = 99;
            }
            else
                objReunion.estado = 1;
            sqlc.Close();
            return hayRegistros;
        }

        public DataSet SelectReunionds()
        {
            DataSet dsReunion = new DataSet();

            string select = "SELECT * FROM TBL_REUNIONES";
            SqlDataAdapter unComando = new SqlDataAdapter(select, sqlc);

            unComando.Fill(dsReunion, "REUNIONDS");
            return dsReunion;
        }















    }
}
