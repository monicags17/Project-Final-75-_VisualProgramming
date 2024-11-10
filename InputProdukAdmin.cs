using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyTrack
{
    public partial class InputProdukAdmin : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public InputProdukAdmin()
        {
            alamat = "server=localhost; database=db_beautytrack; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void InputProdukAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_produk_admin");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "Nama Produk";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "Harga";
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[2].HeaderText = "Jenis Kulit";
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[3].HeaderText = "Jenis Skincare";
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[4].HeaderText = "Kandungan utama & manfaatnya";

                textBoxNamaProduk.Clear();
                textBoxHarga.Clear();
                textBoxKandunganManfaat.Clear();
                textBoxNamaProduk.Focus();
                buttonUpload.Enabled = false;
                buttonDelete.Enabled = false;
                buttonClear.Enabled = false;
                buttonSave.Enabled = true;
                buttonSearch.Enabled = true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxHarga.Text != "")
                {
                    query = string.Format("select * from tbl_produk_admin where harga = '{0}'", textBoxHarga);
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {
                            textBoxNamaProduk.Text = kolom["nama_produk"].ToString();
                            comboBoxJenisKulit.Text = kolom["jenis_kulit"].ToString();
                            comboBoxJenisSkincare.Text = kolom["jenis_skincare"].ToString();
                            textBoxKandunganManfaat.Text = kolom["kandungan_manfaat"].ToString();
                            string fileName = kolom["foto"].ToString();

                            string folderPath = Path.Combine(Application.StartupPath, "C:\\Users\\ASUS\\source\\repos\\KoneksiDatabase\\foto");
                            string filePath = Path.Combine(folderPath, fileName);

                            // Cek apakah file foto ada
                            if (File.Exists(filePath))
                            {
                                // Tampilkan gambar di PictureBox
                                pictureBox2.Image = Image.FromFile(filePath);
                                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                            else
                            {
                                MessageBox.Show("File gambar tidak ditemukan.");
                            }



                        }

                        dataGridView1.DataSource = ds.Tables[0];
                        buttonSave.Enabled = false;
                        buttonUpload.Enabled = true;
                        buttonDelete.Enabled = true;
                        buttonSearch.Enabled = false;
                        buttonClear.Enabled = true;
                        buttonUpload.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        InputProdukAdmin_Load(null, null);
                    }

                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog2.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            labelChoosePhoto.Visible = false;
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog2.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            buttonUpload.Visible = false;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                InputProdukAdmin_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNamaProduk.Text != "")
                {
                    if (MessageBox.Show("Anda Yakin Menghapus Data Ini ??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        query = string.Format("Delete from tbl_input_produk where id_pengguna = '{0}'", textBoxNamaProduk.Text);
                        ds.Clear();
                        koneksi.Open();
                        perintah = new MySqlCommand(query, koneksi);
                        adapter = new MySqlDataAdapter(perintah);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();
                        if (res == 1)
                        {
                            MessageBox.Show("Delete Data Suksess ...");
                        }
                        else
                        {
                            MessageBox.Show("Gagal Delete data");
                        }
                    }
                    InputProdukAdmin_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBoxKandunganManfaat_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxHarga.Text != "" && comboBoxJenisKulit.Text != "" && comboBoxJenisSkincare.Text != "" && pictureBox2.Image != null)
                {
                    // Tentukan folder tempat menyimpan gambar
                    string folderPath = Path.Combine(Application.StartupPath, "C:\\Users\\ASUS\\source\\repos\\KoneksiDatabase\\foto");

                    // Pastikan folder ada, jika tidak, buat folder
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    // Membuat nama unik untuk file gambar agar tidak tertimpa
                    string fileName = Guid.NewGuid().ToString() + ".jpg";
                    string filePath = Path.Combine(folderPath, fileName);

                    // Simpan gambar dari PictureBox ke folder
                    pictureBox2.Image.Save(filePath);


                    query = string.Format("insert into tbl_input_produk  values ('{0}','{1}','{2}','{3}','{4}', '{5}');", textBoxNamaProduk.Text, textBoxHarga.Text, comboBoxJenisKulit.Text, comboBoxJenisSkincare.Text, textBoxKandunganManfaat.Text, fileName);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        InputProdukAdmin_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal Insert Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
