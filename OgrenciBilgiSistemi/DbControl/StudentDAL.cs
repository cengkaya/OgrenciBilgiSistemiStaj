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
    class StudentDAL
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataSet ds = new DataSet();
        private string query;
        public bool OgrenciLogin(string tcno, string password)
        {

            if (tcno.Length == 0 && password.Length == 0)
            {
                return false;
            }
            else
            {
                query = "SELECT * FROM ogrenciler where OgrenciTC=@P1 AND OgrenciSifre=@P2";
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
        public DataSet getSınavSonuç(string tc)
        {
            try
            {
                DbController.Connect();
                query = @"SELECT
  dersler.dersid,
  dersler.dersad AS `Ders Adı`,
  notlar.notturu AS `Not Türü`,
  notlar.puan AS Puan,
  dersler.akts AS `Akts Yükü`,
  akademisyenler.OgretmenAdSoyad AS `Ders Sorumlusu`
FROM dersler
  INNER JOIN notlar
    ON dersler.dersid = notlar.dersid
  INNER JOIN akademisyenler
    ON dersler.sorumluAkademisyenTc = akademisyenler.OgretmenTC
    WHERE ogrencitc=@P1";
                da = new MySqlDataAdapter(query, DbController.conn);
                da.SelectCommand.Parameters.AddWithValue("@P1", tc);
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
        public DataSet getDevamsızlık(string tc)
        {
            try
            {
                DbController.Connect();
                query = @"SELECT
  devamsızlık.devamsızlıkno AS Kod,
  dersler.dersad AS `Ders Adı`,
  akademisyenler.OgretmenAdSoyad AS `Ders Sorumlusu`,
  devamsızlık.tarih AS Tarih
FROM devamsızlık
  INNER JOIN dersler
    ON devamsızlık.dersid = dersler.dersid
  INNER JOIN akademisyenler
    ON dersler.sorumluAkademisyenTc = akademisyenler.OgretmenTC
WHERE devamsızlık.ogrencitc = @P1";
                da = new MySqlDataAdapter(query, DbController.conn);
                da.SelectCommand.Parameters.AddWithValue("@P1", tc);
                da.Fill(ds, "Devamsızlık");
                DbController.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }


        }
        public string getForgetPassword(string tc)
        {

            try
            {
                query = "SELECT OgrenciSifre FROM ogrenciler where OgrenciTc=@P1";
                DbController.Connect();
                cmd = new MySqlCommand(query, DbController.conn);
                cmd.Parameters.AddWithValue("@P1", tc);
                return cmd.ExecuteScalar().ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        private int getOgrenciClassByTc(string tc)
        {

            try
            {
                query = "SELECT sinifid FROM ogrenciler where OgrenciTc=@P1";
                DbController.Connect();
                cmd = new MySqlCommand(query, DbController.conn);
                cmd.Parameters.AddWithValue("@P1", tc);
                return Int32.Parse( cmd.ExecuteScalar().ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }
        public DataSet getDuyurular(string tc)
        {
            int sinifid = getOgrenciClassByTc(tc);
            try
            {
                DbController.Connect();
                query = @"SELECT
  akademisyenler.OgretmenAdSoyad AS `Sorumlu Akademisyen`,
  dersler.dersad AS `Ders Adı`,
  duyurular.duyurumetni AS `Duyuru Metni`,
  bolumler.bolumadi AS Bölüm
FROM akademisyenler
  INNER JOIN duyurular
    ON akademisyenler.OgretmenTC = duyurular.akademisyentc
  INNER JOIN dersler
    ON duyurular.dersid = dersler.dersid
  INNER JOIN bolumler
    ON dersler.dersbolumid = bolumler.bolumid where duyurular.sinifid=@P1";
                da = new MySqlDataAdapter(query, DbController.conn);
                da.SelectCommand.Parameters.AddWithValue("@P1", sinifid);
                da.Fill(ds, "Duyurular");
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
