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
        public DataSet getSorumluDersler()
        {
            try
            {
                DbController.Connect();
                query = @"SELECT
  dersler.sorumluAkademisyenTc AS `TC KİMLİK NO`,
  akademisyenler.OgretmenTC,
  dersler.dersad AS `DERS ADI`,
  dersler.akts AS `AKTS YÜKÜ`,
  bolumler.bolumadi AS `BÖLÜM ADI`,
  siniflar.sınıf AS SINIF
FROM dersler
  INNER JOIN siniflar
    ON siniflar.sinifid = dersler.derssinifid
  INNER JOIN bolumler
    ON bolumler.bolumid = dersler.dersbolumid
  INNER JOIN akademisyenler
    ON akademisyenler.OgretmenTC = dersler.sorumluAkademisyenTc
WHERE dersler.sorumluAkademisyenTc = @P1";
                da = new MySqlDataAdapter(query, DbController.conn);
                da.SelectCommand.Parameters.AddWithValue("@P1", Giriş.loginusertc);

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
        public List<string> getDerslerimList()
        {
            List<string> dersler = new List<string>();
            query = "SELECT * FROM dersler where sorumluAkademisyenTc=@P1";

            
            cmd = new MySqlCommand(query, DbController.conn);
            cmd.Parameters.AddWithValue("@P1", Giriş.loginusertc);
            DbController.Connect();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                dersler.Add(dr["dersad"].ToString());

            }
            if (dr.IsClosed == false)
            {
                dr.Close();
            }
            return dersler;


        }

        public DataSet getOgrenciTablebysinifid(int sinifid)
        {
            try
            {
                DbController.Connect();
                query = @"SELECT  OgrenciTC AS `TC KİMLİK NO`, ogrenciadsoyad AS `AD SOYAD`, cinsiyet AS CİNSİYET FROM  ogrenciler where sinifid=@P1";
                da = new MySqlDataAdapter(query, DbController.conn);
                da.SelectCommand.Parameters.AddWithValue("@P1", sinifid);
                da.Fill(ds, "ogrenciler");
                DbController.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }


        }

        public int getsinifidbydersname(string dersname)
        {
            int id = -1;
            query = "SELECT derssinifid FROM dersler where dersad=@P1";
            cmd = new MySqlCommand(query, DbController.conn);
            cmd.Parameters.AddWithValue("@P1", dersname);
            DbController.Connect();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = Int32.Parse(dr["derssinifid"].ToString());

            }
            if (dr.IsClosed == false)
            {
                dr.Close();
            }

            return id;


        }


    }
}
