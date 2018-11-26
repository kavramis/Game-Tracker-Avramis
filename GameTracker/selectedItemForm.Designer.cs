namespace GameTracker
{
    partial class selectedItemForm
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
            this.SelectedGameOptions = new System.Windows.Forms.ComboBox();
            this.SelectedGameBtn = new System.Windows.Forms.Button();
            this.watchListTableAdapter1 = new GameTracker.GameTracke_DatabaseDataSetTableAdapters.WatchListTableAdapter();
            this.watchListCheckLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectedGameOptions
            // 
            this.SelectedGameOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectedGameOptions.FormattingEnabled = true;
            this.SelectedGameOptions.Items.AddRange(new object[] {
            "Open in Browser",
            "Add to watchlist"});
            this.SelectedGameOptions.Location = new System.Drawing.Point(95, 71);
            this.SelectedGameOptions.Name = "SelectedGameOptions";
            this.SelectedGameOptions.Size = new System.Drawing.Size(191, 21);
            this.SelectedGameOptions.TabIndex = 0;
            // 
            // SelectedGameBtn
            // 
            this.SelectedGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectedGameBtn.ForeColor = System.Drawing.Color.Cyan;
            this.SelectedGameBtn.Location = new System.Drawing.Point(95, 148);
            this.SelectedGameBtn.Name = "SelectedGameBtn";
            this.SelectedGameBtn.Size = new System.Drawing.Size(191, 23);
            this.SelectedGameBtn.TabIndex = 1;
            this.SelectedGameBtn.Text = "Proceed";
            this.SelectedGameBtn.UseVisualStyleBackColor = true;
            this.SelectedGameBtn.Click += new System.EventHandler(this.SelectedGameBtn_Click);
            // 
            // watchListTableAdapter1
            // 
            this.watchListTableAdapter1.ClearBeforeFill = true;
            // 
            // watchListCheckLabel
            // 
            this.watchListCheckLabel.AutoSize = true;
            this.watchListCheckLabel.ForeColor = System.Drawing.Color.Cyan;
            this.watchListCheckLabel.Location = new System.Drawing.Point(95, 109);
            this.watchListCheckLabel.Name = "watchListCheckLabel";
            this.watchListCheckLabel.Size = new System.Drawing.Size(35, 13);
            this.watchListCheckLabel.TabIndex = 2;
            this.watchListCheckLabel.Text = "label1";
            // 
            // selectedItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(450, 234);
            this.Controls.Add(this.watchListCheckLabel);
            this.Controls.Add(this.SelectedGameBtn);
            this.Controls.Add(this.SelectedGameOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selectedItemForm";
            this.Text = "What To Do?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectedGameOptions;
        private System.Windows.Forms.Button SelectedGameBtn;
        private GameTracke_DatabaseDataSetTableAdapters.WatchListTableAdapter watchListTableAdapter1;
        private System.Windows.Forms.Label watchListCheckLabel;
    }
}