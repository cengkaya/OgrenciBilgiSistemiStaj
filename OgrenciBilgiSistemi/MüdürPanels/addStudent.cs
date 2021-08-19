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
    public partial class addStudent : DevExpress.XtraEditors.XtraForm
    {
            int cinsiyet = -1;
            int sinif = -1;
            int bolumid = -1;
        Entities.Müdür müdür = new Entities.Müdür();
        public addStudent()
        {
            InitializeComponent();
            foreach(string i in müdür.getdepartmants())
            {
                bolumlerdropdown.AddItem(i);
            }

        }

        private void bolumlerdropdown_onItemSelected(object sender, EventArgs e)
        {
            string bolumadi = bolumlerdropdown.selectedValue.ToString();
          bolumid=  müdür.getbolumidbyname(bolumadi);
            sinifdropdown.Clear();
            foreach (string i in müdür.getClasses(müdür.getbolumidbyname(bolumadi)))
            {
                sinifdropdown.AddItem(i);
            }
        }

        private void eklebutton_Click(object sender, EventArgs e)
        {
            if(cinsiyet!=-1&&sinif!=-1&&bolumid!=-1&&TC.Text.Length==11&&NAMESURNAME.Text.Length>=1&&PW.Text.Length>=1)
            {
                if(müdür.addStudent(TC.Text,PW.Text,NAMESURNAME.Text,bolumid,sinif,cinsiyet))
                {
                    MessageBox.Show("ÖĞRENCİ KAYIT İŞLEMİ TAMAMLANDI");

                }
                else
                {
                    MessageBox.Show("HATA..");
                }
            }
            else
            {
                MessageBox.Show("Gerekli Alanları Kontrol Ediniz!.."); 
            }
        }

        private void sinifdropdown_onItemSelected(object sender, EventArgs e)
        {
            sinif = Int32.Parse(sinifdropdown.selectedValue.ToString());
        }

        private void kadınradio_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = 0;
        }

        private void erkekradio_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = 1;
        }

        private void addStudent_Load(object sender, EventArgs e)
        {

        }
    }
    }
