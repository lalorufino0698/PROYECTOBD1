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
   public class DocenteDat
    {
        private SqlDataAdapter dat;
        private SqlCommand cmd;
        SqlConnection sqlc = new SqlConnection(ConexionBD.CadenaConexion);


        public int InsertDocente(Docente objDocente)
        {
            cmd = new SqlCommand("sp_InsertDocente", sqlc);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", objDocente.VNOMBRE_DOCENTE);
            cmd.Parameters.AddWithValue("@apaterno", objDocente.VAPATERNO_DOCENTE);
            cmd.Parameters.AddWithValue("@amaterno", objDocente.VAMATERNO_DOCENTE);
            cmd.Parameters.AddWithValue("@cargo",objDocente.FK_ICOD_CARGO);
            sqlc.Open();
            cmd.ExecuteNonQuery();
            sqlc.Close();
            return 1;
        }

        public void UpdateDocente(Docente objDocente)
        {
            string update = "UPDATE TBL_DOCENTES SET VNOMBRE_DOCENTE =  '" + objDocente.VNOMBRE_DOCENTE + "'," + " VAPATERNO_DOCENTE = '" + objDocente.VAPATERNO_DOCENTE + "'," +
                "VAMATERNO_DOCENTE = '" + objDocente.VAMATERNO_DOCENTE + "'," + " FK_ICOD_CARGO = '" + objDocente.FK_ICOD_CARGO + "' WHERE ICOD_DOCENTE = '" + objDocente.ICOD_DOCENTE + "'";
            SqlCommand unComando = new SqlCommand(update, sqlc);
            sqlc.Open();
            unComando.ExecuteNonQuery();
            sqlc.Close();
           

        }
        public void DeleteDocente(Docente objDocente)
        {
            string delete = "DELETE TBL_DOCENTES WHERE ICOD_DOCENTE = '" + objDocente.ICOD_DOCENTE + "'";

            SqlCommand unComando = new SqlCommand(delete, sqlc);

            sqlc.Open();
            unComando.ExecuteNonQuery();
            sqlc.Close();
        }

        public bool SelectDocente(Docente objDocente)
        {
            string select = "SELECT * FROM TBL_DOCENTES WHERE ICOD_DOCENTE = '" + objDocente.ICOD_DOCENTE + "'";

            SqlCommand unComando = new SqlCommand(select, sqlc);

            sqlc.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objDocente.ICOD_DOCENTE = (int)reader[0];
                objDocente.VNOMBRE_DOCENTE = (string)reader[1];
                objDocente.VAPATERNO_DOCENTE = (string)reader[2];
                objDocente.VAMATERNO_DOCENTE = (string)reader[3];
                objDocente.FK_ICOD_CARGO = (int)reader[4];

                objDocente.estado = 99;
            }
            else
                objDocente.estado = 1;
            sqlc.Close();
            return hayRegistros;
        }

        public DataSet SelectDocenteds()
        {
            DataSet dsDocente = new DataSet();

            string select = "SELECT * FROM TBL_DOCENTES";
            SqlDataAdapter unComando = new SqlDataAdapter(select, sqlc);

            unComando.Fill(dsDocente, "DOCENTEDS");
            return dsDocente;
        }





    }
}
