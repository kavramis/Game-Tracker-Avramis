namespace GameTracker
{
    partial class LoadResults
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadResults));
            this.LoadSteamBtn = new System.Windows.Forms.Button();
            this.HtmlResultsBox = new System.Windows.Forms.RichTextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SteamGamesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.pageSpinner = new System.Windows.Forms.NumericUpDown();
            this.LoadIGbtn = new System.Windows.Forms.Button();
            this.igDataGridView = new System.Windows.Forms.DataGridView();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.prefCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.user_Type_of_gamesTableAdapter1 = new GameTracker.GameTracke_DatabaseDataSetTableAdapters.User_Type_of_gamesTableAdapter();
            this.LoadPrefs = new System.Windows.Forms.Button();
            this.WatchListComboBox = new System.Windows.Forms.ComboBox();
            this.watchListTableAdapter1 = new GameTracker.GameTracke_DatabaseDataSetTableAdapters.WatchListTableAdapter();
            this.LoadWatchListBtn = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openPrefList = new System.Windows.Forms.Button();
            this.GoToPreferences = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SteamGamesDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadSteamBtn
            // 
            this.LoadSteamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadSteamBtn.ForeColor = System.Drawing.Color.Cyan;
            this.LoadSteamBtn.Location = new System.Drawing.Point(3, 3);
            this.LoadSteamBtn.Name = "LoadSteamBtn";
            this.LoadSteamBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadSteamBtn.TabIndex = 1;
            this.LoadSteamBtn.Text = "Load Steam";
            this.LoadSteamBtn.UseVisualStyleBackColor = true;
            this.LoadSteamBtn.Click += new System.EventHandler(this.LoadSteamBtn_Click);
            // 
            // HtmlResultsBox
            // 
            this.HtmlResultsBox.Location = new System.Drawing.Point(265, 314);
            this.HtmlResultsBox.Name = "HtmlResultsBox";
            this.HtmlResultsBox.Size = new System.Drawing.Size(309, 175);
            this.HtmlResultsBox.TabIndex = 4;
            this.HtmlResultsBox.Text = "";
            // 
            // SearchBox
            // 
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Location = new System.Drawing.Point(3, 61);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(84, 13);
            this.SearchBox.TabIndex = 5;
            // 
            // SteamGamesDataGridView1
            // 
            this.SteamGamesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SteamGamesDataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.SteamGamesDataGridView1.Location = new System.Drawing.Point(265, 32);
            this.SteamGamesDataGridView1.Name = "SteamGamesDataGridView1";
            this.SteamGamesDataGridView1.Size = new System.Drawing.Size(309, 260);
            this.SteamGamesDataGridView1.TabIndex = 6;
            this.SteamGamesDataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SteamGamesDataGridView1_CellDoubleClick);
            // 
            // pageSpinner
            // 
            this.pageSpinner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pageSpinner.Location = new System.Drawing.Point(0, 87);
            this.pageSpinner.Name = "pageSpinner";
            this.pageSpinner.Size = new System.Drawing.Size(120, 16);
            this.pageSpinner.TabIndex = 7;
            this.pageSpinner.ValueChanged += new System.EventHandler(this.pageSpinner_ValueChanged);
            // 
            // LoadIGbtn
            // 
            this.LoadIGbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadIGbtn.ForeColor = System.Drawing.Color.Cyan;
            this.LoadIGbtn.Location = new System.Drawing.Point(3, 32);
            this.LoadIGbtn.Name = "LoadIGbtn";
            this.LoadIGbtn.Size = new System.Drawing.Size(75, 23);
            this.LoadIGbtn.TabIndex = 8;
            this.LoadIGbtn.Text = "Load IG";
            this.LoadIGbtn.UseVisualStyleBackColor = true;
            this.LoadIGbtn.Click += new System.EventHandler(this.LoadIGbtn_Click);
            // 
            // igDataGridView
            // 
            this.igDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.igDataGridView.Location = new System.Drawing.Point(615, 32);
            this.igDataGridView.Name = "igDataGridView";
            this.igDataGridView.Size = new System.Drawing.Size(319, 260);
            this.igDataGridView.TabIndex = 9;
            this.igDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.igDataGridView_CellDoubleClick);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.ForeColor = System.Drawing.Color.Cyan;
            this.welcomeLabel.Location = new System.Drawing.Point(3, 123);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(35, 13);
            this.welcomeLabel.TabIndex = 10;
            this.welcomeLabel.Text = "label1";
            // 
            // prefCategoryComboBox
            // 
            this.prefCategoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prefCategoryComboBox.FormattingEnabled = true;
            this.prefCategoryComboBox.Location = new System.Drawing.Point(679, 314);
            this.prefCategoryComboBox.Name = "prefCategoryComboBox";
            this.prefCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.prefCategoryComboBox.TabIndex = 12;
            this.prefCategoryComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.prefCategoryComboBox_MouseClick);
            // 
            // user_Type_of_gamesTableAdapter1
            // 
            this.user_Type_of_gamesTableAdapter1.ClearBeforeFill = true;
            // 
            // LoadPrefs
            // 
            this.LoadPrefs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadPrefs.ForeColor = System.Drawing.Color.Cyan;
            this.LoadPrefs.Location = new System.Drawing.Point(816, 312);
            this.LoadPrefs.Name = "LoadPrefs";
            this.LoadPrefs.Size = new System.Drawing.Size(118, 23);
            this.LoadPrefs.TabIndex = 13;
            this.LoadPrefs.Text = "LoadPrefereces";
            this.LoadPrefs.UseVisualStyleBackColor = true;
            this.LoadPrefs.Click += new System.EventHandler(this.LoadPrefs_Click);
            // 
            // WatchListComboBox
            // 
            this.WatchListComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WatchListComboBox.FormattingEnabled = true;
            this.WatchListComboBox.Location = new System.Drawing.Point(679, 361);
            this.WatchListComboBox.Name = "WatchListComboBox";
            this.WatchListComboBox.Size = new System.Drawing.Size(121, 21);
            this.WatchListComboBox.TabIndex = 14;
            this.WatchListComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WatchListComboBox_MouseClick);
            // 
            // watchListTableAdapter1
            // 
            this.watchListTableAdapter1.ClearBeforeFill = true;
            // 
            // LoadWatchListBtn
            // 
            this.LoadWatchListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadWatchListBtn.ForeColor = System.Drawing.Color.Cyan;
            this.LoadWatchListBtn.Location = new System.Drawing.Point(816, 361);
            this.LoadWatchListBtn.Name = "LoadWatchListBtn";
            this.LoadWatchListBtn.Size = new System.Drawing.Size(118, 23);
            this.LoadWatchListBtn.TabIndex = 15;
            this.LoadWatchListBtn.Text = "LoadWatchlist";
            this.LoadWatchListBtn.UseVisualStyleBackColor = true;
            this.LoadWatchListBtn.Click += new System.EventHandler(this.LoadWatchListBtn_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.Color.Cyan;
            this.ClearButton.Location = new System.Drawing.Point(266, 502);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(66, 43);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(262, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Steam Games";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(612, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Instant Gaming Games";
            // 
            // openPrefList
            // 
            this.openPrefList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPrefList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.openPrefList.ForeColor = System.Drawing.Color.Cyan;
            this.openPrefList.Location = new System.Drawing.Point(3, 42);
            this.openPrefList.Name = "openPrefList";
            this.openPrefList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.openPrefList.Size = new System.Drawing.Size(101, 23);
            this.openPrefList.TabIndex = 7;
            this.openPrefList.Text = "WatchList";
            this.openPrefList.UseVisualStyleBackColor = true;
            this.openPrefList.Click += new System.EventHandler(this.openPrefList_Click);
            // 
            // GoToPreferences
            // 
            this.GoToPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToPreferences.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.GoToPreferences.ForeColor = System.Drawing.Color.Cyan;
            this.GoToPreferences.Location = new System.Drawing.Point(3, 9);
            this.GoToPreferences.Name = "GoToPreferences";
            this.GoToPreferences.Size = new System.Drawing.Size(101, 23);
            this.GoToPreferences.TabIndex = 12;
            this.GoToPreferences.Text = "Preferences";
            this.GoToPreferences.UseVisualStyleBackColor = true;
            this.GoToPreferences.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Cyan;
            this.ExitButton.Location = new System.Drawing.Point(863, 511);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(71, 43);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(110, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 23);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(110, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 23);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GoToPreferences);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.openPrefList);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 113);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 502);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 43);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LoadSteamBtn);
            this.panel2.Controls.Add(this.LoadIGbtn);
            this.panel2.Controls.Add(this.SearchBox);
            this.panel2.Controls.Add(this.pageSpinner);
            this.panel2.Controls.Add(this.welcomeLabel);
            this.panel2.Location = new System.Drawing.Point(-1, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 183);
            this.panel2.TabIndex = 21;
            // 
            // LoadResults
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(979, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LoadWatchListBtn);
            this.Controls.Add(this.WatchListComboBox);
            this.Controls.Add(this.LoadPrefs);
            this.Controls.Add(this.prefCategoryComboBox);
            this.Controls.Add(this.igDataGridView);
            this.Controls.Add(this.SteamGamesDataGridView1);
            this.Controls.Add(this.HtmlResultsBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track Games";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.SteamGamesDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadSteamBtn;
        private System.Windows.Forms.RichTextBox HtmlResultsBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView SteamGamesDataGridView1;
        private System.Windows.Forms.NumericUpDown pageSpinner;
        private System.Windows.Forms.Button LoadIGbtn;
        private System.Windows.Forms.DataGridView igDataGridView;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ComboBox prefCategoryComboBox;
        private GameTracke_DatabaseDataSetTableAdapters.User_Type_of_gamesTableAdapter user_Type_of_gamesTableAdapter1;
        private System.Windows.Forms.Button LoadPrefs;
        private System.Windows.Forms.ComboBox WatchListComboBox;
        private GameTracke_DatabaseDataSetTableAdapters.WatchListTableAdapter watchListTableAdapter1;
        private System.Windows.Forms.Button LoadWatchListBtn;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openPrefList;
        private System.Windows.Forms.Button GoToPreferences;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

