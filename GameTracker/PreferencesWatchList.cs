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
        public PreferencesWatchList()
        {
            InitializeComponent();
        }

        private void PreferencesWatchList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameTracke_DatabaseDataSet.WatchList' table. You can move, or remove it, as needed.
            this.watchListTableAdapter.Fill(this.gameTracke_DatabaseDataSet.WatchList);
            // TODO: This line of code loads data into the 'gameTracke_DatabaseDataSet.User_Type_of_games' table. You can move, or remove it, as needed.
            this.user_Type_of_gamesTableAdapter.Fill(this.gameTracke_DatabaseDataSet.User_Type_of_games);

        }
    }
}
