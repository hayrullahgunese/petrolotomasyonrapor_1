using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol_Otomasyon
{
    public partial class PompaciArayüzü : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8FACNE8;Initial Catalog=PetrolOtomasyon;Integrated Security=True");

        public PompaciArayüzü()
        {
            InitializeComponent();
        }

        private void PompaciArayüzü_Load(object sender, EventArgs e)
        {
            // Yakıt türü ve ödeme türü ComboBox'larını doldur
            cboYakitTuru.Items.Add("Benzin");
            cboYakitTuru.Items.Add("Motorin");
            cboYakitTuru.Items.Add("LPG");

            cboOdemeTuru.Items.Add("Nakit");
            cboOdemeTuru.Items.Add("Kredi Kartı");
            cboOdemeTuru.Items.Add("Çek");

            // Satışları yükle
            LoadSalesData();
        }

        private void LoadSalesData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM YakitSatislari";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnSatisTamamla_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO YakitSatislari (Plaka, YakitID, PompaID, PersonelID, Miktar, Tutar, OdemeTuru, SatisTarihi) " +
                                   "VALUES (@Plaka, @YakitID, @PompaID, @PersonelID, @Miktar, @Tutar, @OdemeTuru, @SatisTarihi)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                    command.Parameters.AddWithValue("@YakitID", cboYakitTuru.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@PompaID", txtPompaID.Text);
                    command.Parameters.AddWithValue("@PersonelID", txtPersonelID.Text);
                    command.Parameters.AddWithValue("@Miktar", nudMiktar.Value);
                    command.Parameters.AddWithValue("@Tutar", Convert.ToDecimal(txtTutar.Text));
                    command.Parameters.AddWithValue("@OdemeTuru", cboOdemeTuru.Text);
                    command.Parameters.AddWithValue("@SatisTarihi", DateTime.Now);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Satış başarıyla kaydedildi!");

                    ClearForm();
                    LoadSalesData(); // Yeni satış sonrası DataGridView güncelleniyor
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Satış eklenirken hata oluştu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtPlaka.Text) ||
                cboYakitTuru.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtPompaID.Text) ||
                string.IsNullOrWhiteSpace(txtPersonelID.Text) ||
                nudMiktar.Value <= 0 ||
                string.IsNullOrWhiteSpace(txtTutar.Text) ||
                cboOdemeTuru.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtPlaka.Clear();
            cboYakitTuru.SelectedIndex = -1;
            txtPompaID.Clear();
            txtPersonelID.Clear();
            nudMiktar.Value = 0;
            txtTutar.Clear();
            cboOdemeTuru.SelectedIndex = -1;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearForm(); // Temizleme işlemini tekrar etmemek için ClearForm() çağrılıyor

            MessageBox.Show("Form temizlendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?",
                                                  "Çıkış",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
