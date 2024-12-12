namespace Petrol_Otomasyon
{
    partial class dgvSubeler
    {
       
        private System.ComponentModel.IContainer components = null;

        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSubeID = new System.Windows.Forms.Label();
            this.txtSubeID = new System.Windows.Forms.TextBox();
            this.lblSubeAdi = new System.Windows.Forms.Label();
            this.txtSubeAdi = new System.Windows.Forms.TextBox();
            this.lblSehir = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.lblFirmaID = new System.Windows.Forms.Label();
            this.txtFirmaID = new System.Windows.Forms.TextBox();
            this.lblSefID = new System.Windows.Forms.Label();
            this.txtSefID = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.petrolOtomasyonDataSet = new Petrol_Otomasyon.petrolOtomasyonDataSet();
            this.subelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subelerTableAdapter = new Petrol_Otomasyon.petrolOtomasyonDataSetTableAdapters.SubelerTableAdapter();
            this.subeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sefIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.btnOpenForm2_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).BeginInit();
            this.SuspendLayout();
            
            this.lblSubeID.AutoSize = true;
            this.lblSubeID.Location = new System.Drawing.Point(26, 32);
            this.lblSubeID.Name = "lblSubeID";
            this.lblSubeID.Size = new System.Drawing.Size(46, 13);
            this.lblSubeID.TabIndex = 0;
            this.lblSubeID.Text = "Şube ID";
             
            this.txtSubeID.Location = new System.Drawing.Point(78, 29);
            this.txtSubeID.Name = "txtSubeID";
            this.txtSubeID.Size = new System.Drawing.Size(156, 20);
            this.txtSubeID.TabIndex = 1;
            
            this.lblSubeAdi.AutoSize = true;
            this.lblSubeAdi.Location = new System.Drawing.Point(22, 67);
            this.lblSubeAdi.Name = "lblSubeAdi";
            this.lblSubeAdi.Size = new System.Drawing.Size(50, 13);
            this.lblSubeAdi.TabIndex = 2;
            this.lblSubeAdi.Text = "Şube Adı";
             
            this.txtSubeAdi.Location = new System.Drawing.Point(78, 64);
            this.txtSubeAdi.Name = "txtSubeAdi";
            this.txtSubeAdi.Size = new System.Drawing.Size(156, 20);
            this.txtSubeAdi.TabIndex = 3;
           
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(41, 100);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(31, 13);
            this.lblSehir.TabIndex = 4;
            this.lblSehir.Text = "Şehir";
            
            this.txtSehir.Location = new System.Drawing.Point(78, 97);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(156, 20);
            this.txtSehir.TabIndex = 5;
            
            this.lblFirmaID.AutoSize = true;
            this.lblFirmaID.Location = new System.Drawing.Point(26, 133);
            this.lblFirmaID.Name = "lblFirmaID";
            this.lblFirmaID.Size = new System.Drawing.Size(46, 13);
            this.lblFirmaID.TabIndex = 6;
            this.lblFirmaID.Text = "Firma ID";
            
            this.txtFirmaID.Location = new System.Drawing.Point(78, 130);
            this.txtFirmaID.Name = "txtFirmaID";
            this.txtFirmaID.Size = new System.Drawing.Size(156, 20);
            this.txtFirmaID.TabIndex = 7;
            
            this.lblSefID.AutoSize = true;
            this.lblSefID.Location = new System.Drawing.Point(35, 169);
            this.lblSefID.Name = "lblSefID";
            this.lblSefID.Size = new System.Drawing.Size(37, 13);
            this.lblSefID.TabIndex = 8;
            this.lblSefID.Text = "Şef ID";
            
            this.txtSefID.Location = new System.Drawing.Point(78, 166);
            this.txtSefID.Name = "txtSefID";
            this.txtSefID.Size = new System.Drawing.Size(156, 20);
            this.txtSefID.TabIndex = 9;
           
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnEkle.Location = new System.Drawing.Point(78, 212);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(156, 37);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Şube Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(78, 277);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(156, 37);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Şube Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
             
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subeIDDataGridViewTextBoxColumn,
            this.subeAdiDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.firmaIDDataGridViewTextBoxColumn,
            this.sefIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subelerBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(575, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 160);
            this.dataGridView1.TabIndex = 12;
            
            this.petrolOtomasyonDataSet.DataSetName = "petrolOtomasyonDataSet";
            this.petrolOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            
            this.subelerBindingSource.DataMember = "Subeler";
            this.subelerBindingSource.DataSource = this.petrolOtomasyonDataSet;
            
            this.subelerTableAdapter.ClearBeforeFill = true;
            
            this.subeIDDataGridViewTextBoxColumn.DataPropertyName = "SubeID";
            this.subeIDDataGridViewTextBoxColumn.HeaderText = "SubeID";
            this.subeIDDataGridViewTextBoxColumn.Name = "subeIDDataGridViewTextBoxColumn";
            this.subeIDDataGridViewTextBoxColumn.ReadOnly = true;
            
            this.subeAdiDataGridViewTextBoxColumn.DataPropertyName = "SubeAdi";
            this.subeAdiDataGridViewTextBoxColumn.HeaderText = "SubeAdi";
            this.subeAdiDataGridViewTextBoxColumn.Name = "subeAdiDataGridViewTextBoxColumn";
            
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            
            this.firmaIDDataGridViewTextBoxColumn.DataPropertyName = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.HeaderText = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.Name = "firmaIDDataGridViewTextBoxColumn";
             
            this.sefIDDataGridViewTextBoxColumn.DataPropertyName = "SefID";
            this.sefIDDataGridViewTextBoxColumn.HeaderText = "SefID";
            this.sefIDDataGridViewTextBoxColumn.Name = "sefIDDataGridViewTextBoxColumn";
           
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(572, 236);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(174, 13);
            this.lblBilgi.TabIndex = 13;
            this.lblBilgi.Text = "Durum mesajları burada görünecek.";
             
            this.btnOpenForm2_Click.Location = new System.Drawing.Point(925, 658);
            this.btnOpenForm2_Click.Name = "btnOpenForm2_Click";
            this.btnOpenForm2_Click.Size = new System.Drawing.Size(174, 61);
            this.btnOpenForm2_Click.TabIndex = 14;
            this.btnOpenForm2_Click.Text = "Pompacı Arayüzü";
            this.btnOpenForm2_Click.UseVisualStyleBackColor = true;
            this.btnOpenForm2_Click.Click += new System.EventHandler(this.btnOpenForm2_Click_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1165, 823);
            this.Controls.Add(this.btnOpenForm2_Click);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSefID);
            this.Controls.Add(this.lblSefID);
            this.Controls.Add(this.txtFirmaID);
            this.Controls.Add(this.lblFirmaID);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.txtSubeAdi);
            this.Controls.Add(this.lblSubeAdi);
            this.Controls.Add(this.txtSubeID);
            this.Controls.Add(this.lblSubeID);
            this.Name = "dgvSubeler";
            this.Text = "Şube Yönetimi";
            this.Load += new System.EventHandler(this.dgvSubeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubeID;
        private System.Windows.Forms.TextBox txtSubeID;
        private System.Windows.Forms.Label lblSubeAdi;
        private System.Windows.Forms.TextBox txtSubeAdi;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.Label lblFirmaID;
        private System.Windows.Forms.TextBox txtFirmaID;
        private System.Windows.Forms.Label lblSefID;
        private System.Windows.Forms.TextBox txtSefID;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private petrolOtomasyonDataSet petrolOtomasyonDataSet;
        private System.Windows.Forms.BindingSource subelerBindingSource;
        private petrolOtomasyonDataSetTableAdapters.SubelerTableAdapter subelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sefIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Button btnOpenForm2_Click;
    }
}

