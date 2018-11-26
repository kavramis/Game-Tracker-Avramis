using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTracker
{
    public partial class PreferencesWatchList : Form
    {
        Login localForm;
        public PreferencesWatchList(Login incForm)
        {
            localForm = incForm;
            InitializeComponent();
        }

        private void PreferencesWatchList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameTracke_DatabaseDataSet.WatchList' table. You can move, or remove it, as needed.
            this.watchListTableAdapter.FillByUser(this.gameTracke_DatabaseDataSet.WatchList,localForm.username);
            watchListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // TODO: This line of code loads data into the 'gameTracke_DatabaseDataSet.User_Type_of_games' table. You can move, or remove it, as needed.
            this.user_Type_of_gamesTableAdapter.fillUserPrefs(this.gameTracke_DatabaseDataSet.User_Type_of_games,localForm.username);

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool mouseDown;
        private Point lastLocation;

        private void PreferencesWatchList_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void PreferencesWatchList_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void PreferencesWatchList_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
