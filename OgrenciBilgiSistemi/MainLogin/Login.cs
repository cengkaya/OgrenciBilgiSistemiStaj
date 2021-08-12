using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    
    public partial class Giriş : Form
    {
        Entities.Müdür müdür = new Entities.Müdür();
        public Giriş()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (müdür_radio.Checked)
            {
                if (müdür.MüdürLogin(tc_textbox.Text, pw_textbox.Text))
                {
                    MessageBox.Show("Giriş Başarılı");
                    MüdürPanels.MüdürControlPanel müdürControl = new MüdürPanels.MüdürControlPanel();
                    müdürControl.Show();

                }
                else MessageBox.Show("Giriş Başarsısız");

            }
        }

        private void xuıFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuıFormDesign1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

