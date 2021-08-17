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
        public bool addnewMudur(string tc, string pw, string adsoyad, string unvan)
        {
            if (tc.Length == 11 && pw.Length > 0 && adsoyad.Length > 0 && unvan.Length > 0)
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
        public bool deleteMüdür(string tc)
        {
            if (!String.IsNullOrEmpty(tc))
            {
                try
                {
                    DbController.Connect();
                    query = "DELETE FROM müdürler WHERE MüdürTc=@P1";
                    cmd = new MySqlCommand(query, DbController.conn);
                    cmd.Parameters.AddWithValue("@P1", tc);

                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (MySqlException ex)
                {
                    int errorno = ex.Number;
                    switch (errorno)
                    {


                        default:
                            MessageBox.Show(ex.Message.ToString());
                            break;
                    }
                    return false;
                }


            }
            else return false;
        }
        public bool updateMüdür(string tc, string pw, string name, string title)
        {
            try
            {
                DbController.Connect();
                query = "UPDATE müdürler SET adsoyad=@P1,Password=@P2,ünvan=@P3 WHERE MüdürTc=@P4";
                cmd = new MySqlCommand(query, DbController.conn);
                cmd.Parameters.AddWithValue("@P1", name);
                cmd.Parameters.AddWithValue("@P2", pw);
                cmd.Parameters.AddWithValue("@P3", title);
                cmd.Parameters.AddWithValue("@P4", tc);


                cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex)
            {
                int errorno = ex.Number;
                switch (errorno)
                {

                    case 2628:
                        MessageBox.Show("Girilen bilgiler cok uzun...");
                        break;

                    default:
                        MessageBox.Show(ex.Message.ToString());
                        break;
                }
                return false;
            }
        }
        public List<string> getdepartmants()
        {
            List<string> bolumler = new List<string>();
            query = "SELECT * FROM bolumler";
            cmd = new MySqlCommand(query, DbController.conn);
            DbController.Connect();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                bolumler.Add(dr["bolumadi"].ToString());

            }
            if (dr.IsClosed == false)
            {
                dr.Close();
            }
            return bolumler;


        }
        public List<string> getClasses(int bolumid)
        {
            List<string> siniflar = new List<string>();
            query = "SELECT * FROM Siniflar WHERE bolumid=@P1";
            cmd = new MySqlCommand(query, DbController.conn);
            cmd.Parameters.AddWithValue("@P1", bolumid);
            DbController.Connect();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                siniflar.Add(dr["Sinifid"].ToString());

            }
            if (dr.IsClosed == false)
            {
                dr.Close();
            }
            return siniflar;
        }
        public int getbolumidbyname(string bolumname)
        {
            int id = -1;
            query = "SELECT bolumid FROM bolumler where bolumadi=@P1";
            cmd = new MySqlCommand(query, DbController.conn);
            cmd.Parameters.AddWithValue("@P1", bolumname);
            DbController.Connect();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = Int32.Parse(dr["bolumid"].ToString());

            }
            if (dr.IsClosed == false)
            {
                dr.Close();
            }

            return id;


        }
        public bool addStudent(string tc, string pw,string ad, int bolumid, int sinifid, int cinsiyet)
        {
            if (tc.Length >= 1 && ad.Length >= 1 && sinifid.ToString().Length >= 1)
            {
                try
                {
                    DbController.Connect();
                    query = "INSERT INTO ogrenciler values(@P1,@P2,@P3,@P4,@P5,@P6)";
                    cmd = new MySqlCommand(query, DbController.conn);
                    cmd.Parameters.AddWithValue("@P1", tc);
                    cmd.Parameters.AddWithValue("@P2", pw);
                    cmd.Parameters.AddWithValue("@P3", ad);
                    cmd.Parameters.AddWithValue("@P4", cinsiyet);
                    cmd.Parameters.AddWithValue("@P5", sinifid);
                    cmd.Parameters.AddWithValue("@P6", bolumid);


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
        public DataSet getOgrenciTable()
        {
            try
            {
                DbController.Connect();
                query = @"SELECT  OgrenciTC AS `TC KİMLİK NO`, ogrenciadsoyad AS `AD SOYAD`, OgrenciSifre AS ŞİFRE, cinsiyet AS CİNSİYET, sinifid AS SINIF
                        FROM  ogrenciler";
                da = new MySqlDataAdapter(query, DbController.conn);
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
        public bool updateStudent(string tc, string pw, string name, int cinsiyet)

        {
            try
            {
                DbController.Connect();
                query = "UPDATE ogrenciler SET ogrenciadsoyad=@P1,OgrenciSifre=@P2,cinsiyet=@P3 WHERE OgrenciTC=@P4";
                cmd = new MySqlCommand(query, DbController.conn);
                cmd.Parameters.AddWithValue("@P1", name);
                cmd.Parameters.AddWithValue("@P2", pw);
                cmd.Parameters.AddWithValue("@P3", cinsiyet);
                cmd.Parameters.AddWithValue("@P4", tc);


                cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex)
            {
                int errorno = ex.Number;
                switch (errorno)
                {

                    case 2628:
                        MessageBox.Show("Girilen bilgiler cok uzun...");
                        break;

                    default:
                        MessageBox.Show(ex.Message.ToString());
                        break;
                }
                return false;
            }
        }
        public bool deleteStudent(string tc)
        {
            if (!String.IsNullOrEmpty(tc))
            {
                try
                {
                    DbController.Connect();
                    query = "DELETE FROM ogrenciler WHERE OgrenciTc=@P1";
                    cmd = new MySqlCommand(query, DbController.conn);
                    cmd.Parameters.AddWithValue("@P1", tc);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException ex)
                {
                    int errorno = ex.Number;
                    switch (errorno)
                    {


                        default:
                            MessageBox.Show(ex.Message.ToString());
                            break;
                    }
                    return false;
                }


            }
            else return false;
        }
        public int countStudent()
        {
            query = "SELECT COUNT(*) FROM ogrenciler";
            DbController.Connect();
            cmd = new MySqlCommand(query, DbController.conn);
            Int32 count = Int32.Parse(cmd.ExecuteScalar().ToString());
            DbController.Disconnect();
            return count;
        }
        public bool addAkademisyen(string tc, string pw, string ad, int bolumid)
        {
            if (tc.Length ==11&& ad.Length >= 1 &&bolumid!=-1)
            {
                try
                {
                    DbController.Connect();
                    query = "INSERT INTO akademisyenler values(@P1,@P2,@P3,@P4)";
                    cmd = new MySqlCommand(query, DbController.conn);
                    cmd.Parameters.AddWithValue("@P1", tc);
                    cmd.Parameters.AddWithValue("@P2", pw);
                    cmd.Parameters.AddWithValue("@P3", ad);
                    cmd.Parameters.AddWithValue("@P4", bolumid);


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
        public DataSet getAkademisyenTablo()
        {
            try
            {
                DbController.Connect();
                query = @"SELECT  akademisyenler.OgretmenTC AS `TC KİMLİK NO`, akademisyenler.pw AS ŞİFRE, akademisyenler.OgretmenAdSoyad AS `AD SOYAD`
                        FROM    akademisyenler";
                da = new MySqlDataAdapter(query, DbController.conn);
                da.Fill(ds, "akademisyenler");
                DbController.Disconnect();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ds;
            }


        }
        public bool updateAkademisyen(string tc, string pw, string name)
        {
            try
            {
                DbController.Connect();
                query = "UPDATE akademisyenler SET OgretmenAdSoyad=@P1,pw=@P2 WHERE OgretmenTC=@P3";
                cmd = new MySqlCommand(query, DbController.conn);
                cmd.Parameters.AddWithValue("@P1", name);
                cmd.Parameters.AddWithValue("@P2", pw);
                cmd.Parameters.AddWithValue("@P3", tc);


                cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex)
            {
                int errorno = ex.Number;
                switch (errorno)
                {

                    case 2628:
                        MessageBox.Show("Girilen bilgiler cok uzun...");
                        break;

                    default:
                        MessageBox.Show(ex.Message.ToString());
                        break;
                }
                return false;
            }
        }

        public bool deleteAkademisyen(string tc)
        {
            if (!String.IsNullOrEmpty(tc))
            {
                try
                {
                    DbController.Connect();
                    query = "DELETE FROM Akademisyenler WHERE OgretmenTc=@P1";
                    cmd = new MySqlCommand(query, DbController.conn);
                    cmd.Parameters.AddWithValue("@P1", tc);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException ex)
                {
                    int errorno = ex.Number;
                    switch (errorno)
                    {


                        default:
                            MessageBox.Show(ex.Message.ToString());
                            break;
                    }
                    return false;
                }


            }
            else return false;
        }
    }
}

