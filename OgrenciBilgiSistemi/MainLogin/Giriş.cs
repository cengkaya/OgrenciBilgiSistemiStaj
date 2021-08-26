using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    
    public partial class Giriş : Form
    {
       static  Entities.Müdür müdür = new Entities.Müdür();
        static Entities.Akademisyen akademisyen = new Entities.Akademisyen();
        static Entities.Ogrenci ogrenci = new Entities.Ogrenci();
        public static string loginusertc;
        public Giriş()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (müdür_radio.Checked)
            {
                if (müdür.MüdürLogin(tc_textbox.Text, pw_textbox.Text))
                {
                    MessageBox.Show("Giriş Başarılı");
                    MüdürPanels.MüdürControlPanel müdürControl = new MüdürPanels.MüdürControlPanel();
                    müdürControl.Show();
                    this.Hide();
                    loginusertc = tc_textbox.Text;

                }
                else MessageBox.Show("Giriş Başarsısız");

            }
            if(akademisyenradio.Checked)
            {
                if (akademisyen.AkademisyenLogin(tc_textbox.Text, pw_textbox.Text))
                {
                    MessageBox.Show("Giriş Başarılı");
                    AkademisyenPanels.AkademisyenMainPanel müdürControl = new AkademisyenPanels.AkademisyenMainPanel();
                    müdürControl.Show();
                    this.Hide();
                    loginusertc = tc_textbox.Text;

                }
                else MessageBox.Show("Giriş Başarsısız");

            }
            if (öğrenci_radio.Checked)
            {
                if(ogrenci.OgrenciLogin(tc_textbox.Text, pw_textbox.Text))
                {
                    MessageBox.Show("Giriş Başarılı");
                    OgrenciPanels.OgrenciMainPanel ogrenci = new OgrenciPanels.OgrenciMainPanel();
                    ogrenci.Show();
                    this.Hide();
                    loginusertc = tc_textbox.Text;
                }
                else MessageBox.Show("Giriş Başarsısız");
            }

        }

        private void xuıFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuıFormDesign1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MainLogin.SifreYenile yenile = new MainLogin.SifreYenile();
            yenile.Show();
           
            
        }

        private void öğretmen_radio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

