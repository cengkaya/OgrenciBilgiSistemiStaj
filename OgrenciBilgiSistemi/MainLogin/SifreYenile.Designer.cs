
namespace OgrenciBilgiSistemi.MainLogin
{
    partial class SifreYenile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreYenile));
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.öğrenci_radio = new System.Windows.Forms.RadioButton();
            this.akademisyenradio = new System.Windows.Forms.RadioButton();
            this.müdür_radio = new System.Windows.Forms.RadioButton();
            this.tc_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.emailbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Şifremi Gönder";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(175, 243);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(125, 48);
            this.bunifuFlatButton2.TabIndex = 13;
            this.bunifuFlatButton2.Text = "Şifremi Gönder";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // öğrenci_radio
            // 
            this.öğrenci_radio.AutoSize = true;
            this.öğrenci_radio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("öğrenci_radio.BackgroundImage")));
            this.öğrenci_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.öğrenci_radio.ForeColor = System.Drawing.Color.White;
            this.öğrenci_radio.Location = new System.Drawing.Point(329, 182);
            this.öğrenci_radio.Name = "öğrenci_radio";
            this.öğrenci_radio.Size = new System.Drawing.Size(105, 29);
            this.öğrenci_radio.TabIndex = 12;
            this.öğrenci_radio.TabStop = true;
            this.öğrenci_radio.Text = "Öğrenci";
            this.öğrenci_radio.UseVisualStyleBackColor = true;
            // 
            // akademisyenradio
            // 
            this.akademisyenradio.AutoSize = true;
            this.akademisyenradio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("akademisyenradio.BackgroundImage")));
            this.akademisyenradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.akademisyenradio.ForeColor = System.Drawing.Color.White;
            this.akademisyenradio.Location = new System.Drawing.Point(165, 182);
            this.akademisyenradio.Name = "akademisyenradio";
            this.akademisyenradio.Size = new System.Drawing.Size(159, 29);
            this.akademisyenradio.TabIndex = 11;
            this.akademisyenradio.TabStop = true;
            this.akademisyenradio.Text = "Akademisyen";
            this.akademisyenradio.UseVisualStyleBackColor = true;
            // 
            // müdür_radio
            // 
            this.müdür_radio.AutoSize = true;
            this.müdür_radio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("müdür_radio.BackgroundImage")));
            this.müdür_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müdür_radio.ForeColor = System.Drawing.Color.White;
            this.müdür_radio.Location = new System.Drawing.Point(53, 182);
            this.müdür_radio.Name = "müdür_radio";
            this.müdür_radio.Size = new System.Drawing.Size(115, 29);
            this.müdür_radio.TabIndex = 10;
            this.müdür_radio.TabStop = true;
            this.müdür_radio.Text = "Personel";
            this.müdür_radio.UseVisualStyleBackColor = true;
            // 
            // tc_textbox
            // 
            this.tc_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tc_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tc_textbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tc_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tc_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tc_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tc_textbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tc_textbox.HintText = "TC KİMLİK NO";
            this.tc_textbox.isPassword = false;
            this.tc_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tc_textbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tc_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tc_textbox.LineThickness = 3;
            this.tc_textbox.Location = new System.Drawing.Point(85, 56);
            this.tc_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.tc_textbox.MaxLength = 32767;
            this.tc_textbox.Name = "tc_textbox";
            this.tc_textbox.Size = new System.Drawing.Size(318, 33);
            this.tc_textbox.TabIndex = 8;
            this.tc_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailbx
            // 
            this.emailbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.emailbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.emailbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailbx.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailbx.HintText = "E Posta Adresiniz";
            this.emailbx.isPassword = false;
            this.emailbx.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailbx.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailbx.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailbx.LineThickness = 3;
            this.emailbx.Location = new System.Drawing.Point(85, 123);
            this.emailbx.Margin = new System.Windows.Forms.Padding(4);
            this.emailbx.MaxLength = 32767;
            this.emailbx.Name = "emailbx";
            this.emailbx.Size = new System.Drawing.Size(318, 33);
            this.emailbx.TabIndex = 14;
            this.emailbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SifreYenile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::OgrenciBilgiSistemi.Properties.Resources._942c96af;
            this.ClientSize = new System.Drawing.Size(472, 326);
            this.Controls.Add(this.emailbx);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.öğrenci_radio);
            this.Controls.Add(this.akademisyenradio);
            this.Controls.Add(this.müdür_radio);
            this.Controls.Add(this.tc_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SifreYenile";
            this.Text = "ŞifreYenileme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.RadioButton öğrenci_radio;
        private System.Windows.Forms.RadioButton akademisyenradio;
        private System.Windows.Forms.RadioButton müdür_radio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tc_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailbx;
    }
}