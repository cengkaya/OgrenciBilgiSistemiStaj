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
    public partial class Gönderilen_Duyurular : DevExpress.XtraEditors.XtraForm
    {
        Entities.Akademisyen akademisyen = new Entities.Akademisyen();
        public Gönderilen_Duyurular()
        {
            InitializeComponent();
            dgv.DataSource = akademisyen.getDuyurular(Giriş.loginusertc).Tables[0].DefaultView;
            dgv.Columns["Duyuru Metni"].Width = 333;
            dgv.Columns["Ders Adı"].Width = 333;

        }
    }
}