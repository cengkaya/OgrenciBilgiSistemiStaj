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
    public partial class DevamsızlıkKayıtları : DevExpress.XtraEditors.XtraForm
    {
        Entities.Ogrenci ogrenci = new Entities.Ogrenci();
        public DevamsızlıkKayıtları()
        {
            InitializeComponent();
            dgv.DataSource = ogrenci.getDevamsızlık(Giriş.loginusertc).Tables[0].DefaultView;
            dgv.Columns["Tarih"].Width = 150;
        }
    }
}