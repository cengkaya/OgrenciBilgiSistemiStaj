﻿
namespace OgrenciBilgiSistemi.AkademisyenPanels
{
    partial class Not_Girişi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Not_Girişi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vize = new System.Windows.Forms.RadioButton();
            this.final = new System.Windows.Forms.RadioButton();
            this.bütünleme = new System.Windows.Forms.RadioButton();
            this.not = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ogrencitc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.derslerdrop = new Bunifu.Framework.UI.BunifuDropdown();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.adsoyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // vize
            // 
            this.vize.AutoSize = true;
            this.vize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vize.BackgroundImage")));
            this.vize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vize.ForeColor = System.Drawing.Color.White;
            this.vize.Location = new System.Drawing.Point(398, 199);
            this.vize.Name = "vize";
            this.vize.Size = new System.Drawing.Size(72, 29);
            this.vize.TabIndex = 2;
            this.vize.TabStop = true;
            this.vize.Text = "Vize";
            this.vize.UseVisualStyleBackColor = true;
            this.vize.CheckedChanged += new System.EventHandler(this.vize_CheckedChanged);
            // 
            // final
            // 
            this.final.AutoSize = true;
            this.final.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("final.BackgroundImage")));
            this.final.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.final.ForeColor = System.Drawing.Color.White;
            this.final.Location = new System.Drawing.Point(526, 199);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(77, 29);
            this.final.TabIndex = 3;
            this.final.TabStop = true;
            this.final.Text = "Final";
            this.final.UseVisualStyleBackColor = true;
            this.final.CheckedChanged += new System.EventHandler(this.final_CheckedChanged);
            // 
            // bütünleme
            // 
            this.bütünleme.AutoSize = true;
            this.bütünleme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bütünleme.BackgroundImage")));
            this.bütünleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bütünleme.ForeColor = System.Drawing.Color.White;
            this.bütünleme.Location = new System.Drawing.Point(637, 199);
            this.bütünleme.Name = "bütünleme";
            this.bütünleme.Size = new System.Drawing.Size(132, 29);
            this.bütünleme.TabIndex = 4;
            this.bütünleme.TabStop = true;
            this.bütünleme.Text = "Bütünleme";
            this.bütünleme.UseVisualStyleBackColor = true;
            this.bütünleme.CheckedChanged += new System.EventHandler(this.bütünleme_CheckedChanged);
            // 
            // not
            // 
            this.not.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.not.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.not.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.not.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.not.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.not.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.not.HintForeColor = System.Drawing.Color.Empty;
            this.not.HintText = "Not Giriniz 0-100";
            this.not.isPassword = false;
            this.not.LineFocusedColor = System.Drawing.Color.Blue;
            this.not.LineIdleColor = System.Drawing.Color.Gray;
            this.not.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.not.LineThickness = 3;
            this.not.Location = new System.Drawing.Point(395, 251);
            this.not.Margin = new System.Windows.Forms.Padding(4);
            this.not.MaxLength = 32767;
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(379, 33);
            this.not.TabIndex = 5;
            this.not.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.ogrencitc.Location = new System.Drawing.Point(395, 106);
            this.ogrencitc.Margin = new System.Windows.Forms.Padding(4);
            this.ogrencitc.MaxLength = 32767;
            this.ogrencitc.Name = "ogrencitc";
            this.ogrencitc.Size = new System.Drawing.Size(379, 33);
            this.ogrencitc.TabIndex = 7;
            this.ogrencitc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::OgrenciBilgiSistemi.Properties.Resources._942c96af;
            this.label2.Location = new System.Drawing.Point(391, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ders Seçiniz";
            // 
            // derslerdrop
            // 
            this.derslerdrop.BackColor = System.Drawing.Color.Transparent;
            this.derslerdrop.BorderRadius = 3;
            this.derslerdrop.DisabledColor = System.Drawing.Color.Gray;
            this.derslerdrop.ForeColor = System.Drawing.Color.White;
            this.derslerdrop.items = new string[0];
            this.derslerdrop.Location = new System.Drawing.Point(395, 50);
            this.derslerdrop.Name = "derslerdrop";
            this.derslerdrop.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.derslerdrop.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.derslerdrop.selectedIndex = -1;
            this.derslerdrop.Size = new System.Drawing.Size(374, 35);
            this.derslerdrop.TabIndex = 10;
            this.derslerdrop.onItemSelected += new System.EventHandler(this.derslerdrop_onItemSelected);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.Location = new System.Drawing.Point(-1, -2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(378, 372);
            this.dgv.TabIndex = 12;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
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
            this.adsoyad.Location = new System.Drawing.Point(395, 159);
            this.adsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.adsoyad.MaxLength = 32767;
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(379, 33);
            this.adsoyad.TabIndex = 13;
            this.adsoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Notu Kaydet";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(470, 307);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 14;
            this.bunifuFlatButton1.Text = "Notu Kaydet";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Not_Girişi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::OgrenciBilgiSistemi.Properties.Resources._942c96af;
            this.ClientSize = new System.Drawing.Size(828, 367);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.derslerdrop);
            this.Controls.Add(this.ogrencitc);
            this.Controls.Add(this.not);
            this.Controls.Add(this.bütünleme);
            this.Controls.Add(this.final);
            this.Controls.Add(this.vize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Not_Girişi";
            this.Text = "Not_Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton vize;
        private System.Windows.Forms.RadioButton final;
        private System.Windows.Forms.RadioButton bütünleme;
        private Bunifu.Framework.UI.BunifuMaterialTextbox not;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ogrencitc;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown derslerdrop;
        private System.Windows.Forms.DataGridView dgv;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adsoyad;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}