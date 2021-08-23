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
    public partial class SorumluDersler : DevExpress.XtraEditors.XtraForm
        
    {
        Entities.Akademisyen akademisyen = new Entities.Akademisyen();
        public SorumluDersler()
        {
            InitializeComponent();
        }

        private void SorumluDersler_Load(object sender, EventArgs e)
        {
            dgv.DataSource = akademisyen.getSorumluDersler().Tables[0].DefaultView;
            dgv.Columns["OgretmenTc"].Visible = false;
            foreach(DataGridViewColumn column in dgv.Columns)
            {
                column.Width = 175;
            }
        


        }
    }
}