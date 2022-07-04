using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidya_backlog_app
{
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblRatingNum.Text = tbRating.Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                tbRating.Enabled = false;
                lblRating.ForeColor = Color.Gray;
                lblRatingNum.ForeColor = Color.Gray;
            }
            else
            {
                tbRating.Enabled = true;
                lblRating.ForeColor = Color.Black;
                lblRatingNum.ForeColor = Color.Black;
            }
        }
    }
}
