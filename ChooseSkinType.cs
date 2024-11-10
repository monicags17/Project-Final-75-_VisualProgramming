using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyTrack
{
    public partial class ChooseSkinType : Form
    {
        public ChooseSkinType()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxSkinType.Text == "Normal Skin")
            {
                NormalSkinPage normalSkinPage = new NormalSkinPage();
                normalSkinPage.Show();
                this.Hide();
            }
            else if(comboBoxSkinType.Text == "Dry Skin")
            {
                DrySkinPage drySkinPage = new DrySkinPage();
                drySkinPage.Show();
                this.Hide();
            }
            else if (comboBoxSkinType.Text == "Oily Skin")
            {
                OilySkinPage oilySkinPage = new OilySkinPage();
                oilySkinPage.Show();
                this.Hide();
            }
            else if (comboBoxSkinType.Text == "Sensitive Skin")
            {
                SensitiveSkinPage sensitiveSkinPage = new SensitiveSkinPage();
                sensitiveSkinPage.Show();
                this.Hide();
            }
            else if (comboBoxSkinType.Text == "Combination Skin")
            {
                CombinationSkinPage combinationSkinPage = new CombinationSkinPage();
                combinationSkinPage.Show();
                this.Hide();
            }

        }

        private void labelChooseSkinType_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
