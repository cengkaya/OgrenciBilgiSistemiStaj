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
    public partial class Not_Girişi : DevExpress.XtraEditors.XtraForm
    {
        int secilenderssinifid = -1;
        string secilenogrenci = null;
        string notturu = null;
        Entities.Akademisyen akademisyen = new Entities.Akademisyen();
        public Not_Girişi()
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
            
            dgv.DataSource = akademisyen.getOgrenciTablebysinifid(secilenderssinifid).Tables[0].DefaultView;


        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ogrencitc.Text= dgv.CurrentRow.Cells["TC KİMLİK NO"].Value.ToString();
            adsoyad.Text= dgv.CurrentRow.Cells["AD SOYAD"].Value.ToString();
            secilenogrenci = ogrencitc.Text;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (secilenderssinifid != -1 && secilenogrenci != null && notturu != null)
            {
                if (akademisyen.addNot(secilenogrenci, notturu, derslerdrop.selectedValue, Int32.Parse(not.Text)))
                    {
                    MessageBox.Show("Başarıyla Kaydedildi");
                }
                else MessageBox.Show("Not Kaydedilirken Hata Oluştu");
            }
            else MessageBox.Show("Gerekli Alanlar Doldurulmadı veya öğrenci seçilmedi");

        }

        private void vize_CheckedChanged(object sender, EventArgs e)
        {
            notturu = "Vize";
        }

        private void final_CheckedChanged(object sender, EventArgs e)
        {
            notturu = "Final";
        }

        private void bütünleme_CheckedChanged(object sender, EventArgs e)
        {
            notturu = "Bütünleme";
        }
    }
}