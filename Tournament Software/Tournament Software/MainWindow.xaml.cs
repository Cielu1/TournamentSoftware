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

namespace Tournament_Software
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        __Player PlayerObject = new __Player();

        private void B_SignUp_Click(object sender, RoutedEventArgs e)
        {
            PlayerObject.GeneratePlayer(PlayerIGN_1.Text, PlayerDN_1.Text);
        }

        private void B_Generate_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Team1.Text = PlayerObject.FindPlayerByID(0).IGN;
            ResultNick1.Text = PlayerObject.FindPlayerByID(0).IGN;
        }

        private void B_Submitt_Click(object sender, RoutedEventArgs e)
        {
            PlayerObject.AssignScores(ResultNick1.Text, System.Convert.ToInt32(ScoreBox1.Text));
            TextBox_Team2.Text = PlayerObject.FindPlayerByID(0).Score.ToString();
        }

        private void TextBox_Team2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        int PointsFromPlace (string place)
        {
            int test;
            test = System.Convert.ToInt32(place);

            switch (test)
            {
                case 1:
                    return 12;
                case 2:
                    return 9;
                case 3:
                    return 7;
                case 4:
                    return 5;
                case 5:
                    return 3;
                case 6:
                    return 2;
                case 7:
                    return 1;
                case 8:
                    return 0;

            }
            return 0;
        }



    }




    public class __Player
    {
        int IDCounter = 0;

        public string IGN;
        public string DCN;
        public int ID;
        public int Score =0;

        public List<__Player> PlayersList = new List<__Player>();

        public __Player()
        {

        }

        public __Player(string RN, string DN, int id)
        {
             IGN = RN; //RiotName
             DCN = DN; //DiscordName
             ID = id;
        }

        public void GeneratePlayer(string RiotName, string DiscordName)
        { 
             __Player Player = new __Player(RiotName, DiscordName, IDCounter);
            PlayersList.Add(Player);
            IDCounter++;

        }

        //ResultNick1

        public __Player FindPlayerByID(int id)
        {
            foreach (__Player p in PlayersList)
            {
                if (p.ID == id)
                {
                    return p;
                }
                else return null;
            }
            return null;
        }

        public void AssignScores(string nickname, int points)
        {
            foreach (__Player p in PlayersList)
            {
                if (p.IGN == nickname)
                {
                    p.Score += points;
                }
            }
        }

    }


}
