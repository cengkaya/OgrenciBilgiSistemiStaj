
namespace OgrenciBilgiSistemi.MüdürPanels
{
    partial class addStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addStudent));
            this.NAMESURNAME = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PW = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.eklebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sinifdropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.bolumlerdropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kadınradio = new System.Windows.Forms.RadioButton();
            this.erkekradio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.NAMESURNAME.Location = new System.Drawing.Point(45, 150);
            this.NAMESURNAME.Margin = new System.Windows.Forms.Padding(4);
            this.NAMESURNAME.MaxLength = 32767;
            this.NAMESURNAME.Name = "NAMESURNAME";
            this.NAMESURNAME.Size = new System.Drawing.Size(293, 33);
            this.NAMESURNAME.TabIndex = 12;
            this.NAMESURNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.PW.Location = new System.Drawing.Point(353, 65);
            this.PW.Margin = new System.Windows.Forms.Padding(4);
            this.PW.MaxLength = 32767;
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(293, 33);
            this.PW.TabIndex = 11;
            this.PW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.TC.Location = new System.Drawing.Point(45, 65);
            this.TC.Margin = new System.Windows.Forms.Padding(4);
            this.TC.MaxLength = 32767;
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(293, 33);
            this.TC.TabIndex = 10;
            this.TC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // eklebutton
            // 
            this.eklebutton.Active = false;
            this.eklebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.eklebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.eklebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eklebutton.BorderRadius = 0;
            this.eklebutton.ButtonText = "Öğrenci Kayddet";
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
            this.eklebutton.Location = new System.Drawing.Point(418, 337);
            this.eklebutton.Name = "eklebutton";
            this.eklebutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.eklebutton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.eklebutton.OnHoverTextColor = System.Drawing.Color.White;
            this.eklebutton.selected = false;
            this.eklebutton.Size = new System.Drawing.Size(241, 48);
            this.eklebutton.TabIndex = 9;
            this.eklebutton.Text = "Öğrenci Kayddet";
            this.eklebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eklebutton.Textcolor = System.Drawing.Color.White;
            this.eklebutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eklebutton.Click += new System.EventHandler(this.eklebutton_Click);
            // 
            // sinifdropdown
            // 
            this.sinifdropdown.BackColor = System.Drawing.Color.Transparent;
            this.sinifdropdown.BorderRadius = 3;
            this.sinifdropdown.DisabledColor = System.Drawing.Color.Gray;
            this.sinifdropdown.ForeColor = System.Drawing.Color.White;
            this.sinifdropdown.items = new string[0];
            this.sinifdropdown.Location = new System.Drawing.Point(45, 259);
            this.sinifdropdown.Name = "sinifdropdown";
            this.sinifdropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.sinifdropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.sinifdropdown.selectedIndex = -1;
            this.sinifdropdown.Size = new System.Drawing.Size(217, 35);
            this.sinifdropdown.TabIndex = 14;
            this.sinifdropdown.onItemSelected += new System.EventHandler(this.sinifdropdown_onItemSelected);
            // 
            // bolumlerdropdown
            // 
            this.bolumlerdropdown.BackColor = System.Drawing.Color.Transparent;
            this.bolumlerdropdown.BorderRadius = 3;
            this.bolumlerdropdown.DisabledColor = System.Drawing.Color.Gray;
            this.bolumlerdropdown.ForeColor = System.Drawing.Color.White;
            this.bolumlerdropdown.items = new string[0];
            this.bolumlerdropdown.Location = new System.Drawing.Point(353, 259);
            this.bolumlerdropdown.Name = "bolumlerdropdown";
            this.bolumlerdropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bolumlerdropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bolumlerdropdown.selectedIndex = -1;
            this.bolumlerdropdown.Size = new System.Drawing.Size(217, 35);
            this.bolumlerdropdown.TabIndex = 15;
            this.bolumlerdropdown.onItemSelected += new System.EventHandler(this.bolumlerdropdown_onItemSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(40, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sınıf Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(348, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bölüm Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(40, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sınıfların yüklenmesi için önce bölüm seçiniz";
            // 
            // kadınradio
            // 
            this.kadınradio.AutoSize = true;
            this.kadınradio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kadınradio.Location = new System.Drawing.Point(458, 150);
            this.kadınradio.Name = "kadınradio";
            this.kadınradio.Size = new System.Drawing.Size(66, 23);
            this.kadınradio.TabIndex = 19;
            this.kadınradio.TabStop = true;
            this.kadınradio.Text = "Kadın";
            this.kadınradio.UseVisualStyleBackColor = true;
            this.kadınradio.CheckedChanged += new System.EventHandler(this.kadınradio_CheckedChanged);
            // 
            // erkekradio
            // 
            this.erkekradio.AutoSize = true;
            this.erkekradio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.erkekradio.Location = new System.Drawing.Point(580, 150);
            this.erkekradio.Name = "erkekradio";
            this.erkekradio.Size = new System.Drawing.Size(66, 23);
            this.erkekradio.TabIndex = 20;
            this.erkekradio.TabStop = true;
            this.erkekradio.Text = "Erkek";
            this.erkekradio.UseVisualStyleBackColor = true;
            this.erkekradio.CheckedChanged += new System.EventHandler(this.erkekradio_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(347, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cinsiyet:";
            // 
            // addStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::OgrenciBilgiSistemi.Properties.Resources._942c96af;
            this.ClientSize = new System.Drawing.Size(691, 425);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.erkekradio);
            this.Controls.Add(this.kadınradio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bolumlerdropdown);
            this.Controls.Add(this.sinifdropdown);
            this.Controls.Add(this.NAMESURNAME);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.TC);
            this.Controls.Add(this.eklebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addStudent";
            this.Text = "addStudent";
            this.Load += new System.EventHandler(this.addStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox NAMESURNAME;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PW;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TC;
        private Bunifu.Framework.UI.BunifuFlatButton eklebutton;
        private Bunifu.Framework.UI.BunifuDropdown sinifdropdown;
        private Bunifu.Framework.UI.BunifuDropdown bolumlerdropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton kadınradio;
        private System.Windows.Forms.RadioButton erkekradio;
        private System.Windows.Forms.Label label4;
    }
}