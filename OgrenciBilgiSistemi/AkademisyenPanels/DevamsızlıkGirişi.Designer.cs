
namespace OgrenciBilgiSistemi.AkademisyenPanels
{
    partial class DevamsızlıkGirişi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevamsızlıkGirişi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adsoyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.derslerdrop = new Bunifu.Framework.UI.BunifuDropdown();
            this.ogrencitc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tarihsec = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Devamsızlık Kaydet";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(488, 297);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 24;
            this.bunifuFlatButton1.Text = "Devamsızlık Kaydet";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // adsoyad
            // 
            this.adsoyad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.adsoyad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.adsoyad.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adsoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adsoyad.Enabled = false;
            this.adsoyad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adsoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adsoyad.HintForeColor = System.Drawing.Color.Empty;
            this.adsoyad.HintText = "Seçilen Öğrenci Ad Soyad";
            this.adsoyad.isPassword = false;
            this.adsoyad.LineFocusedColor = System.Drawing.Color.Blue;
            this.adsoyad.LineIdleColor = System.Drawing.Color.Gray;
            this.adsoyad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.adsoyad.LineThickness = 3;
            this.adsoyad.Location = new System.Drawing.Point(408, 173);
            this.adsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.adsoyad.MaxLength = 32767;
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(379, 33);
            this.adsoyad.TabIndex = 23;
            this.adsoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.Location = new System.Drawing.Point(2, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(388, 354);
            this.dgv.TabIndex = 22;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::OgrenciBilgiSistemi.Properties.Resources._942c96af;
            this.label2.Location = new System.Drawing.Point(404, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ders Seçiniz";
            // 
            // derslerdrop
            // 
            this.derslerdrop.BackColor = System.Drawing.Color.Transparent;
            this.derslerdrop.BorderRadius = 3;
            this.derslerdrop.DisabledColor = System.Drawing.Color.Gray;
            this.derslerdrop.ForeColor = System.Drawing.Color.White;
            this.derslerdrop.items = new string[0];
            this.derslerdrop.Location = new System.Drawing.Point(408, 64);
            this.derslerdrop.Name = "derslerdrop";
            this.derslerdrop.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.derslerdrop.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.derslerdrop.selectedIndex = -1;
            this.derslerdrop.Size = new System.Drawing.Size(374, 35);
            this.derslerdrop.TabIndex = 20;
            this.derslerdrop.onItemSelected += new System.EventHandler(this.derslerdrop_onItemSelected);
            // 
            // ogrencitc
            // 
            this.ogrencitc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ogrencitc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ogrencitc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ogrencitc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ogrencitc.Enabled = false;
            this.ogrencitc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ogrencitc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ogrencitc.HintForeColor = System.Drawing.Color.Empty;
            this.ogrencitc.HintText = "Seçilen Öğrenci TC KİMLİK NO";
            this.ogrencitc.isPassword = false;
            this.ogrencitc.LineFocusedColor = System.Drawing.Color.Blue;
            this.ogrencitc.LineIdleColor = System.Drawing.Color.Gray;
            this.ogrencitc.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ogrencitc.LineThickness = 3;
            this.ogrencitc.Location = new System.Drawing.Point(408, 120);
            this.ogrencitc.Margin = new System.Windows.Forms.Padding(4);
            this.ogrencitc.MaxLength = 32767;
            this.ogrencitc.Name = "ogrencitc";
            this.ogrencitc.Size = new System.Drawing.Size(379, 33);
            this.ogrencitc.TabIndex = 19;
            this.ogrencitc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tarihsec
            // 
            this.tarihsec.BackColor = System.Drawing.Color.SeaGreen;
            this.tarihsec.BorderRadius = 0;
            this.tarihsec.ForeColor = System.Drawing.Color.White;
            this.tarihsec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarihsec.FormatCustom = "dd:MM:yyyy";
            this.tarihsec.Location = new System.Drawing.Point(408, 230);
            this.tarihsec.Name = "tarihsec";
            this.tarihsec.Size = new System.Drawing.Size(379, 36);
            this.tarihsec.TabIndex = 25;
            this.tarihsec.Value = new System.DateTime(2021, 8, 24, 0, 34, 24, 397);
            this.tarihsec.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // DevamsızlıkGirişi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::OgrenciBilgiSistemi.Properties.Resources._942c96af;
            this.ClientSize = new System.Drawing.Size(807, 355);
            this.Controls.Add(this.tarihsec);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.derslerdrop);
            this.Controls.Add(this.ogrencitc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DevamsızlıkGirişi";
            this.Text = "Devamsızlık Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adsoyad;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown derslerdrop;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ogrencitc;
        private Bunifu.Framework.UI.BunifuDatepicker tarihsec;
    }
}