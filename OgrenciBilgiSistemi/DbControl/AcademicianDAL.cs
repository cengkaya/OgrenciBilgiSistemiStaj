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
        public int getdersidbydersname(string dersname)
        {
            int id = -1;
            query = "SELECT dersid FROM dersler where dersad=@P1";
            cmd = new MySqlCommand(query, DbController.conn);
            cmd.Parameters.AddWithValue("@P1", dersname);
            DbController.Connect();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = Int32.Parse(dr["dersid"].ToString());

            }
            if (dr.IsClosed == false)
            {
                dr.Close();
            }

            return id;


        }
        public bool addNot(string tc, string notturu, string dersad,int not)
        {
          
                int dersid = getdersidbydersname(dersad);
                try
                {
                    DbController.Connect();
                    query = "INSERT INTO notlar (ogrencitc,dersid,notturu,puan) values(@P1,@P2,@P3,@P4)";
                    cmd = new MySqlCommand(query, DbController.conn);
                    cmd.Parameters.AddWithValue("@P1", tc);
                    cmd.Parameters.AddWithValue("@P2", dersid);
                    cmd.Parameters.AddWithValue("@P3", notturu);
                    cmd.Parameters.AddWithValue("@P4", not);



                cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException ex)
                {
                MessageBox.Show(ex.Message.ToString());

                    return false;

                }
            }
        public bool adddevamsızlık(string tc, string tarih,string dersad)
        {

            int dersid = getdersidbydersname(dersad);
            try
            {
                DbController.Connect();
                query = "INSERT INTO devamsızlık (ogrencitc,tarih,dersid) values(@P1,@P2,@P3)";
                cmd = new MySqlCommand(query, DbController.conn);
                cmd.Parameters.AddWithValue("@P1", tc);
                cmd.Parameters.AddWithValue("@P2", tarih);
                cmd.Parameters.AddWithValue("@P3", dersid);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());

                return false;

            }
        }
        public string getForgetPassword(string tc)
        {

            try
            {
                query = "SELECT pw FROM akademisyenler where OgretmenTC=@P1";
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
        public bool addnewDuyuru(string tc, string duyurumetni, string dersad)
        {

            int dersid = getdersidbydersname(dersad);
            int sinifid = getsinifidbydersname(dersad);
            try
            {
                DbController.Connect();
                query = "INSERT INTO duyurular (akademisyentc,dersid,sinifid,duyurumetni) values(@P1,@P2,@P3,@P4)";
                cmd = new MySqlCommand(query, DbController.conn);
                cmd.Parameters.AddWithValue("@P1", tc);
                cmd.Parameters.AddWithValue("@P2", dersid);
                cmd.Parameters.AddWithValue("@P3", sinifid);
                cmd.Parameters.AddWithValue("@P4", duyurumetni);
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());

                return false;

            }
        }
        public DataSet getDuyurular(string tc)
        {
            try
            {
                DbController.Connect();
                query = @"SELECT
  duyurular.duyurumetni AS `Duyuru Metni`,
  siniflar.sınıf AS Sınıf,
  dersler.dersad AS `Ders Adı`
FROM duyurular
  INNER JOIN siniflar
    ON duyurular.sinifid = siniflar.sinifid
  INNER JOIN dersler
    ON duyurular.dersid = dersler.dersid
WHERE duyurular.akademisyentc = @P1";
                da = new MySqlDataAdapter(query, DbController.conn);
                da.SelectCommand.Parameters.AddWithValue("@P1", tc);
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

