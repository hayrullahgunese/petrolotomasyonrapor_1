namespace Petrol_Otomasyon
{
    partial class PompaciArayüzü
    {
        
        private System.ComponentModel.IContainer components = null;

        
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

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.cboYakitTuru = new System.Windows.Forms.ComboBox();
            this.txtPompaID = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.cboOdemeTuru = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSatisTamamla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.yakitSatislariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolOtomasyonDataSet = new Petrol_Otomasyon.PetrolOtomasyonDataSet();
            this.yakitSatislariTableAdapter = new Petrol_Otomasyon.PetrolOtomasyonDataSetTableAdapters.YakitSatislariTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.petrolOtomasyonDataSet1 = new Petrol_Otomasyon.PetrolOtomasyonDataSet1();
            this.yakitSatislariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yakitSatislariTableAdapter1 = new Petrol_Otomasyon.PetrolOtomasyonDataSet1TableAdapters.YakitSatislariTableAdapter();
            this.satisIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pompaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitSatislariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitSatislariBindingSource1)).BeginInit();
            this.SuspendLayout();
            
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yakıt Satışı İşlemi";
             
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plaka ";
            
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yakıt Türü";
            
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pompa ID";
            
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Personel ID";
             
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Miktar (Litre)";
            
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tutar";
            
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ödeme Türü";
           
            this.txtPlaka.Location = new System.Drawing.Point(82, 67);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(120, 20);
            this.txtPlaka.TabIndex = 8;
            
            this.cboYakitTuru.FormattingEnabled = true;
            this.cboYakitTuru.Location = new System.Drawing.Point(82, 97);
            this.cboYakitTuru.Name = "cboYakitTuru";
            this.cboYakitTuru.Size = new System.Drawing.Size(120, 21);
            this.cboYakitTuru.TabIndex = 9;
            
            this.txtPompaID.Location = new System.Drawing.Point(82, 128);
            this.txtPompaID.Name = "txtPompaID";
            this.txtPompaID.Size = new System.Drawing.Size(120, 20);
            this.txtPompaID.TabIndex = 10;
            
            this.txtPersonelID.Location = new System.Drawing.Point(82, 160);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(120, 20);
            this.txtPersonelID.TabIndex = 11;
            
            this.nudMiktar.Location = new System.Drawing.Point(82, 190);
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(120, 20);
            this.nudMiktar.TabIndex = 12;
            
            this.txtTutar.Location = new System.Drawing.Point(82, 220);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(120, 20);
            this.txtTutar.TabIndex = 13;
             
            this.cboOdemeTuru.FormattingEnabled = true;
            this.cboOdemeTuru.Location = new System.Drawing.Point(82, 250);
            this.cboOdemeTuru.Name = "cboOdemeTuru";
            this.cboOdemeTuru.Size = new System.Drawing.Size(120, 21);
            this.cboOdemeTuru.TabIndex = 14;
             
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 286);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker1.TabIndex = 15;
            
            this.btnSatisTamamla.Location = new System.Drawing.Point(85, 324);
            this.btnSatisTamamla.Name = "btnSatisTamamla";
            this.btnSatisTamamla.Size = new System.Drawing.Size(116, 20);
            this.btnSatisTamamla.TabIndex = 16;
            this.btnSatisTamamla.Text = "Satışı Tamamla";
            this.btnSatisTamamla.UseVisualStyleBackColor = true;
            this.btnSatisTamamla.Click += new System.EventHandler(this.btnSatisTamamla_Click);
             
            this.btnTemizle.Location = new System.Drawing.Point(85, 350);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(116, 20);
            this.btnTemizle.TabIndex = 17;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            
            this.btnCikis.Location = new System.Drawing.Point(86, 376);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(116, 20);
            this.btnCikis.TabIndex = 18;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            
            this.yakitSatislariBindingSource.DataMember = "YakitSatislari";
            this.yakitSatislariBindingSource.DataSource = this.petrolOtomasyonDataSet;
            
            this.petrolOtomasyonDataSet.DataSetName = "PetrolOtomasyonDataSet";
            this.petrolOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            
            this.yakitSatislariTableAdapter.ClearBeforeFill = true;
            
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satisIDDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.yakitIDDataGridViewTextBoxColumn,
            this.pompaIDDataGridViewTextBoxColumn,
            this.personelIDDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn,
            this.odemeTuruDataGridViewTextBoxColumn,
            this.satisTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yakitSatislariBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 422);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(953, 203);
            this.dataGridView1.TabIndex = 19;
           
            this.petrolOtomasyonDataSet1.DataSetName = "PetrolOtomasyonDataSet1";
            this.petrolOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            
            this.yakitSatislariBindingSource1.DataMember = "YakitSatislari";
            this.yakitSatislariBindingSource1.DataSource = this.petrolOtomasyonDataSet1;
            
            this.yakitSatislariTableAdapter1.ClearBeforeFill = true;
             
            this.satisIDDataGridViewTextBoxColumn.DataPropertyName = "SatisID";
            this.satisIDDataGridViewTextBoxColumn.HeaderText = "SatisID";
            this.satisIDDataGridViewTextBoxColumn.Name = "satisIDDataGridViewTextBoxColumn";
            this.satisIDDataGridViewTextBoxColumn.ReadOnly = true;
            
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            
            this.yakitIDDataGridViewTextBoxColumn.DataPropertyName = "YakitID";
            this.yakitIDDataGridViewTextBoxColumn.HeaderText = "YakitID";
            this.yakitIDDataGridViewTextBoxColumn.Name = "yakitIDDataGridViewTextBoxColumn";
            
            this.pompaIDDataGridViewTextBoxColumn.DataPropertyName = "PompaID";
            this.pompaIDDataGridViewTextBoxColumn.HeaderText = "PompaID";
            this.pompaIDDataGridViewTextBoxColumn.Name = "pompaIDDataGridViewTextBoxColumn";
            
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
             
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
           
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "Tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "Tutar";
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
             
            this.odemeTuruDataGridViewTextBoxColumn.DataPropertyName = "OdemeTuru";
            this.odemeTuruDataGridViewTextBoxColumn.HeaderText = "OdemeTuru";
            this.odemeTuruDataGridViewTextBoxColumn.Name = "odemeTuruDataGridViewTextBoxColumn";
            
            this.satisTarihiDataGridViewTextBoxColumn.DataPropertyName = "SatisTarihi";
            this.satisTarihiDataGridViewTextBoxColumn.HeaderText = "SatisTarihi";
            this.satisTarihiDataGridViewTextBoxColumn.Name = "satisTarihiDataGridViewTextBoxColumn";
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 811);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSatisTamamla);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cboOdemeTuru);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtPompaID);
            this.Controls.Add(this.cboYakitTuru);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PompaciArayüzü";
            this.Text = "PompaciArayüzü";
            this.Load += new System.EventHandler(this.PompaciArayüzü_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitSatislariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitSatislariBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.ComboBox cboYakitTuru;
        private System.Windows.Forms.TextBox txtPompaID;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ComboBox cboOdemeTuru;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSatisTamamla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCikis;
        private PetrolOtomasyonDataSet petrolOtomasyonDataSet;
        private System.Windows.Forms.BindingSource yakitSatislariBindingSource;
        private PetrolOtomasyonDataSetTableAdapters.YakitSatislariTableAdapter yakitSatislariTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PetrolOtomasyonDataSet1 petrolOtomasyonDataSet1;
        private System.Windows.Forms.BindingSource yakitSatislariBindingSource1;
        private PetrolOtomasyonDataSet1TableAdapters.YakitSatislariTableAdapter yakitSatislariTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pompaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisTarihiDataGridViewTextBoxColumn;
    }
}