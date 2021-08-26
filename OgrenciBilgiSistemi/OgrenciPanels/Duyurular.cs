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

namespace OgrenciBilgiSistemi.OgrenciPanels
{
    public partial class Duyurular : DevExpress.XtraEditors.XtraForm
    {
        Entities.Ogrenci ogrenci = new Entities.Ogrenci();
        public Duyurular()
        {
            InitializeComponent();
            dgv.DataSource = ogrenci.getDuyurular(Giriş.loginusertc).Tables[0].DefaultView;
            dgv.Columns["Duyuru Metni"].Width = 250;
        }
    }
}