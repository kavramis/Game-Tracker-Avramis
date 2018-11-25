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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gameTracke_DatabaseDataSet = new GameTracker.GameTracke_DatabaseDataSet();
            this.userTypeofgamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_Type_of_gamesTableAdapter = new GameTracker.GameTracke_DatabaseDataSetTableAdapters.User_Type_of_gamesTableAdapter();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeofgamesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.gameTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userTypeofgamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(166, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // gameTracke_DatabaseDataSet
            // 
            this.gameTracke_DatabaseDataSet.DataSetName = "GameTracke_DatabaseDataSet";
            this.gameTracke_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTypeofgamesBindingSource
            // 
            this.userTypeofgamesBindingSource.DataMember = "User_Type_of_games";
            this.userTypeofgamesBindingSource.DataSource = this.gameTracke_DatabaseDataSet;
            // 
            // user_Type_of_gamesTableAdapter
            // 
            this.user_Type_of_gamesTableAdapter.ClearBeforeFill = true;
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
            // PreferencesWatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PreferencesWatchList";
            this.Text = "PreferencesWatchList";
            this.Load += new System.EventHandler(this.PreferencesWatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeofgamesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GameTracke_DatabaseDataSet gameTracke_DatabaseDataSet;
        private System.Windows.Forms.BindingSource userTypeofgamesBindingSource;
        private GameTracke_DatabaseDataSetTableAdapters.User_Type_of_gamesTableAdapter user_Type_of_gamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTypeDataGridViewTextBoxColumn;
    }
}