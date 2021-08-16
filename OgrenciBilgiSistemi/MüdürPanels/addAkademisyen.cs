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
    public partial class addAkademisyen : DevExpress.XtraEditors.XtraForm
    {
        int bolumid=-1;
        Entities.Müdür müdür = new Entities.Müdür();
        public addAkademisyen()
        {
            InitializeComponent();
            foreach (string i in müdür.getdepartmants())
            {
                bolumlerdropdown.AddItem(i);
            }
        }

        private void bolumlerdropdown_onItemSelected(object sender, EventArgs e)
        {
            string bolumadi = bolumlerdropdown.selectedValue.ToString();
            bolumid = müdür.getbolumidbyname(bolumadi);
            MessageBox.Show(bolumid.ToString());    
        }

        private void eklebutton_Click(object sender, EventArgs e)
        {
            if(bolumid!=-1)
            {
      
               if(müdür.addAkademisyen(tc.Text,pw.Text,name.Text,bolumid))
                {
                    MessageBox.Show("Başarıyla Kaydedildi");
                }
               else MessageBox.Show("Alanları kontrol edin!");
            }
            else MessageBox.Show("Bölüm Seçin!");

        }
    }
}