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
    public partial class AkademisyenListesi : DevExpress.XtraEditors.XtraForm
    {
        Entities.Müdür müdür = new Entities.Müdür();
        public AkademisyenListesi()
        {
            InitializeComponent();
        }

        private void AkademisyenListesi_Load(object sender, EventArgs e)
        {
            dgv.DataSource = müdür.getAkademisyenTablo().Tables[0].DefaultView;


        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns["silcolumn"].Index && e.RowIndex >= 0)
            {
                string tc = dgv.CurrentRow.Cells["TC KİMLİK NO"].Value.ToString();
                if (müdür.deleteAkademisyen(tc))
                {
                    MessageBox.Show("Akademisyen Başarıyla Silindi");
                    AkademisyenListesi akademisyen = new AkademisyenListesi();
                    akademisyen.Show();
                    this.Hide();

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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tcbox.Text))
            {

                if (müdür.updateAkademisyen(tcbox.Text, pwbox.Text, namebox.Text))
                {
                    MessageBox.Show("Başarıyla Düzenlendi");

                    AkademisyenListesi akademisyen = new AkademisyenListesi();
                    akademisyen.Show();
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Hata Oluştu...");
                }
            }
        }
    }
}