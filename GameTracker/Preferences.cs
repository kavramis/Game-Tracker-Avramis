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
    
    public partial class Preferences : Form
    {
        Login localForm = new Login();        
        public string userName;
        public string gameCategory;
        public Preferences(Login incomingForm)
        {
            localForm = incomingForm;
            
            InitializeComponent();
            selectedUnameLabel.Hide();
            selectedCategoryLabel.Hide();
            verificationLabel.Hide();
        }

       

        private void Preferences_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameTracke_DatabaseDataSet.Type_of_games' table. You can move, or remove it, as needed.
            this.type_of_gamesTableAdapter.Fill(this.gameTracke_DatabaseDataSet.Type_of_games);                
            preferencesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            userLabel.Text = localForm.username;            

        }

        private void preferencesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUnameLabel.Show();
            selectedCategoryLabel.Show();
            verificationLabel.Show();
            this.userName = localForm.username;
            this.gameCategory = preferencesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            int dups = (int)user_Type_of_gamesTableAdapter1.CheckDuplicates(this.userName, this.gameCategory);
            if (dups == 0)
            {
                //MessageBox.Show( Convert.ToString(dups));
                selectedCategoryLabel.Text = this.gameCategory;
                selectedUnameLabel.Text = this.userName;
               user_Type_of_gamesTableAdapter1.InsertToPrefs(this.userName, this.gameCategory);              
                verificationLabel.Text = "Added";
            }
            else
            {
                verificationLabel.Text = "Already Exists";
            }
        }

        private void openPrefList_Click(object sender, EventArgs e)
        {
           
            this.userName = localForm.username;
            PreferencesWatchList pw = new PreferencesWatchList(localForm);
            pw.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Preferences_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void Preferences_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void Preferences_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
