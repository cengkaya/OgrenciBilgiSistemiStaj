using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi.AkademisyenPanels
{
    public partial class AkademisyenMainPanel : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public AkademisyenMainPanel()
        {
            InitializeComponent();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            SorumluDersler sorumluDersler = new SorumluDersler();
            sorumluDersler.Show();
        }

        private void AkademisyenMainPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            Not_Girişi not_Girişi = new Not_Girişi();
            not_Girişi.Show();
        }
    }
}
