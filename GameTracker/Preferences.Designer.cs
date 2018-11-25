namespace GameTracker
{
    partial class Preferences
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
            this.preferencesDataGridView = new System.Windows.Forms.DataGridView();
            this.gamesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofgamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTracke_DatabaseDataSet = new GameTracker.GameTracke_DatabaseDataSet();
            this.verificationLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.selectedUnameLabel = new System.Windows.Forms.Label();
            this.selectedCategoryLabel = new System.Windows.Forms.Label();
            this.openPrefList = new System.Windows.Forms.Button();
            this.type_of_gamesTableAdapter = new GameTracker.GameTracke_DatabaseDataSetTableAdapters.Type_of_gamesTableAdapter();
            this.user_Type_of_gamesTableAdapter1 = new GameTracker.GameTracke_DatabaseDataSetTableAdapters.User_Type_of_gamesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofgamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // preferencesDataGridView
            // 
            this.preferencesDataGridView.AutoGenerateColumns = false;
            this.preferencesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preferencesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gamesDataGridViewTextBoxColumn});
            this.preferencesDataGridView.DataSource = this.typeofgamesBindingSource;
            this.preferencesDataGridView.Location = new System.Drawing.Point(45, 47);
            this.preferencesDataGridView.Name = "preferencesDataGridView";
            this.preferencesDataGridView.Size = new System.Drawing.Size(240, 150);
            this.preferencesDataGridView.TabIndex = 0;
            this.preferencesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.preferencesDataGridView_CellDoubleClick);
            // 
            // gamesDataGridViewTextBoxColumn
            // 
            this.gamesDataGridViewTextBoxColumn.DataPropertyName = "Games";
            this.gamesDataGridViewTextBoxColumn.HeaderText = "Games";
            this.gamesDataGridViewTextBoxColumn.Name = "gamesDataGridViewTextBoxColumn";
            // 
            // typeofgamesBindingSource
            // 
            this.typeofgamesBindingSource.DataMember = "Type_of_games";
            this.typeofgamesBindingSource.DataSource = this.gameTracke_DatabaseDataSet;
            // 
            // gameTracke_DatabaseDataSet
            // 
            this.gameTracke_DatabaseDataSet.DataSetName = "GameTracke_DatabaseDataSet";
            this.gameTracke_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verificationLabel
            // 
            this.verificationLabel.AutoSize = true;
            this.verificationLabel.Location = new System.Drawing.Point(62, 286);
            this.verificationLabel.Name = "verificationLabel";
            this.verificationLabel.Size = new System.Drawing.Size(35, 13);
            this.verificationLabel.TabIndex = 1;
            this.verificationLabel.Text = "label1";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(42, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(35, 13);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "label1";
            // 
            // selectedUnameLabel
            // 
            this.selectedUnameLabel.AutoSize = true;
            this.selectedUnameLabel.Location = new System.Drawing.Point(330, 47);
            this.selectedUnameLabel.Name = "selectedUnameLabel";
            this.selectedUnameLabel.Size = new System.Drawing.Size(35, 13);
            this.selectedUnameLabel.TabIndex = 3;
            this.selectedUnameLabel.Text = "label1";
            // 
            // selectedCategoryLabel
            // 
            this.selectedCategoryLabel.AutoSize = true;
            this.selectedCategoryLabel.Location = new System.Drawing.Point(330, 80);
            this.selectedCategoryLabel.Name = "selectedCategoryLabel";
            this.selectedCategoryLabel.Size = new System.Drawing.Size(35, 13);
            this.selectedCategoryLabel.TabIndex = 4;
            this.selectedCategoryLabel.Text = "label2";
            // 
            // openPrefList
            // 
            this.openPrefList.Location = new System.Drawing.Point(409, 47);
            this.openPrefList.Name = "openPrefList";
            this.openPrefList.Size = new System.Drawing.Size(75, 23);
            this.openPrefList.TabIndex = 6;
            this.openPrefList.Text = "My prefs";
            this.openPrefList.UseVisualStyleBackColor = true;
            this.openPrefList.Click += new System.EventHandler(this.openPrefList_Click);
            // 
            // type_of_gamesTableAdapter
            // 
            this.type_of_gamesTableAdapter.ClearBeforeFill = true;
            // 
            // user_Type_of_gamesTableAdapter1
            // 
            this.user_Type_of_gamesTableAdapter1.ClearBeforeFill = true;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openPrefList);
            this.Controls.Add(this.selectedCategoryLabel);
            this.Controls.Add(this.selectedUnameLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.verificationLabel);
            this.Controls.Add(this.preferencesDataGridView);
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.preferencesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofgamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView preferencesDataGridView;
        private System.Windows.Forms.Label verificationLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label selectedUnameLabel;
        private System.Windows.Forms.Label selectedCategoryLabel;
        private System.Windows.Forms.Button openPrefList;
        private GameTracke_DatabaseDataSet gameTracke_DatabaseDataSet;
        private System.Windows.Forms.BindingSource typeofgamesBindingSource;
        private GameTracke_DatabaseDataSetTableAdapters.Type_of_gamesTableAdapter type_of_gamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamesDataGridViewTextBoxColumn;
        private GameTracke_DatabaseDataSetTableAdapters.User_Type_of_gamesTableAdapter user_Type_of_gamesTableAdapter1;
    }
}