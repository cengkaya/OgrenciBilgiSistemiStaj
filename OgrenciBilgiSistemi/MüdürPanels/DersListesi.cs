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
    public partial class DersListesi : DevExpress.XtraEditors.XtraForm
    {
        Entities.Müdür müdür=new Entities.Müdür();
        public DersListesi()
        {
            InitializeComponent();
            dgv.DataSource = müdür.getDerslerTable().Tables[0].DefaultView;
        }

        private void DersListesi_Load(object sender, EventArgs e)
        {



        }
    }
}