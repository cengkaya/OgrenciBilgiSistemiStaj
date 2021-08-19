
namespace OgrenciBilgiSistemi.MüdürPanels
{
    partial class AddBolum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBolum));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yilbox = new Bunifu.Framework.UI.BunifuDropdown();
            this.bolıumadibox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.eklebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(397, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Bolum Toplam Yıl Seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(22, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "BolumAd";
            // 
            // yilbox
            // 
            this.yilbox.BackColor = System.Drawing.Color.Transparent;
            this.yilbox.BorderRadius = 3;
            this.yilbox.DisabledColor = System.Drawing.Color.Gray;
            this.yilbox.ForeColor = System.Drawing.Color.White;
            this.yilbox.items = new string[] {
        "2",
        "4",
        "6"};
            this.yilbox.Location = new System.Drawing.Point(406, 78);
            this.yilbox.Name = "yilbox";
            this.yilbox.NomalColor = System.Drawing.Color.Tomato;
            this.yilbox.onHoverColor = System.Drawing.Color.Tomato;
            this.yilbox.selectedIndex = -1;
            this.yilbox.Size = new System.Drawing.Size(217, 35);
            this.yilbox.TabIndex = 30;
            this.yilbox.onItemSelected += new System.EventHandler(this.yilbox_onItemSelected);
            // 
            // bolıumadibox
            // 
            this.bolıumadibox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bolıumadibox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bolıumadibox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bolıumadibox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bolıumadibox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bolıumadibox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bolıumadibox.HintForeColor = System.Drawing.Color.Empty;
            this.bolıumadibox.HintText = "Bolüm Adi Giriniz";
            this.bolıumadibox.isPassword = false;
            this.bolıumadibox.LineFocusedColor = System.Drawing.Color.Blue;
            this.bolıumadibox.LineIdleColor = System.Drawing.Color.Gray;
            this.bolıumadibox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bolıumadibox.LineThickness = 3;
            this.bolıumadibox.Location = new System.Drawing.Point(25, 80);
            this.bolıumadibox.Margin = new System.Windows.Forms.Padding(4);
            this.bolıumadibox.MaxLength = 32767;
            this.bolıumadibox.Name = "bolıumadibox";
            this.bolıumadibox.Size = new System.Drawing.Size(293, 33);
            this.bolıumadibox.TabIndex = 29;
            this.bolıumadibox.Text = "Ders Adı Giriniz";
            this.bolıumadibox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // eklebutton
            // 
            this.eklebutton.Active = false;
            this.eklebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.eklebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.eklebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eklebutton.BorderRadius = 0;
            this.eklebutton.ButtonText = "BÖLÜM EKLE";
            this.eklebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eklebutton.DisabledColor = System.Drawing.Color.Gray;
            this.eklebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.eklebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("eklebutton.Iconimage")));
            this.eklebutton.Iconimage_right = null;
            this.eklebutton.Iconimage_right_Selected = null;
            this.eklebutton.Iconimage_Selected = null;
            this.eklebutton.IconMarginLeft = 0;
            this.eklebutton.IconMarginRight = 0;
            this.eklebutton.IconRightVisible = true;
            this.eklebutton.IconRightZoom = 0D;
            this.eklebutton.IconVisible = true;
            this.eklebutton.IconZoom = 90D;
            this.eklebutton.IsTab = false;
            this.eklebutton.Location = new System.Drawing.Point(236, 173);
            this.eklebutton.Name = "eklebutton";
            this.eklebutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.eklebutton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.eklebutton.OnHoverTextColor = System.Drawing.Color.White;
            this.eklebutton.selected = false;
            this.eklebutton.Size = new System.Drawing.Size(241, 48);
            this.eklebutton.TabIndex = 33;
            this.eklebutton.Text = "BÖLÜM EKLE";
            this.eklebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eklebutton.Textcolor = System.Drawing.Color.White;
            this.eklebutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eklebutton.Click += new System.EventHandler(this.eklebutton_Click);
            // 
            // AddBolum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::OgrenciBilgiSistemi.Properties.Resources._942c96af;
            this.ClientSize = new System.Drawing.Size(677, 242);
            this.Controls.Add(this.eklebutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yilbox);
            this.Controls.Add(this.bolıumadibox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddBolum";
            this.Text = "AddBolum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDropdown yilbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bolıumadibox;
        private Bunifu.Framework.UI.BunifuFlatButton eklebutton;
    }
}