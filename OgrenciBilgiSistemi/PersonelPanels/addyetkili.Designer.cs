
namespace OgrenciBilgiSistemi.MüdürPanels
{
    partial class addyetkili
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addyetkili));
            this.eklebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PW = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NAMESURNAME = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Title = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // eklebutton
            // 
            this.eklebutton.Active = false;
            this.eklebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.eklebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.eklebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eklebutton.BorderRadius = 0;
            this.eklebutton.ButtonText = "Yeni Yönetici  Ekle";
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
            this.eklebutton.Location = new System.Drawing.Point(198, 232);
            this.eklebutton.Name = "eklebutton";
            this.eklebutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.eklebutton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.eklebutton.OnHoverTextColor = System.Drawing.Color.White;
            this.eklebutton.selected = false;
            this.eklebutton.Size = new System.Drawing.Size(241, 48);
            this.eklebutton.TabIndex = 4;
            this.eklebutton.Text = "Yeni Yönetici  Ekle";
            this.eklebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eklebutton.Textcolor = System.Drawing.Color.White;
            this.eklebutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eklebutton.Click += new System.EventHandler(this.eklebutton_Click);
            // 
            // TC
            // 
            this.TC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TC.HintForeColor = System.Drawing.Color.Empty;
            this.TC.HintText = "Tc Kimlik No";
            this.TC.isPassword = false;
            this.TC.LineFocusedColor = System.Drawing.Color.Blue;
            this.TC.LineIdleColor = System.Drawing.Color.Gray;
            this.TC.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TC.LineThickness = 3;
            this.TC.Location = new System.Drawing.Point(37, 61);
            this.TC.Margin = new System.Windows.Forms.Padding(4);
            this.TC.MaxLength = 32767;
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(293, 33);
            this.TC.TabIndex = 5;
            this.TC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PW
            // 
            this.PW.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PW.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PW.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PW.HintForeColor = System.Drawing.Color.Empty;
            this.PW.HintText = "Şifre";
            this.PW.isPassword = false;
            this.PW.LineFocusedColor = System.Drawing.Color.Blue;
            this.PW.LineIdleColor = System.Drawing.Color.Gray;
            this.PW.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PW.LineThickness = 3;
            this.PW.Location = new System.Drawing.Point(345, 61);
            this.PW.Margin = new System.Windows.Forms.Padding(4);
            this.PW.MaxLength = 32767;
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(293, 33);
            this.PW.TabIndex = 6;
            this.PW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NAMESURNAME
            // 
            this.NAMESURNAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NAMESURNAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NAMESURNAME.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NAMESURNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NAMESURNAME.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NAMESURNAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NAMESURNAME.HintForeColor = System.Drawing.Color.Empty;
            this.NAMESURNAME.HintText = "Ad Soyad";
            this.NAMESURNAME.isPassword = false;
            this.NAMESURNAME.LineFocusedColor = System.Drawing.Color.Blue;
            this.NAMESURNAME.LineIdleColor = System.Drawing.Color.Gray;
            this.NAMESURNAME.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.NAMESURNAME.LineThickness = 3;
            this.NAMESURNAME.Location = new System.Drawing.Point(37, 146);
            this.NAMESURNAME.Margin = new System.Windows.Forms.Padding(4);
            this.NAMESURNAME.MaxLength = 32767;
            this.NAMESURNAME.Name = "NAMESURNAME";
            this.NAMESURNAME.Size = new System.Drawing.Size(293, 33);
            this.NAMESURNAME.TabIndex = 7;
            this.NAMESURNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Title
            // 
            this.Title.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Title.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Title.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Title.HintForeColor = System.Drawing.Color.Empty;
            this.Title.HintText = "Ünvan";
            this.Title.isPassword = false;
            this.Title.LineFocusedColor = System.Drawing.Color.Blue;
            this.Title.LineIdleColor = System.Drawing.Color.Gray;
            this.Title.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Title.LineThickness = 3;
            this.Title.Location = new System.Drawing.Point(345, 146);
            this.Title.Margin = new System.Windows.Forms.Padding(4);
            this.Title.MaxLength = 32767;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(293, 33);
            this.Title.TabIndex = 8;
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addyetkili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::OgrenciBilgiSistemi.Properties.Resources._942c96af;
            this.ClientSize = new System.Drawing.Size(651, 346);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.NAMESURNAME);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.TC);
            this.Controls.Add(this.eklebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addyetkili";
            this.Text = "Müdür-Müdür Yardımcısı Ekle";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton eklebutton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TC;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PW;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NAMESURNAME;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Title;
    }
}