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
    public partial class MyList : Form
    {
        public MyList()
        {
            InitializeComponent();
            // Removes the blue highlight in the first row
            dgv.DefaultCellStyle.SelectionBackColor = Color.White;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Makes the rows change in size dynamically when resizing window
            dgv.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Adds word wrap for the notes column

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void MyList_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGame window = new();
            window.Show();
        }
    }
}
