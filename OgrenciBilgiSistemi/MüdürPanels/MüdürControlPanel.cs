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
        Entities.Müdür müdür=new Entities.Müdür();
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

        private void ogrencigroup_Click(object sender, EventArgs e)
        {

        }

        private void müdürislemlerigroup_Click(object sender, EventArgs e)
        {

        }

        private void newogrenci_Click(object sender, EventArgs e)
        {
            addStudent add = new addStudent();
            add.Show();
        }

        private void ogrenciedit_Click(object sender, EventArgs e)
        {
            OgrenciListesi ogrenciListesi = new OgrenciListesi();
            ogrenciListesi.Show();
        }

        private void MüdürControlPanel_Load(object sender, EventArgs e)
        {
            toplamogrencigauge.Text = müdür.countStudent().ToString();
        }

        private void newogretmen_Click(object sender, EventArgs e)
        {
            addAkademisyen addAkademisyen = new addAkademisyen();
            addAkademisyen.Show();
        }

        private void editogretmen_Click(object sender, EventArgs e)
        {
            AkademisyenListesi akademisyenListesi = new AkademisyenListesi();
            akademisyenListesi.Show();
        }

        private void dersekle_Click(object sender, EventArgs e)
        {
            AddDers add = new AddDers();
            add.Show();
        }
    }
}
