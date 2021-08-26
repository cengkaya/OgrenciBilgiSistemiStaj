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
    public partial class YetkiliListe : DevExpress.XtraEditors.XtraForm
    {
        Entities.Müdür müdür = new Entities.Müdür();
        public YetkiliListe()
        {
            InitializeComponent();
        }

        private void YetkiliEdit_Load(object sender, EventArgs e)
        {

            dgv.DataSource = müdür.getMudurTable().Tables[0].DefaultView;

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns["silcolumn"].Index && e.RowIndex >= 0)
            {
                string tc = dgv.CurrentRow.Cells["TC KİMLİK NO"].Value.ToString();
                if(müdür.deleteMüdür(tc))
                {
                    MessageBox.Show("Müdür Başarıyla Silindi");
                   
                    YetkiliListe yetkili = new YetkiliListe();
                    yetkili.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hata Oluştu...");
                }

            }
            else if(e.ColumnIndex == dgv.Columns["duzenlecolumn"].Index && e.RowIndex >= 0)
            {
                tcbox.Text = dgv.CurrentRow.Cells["TC KİMLİK NO"].Value.ToString();
                pwbox.Text = dgv.CurrentRow.Cells["ŞİFRE"].Value.ToString();
                namebox.Text= dgv.CurrentRow.Cells["AD SOYAD"].Value.ToString();
                titlebox.Text= dgv.CurrentRow.Cells["ÜNVAN"].Value.ToString();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tcbox.Text))
                {

                if (müdür.updateMüdür(tcbox.Text, pwbox.Text, namebox.Text, titlebox.Text))
                {
                    MessageBox.Show("Başarıyla Düzenlendi");
                   
                    YetkiliListe yetkili = new YetkiliListe();
                    yetkili.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hata Oluştu...");
                }
            }
                


            else
            {
                MessageBox.Show("Düzenlenecek Kayıt Seçiniz.");
            }

        }
    }
}