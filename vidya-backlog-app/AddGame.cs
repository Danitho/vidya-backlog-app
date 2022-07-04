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
            if(cbStatus.SelectedIndex == 0 || cbStatus.SelectedIndex == 1)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string title = txbTitle.Text.Trim();
            string genre = txbGenre.Text.Trim();
            string platform = txbPlatform.Text.Trim();
            string status = cbStatus.Text.ToString();
            int rating = Int32.Parse(lblRatingNum.Text.Trim());
            string notes = txbNotes.Text.Trim();
            DBManager.Write(title, genre, platform, status, rating, notes);

            // Now clear the fields (gonna make this into another function in the near future)
            txbTitle.Clear();
            txbGenre.Clear();
            txbPlatform.Clear();
            lblRatingNum.Text = "0";
            txbNotes.Clear();

            // Need to also refresh the datagrid to show the latest added game
            // [To be implemented...]

            MessageBox.Show("Game added!");
            
        }
    }
}
