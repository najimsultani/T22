using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
//Najim sultani 
//List T
//3-17-23
namespace list_T
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {//animes Add 
        string[] anime= 
            { "Naruto ", "One Piece", "Attack on titan", "avatar", "Demon slayer", "Classroom of the Elite", "Jujutsu Kaisen", "Black Lagoon" };
        //with their episodes, right number
        int[] episodes = { 720, 1049, 49, 61, 68, 83, 91, 46 };

        List<string> animeList =  new List<string> //use list
        { "Naruto ", "One Piece", "Attack on titan", "avatar", "Demon slayer", "Classroom of the Elite", "Jujutsu Kaisen", "Black Lagoon" };
       //use episodes list
        List<int> episodesList;

        string[] newAnime ;//new for anime
        int[] newEpisodes;//new for episodes
        public MainWindow()
        {//Displays everything here main 
            InitializeComponent();
            episodesList = episodes.ToList();
            DisplayFromList();
            runDisplay.Text = "";
        }
        public void FormatString(int i)
        {//right amine with right episodes
            runDisplay.Text += $"{i}- {animeList[i]}-{episodesList[i]}\n";
        }
        public void DisplayFromList()
        {//to display all the text
            runDisplay.Text = "";

            for (int i = 0; i < animeList.Count ; i++)
            {
                FormatString(i);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            runDisplay.Text = "";
            //list the episodes here
            string episodes = txtEpisodes.Text;
            string anime  = txtAnime.Text;
            string fanime = txtAnime.Text;

            runDisplay.Text = "";
            var lepisodes = int.Parse(txtEpisodes.Text);

            animeList.Add(fanime);
            episodesList.Add(lepisodes);
            DisplayFromList();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {//
            runDisplay.Text = "";//space
            string fanime = txtAnime.Text;
            int lepisodes = int.Parse(txtEpisodes.Text);
            int index = int.Parse(txtinsertto.Text);

            animeList.Insert(index, fanime);
            episodesList.Insert(index, lepisodes);
            DisplayFromList();
        }
        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            //button to remove animes from the list
            string fanime = txtRemove.Text;
            bool wasremoved = animeList.Remove(fanime);
            DisplayFromList();

            if(wasremoved)
            {//true
                MessageBox.Show($"{fanime} was removed");
            }
            else
            {//false
                MessageBox.Show("was not removed");
            }
            foreach (string name in animeList)
            {
                runDisplay.Text += name + "\n";
                runDisplay.Text = "";
            }//display from list
             DisplayFromList();
        }
        private void btnremoveNum_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(txtremoveNum.Text);
            //if right number
            if(index < animeList.Count)
            {//true
                animeList.RemoveAt(index);
                episodesList.RemoveAt(index);
            }
            else
            {//false
                MessageBox.Show("input a number ");
            }
            DisplayFromList();
        }
        private void btnclear_Click(object sender, RoutedEventArgs e)
        {//button to clear all the list
            runDisplay.Text = "";
        }
    }
}
