using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi.AkademisyenPanels
{
    public partial class Duyuru_Gönder : DevExpress.XtraEditors.XtraForm
    {
        int secilenderssinifid = -1;
        Entities.Akademisyen akademisyen = new Entities.Akademisyen();
        public Duyuru_Gönder()
        {
            InitializeComponent();
            foreach (string i in akademisyen.getDerslerimList())
            {
                derslerdrop.AddItem(i);
            }
        }

        private void derslerdrop_onItemSelected(object sender, EventArgs e)
        {
            derslerdrop.Enabled = false;
            secilenderssinifid = akademisyen.getsinifidbydersname(derslerdrop.selectedValue);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (secilenderssinifid != -1 && duyurubox.Text != null)
            {
                if (akademisyen.addnewDuyuru(Giriş.loginusertc, duyurubox.Text, derslerdrop.selectedValue.ToString()))
                {
                    MessageBox.Show("Duyuru GÖNERİLDİ");
                }
                else MessageBox.Show("Hata!");

            }
            else MessageBox.Show("Belirtilen Alanları Doldurunuz");
        }
    }
}