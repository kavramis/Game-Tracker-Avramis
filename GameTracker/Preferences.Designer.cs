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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofgamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // preferencesDataGridView
            // 
            this.preferencesDataGridView.AutoGenerateColumns = false;
            this.preferencesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.preferencesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preferencesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gamesDataGridViewTextBoxColumn});
            this.preferencesDataGridView.DataSource = this.typeofgamesBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.preferencesDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.preferencesDataGridView.Location = new System.Drawing.Point(177, 47);
            this.preferencesDataGridView.Name = "preferencesDataGridView";
            this.preferencesDataGridView.Size = new System.Drawing.Size(145, 202);
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
            this.verificationLabel.ForeColor = System.Drawing.Color.Cyan;
            this.verificationLabel.Location = new System.Drawing.Point(174, 281);
            this.verificationLabel.Name = "verificationLabel";
            this.verificationLabel.Size = new System.Drawing.Size(35, 13);
            this.verificationLabel.TabIndex = 1;
            this.verificationLabel.Text = "label1";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.ForeColor = System.Drawing.Color.Cyan;
            this.userLabel.Location = new System.Drawing.Point(178, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(35, 13);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "label1";
            // 
            // selectedUnameLabel
            // 
            this.selectedUnameLabel.AutoSize = true;
            this.selectedUnameLabel.ForeColor = System.Drawing.Color.Cyan;
            this.selectedUnameLabel.Location = new System.Drawing.Point(461, 47);
            this.selectedUnameLabel.Name = "selectedUnameLabel";
            this.selectedUnameLabel.Size = new System.Drawing.Size(35, 13);
            this.selectedUnameLabel.TabIndex = 3;
            this.selectedUnameLabel.Text = "label1";
            // 
            // selectedCategoryLabel
            // 
            this.selectedCategoryLabel.AutoSize = true;
            this.selectedCategoryLabel.ForeColor = System.Drawing.Color.Cyan;
            this.selectedCategoryLabel.Location = new System.Drawing.Point(461, 80);
            this.selectedCategoryLabel.Name = "selectedCategoryLabel";
            this.selectedCategoryLabel.Size = new System.Drawing.Size(35, 13);
            this.selectedCategoryLabel.TabIndex = 4;
            this.selectedCategoryLabel.Text = "label2";
            // 
            // openPrefList
            // 
            this.openPrefList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPrefList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.openPrefList.ForeColor = System.Drawing.Color.Cyan;
            this.openPrefList.Location = new System.Drawing.Point(0, 12);
            this.openPrefList.Name = "openPrefList";
            this.openPrefList.Size = new System.Drawing.Size(91, 23);
            this.openPrefList.TabIndex = 6;
            this.openPrefList.Text = "WatchList";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.openPrefList);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 451);
            this.panel1.TabIndex = 19;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ExitButton.ForeColor = System.Drawing.Color.Cyan;
            this.ExitButton.Location = new System.Drawing.Point(0, 47);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(89, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(173, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Preferences";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 22);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(95, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 22);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectedCategoryLabel);
            this.Controls.Add(this.selectedUnameLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.verificationLabel);
            this.Controls.Add(this.preferencesDataGridView);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.preferencesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeofgamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTracke_DatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}