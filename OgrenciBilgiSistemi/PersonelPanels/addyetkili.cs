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
    public partial class addyetkili : DevExpress.XtraEditors.XtraForm
    {
        Entities.Müdür müdür = new Entities.Müdür();

        public addyetkili()
        {
            InitializeComponent();
        }

        private void eklebutton_Click(object sender, EventArgs e)
        {

            if(TC.Text.Length==11&&PW.Text.Length!=0&&NAMESURNAME.Text.Length!=0&&Title.Text.Length!=0)
            {
                if (müdür.addnewMudur(TC.Text, PW.Text, NAMESURNAME.Text, Title.Text))
                {
                    MessageBox.Show("Başarılı bir şekilde eklendi");
                }
                else
                {
                    MessageBox.Show("Yönetici Eklerken Hata Oluştu");
                }
               
            }
            else
            {
                MessageBox.Show("Bilgileri Eksiksiz Girin tc no 11 haneden oluşmali ad soyad şifre ve ünvan max 45 karakter min  1 karakter");
            }
        
        }
    }
}