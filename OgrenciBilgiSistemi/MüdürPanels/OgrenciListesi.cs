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

namespace OgrenciBilgiSistemi.MüdürPanels
{
    public partial class OgrenciListesi : DevExpress.XtraEditors.XtraForm
    {
        Entities.Müdür müdür = new Entities.Müdür();
        int cinsiyet = -1;

        public OgrenciListesi()
        {
            InitializeComponent();
        }

        private void OgrenciListesi_Load(object sender, EventArgs e)
        {
            dgv.DataSource = müdür.getOgrenciTable().Tables[0].DefaultView;

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns["silcolumn"].Index && e.RowIndex >= 0)
            {
                string tc = dgv.CurrentRow.Cells["TC KİMLİK NO"].Value.ToString();
                if (müdür.deleteStudent(tc))
                {
                    MessageBox.Show("Ogrenci Başarıyla Silindi");
                  
                    
                    OgrenciListesi ogrenci = new OgrenciListesi();
                    ogrenci.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Hata Oluştu...");
                }

            }
            else if (e.ColumnIndex == dgv.Columns["duzenlecolumn"].Index && e.RowIndex >= 0)
            {
                tcbox.Text = dgv.CurrentRow.Cells["TC KİMLİK NO"].Value.ToString();
                pwbox.Text = dgv.CurrentRow.Cells["ŞİFRE"].Value.ToString();
                namebox.Text = dgv.CurrentRow.Cells["AD SOYAD"].Value.ToString();

            }
        }

        private void kadınradio_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = 0;
        }

        private void erkekradio_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = 1;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tcbox.Text)&&cinsiyet!=-1&&!String.IsNullOrEmpty(pwbox.Text)&&!String.IsNullOrEmpty(namebox.Text))
            {

                if (müdür.updateStudent(tcbox.Text, pwbox.Text, namebox.Text, cinsiyet))
                {
                    MessageBox.Show("Başarıyla Düzenlendi");
                        this.Close();
                 
                   
                    

                }
                else
                {
                    MessageBox.Show("Hata Oluştu...");
                }
            }
            else
            {
                MessageBox.Show("Kayıt seçilmedi  veya alanlar boş bırakıldı");
            }
        }
    }
}
