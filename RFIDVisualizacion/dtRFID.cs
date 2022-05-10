using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;
namespace RFIDVisualizacion
{
   
   public class dtRFID
     {
        // using System.Data;
        // using System.Data.SqlClient;
        public static MessageBoxIcon MessageBoxIcon { get; set; }
        public static DataTable Fill() {DataTable dt = new DataTable();if ( conection.Open() != null){ SqlDataAdapter da = new SqlDataAdapter("Select * from dbo.lecturasRFID" , conection.Open()); da.Fill(dt); conection.Close(); }  else { dt = null; } return dt; }
        public static DataTable SelectXid( int id) { string Query = "SELECT * FROM dbo.lecturasRFID WHERE id = '" + id + "'"; DataTable dt = new DataTable();if (conection.Open() != null){ SqlDataAdapter da = new SqlDataAdapter(Query ,conection.Open()); da.Fill(dt); conection.Close(); }  else { dt = null; } return dt; }

        public static string Actualizar(  int id, string EPC_ID, int TAG_COUNT, int ANTENA, string HORA_REGISTRO) 
         { 
            string result = "";
             try
            {
                SqlCommand cmd = new SqlCommand("UPDATE dbo.lecturasRFID SET id=@id, EPC_ID=@EPC_ID, TAG_COUNT=@TAG_COUNT, ANTENA=@ANTENA, HORA_REGISTRO=@HORA_REGISTRO WHERE id = @id",conection.Open());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@EPC_ID", EPC_ID);
                cmd.Parameters.AddWithValue("@TAG_COUNT", TAG_COUNT);
                cmd.Parameters.AddWithValue("@ANTENA", ANTENA);
                cmd.Parameters.AddWithValue("@HORA_REGISTRO", HORA_REGISTRO);
                cmd.ExecuteNonQuery(); 
                conection.Close(); 
                result = "Los datos actualizados correctamente en la base de datos. "; 
                ;
            }
            catch (Exception ex) { result = "Ocurrió un error al actualizar: " + ex.Message;}
            return result;
        }

        public static string Insertar(  int id, string EPC_ID, int TAG_COUNT, int ANTENA, string HORA_REGISTRO) 
         { 
            string result = "";
             try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.lecturasRFID (id,EPC_ID,TAG_COUNT,ANTENA,HORA_REGISTRO) VALUES (@id,@EPC_ID,@TAG_COUNT,@ANTENA,@HORA_REGISTRO)",conection.Open());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@EPC_ID", EPC_ID);
                cmd.Parameters.AddWithValue("@TAG_COUNT", TAG_COUNT);
                cmd.Parameters.AddWithValue("@ANTENA", ANTENA);
                cmd.Parameters.AddWithValue("@HORA_REGISTRO", HORA_REGISTRO);
                cmd.ExecuteNonQuery(); 
                conection.Close(); 
                result = "Los datos insertados correctamente en la base de datos. "; 
                ;
            }
            catch (Exception ex) { result = "Ocurrió un error al insertar: " + ex.Message; }
            return result;
        }

        public static string Eliminar(int id) {
           string r = "";
           if (conection.Open() != null)
           {
               try
               {
                   SqlCommand cmd = new SqlCommand("Delete from dbo.lecturasRFID where id = '" + id + "'", conection.Open());
                   cmd.ExecuteNonQuery();
                   conection.Close();
                   r = "Se eliminó correctamente del sistema";
               }
               catch (Exception ex)
               {
                   r = "Ocurrió un error al intentar eliminar el dato solicitado " + ex.Message;
               }
            }
            return r;
         }

        public static bool ExisteId(int id)
        {
            bool result = false;
            if (SelectXid(id).Rows.Count > 0) { result = true; } else { result = false; }
            return result;
        }
    }
}

