using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BeautyTrack
{
    public partial class LoginPage : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public LoginPage()
        {
            alamat = "server=localhost; database=db_beautytrack; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxLoginPage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (comboBoxLoginPage.Text == "Login User")
            {
                try
                {
                    koneksi.Open();
                    query = string.Format("select * from user where username = '{0}'", textBoxUsername.Text);
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    ds.Clear();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {
                            string sandi;
                            sandi = kolom["password"].ToString();
                            if (sandi == textBoxPassword.Text)
                            {
                                AccessPage accessPage = new AccessPage();
                                accessPage.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Anda salah input password");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Username tidak ditemukan");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            else if (comboBoxLoginPage.Text == "Login Admin")
            {
                try
                {
                    query = string.Format("select * from admin where username = '{0}'", textBoxUsername.Text);
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
                            string sandi;
                            sandi = kolom["password"].ToString();
                            if (sandi == textBoxPassword.Text)
                            {
                                InputProdukAdmin adminPage = new InputProdukAdmin();
                                adminPage.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Anda salah input password");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Username tidak ditemukan");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            else
            {
                MessageBox.Show("Silahkan pilih role");
            }

                   

        }
    }
}
