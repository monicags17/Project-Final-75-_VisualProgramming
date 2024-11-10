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
    public partial class DrySkinPage : Form
    {
        public DrySkinPage()
        {
            InitializeComponent();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void buttonBackDrySkin_Click(object sender, EventArgs e)
        {
            ChooseSkinType chooseSkinType = new ChooseSkinType();
            chooseSkinType.Show();
            this.Hide();
        }
    }
}
