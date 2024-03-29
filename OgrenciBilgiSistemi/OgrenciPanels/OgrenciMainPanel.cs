﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi.OgrenciPanels
{
    public partial class OgrenciMainPanel : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public OgrenciMainPanel()
        {
            InitializeComponent();
        }

        private void OgrenciMainPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sinavsonucitem_Click(object sender, EventArgs e)
        {
            SınavSonuçları sınavSonuçları = new SınavSonuçları();
            sınavSonuçları.Show();
        }

        private void devamsızlıkitem_Click(object sender, EventArgs e)
        {
            DevamsızlıkKayıtları devamsızlıkKayıtları = new DevamsızlıkKayıtları();
            devamsızlıkKayıtları.Show();
        }

        private void duyuruitem_Click(object sender, EventArgs e)
        {
            Duyurular duyurular = new Duyurular();
            duyurular.Show();
        }
    }
}
