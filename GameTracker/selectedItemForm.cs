using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTracker
{
    public partial class selectedItemForm : Form
    {

        LoadResults LrForm;
        public selectedItemForm(LoadResults incomingForm)
        {
            LrForm = incomingForm;
            InitializeComponent();
            watchListCheckLabel.Hide();

        }
       

        private void SelectedGameBtn_Click(object sender, EventArgs e)
        {

            watchListCheckLabel.Show();
            watchListCheckLabel.Text = "Added to watch list";
            if (SelectedGameOptions.SelectedIndex == 0)
            {
                string url = LrForm.urlVar;
                System.Diagnostics.Process.Start(url);
            }
            else if (SelectedGameOptions.SelectedIndex == 1)
            {
                if ((int)watchListTableAdapter1.CheckWatchListDuplicate(LrForm.gameName, LrForm.user) == 0)
                {
                    watchListTableAdapter1.InsertWatchList(LrForm.gameName, LrForm.user);
                }
                else { watchListCheckLabel.Text = "Already Added to watch list"; }

            }
            this.Hide();

        }
    }
}
