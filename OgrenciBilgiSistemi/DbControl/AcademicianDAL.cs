using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DbControl
{
    class AcademicianDAL
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataSet ds = new DataSet();
        private string query;
        public bool AkademisyenLogin(string tcno, string password)
        {

            if (tcno.Length == 0 && password.Length == 0)
            {
                return false;
            }
            else
            {
                query = "SELECT * FROM akademisyenler where OgretmenTC=@P1 AND pw=@P2";
                cmd = new MySqlCommand(query, DbController.conn);
                cmd.Parameters.AddWithValue("@P1", tcno);
                cmd.Parameters.AddWithValue("@P2", password);
                DbController.Connect();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DbController.Disconnect();
                    dr.Close();
                    return true;
                }
                else
                {
                    DbController.Disconnect();
                    dr.Close();
                    return false;
                }

            }



        }
    }
}
