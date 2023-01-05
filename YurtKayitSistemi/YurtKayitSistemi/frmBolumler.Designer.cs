
namespace YurtKayitSistemi
{
    partial class frmBolumler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBolumler));
            this.pcbEkle = new System.Windows.Forms.PictureBox();
            this.pcbSil = new System.Windows.Forms.PictureBox();
            this.pcbDuzenle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolumId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayitDataSet = new YurtKayitSistemi.YurtKayitDataSet();
            this.bolumlerTableAdapter = new YurtKayitSistemi.YurtKayitDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbEkle
            // 
            this.pcbEkle.Image = ((System.Drawing.Image)(resources.GetObject("pcbEkle.Image")));
            this.pcbEkle.Location = new System.Drawing.Point(494, 14);
            this.pcbEkle.Name = "pcbEkle";
            this.pcbEkle.Size = new System.Drawing.Size(100, 50);
            this.pcbEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEkle.TabIndex = 0;
            this.pcbEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbEkle, "Bölüm Ekle");
            this.pcbEkle.Click += new System.EventHandler(this.pcbEkle_Click);
            // 
            // pcbSil
            // 
            this.pcbSil.Image = ((System.Drawing.Image)(resources.GetObject("pcbSil.Image")));
            this.pcbSil.Location = new System.Drawing.Point(613, 14);
            this.pcbSil.Name = "pcbSil";
            this.pcbSil.Size = new System.Drawing.Size(100, 50);
            this.pcbSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSil.TabIndex = 0;
            this.pcbSil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbSil, "Bölüm Sil");
            this.pcbSil.Click += new System.EventHandler(this.pcbSil_Click);
            // 
            // pcbDuzenle
            // 
            this.pcbDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("pcbDuzenle.Image")));
            this.pcbDuzenle.Location = new System.Drawing.Point(552, 70);
            this.pcbDuzenle.Name = "pcbDuzenle";
            this.pcbDuzenle.Size = new System.Drawing.Size(100, 50);
            this.pcbDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDuzenle.TabIndex = 0;
            this.pcbDuzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbDuzenle, "Bölüm Güncelle");
            this.pcbDuzenle.Click += new System.EventHandler(this.pcbDuzenle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölüm Id:";
            // 
            // txtBolumId
            // 
            this.txtBolumId.Enabled = false;
            this.txtBolumId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumId.Location = new System.Drawing.Point(144, 12);
            this.txtBolumId.Name = "txtBolumId";
            this.txtBolumId.Size = new System.Drawing.Size(263, 30);
            this.txtBolumId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölüm Ad:";
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumAd.Location = new System.Drawing.Point(144, 66);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(263, 30);
            this.txtBolumAd.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIDDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 440);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            this.bolumIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtKayitDataSet;
            // 
            // yurtKayitDataSet
            // 
            this.yurtKayitDataSet.DataSetName = "YurtKayitDataSet";
            this.yurtKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1039, 622);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.txtBolumId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbDuzenle);
            this.Controls.Add(this.pcbSil);
            this.Controls.Add(this.pcbEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.frmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbEkle;
        private System.Windows.Forms.PictureBox pcbSil;
        private System.Windows.Forms.PictureBox pcbDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolumId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayitDataSet yurtKayitDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtKayitDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}