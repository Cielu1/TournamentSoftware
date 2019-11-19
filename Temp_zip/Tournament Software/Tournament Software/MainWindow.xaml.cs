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
using System.Security.Cryptography;
using System.Threading;

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
        List<string> Nicknames = new List<string>();
        List<string> DiscordNames = new List<string>();


        List<__Player> RandomPlayers = new List<__Player>();

        List<TextBlock> ResultNicks = new List<TextBlock>();

        List<__Player> OutputNamesTeam1 = new List<__Player>();
        List<__Player> OutputNamesTeam2 = new List<__Player>();

        List<TextBox> PlacingInRounds = new List<TextBox>();
        List<TextBlock> PointsInRounds = new List<TextBlock>();

        List<TextBlock> LeaderBoardNicks = new List<TextBlock>();
        List<TextBlock> LeaderBoardDiscords = new List<TextBlock>();
        List<TextBlock> LeaderBoardScores = new List<TextBlock>();

        List<__Player> PlayersGame1 = new List<__Player>();
        List<__Player> PlayersGame2 = new List<__Player>();
        List<__Player> PlayersGame3 = new List<__Player>();
        List<__Player> PlayersGame4 = new List<__Player>();
        List<__Player> PlayersGame5 = new List<__Player>();

        #region ListDefinitions
        void GenerateLists()
        {
            Nicknames.Add(Nickname1.Text); Nicknames.Add(Nickname2.Text); Nicknames.Add(Nickname3.Text); Nicknames.Add(Nickname4.Text); Nicknames.Add(Nickname5.Text); Nicknames.Add(Nickname6.Text); Nicknames.Add(Nickname7.Text); Nicknames.Add(Nickname8.Text); Nicknames.Add(Nickname9.Text); Nicknames.Add(Nickname10.Text); Nicknames.Add(Nickname11.Text); Nicknames.Add(Nickname12.Text); Nicknames.Add(Nickname13.Text); Nicknames.Add(Nickname14.Text); Nicknames.Add(Nickname15.Text); Nicknames.Add(Nickname16.Text);
            DiscordNames.Add(DiscordName1.Text); DiscordNames.Add(DiscordName2.Text); DiscordNames.Add(DiscordName3.Text); DiscordNames.Add(DiscordName4.Text); DiscordNames.Add(DiscordName5.Text); DiscordNames.Add(DiscordName6.Text); DiscordNames.Add(DiscordName7.Text); DiscordNames.Add(DiscordName8.Text); DiscordNames.Add(DiscordName9.Text); DiscordNames.Add(DiscordName10.Text); DiscordNames.Add(DiscordName11.Text); DiscordNames.Add(DiscordName12.Text); DiscordNames.Add(DiscordName13.Text); DiscordNames.Add(DiscordName14.Text); DiscordNames.Add(DiscordName15.Text); DiscordNames.Add(DiscordName16.Text);

            ResultNicks.Add(ResultNick1); ResultNicks.Add(ResultNick2); ResultNicks.Add(ResultNick3); ResultNicks.Add(ResultNick4); ResultNicks.Add(ResultNick5); ResultNicks.Add(ResultNick6); ResultNicks.Add(ResultNick7); ResultNicks.Add(ResultNick8); ResultNicks.Add(ResultNick9); ResultNicks.Add(ResultNick10); ResultNicks.Add(ResultNick11); ResultNicks.Add(ResultNick12); ResultNicks.Add(ResultNick13); ResultNicks.Add(ResultNick14); ResultNicks.Add(ResultNick15); ResultNicks.Add(ResultNick16);

            PlacingInRounds.Add(PlacingInRound1); PlacingInRounds.Add(PlacingInRound2); PlacingInRounds.Add(PlacingInRound3); PlacingInRounds.Add(PlacingInRound4); PlacingInRounds.Add(PlacingInRound5); PlacingInRounds.Add(PlacingInRound6); PlacingInRounds.Add(PlacingInRound7); PlacingInRounds.Add(PlacingInRound8); PlacingInRounds.Add(PlacingInRound9); PlacingInRounds.Add(PlacingInRound10); PlacingInRounds.Add(PlacingInRound11); PlacingInRounds.Add(PlacingInRound12); PlacingInRounds.Add(PlacingInRound13); PlacingInRounds.Add(PlacingInRound14); PlacingInRounds.Add(PlacingInRound15); PlacingInRounds.Add(PlacingInRound16);
            PointsInRounds.Add(PointsInRound1); PointsInRounds.Add(PointsInRound2); PointsInRounds.Add(PointsInRound3); PointsInRounds.Add(PointsInRound4); PointsInRounds.Add(PointsInRound5); PointsInRounds.Add(PointsInRound6); PointsInRounds.Add(PointsInRound7); PointsInRounds.Add(PointsInRound8); PointsInRounds.Add(PointsInRound9); PointsInRounds.Add(PointsInRound10); PointsInRounds.Add(PointsInRound11); PointsInRounds.Add(PointsInRound12); PointsInRounds.Add(PointsInRound13); PointsInRounds.Add(PointsInRound14); PointsInRounds.Add(PointsInRound15); PointsInRounds.Add(PointsInRound16);

            LeaderBoardNicks.Add(LeaderBoardNick1); LeaderBoardNicks.Add(LeaderBoardNick2); LeaderBoardNicks.Add(LeaderBoardNick3); LeaderBoardNicks.Add(LeaderBoardNick4); LeaderBoardNicks.Add(LeaderBoardNick5); LeaderBoardNicks.Add(LeaderBoardNick6); LeaderBoardNicks.Add(LeaderBoardNick7); LeaderBoardNicks.Add(LeaderBoardNick8); LeaderBoardNicks.Add(LeaderBoardNick9); LeaderBoardNicks.Add(LeaderBoardNick10); LeaderBoardNicks.Add(LeaderBoardNick11); LeaderBoardNicks.Add(LeaderBoardNick12); LeaderBoardNicks.Add(LeaderBoardNick13); LeaderBoardNicks.Add(LeaderBoardNick14); LeaderBoardNicks.Add(LeaderBoardNick15); LeaderBoardNicks.Add(LeaderBoardNick16);
            LeaderBoardDiscords.Add(LeaderBoardDiscord1); LeaderBoardDiscords.Add(LeaderBoardDiscord2); LeaderBoardDiscords.Add(LeaderBoardDiscord3); LeaderBoardDiscords.Add(LeaderBoardDiscord4); LeaderBoardDiscords.Add(LeaderBoardDiscord5); LeaderBoardDiscords.Add(LeaderBoardDiscord6); LeaderBoardDiscords.Add(LeaderBoardDiscord7); LeaderBoardDiscords.Add(LeaderBoardDiscord8); LeaderBoardDiscords.Add(LeaderBoardDiscord9); LeaderBoardDiscords.Add(LeaderBoardDiscord10); LeaderBoardDiscords.Add(LeaderBoardDiscord11); LeaderBoardDiscords.Add(LeaderBoardDiscord12); LeaderBoardDiscords.Add(LeaderBoardDiscord13); LeaderBoardDiscords.Add(LeaderBoardDiscord14); LeaderBoardDiscords.Add(LeaderBoardDiscord15); LeaderBoardDiscords.Add(LeaderBoardDiscord16);
            LeaderBoardScores.Add(LeaderBoardScore1); LeaderBoardScores.Add(LeaderBoardScore2); LeaderBoardScores.Add(LeaderBoardScore3); LeaderBoardScores.Add(LeaderBoardScore4); LeaderBoardScores.Add(LeaderBoardScore5); LeaderBoardScores.Add(LeaderBoardScore6); LeaderBoardScores.Add(LeaderBoardScore7); LeaderBoardScores.Add(LeaderBoardScore8); LeaderBoardScores.Add(LeaderBoardScore9); LeaderBoardScores.Add(LeaderBoardScore10); LeaderBoardScores.Add(LeaderBoardScore11); LeaderBoardScores.Add(LeaderBoardScore12); LeaderBoardScores.Add(LeaderBoardScore13); LeaderBoardScores.Add(LeaderBoardScore14); LeaderBoardScores.Add(LeaderBoardScore15); LeaderBoardScores.Add(LeaderBoardScore16);
        }

        void GenerateOutputLists()
        {

        }

        void GenerateRandomOutputLists()
        {

            for (int i = 0; i < RandomPlayers.Count / 2 - 1; i++)
            {
                OutputNamesTeam1.Add(RandomPlayers[i]);
            }

            for (int i = RandomPlayers.Count / 2; i < RandomPlayers.Count; i++)
            {
                OutputNamesTeam2.Add(RandomPlayers[i]);
            }

        }

        #endregion




       public List<User> items = new List<User>();


        private void B_SignUp_Click(object sender, RoutedEventArgs e)
        {

            
            items.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            items.Add(new User() { Name = "Sammy Doe", Age = 7, Mail = "sammy.doe@gmail.com" });
            lvUsers.ItemsSource = items;

            TextBox_Team2.Text = items[0].Name;

            int i = 0;
            GenerateLists();
            PlayerObject.ClearLists();
            foreach (string s in Nicknames)
            {
                PlayerObject.GeneratePlayer(Nicknames[i], DiscordNames[i]);
                i++;
            }

        }

        private void B_Generate_Click(object sender, RoutedEventArgs e)
        {

            RandomPlayers = PlayerObject.RandomizePlayers();
            for (int i = 0; i < 16; i++)
            {
                ResultNicks[i].Text = RandomPlayers[i].IGN;
            }

            string CopyTextA ="LOBBY 1 \r\n";
            string CopyTextB=" LOBBY 2 \r\n";

            for (int i = 0; i<RandomPlayers.Count/2; i++)
            {
                CopyTextA = CopyTextA + "\r\n @" + RandomPlayers[i].DCN + " - " + RandomPlayers[i].IGN;
                CopyTextB = CopyTextB + "\r \n@" + RandomPlayers[+8].DCN + " - " + RandomPlayers[i+8].IGN;
            }

            TextBox_Team1.Text = CopyTextA;
            TextBox_Team2.Text = CopyTextB;

            /*
            for (int i = ResultNicks.Count / 2; i < ResultNicks.Count; i++)
            {
                OutputNamesTeam2.Add(RandomPlayers[i]);
            }

            TextBox_Team1.Text = PlayerObject.FindPlayerByID(0).IGN;
            ResultNick1.Text = PlayerObject.FindPlayerByID(0).IGN;*/
        }

        private void B_Submitt_Click(object sender, RoutedEventArgs e)
        {
            //List<TextBox> PlacingInRounds = new List<TextBox>();
            //List<TextBlock> PointsInRounds = new List<TextBlock>();

            int i = 0;
            int points = 0;
            foreach (__Player p in RandomPlayers)
            {
                points = PointsFromPlace(PlacingInRounds[i].Text);
                PointsInRounds[i].Text = points.ToString();    
                p.Score += points;
                i++;
            }

            i = 0;
            List<__Player> LeaderBoardList = PlayerObject.LeaderBoardList(RandomPlayers);

           foreach (__Player p in LeaderBoardList)
            {

                LeaderBoardNicks[i].Text = p.IGN;
                LeaderBoardDiscords[i].Text = p.DCN;
                LeaderBoardScores[i].Text = p.Score.ToString();
                i++;
            }



        }






        private void TextBox_Team2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        int PointsFromPlace(string place)
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

        private void B_R1_Click(object sender, RoutedEventArgs e)
        {  
            Window WindowR1 = new Round1();
            WindowR1.Show();
            
        }

        private void B_R2_Click(object sender, RoutedEventArgs e)
        {
            Window WindowR2 = new Round1();
            WindowR2.Show();
      
        }

        public class User
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string Mail { get; set; }
        }


    }




    public class __Player
    {
        int IDCounter = 0;

        public string IGN;
        public string DCN;
        public int ID;
        public int Score = 0;

        public List<__Player> PlayersList = new List<__Player>();
        public List<__Player> InputList = new List<__Player>();

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
            InputList.Add(Player);
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

        public List<__Player> RandomizePlayers()
        {
            Shuffle(InputList);
            return InputList;
        }



        public void ClearLists()
        {
            InputList.Clear();
            PlayersList.Clear();
        }

        private  Random rng = new Random();

        public  void Shuffle(List<__Player> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                __Player value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

       public List<__Player> LeaderBoardList(List<__Player> Input)
        {
            List<__Player> target = new List<__Player>();

            foreach (__Player p in Input)
            {
                // pierwszy toster
                if (target.Count == 0)
                {
                    target.Add(p);
                }

                // Jezeli zadaje wiecej - daj go na poczatek
                else if (p.Score > target[0].Score)
                {
                    target.Insert(0, p);
                }

                // Jezeli zadaje mniej - sortuj
                else
                {
                    bool sorting = true;
                    int i = target.Count - 1;
                    while (sorting)
                    {
                        if (p.Score <= target[i].Score)
                        {
                            target.Insert(i + 1, p);
                            sorting = false;
                        }
                        i--;
                    }
                }
            }
            return target;
        }

    }
}


