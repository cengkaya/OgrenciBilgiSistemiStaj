
namespace OgrenciBilgiSistemi.MüdürPanels
{
    partial class OgrenciListesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciListesi));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.duzenlecolumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.silcolumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pwbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.namebox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tcbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.erkekradio = new System.Windows.Forms.RadioButton();
            this.kadınradio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.duzenlecolumn,
            this.silcolumn});
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgv.Location = new System.Drawing.Point(0, -1);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(705, 412);
            this.dgv.TabIndex = 6;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // duzenlecolumn
            // 
            this.duzenlecolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = "Düzenle";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.duzenlecolumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.duzenlecolumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duzenlecolumn.HeaderText = "Düzenle";
            this.duzenlecolumn.Name = "duzenlecolumn";
            this.duzenlecolumn.ReadOnly = true;
            this.duzenlecolumn.Text = "Seçilen Müdürü Düzenle";
            // 
            // silcolumn
            // 
            this.silcolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "Sil";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.silcolumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.silcolumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silcolumn.HeaderText = "Sil";
            this.silcolumn.Name = "silcolumn";
            this.silcolumn.ReadOnly = true;
            this.silcolumn.Text = "Seçilen Müdürü Sil";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Seçileni Düzenle";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(741, 351);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 11;
            this.bunifuFlatButton1.Text = "Seçileni Düzenle";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pwbox
            // 
            this.pwbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pwbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pwbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pwbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pwbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pwbox.HintForeColor = System.Drawing.Color.Empty;
            this.pwbox.HintText = "ŞİFRE";
            this.pwbox.isPassword = false;
            this.pwbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.pwbox.LineIdleColor = System.Drawing.Color.Gray;
            this.pwbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pwbox.LineThickness = 3;
            this.pwbox.Location = new System.Drawing.Point(728, 202);
            this.pwbox.Margin = new System.Windows.Forms.Padding(4);
            this.pwbox.MaxLength = 32767;
            this.pwbox.Name = "pwbox";
            this.pwbox.Size = new System.Drawing.Size(270, 33);
            this.pwbox.TabIndex = 9;
            this.pwbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // namebox
            // 
            this.namebox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.namebox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.namebox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.namebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.namebox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.namebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.namebox.HintForeColor = System.Drawing.Color.Empty;
            this.namebox.HintText = "AD SOYAD";
            this.namebox.isPassword = false;
            this.namebox.LineFocusedColor = System.Drawing.Color.Blue;
            this.namebox.LineIdleColor = System.Drawing.Color.Gray;
            this.namebox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.namebox.LineThickness = 3;
            this.namebox.Location = new System.Drawing.Point(728, 118);
            this.namebox.Margin = new System.Windows.Forms.Padding(4);
            this.namebox.MaxLength = 32767;
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(270, 33);
            this.namebox.TabIndex = 8;
            this.namebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tcbox
            // 
            this.tcbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tcbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tcbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tcbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcbox.Enabled = false;
            this.tcbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tcbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcbox.HintForeColor = System.Drawing.Color.Empty;
            this.tcbox.HintText = "TC";
            this.tcbox.isPassword = false;
            this.tcbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.tcbox.LineIdleColor = System.Drawing.Color.Gray;
            this.tcbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tcbox.LineThickness = 3;
            this.tcbox.Location = new System.Drawing.Point(728, 38);
            this.tcbox.Margin = new System.Windows.Forms.Padding(4);
            this.tcbox.MaxLength = 32767;
            this.tcbox.Name = "tcbox";
            this.tcbox.Size = new System.Drawing.Size(270, 33);
            this.tcbox.TabIndex = 7;
            this.tcbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(723, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cinsiyet:";
            // 
            // erkekradio
            // 
            this.erkekradio.AutoSize = true;
            this.erkekradio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.erkekradio.Location = new System.Drawing.Point(932, 282);
            this.erkekradio.Name = "erkekradio";
            this.erkekradio.Size = new System.Drawing.Size(66, 23);
            this.erkekradio.TabIndex = 23;
            this.erkekradio.TabStop = true;
            this.erkekradio.Text = "Erkek";
            this.erkekradio.UseVisualStyleBackColor = true;
            this.erkekradio.CheckedChanged += new System.EventHandler(this.erkekradio_CheckedChanged);
            // 
            // kadınradio
            // 
            this.kadınradio.AutoSize = true;
            this.kadınradio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kadınradio.Location = new System.Drawing.Point(837, 282);
            this.kadınradio.Name = "kadınradio";
            this.kadınradio.Size = new System.Drawing.Size(66, 23);
            this.kadınradio.TabIndex = 22;
            this.kadınradio.TabStop = true;
            this.kadınradio.Text = "Kadın";
            this.kadınradio.UseVisualStyleBackColor = true;
            this.kadınradio.CheckedChanged += new System.EventHandler(this.kadınradio_CheckedChanged);
            // 
            // OgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::OgrenciBilgiSistemi.Properties.Resources._942c96af;
            this.ClientSize = new System.Drawing.Size(1011, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.erkekradio);
            this.Controls.Add(this.kadınradio);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.pwbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.tcbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OgrenciListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciListesi";
            this.Load += new System.EventHandler(this.OgrenciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewButtonColumn duzenlecolumn;
        private System.Windows.Forms.DataGridViewButtonColumn silcolumn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pwbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox namebox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tcbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton erkekradio;
        private System.Windows.Forms.RadioButton kadınradio;
    }
}