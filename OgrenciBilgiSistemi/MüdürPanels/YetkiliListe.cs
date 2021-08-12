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
    }
}