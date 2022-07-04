namespace vidya_backlog_app
{
    partial class AddGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRatingNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txbNotes = new System.Windows.Forms.TextBox();
            this.tbRating = new System.Windows.Forms.TrackBar();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txbPlatform = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txbGenre = new System.Windows.Forms.TextBox();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRating)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRatingNum);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txbNotes);
            this.panel1.Controls.Add(this.tbRating);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.txbPlatform);
            this.panel1.Controls.Add(this.lblNotes);
            this.panel1.Controls.Add(this.lblRating);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblPlatform);
            this.panel1.Controls.Add(this.lblGenre);
            this.panel1.Controls.Add(this.txbGenre);
            this.panel1.Controls.Add(this.txbTitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 455);
            this.panel1.TabIndex = 0;
            // 
            // lblRatingNum
            // 
            this.lblRatingNum.AutoSize = true;
            this.lblRatingNum.Location = new System.Drawing.Point(189, 180);
            this.lblRatingNum.Name = "lblRatingNum";
            this.lblRatingNum.Size = new System.Drawing.Size(13, 15);
            this.lblRatingNum.TabIndex = 13;
            this.lblRatingNum.Text = "0";
            this.lblRatingNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(32, 268);
            this.txbNotes.Multiline = true;
            this.txbNotes.Name = "txbNotes";
            this.txbNotes.Size = new System.Drawing.Size(259, 115);
            this.txbNotes.TabIndex = 11;
            // 
            // tbRating
            // 
            this.tbRating.Location = new System.Drawing.Point(79, 180);
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(104, 45);
            this.tbRating.TabIndex = 10;
            this.tbRating.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Planned",
            "Ready",
            "Playing",
            "Completed",
            "On Hold",
            "Dropped"});
            this.cbStatus.Location = new System.Drawing.Point(79, 137);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 23);
            this.cbStatus.TabIndex = 9;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txbPlatform
            // 
            this.txbPlatform.Location = new System.Drawing.Point(79, 95);
            this.txbPlatform.Name = "txbPlatform";
            this.txbPlatform.Size = new System.Drawing.Size(148, 23);
            this.txbPlatform.TabIndex = 8;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(32, 250);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 15);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "Notes";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(32, 180);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(41, 15);
            this.lblRating.TabIndex = 6;
            this.lblRating.Text = "Rating";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(34, 140);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(20, 98);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(53, 15);
            this.lblPlatform.TabIndex = 4;
            this.lblPlatform.Text = "Platform";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(35, 59);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(38, 15);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre";
            // 
            // txbGenre
            // 
            this.txbGenre.Location = new System.Drawing.Point(79, 56);
            this.txbGenre.Name = "txbGenre";
            this.txbGenre.Size = new System.Drawing.Size(148, 23);
            this.txbGenre.TabIndex = 2;
            this.txbGenre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(79, 22);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(186, 23);
            this.txbTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(44, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(29, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 455);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddGame";
            this.Text = "AddGame";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblNotes;
        private Label lblRating;
        private Label lblStatus;
        private Label lblPlatform;
        private Label lblGenre;
        private TextBox txbGenre;
        private TextBox txbTitle;
        private Label lblTitle;
        private Button button1;
        private TextBox txbNotes;
        private TrackBar tbRating;
        private ComboBox cbStatus;
        private TextBox txbPlatform;
        private Label lblRatingNum;
    }
}