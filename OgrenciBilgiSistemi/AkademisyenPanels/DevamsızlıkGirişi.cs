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
    public partial class DevamsızlıkGirişi : DevExpress.XtraEditors.XtraForm
    {
        string secilenogrenci = null;
        int secilenderssinifid = -1;
        Entities.Akademisyen akademisyen = new Entities.Akademisyen();
        public DevamsızlıkGirişi()
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
            ogrencitc.Text = dgv.CurrentRow.Cells["TC KİMLİK NO"].Value.ToString();
            adsoyad.Text = dgv.CurrentRow.Cells["AD SOYAD"].Value.ToString();
            secilenogrenci = ogrencitc.Text;
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(secilenogrenci!=null&&secilenderssinifid!=-1&&tarihsec.Value!=null)
            {
                if (akademisyen.adddevamsızlık(secilenogrenci, tarihsec.Value.ToString(), derslerdrop.selectedValue))
                {
                    MessageBox.Show("Devamsızlık Kayıt İşlemi Başarıyla Tamamlandı!");
                }
                else MessageBox.Show("Hata oluştu");
            }
            else MessageBox.Show("Gerekli Alanlar Doldurulmamış!");
        }
    }
}