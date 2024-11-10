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
    public partial class CombinationSkinPage : Form
    {
        public CombinationSkinPage()
        {
            InitializeComponent();
        }

        private void CombinationSkinPage_Load(object sender, EventArgs e)
        {

        }

        private void buttonBackCombinationSkin_Click(object sender, EventArgs e)
        {
            ChooseSkinType chooseSkinType = new ChooseSkinType();
            chooseSkinType.Show();
            this.Hide();
        }
    }
}
