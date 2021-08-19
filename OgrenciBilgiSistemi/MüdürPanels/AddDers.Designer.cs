
namespace OgrenciBilgiSistemi.MüdürPanels
{
    partial class AddDers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDers));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bolumlerdropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.sinifdropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.eklebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dersad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.aktsbx = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(20, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sınıfların yüklenmesi için önce bölüm seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(20, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Bölüm Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(22, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sınıf Seçiniz";
            // 
            // bolumlerdropdown
            // 
            this.bolumlerdropdown.BackColor = System.Drawing.Color.Transparent;
            this.bolumlerdropdown.BorderRadius = 3;
            this.bolumlerdropdown.DisabledColor = System.Drawing.Color.Gray;
            this.bolumlerdropdown.ForeColor = System.Drawing.Color.White;
            this.bolumlerdropdown.items = new string[0];
            this.bolumlerdropdown.Location = new System.Drawing.Point(25, 236);
            this.bolumlerdropdown.Name = "bolumlerdropdown";
            this.bolumlerdropdown.NomalColor = System.Drawing.Color.RoyalBlue;
            this.bolumlerdropdown.onHoverColor = System.Drawing.Color.RoyalBlue;
            this.bolumlerdropdown.selectedIndex = -1;
            this.bolumlerdropdown.Size = new System.Drawing.Size(217, 35);
            this.bolumlerdropdown.TabIndex = 20;
            this.bolumlerdropdown.onItemSelected += new System.EventHandler(this.bolumlerdropdown_onItemSelected);
            // 
            // sinifdropdown
            // 
            this.sinifdropdown.BackColor = System.Drawing.Color.Transparent;
            this.sinifdropdown.BorderRadius = 3;
            this.sinifdropdown.DisabledColor = System.Drawing.Color.Gray;
            this.sinifdropdown.ForeColor = System.Drawing.Color.White;
            this.sinifdropdown.items = new string[0];
            this.sinifdropdown.Location = new System.Drawing.Point(25, 325);
            this.sinifdropdown.Name = "sinifdropdown";
            this.sinifdropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.sinifdropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.sinifdropdown.selectedIndex = -1;
            this.sinifdropdown.Size = new System.Drawing.Size(217, 35);
            this.sinifdropdown.TabIndex = 19;
            this.sinifdropdown.onItemSelected += new System.EventHandler(this.sinifdropdown_onItemSelected);
            // 
            // eklebutton
            // 
            this.eklebutton.Active = false;
            this.eklebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.eklebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.eklebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eklebutton.BorderRadius = 0;
            this.eklebutton.ButtonText = "Ders Ekle";
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
            this.eklebutton.Location = new System.Drawing.Point(366, 356);
            this.eklebutton.Name = "eklebutton";
            this.eklebutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.eklebutton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.eklebutton.OnHoverTextColor = System.Drawing.Color.White;
            this.eklebutton.selected = false;
            this.eklebutton.Size = new System.Drawing.Size(241, 48);
            this.eklebutton.TabIndex = 24;
            this.eklebutton.Text = "Ders Ekle";
            this.eklebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eklebutton.Textcolor = System.Drawing.Color.White;
            this.eklebutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eklebutton.Click += new System.EventHandler(this.eklebutton_Click);
            // 
            // dersad
            // 
            this.dersad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.dersad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.dersad.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.dersad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dersad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dersad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dersad.HintForeColor = System.Drawing.Color.Empty;
            this.dersad.HintText = "Ders Adı Giriniz";
            this.dersad.isPassword = false;
            this.dersad.LineFocusedColor = System.Drawing.Color.Blue;
            this.dersad.LineIdleColor = System.Drawing.Color.Gray;
            this.dersad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.dersad.LineThickness = 3;
            this.dersad.Location = new System.Drawing.Point(25, 51);
            this.dersad.Margin = new System.Windows.Forms.Padding(4);
            this.dersad.MaxLength = 32767;
            this.dersad.Name = "dersad";
            this.dersad.Size = new System.Drawing.Size(293, 33);
            this.dersad.TabIndex = 25;
            this.dersad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // aktsbx
            // 
            this.aktsbx.BackColor = System.Drawing.Color.Transparent;
            this.aktsbx.BorderRadius = 3;
            this.aktsbx.DisabledColor = System.Drawing.Color.Gray;
            this.aktsbx.ForeColor = System.Drawing.Color.White;
            this.aktsbx.items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10"};
            this.aktsbx.Location = new System.Drawing.Point(29, 147);
            this.aktsbx.Name = "aktsbx";
            this.aktsbx.NomalColor = System.Drawing.Color.Tomato;
            this.aktsbx.onHoverColor = System.Drawing.Color.Tomato;
            this.aktsbx.selectedIndex = -1;
            this.aktsbx.Size = new System.Drawing.Size(217, 35);
            this.aktsbx.TabIndex = 26;
            this.aktsbx.onItemSelected += new System.EventHandler(this.aktsbx_onItemSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(22, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ders Adı Giriniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(20, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Akts Seçiniz";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgv.Location = new System.Drawing.Point(325, 70);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(321, 268);
            this.dgv.TabIndex = 29;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(325, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ders Sorumlusu Seçiniz";
            // 
            // AddDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::OgrenciBilgiSistemi.Properties.Resources._942c96af;
            this.ClientSize = new System.Drawing.Size(646, 416);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aktsbx);
            this.Controls.Add(this.dersad);
            this.Controls.Add(this.eklebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bolumlerdropdown);
            this.Controls.Add(this.sinifdropdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddDers";
            this.Text = "AddDers";
            this.Load += new System.EventHandler(this.AddDers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown bolumlerdropdown;
        private Bunifu.Framework.UI.BunifuDropdown sinifdropdown;
        private Bunifu.Framework.UI.BunifuFlatButton eklebutton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox dersad;
        private Bunifu.Framework.UI.BunifuDropdown aktsbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label6;
    }
}