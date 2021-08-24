
namespace OgrenciBilgiSistemi.AkademisyenPanels
{
    partial class Duyuru_Gönder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Duyuru_Gönder));
            this.derslerdrop = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.duyurubox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // derslerdrop
            // 
            this.derslerdrop.BackColor = System.Drawing.Color.Transparent;
            this.derslerdrop.BorderRadius = 3;
            this.derslerdrop.DisabledColor = System.Drawing.Color.Gray;
            this.derslerdrop.ForeColor = System.Drawing.Color.White;
            this.derslerdrop.items = new string[0];
            this.derslerdrop.Location = new System.Drawing.Point(16, 67);
            this.derslerdrop.Name = "derslerdrop";
            this.derslerdrop.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.derslerdrop.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.derslerdrop.selectedIndex = -1;
            this.derslerdrop.Size = new System.Drawing.Size(374, 35);
            this.derslerdrop.TabIndex = 12;
            this.derslerdrop.onItemSelected += new System.EventHandler(this.derslerdrop_onItemSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::OgrenciBilgiSistemi.Properties.Resources._942c96af;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ders Seçiniz";
            // 
            // duyurubox
            // 
            this.duyurubox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.duyurubox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.duyurubox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.duyurubox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.duyurubox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.duyurubox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.duyurubox.HintForeColor = System.Drawing.Color.Empty;
            this.duyurubox.HintText = "Duyuru Metni Max 250 Karakter";
            this.duyurubox.isPassword = false;
            this.duyurubox.LineFocusedColor = System.Drawing.Color.Blue;
            this.duyurubox.LineIdleColor = System.Drawing.Color.Gray;
            this.duyurubox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.duyurubox.LineThickness = 3;
            this.duyurubox.Location = new System.Drawing.Point(16, 131);
            this.duyurubox.Margin = new System.Windows.Forms.Padding(4);
            this.duyurubox.MaxLength = 250;
            this.duyurubox.Name = "duyurubox";
            this.duyurubox.Size = new System.Drawing.Size(379, 190);
            this.duyurubox.TabIndex = 14;
            this.duyurubox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Duyuru Gönder";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(83, 343);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 15;
            this.bunifuFlatButton1.Text = "Duyuru Gönder";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Duyuru_Gönder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::OgrenciBilgiSistemi.Properties.Resources._942c96af;
            this.ClientSize = new System.Drawing.Size(417, 403);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.duyurubox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.derslerdrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Duyuru_Gönder";
            this.Text = "Duyuru_Gönder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown derslerdrop;
        private Bunifu.Framework.UI.BunifuMaterialTextbox duyurubox;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}