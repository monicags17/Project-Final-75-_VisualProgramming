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
    public partial class OilySkinPage : Form
    {
        public OilySkinPage()
        {
            InitializeComponent();
        }

        private void buttonBackOilySkin_Click(object sender, EventArgs e)
        {
            ChooseSkinType chooseSkinType = new ChooseSkinType();
            chooseSkinType.Show();
            this.Hide();
        }
    }
}
