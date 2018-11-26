
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Xml;
using System.Threading;

namespace GameTracker
{
    public partial class LoadResults : Form
    {
        public string urlVar;
        public string gameName;
        public string user;
        Login loginForm = new Login();
        
        public LoadResults(Login incomingForm)
        {
            loginForm = incomingForm;
            InitializeComponent();
            string unamevar = loginForm.username;
            welcomeLabel.Text ="Welcome Mr " + loginForm.username;
        }
       
        
        private string constructSteamUrl() {
            //construct url
            var SteamUrl = "https://store.steampowered.com/search/?term=";
            var SearchTerm = SearchBox.Text + "\n";
            var fullUrl = SteamUrl + SearchTerm;
            HtmlResultsBox.Text+= fullUrl +"\n";
            if (pageSpinner.Value > 0) {
                fullUrl += "&page=" + pageSpinner.Value;
            }

       

            return fullUrl;
        }
        private string constructIgUrl()
        {
            var IgUrl = "https://www.instant-gaming.com/en/search/?q=";
            var SearchTerm = SearchBox.Text + "\n";
            var fullUrl = IgUrl + SearchTerm;
            HtmlResultsBox.Text += fullUrl+"\n";
            if (pageSpinner.Value > 0)
            {
                fullUrl += "&page=" + pageSpinner.Value;
            }


            return fullUrl;

        }
        private void LoadSteamBtn_Click(object sender, EventArgs e)
         {
            LoadSteamResults();
            
        }
        private void LoadIGbtn_Click(object sender, EventArgs e)
        {
            LoadIgResults();
        }
        private void LoadSteamResults() {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            var fullUrl = constructSteamUrl();                       
            doc = web.Load(fullUrl);
            var ItemList = doc.DocumentNode.SelectSingleNode("//*[@id='search_result_container']");
            var Items = ItemList.SelectSingleNode("//*[@id='search_result_container']/div[2]");
            if (Items != null)//in case no results are found
            {
                var GameItems = Items.SelectNodes(".//a");
                DataTable GameTable = new DataTable();
                GameTable.Columns.Add("Game Name");
                GameTable.Columns.Add("Game Price");
                
                foreach (HtmlNode item in GameItems)
                {
                    if (item.Name != "a")
                    {
                        HtmlResultsBox.Text = "its node a game \n";

                    }
                    //Scrap game name

                    var nameNode = item.SelectSingleNode(".//div[@class='responsive_search_name_combined']");
                    var nameDeeperNode = nameNode.SelectSingleNode(".//div[@class='col search_name ellipsis']");
                    var nameSpan = nameDeeperNode.SelectSingleNode(".//span[@class='title']");
                    var Name = nameSpan.InnerText;

                    //Scrap game Price
                    var priceDiscountNode = nameNode.SelectSingleNode(".//div[@class='col search_price_discount_combined responsive_secondrow']");
                    //Sthn periptwsh pou exei ekptwsh allazei to price node se priceNodedisc analoga thn periptwsh pernoume auto pou einai gemato
                    var priceNodeDisc = priceDiscountNode.SelectSingleNode(".//div[@class='col search_price discounted responsive_secondrow']");
                    var PriceNode = priceDiscountNode.SelectSingleNode(".//div[@class='col search_price  responsive_secondrow']");
                    var Price = "Not available at this point";
                    if (PriceNode != null)
                    {
                        Price = PriceNode.InnerText;
                    }
                    else if (priceNodeDisc != null) {
                      var PriceString = priceNodeDisc.InnerText; //pairnei arxikh telikh timh
                        int index = PriceString.IndexOf('€'); //kovw thn arxikh timh sto prwto symvolo €
                        Price = PriceString.Substring(index + 1); //pairnw telikh timh apo to prwto € kai meta
                    }


                   
                    GameTable.Rows.Add(Name, Price);
                    

                }

                SteamGamesDataGridView1.DataSource = GameTable;
                SteamGamesDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;//gia na fainetai olo to cell
         
            }
            else
            {
                HtmlResultsBox.Text = "No Results were returned for that query";
            }
        }
        private void LoadIgResults() {
            
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            var fullUrl = constructIgUrl();
            doc = web.Load(fullUrl);
            
            var ItemWrapper = doc.DocumentNode.SelectSingleNode(".//div[@class='search-wrapper']");
            var ItemList = ItemWrapper.SelectSingleNode(".//div[@class='search']");
            if (ItemList != null)
            {
                var Items = ItemList.Elements("div");
                DataTable GameTable = new DataTable();
                GameTable.Columns.Add("Game Name");
                GameTable.Columns.Add("Game Price");


                foreach (HtmlNode item in Items)
                {
                    var Name = item.SelectSingleNode(".//div[@class='name']").InnerText;


                    var itemCover = item.SelectSingleNode(".//a[@class='cover']");
                    var itemSpecs = itemCover.SelectSingleNode(".//div[@class='shadow']");
                    var Price = itemSpecs.SelectSingleNode(".//div[@class='price']").InnerText;

                    
                    GameTable.Rows.Add(Name, Price);

                }
                igDataGridView.DataSource = GameTable;
                igDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;//gia na fainetai olo to cell
            }
            else
            {
                HtmlResultsBox.Text += "No Result where found  ";
            }

        }
        private void pageSpinner_ValueChanged(object sender, EventArgs e)
        {
            if (pageSpinner.Value > 0) {
                LoadSteamResults();
                LoadIgResults();

            }
        }
        private void SteamGamesDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.gameName = SteamGamesDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            this.user = loginForm.username;
           this.urlVar = constructSteamUrl();                
            selectedItemForm form = new selectedItemForm(this);
            form.Show();
        }
        private void igDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.gameName = igDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            this.user = loginForm.username;
            this.urlVar = constructIgUrl();
            selectedItemForm form = new selectedItemForm(this);
            form.Show();
        }

        

        private void prefCategoryComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            GameTracke_DatabaseDataSet.User_Type_of_gamesDataTable prefTable = new GameTracke_DatabaseDataSet.User_Type_of_gamesDataTable();

            user_Type_of_gamesTableAdapter1.fillUserPrefs(prefTable, loginForm.username);
            prefCategoryComboBox.DataSource = prefTable;
            prefCategoryComboBox.DisplayMember = "GameType";
            
        }

        private void LoadPrefs_Click(object sender, EventArgs e)
        {
            string categoryForSearch = prefCategoryComboBox.GetItemText(prefCategoryComboBox.SelectedItem);
            SearchBox.Text = categoryForSearch;
            LoadSteamResults();
            LoadIgResults();
        }

        private void WatchListComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            GameTracke_DatabaseDataSet.WatchListDataTable watchTable = new GameTracke_DatabaseDataSet.WatchListDataTable();
            watchListTableAdapter1.FillByUser(watchTable, loginForm.username);
            WatchListComboBox.DataSource = watchTable;
            WatchListComboBox.DisplayMember = "GameTitle";
        }

        private void LoadWatchListBtn_Click(object sender, EventArgs e)
        {
            string gameForSearch = WatchListComboBox.GetItemText(WatchListComboBox.SelectedItem);
            SearchBox.Text = gameForSearch;
            LoadSteamResults();
            LoadIgResults();

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            HtmlResultsBox.Clear();
        }

        private void openPrefList_Click(object sender, EventArgs e)
        {
            PreferencesWatchList pr = new PreferencesWatchList(loginForm);
            pr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Preferences pref = new Preferences(loginForm);
            pref.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
   
}
