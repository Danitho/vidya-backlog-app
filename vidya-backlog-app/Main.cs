namespace vidya_backlog_app
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }


        private void ButtonMyList(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();


            MyList list = new()
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                AutoScroll = true
            };

            panelMain.Controls.Add(list);
            list.Show();

            // View data in database
            DBManager.ConnectAndRead(list);
        }

        private void ButtonStats(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            Form myform = new();
            myform.BackColor = Color.Red;
            myform.Dock = DockStyle.Fill;
            myform.FormBorderStyle = FormBorderStyle.None;
            myform.TopLevel = false;
            myform.AutoScroll = true;
            panelMain.Controls.Add(myform);
            myform.Show();
        }

        private void ButtonOptions(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            Form myform = new();
            myform.BackColor = Color.Green;
            myform.Dock = DockStyle.Fill;
            myform.FormBorderStyle = FormBorderStyle.None;
            myform.TopLevel = false;
            myform.AutoScroll = true;
            panelMain.Controls.Add(myform);
            myform.Show();
        }

        private void PanelMain(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}