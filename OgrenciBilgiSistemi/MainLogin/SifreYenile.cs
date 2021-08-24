using DevExpress.XtraEditors;
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

namespace OgrenciBilgiSistemi.MainLogin
{
    public partial class SifreYenile : DevExpress.XtraEditors.XtraForm
    {
        Entities.Müdür müdür = new Entities.Müdür();
        Entities.Akademisyen akademisyen = new Entities.Akademisyen();
        public SifreYenile()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {


            if (müdür_radio.Checked && tc_textbox.Text.Length == 11 && emailbx.Text.Length > 0)
            {
                if (müdür.getForgetPassword(tc_textbox.Text) != null)
                {
                    var client = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential("obssifresender@gmail.com", "Yusufk47"),
                        EnableSsl = true
                    };
                    client.Send("obssifresender@gmail.com", emailbx.Text, "Üniversite Bilgi Sistemi Şifre İsteği", "Merhaba,\n Girilen Tc Numarasına Ait Personel Şifrei:" + müdür.getForgetPassword(tc_textbox.Text) + "  dir \n İyi Günler Dileriz!");
                    MessageBox.Show("Gönderildi!");
                }
                else
                    MessageBox.Show("Tc Kimlik No hatalı");


            }
            if(akademisyenradio.Checked && tc_textbox.Text.Length == 11 && emailbx.Text.Length > 0)
            {
                if (akademisyen.getForgetPassword(tc_textbox.Text) != null)
                {
                    try
                    {
                        var client = new SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new NetworkCredential("obssifresender@gmail.com", "Yusufk47"),
                            EnableSsl = true
                        };
                        client.Send("obssifresender@gmail.com", emailbx.Text, "Üniversite Bilgi Sistemi Şifre İsteği", "Merhaba,\nGirilen Tc Numarasına Ait Akademisyen Şifrei:" + akademisyen.getForgetPassword(tc_textbox.Text) + "  dir \n İyi Günler Dileriz!");
                        MessageBox.Show("Gönderildi!");
                    }
                    catch(Exception E)
                    {
                        MessageBox.Show(E.Message.ToString());
                    }
                   
                }
                else
                    MessageBox.Show("Tc Kimlik No hatalı");

            }
            else MessageBox.Show("Gerekli Alanları Doldurun!");
        }
    }
}