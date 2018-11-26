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
            this.userCategoryPrefDataGridView = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeofgamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTracke_DatabaseDataSet = new GameTracker.GameTracke_DatabaseDataSet();
            this.user_Type_of_gamesTableAdapter = new GameTracker.GameTracke_DatabaseDataSetTableAdapters.User_Type_of_gamesTableAdapter();
            this.watchListDataGridView = new System.Windows.Forms.DataGridView();
            this.watchListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.watchListTableAdapter = new GameTracker.GameTracke_DatabaseDataSetTableAdapters.WatchListTableAdapter();
            this.gameTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userCategoryPrefDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeofgamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userCategoryPrefDataGridView
            // 
            this.userCategoryPrefDataGridView.AutoGenerateColumns = false;
            this.userCategoryPrefDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userCategoryPrefDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.gameTypeDataGridViewTextBoxColumn});
            this.userCategoryPrefDataGridView.DataSource = this.userTypeofgamesBindingSource;
            this.userCategoryPrefDataGridView.Location = new System.Drawing.Point(12, 12);
            this.userCategoryPrefDataGridView.Name = "userCategoryPrefDataGridView";
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
            this.watchListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watchListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameTitleDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn1});
            this.watchListDataGridView.DataSource = this.watchListBindingSource;
            this.watchListDataGridView.Location = new System.Drawing.Point(367, 12);
            this.watchListDataGridView.Name = "watchListDataGridView";
            this.watchListDataGridView.Size = new System.Drawing.Size(240, 150);
            this.watchListDataGridView.TabIndex = 1;
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
            // PreferencesWatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.watchListDataGridView);
            this.Controls.Add(this.userCategoryPrefDataGridView);
            this.Name = "PreferencesWatchList";
            this.Text = "PreferencesWatchList";
            this.Load += new System.EventHandler(this.PreferencesWatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userCategoryPrefDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeofgamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchListBindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}