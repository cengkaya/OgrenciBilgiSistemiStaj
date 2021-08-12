using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi.DbControl
{
    class MüdürDAL
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataSet ds = new DataSet();
        private string query;
        public bool MüdürLogin(string tcno, string password)
        {

            if (tcno.Length == 0 && password.Length == 0)
            {
                return false;
            }
            else
            {
                query = "SELECT * FROM müdürler where MüdürTc=@P1 AND password=@P2";
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
        public  bool addnewMudur(string tc,string pw,string adsoyad,string unvan)
        {
            if (tc.Length==11&&pw.Length>0&&adsoyad.Length>0&&unvan.Length>0)
            {
                try
                {
                    DbController.Connect();
                    query = "INSERT INTO müdürler values(@P1,@P2,@P3,@P4)";
                    cmd = new MySqlCommand(query, DbController.conn);
                    cmd.Parameters.AddWithValue("@P1", tc);
                    cmd.Parameters.AddWithValue("@P2", pw);
                    cmd.Parameters.AddWithValue("@P3", adsoyad);
                    cmd.Parameters.AddWithValue("@P4", unvan);
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                    return false;

                }
            }
            else return false;
        }
        public DataSet getMudurTable()
        {
            try
            {
                DbController.Connect();
                query = @"SELECT MüdürTc AS `TC KİMLİK NO`, Password AS ŞİFRE, adsoyad AS `AD SOYAD`, ünvan AS ÜNVAN FROM müdürler";
                da = new MySqlDataAdapter(query, DbController.conn);
                da.Fill(ds, "müdürler");
                DbController.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }


        }
    }
}
