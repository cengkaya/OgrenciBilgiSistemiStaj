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
    public partial class SınavSonuçları : DevExpress.XtraEditors.XtraForm
    {
        Entities.Ogrenci ogrenci = new Entities.Ogrenci();
        public SınavSonuçları()
        {
            InitializeComponent();
            dgv.DataSource = ogrenci.getSınavSonuç(Giriş.loginusertc).Tables[0].DefaultView;
        }
    }
}