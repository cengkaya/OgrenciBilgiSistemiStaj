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
    
    public partial class AddBolum : DevExpress.XtraEditors.XtraForm
    {
        string bolumad=null;
        int yil = -1;
        Entities.Müdür müdür = new Entities.Müdür();
        public AddBolum()
        {
            InitializeComponent();
        }

        private void eklebutton_Click(object sender, EventArgs e)
        {
            bolumad = bolıumadibox.Text.ToString();
            yil = Int32.Parse(yilbox.selectedValue);
            if (!String.IsNullOrEmpty(bolumad)&&yil!=-1)
            {
                if(müdür.addnewBolum(bolumad,yil))
                    {
                    MessageBox.Show("Bölüm Başarıyla Eklendi!");
                }
                else MessageBox.Show("Hata oluştu!");
            }
            else MessageBox.Show("Alanların Doldurulduğundan Emin Olunuz");
        }

        private void yilbox_onItemSelected(object sender, EventArgs e)
        {
            yil = Int32.Parse(yilbox.selectedValue);
        }
    }
}