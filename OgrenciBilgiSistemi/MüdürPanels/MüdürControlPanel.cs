using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi.MüdürPanels
{
    public partial class MüdürControlPanel : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MüdürControlPanel()
        {
            InitializeComponent();
        }

        private void addyetkili_Click(object sender, EventArgs e)
        {

            addyetkili add = new addyetkili();
            add.Show();
        }

        private void muduredit_Click(object sender, EventArgs e)
        {
            YetkiliListe yetkiliEdit = new YetkiliListe();
            yetkiliEdit.Show();
        }
    }
}
