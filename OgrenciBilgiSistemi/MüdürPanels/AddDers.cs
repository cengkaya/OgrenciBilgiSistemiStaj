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
    public partial class AddDers : DevExpress.XtraEditors.XtraForm
    {
        string secilenakademisyenTc;
        int sinif = -1;
        int bolumid = -1;
        int akts = -1;
        Entities.Müdür müdür = new Entities.Müdür();
        public AddDers()
        {
            InitializeComponent();
            foreach (string i in müdür.getdepartmants())
            {
                bolumlerdropdown.AddItem(i);
            }
            dgv.DataSource = müdür.getAkademisyenTablo().Tables[0].DefaultView;
        }

        private void bolumlerdropdown_onItemSelected(object sender, EventArgs e)
        {
            string bolumadi = bolumlerdropdown.selectedValue.ToString();
            bolumid = müdür.getbolumidbyname(bolumadi);
            foreach (string i in müdür.getClasses(müdür.getbolumidbyname(bolumadi)))
            {
                sinifdropdown.AddItem(i);
            }
        }

        private void eklebutton_Click(object sender, EventArgs e)
        {
            if(sinif!=-1&&bolumid!=-1&&akts!=-1&&dersad.Text.Length!=0&&!String.IsNullOrEmpty(secilenakademisyenTc))
            {
                if(müdür.addDers(dersad.Text,akts.ToString(),bolumid,sinif.ToString(),secilenakademisyenTc))
                {
                    MessageBox.Show("Ders Ekleme Başarılı");
                }
                else MessageBox.Show("Hata...");
            }
            else MessageBox.Show("Alanları Kontrol Edin!");
        }

        private void AddDers_Load(object sender, EventArgs e)
        {

        }

        private void sinifdropdown_onItemSelected(object sender, EventArgs e)
        {
            sinif = Int32.Parse(sinifdropdown.selectedValue.ToString());
        }

        private void aktsbx_onItemSelected(object sender, EventArgs e)
        {
            akts = Int32.Parse(aktsbx.selectedValue.ToString());
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenakademisyenTc= dgv.CurrentRow.Cells["TC KİMLİK NO"].Value.ToString();
        }
    }
}