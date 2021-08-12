using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    class DbController
    {
        public static MySqlConnection conn = new MySqlConnection(@"server=localhost;user id=root;password=admin;database=ogrencibilgisistem");

        public static void Connect()
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                

            }

        }
        public static void Disconnect()
        {
            if (conn.State != ConnectionState.Closed)
            {

                try
                {
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            

        }

    }
}


