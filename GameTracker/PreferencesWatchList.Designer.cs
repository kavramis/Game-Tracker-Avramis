namespace GameTracker
{
    partial class PreferencesWatchList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesWatchList));
            this.userCategoryPrefDataGridView = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeofgamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTracke_DatabaseDataSet = new GameTracker.GameTracke_DatabaseDataSet();
            this.user_Type_of_gamesTableAdapter = new GameTracker.GameTracke_DatabaseDataSetTableAdapters.User_Type_of_gamesTableAdapter();
            this.watchListDataGridView = new System.Windows.Forms.DataGridView();
            this.gameTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.watchListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watchListTableAdapter = new GameTracker.GameTracke_DatabaseDataSetTableAdapters.WatchListTableAdapter();
            this.Preferences = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeletePrefsButton = new System.Windows.Forms.Button();
            this.DeleteWatchlistButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userCategoryPrefDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeofgamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchListBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // userCategoryPrefDataGridView
            // 
            this.userCategoryPrefDataGridView.AutoGenerateColumns = false;
            this.userCategoryPrefDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userCategoryPrefDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userCategoryPrefDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userCategoryPrefDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.gameTypeDataGridViewTextBoxColumn});
            this.userCategoryPrefDataGridView.DataSource = this.userTypeofgamesBindingSource;
            this.userCategoryPrefDataGridView.EnableHeadersVisualStyles = false;
            this.userCategoryPrefDataGridView.Location = new System.Drawing.Point(181, 34);
            this.userCategoryPrefDataGridView.Name = "userCategoryPrefDataGridView";
            this.userCategoryPrefDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userCategoryPrefDataGridView.Size = new System.Drawing.Size(240, 150);
            this.userCategoryPrefDataGridView.TabIndex = 0;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // gameTypeDataGridViewTextBoxColumn
            // 
            this.gameTypeDataGridViewTextBoxColumn.DataPropertyName = "GameType";
            this.gameTypeDataGridViewTextBoxColumn.HeaderText = "GameType";
            this.gameTypeDataGridViewTextBoxColumn.Name = "gameTypeDataGridViewTextBoxColumn";
            // 
            // userTypeofgamesBindingSource
            // 
            this.userTypeofgamesBindingSource.DataMember = "User_Type_of_games";
            this.userTypeofgamesBindingSource.DataSource = this.gameTracke_DatabaseDataSet;
            // 
            // gameTracke_DatabaseDataSet
            // 
            this.gameTracke_DatabaseDataSet.DataSetName = "GameTracke_DatabaseDataSet";
            this.gameTracke_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_Type_of_gamesTableAdapter
            // 
            this.user_Type_of_gamesTableAdapter.ClearBeforeFill = true;
            // 
            // watchListDataGridView
            // 
            this.watchListDataGridView.AutoGenerateColumns = false;
            this.watchListDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.watchListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.watchListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watchListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameTitleDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn1});
            this.watchListDataGridView.DataSource = this.watchListBindingSource;
            this.watchListDataGridView.EnableHeadersVisualStyles = false;
            this.watchListDataGridView.Location = new System.Drawing.Point(529, 34);
            this.watchListDataGridView.Name = "watchListDataGridView";
            this.watchListDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.watchListDataGridView.Size = new System.Drawing.Size(240, 150);
            this.watchListDataGridView.TabIndex = 1;
            // 
            // gameTitleDataGridViewTextBoxColumn
            // 
            this.gameTitleDataGridViewTextBoxColumn.DataPropertyName = "GameTitle";
            this.gameTitleDataGridViewTextBoxColumn.HeaderText = "GameTitle";
            this.gameTitleDataGridViewTextBoxColumn.Name = "gameTitleDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn1
            // 
            this.userNameDataGridViewTextBoxColumn1.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn1.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn1.Name = "userNameDataGridViewTextBoxColumn1";
            // 
            // watchListBindingSource
            // 
            this.watchListBindingSource.DataMember = "WatchList";
            this.watchListBindingSource.DataSource = this.gameTracke_DatabaseDataSet;
            // 
            // watchListTableAdapter
            // 
            this.watchListTableAdapter.ClearBeforeFill = true;
            // 
            // Preferences
            // 
            this.Preferences.AutoSize = true;
            this.Preferences.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Preferences.ForeColor = System.Drawing.Color.Cyan;
            this.Preferences.Location = new System.Drawing.Point(178, 12);
            this.Preferences.Name = "Preferences";
            this.Preferences.Size = new System.Drawing.Size(101, 19);
            this.Preferences.TabIndex = 2;
            this.Preferences.Text = "Preferences";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(526, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "WatchList";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 452);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(92, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 22);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ExitButton.ForeColor = System.Drawing.Color.Cyan;
            this.ExitButton.Location = new System.Drawing.Point(0, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(85, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeletePrefsButton
            // 
            this.DeletePrefsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePrefsButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DeletePrefsButton.ForeColor = System.Drawing.Color.Cyan;
            this.DeletePrefsButton.Location = new System.Drawing.Point(181, 226);
            this.DeletePrefsButton.Name = "DeletePrefsButton";
            this.DeletePrefsButton.Size = new System.Drawing.Size(91, 33);
            this.DeletePrefsButton.TabIndex = 5;
            this.DeletePrefsButton.Text = "DeletePrefs";
            this.DeletePrefsButton.UseVisualStyleBackColor = true;
            // 
            // DeleteWatchlistButton
            // 
            this.DeleteWatchlistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteWatchlistButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteWatchlistButton.ForeColor = System.Drawing.Color.Cyan;
            this.DeleteWatchlistButton.Location = new System.Drawing.Point(529, 226);
            this.DeleteWatchlistButton.Name = "DeleteWatchlistButton";
            this.DeleteWatchlistButton.Size = new System.Drawing.Size(111, 33);
            this.DeleteWatchlistButton.TabIndex = 6;
            this.DeleteWatchlistButton.Text = "DeleteWatchlist";
            this.DeleteWatchlistButton.UseVisualStyleBackColor = true;
            // 
            // PreferencesWatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteWatchlistButton);
            this.Controls.Add(this.DeletePrefsButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Preferences);
            this.Controls.Add(this.watchListDataGridView);
            this.Controls.Add(this.userCategoryPrefDataGridView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreferencesWatchList";
            this.Text = "My Preferences";
            this.Load += new System.EventHandler(this.PreferencesWatchList_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PreferencesWatchList_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PreferencesWatchList_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PreferencesWatchList_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.userCategoryPrefDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeofgamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchListBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userCategoryPrefDataGridView;
        private GameTracke_DatabaseDataSet gameTracke_DatabaseDataSet;
        private System.Windows.Forms.BindingSource userTypeofgamesBindingSource;
        private GameTracke_DatabaseDataSetTableAdapters.User_Type_of_gamesTableAdapter user_Type_of_gamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView watchListDataGridView;
        private System.Windows.Forms.BindingSource watchListBindingSource;
        private GameTracke_DatabaseDataSetTableAdapters.WatchListTableAdapter watchListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label Preferences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeletePrefsButton;
        private System.Windows.Forms.Button DeleteWatchlistButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}