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

        public int PlayersNumber;        // ILOŚC GRACZY 
        public void SetPlayersNumber(int i)
        {
            PlayersNumber = i;
        }

        __Player PlayerObject = new __Player();



        private void B_SignUp_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < PlayersNumber; i++)
            {
                PlayerObject.GeneratePlayer(DiscordName1.GetLineText(i).TrimEnd('\n').TrimEnd('\r'), Nickname1.GetLineText(i).TrimEnd('\n').TrimEnd('\r'));
            }

            GenerateListOfPlacings();
            GenerateListOfLists();
        }

        int GroupingNumber = 0;
        public void SetGroupingNumber(int i)
        {
            GroupingNumber = i;
        }

        void GenerateListOfLists()
        {
            ListOfLobbies.Add(TempLobby1);
            ListOfLobbies.Add(TempLobby2);
            ListOfLobbies.Add(TempLobby3);
            ListOfLobbies.Add(TempLobby4);

            ListOfLobbies.Add(TempLobby5);
            ListOfLobbies.Add(TempLobby6);
            ListOfLobbies.Add(TempLobby7);
            ListOfLobbies.Add(TempLobby8);

            ListOfLobbies.Add(TempLobby9);
            ListOfLobbies.Add(TempLobby10);
            ListOfLobbies.Add(TempLobby11);
            ListOfLobbies.Add(TempLobby12);

            ListOfLobbies.Add(TempLobby13);
            ListOfLobbies.Add(TempLobby14);
            ListOfLobbies.Add(TempLobby15);
            ListOfLobbies.Add(TempLobby16);

            ListOfString.Add(CopyTextA);
            ListOfString.Add(CopyTextB);
            ListOfString.Add(CopyTextC);
            ListOfString.Add(CopyTextD);

            ListOfString.Add(CopyTextE);
            ListOfString.Add(CopyTextF);
            ListOfString.Add(CopyTextG);
            ListOfString.Add(CopyTextH);

            ListOfString.Add(CopyTextI);
            ListOfString.Add(CopyTextJ);
            ListOfString.Add(CopyTextK);
            ListOfString.Add(CopyTextL);

            ListOfString.Add(CopyTextM);
            ListOfString.Add(CopyTextN);
            ListOfString.Add(CopyTextO);
            ListOfString.Add(CopyTextP);

        }

        List<__Player> TempLobby1 = new List<__Player>();
        List<__Player> TempLobby2 = new List<__Player>();
        List<__Player> TempLobby3 = new List<__Player>();
        List<__Player> TempLobby4 = new List<__Player>();

        List<__Player> TempLobby5 = new List<__Player>();
        List<__Player> TempLobby6 = new List<__Player>();
        List<__Player> TempLobby7 = new List<__Player>();
        List<__Player> TempLobby8 = new List<__Player>();

        List<__Player> TempLobby9 = new List<__Player>();
        List<__Player> TempLobby10 = new List<__Player>();
        List<__Player> TempLobby11 = new List<__Player>();
        List<__Player> TempLobby12 = new List<__Player>();

        List<__Player> TempLobby13 = new List<__Player>();
        List<__Player> TempLobby14 = new List<__Player>();
        List<__Player> TempLobby15 = new List<__Player>();
        List<__Player> TempLobby16 = new List<__Player>();

        List<List<__Player>> ListOfLobbies = new List<List<__Player>>();


        string CopyTextA = "LOBBY 1 \r\n";
        string CopyTextB = "LOBBY 2 \r\n";
        string CopyTextC = "LOBBY 3 \r\n";
        string CopyTextD = "LOBBY 4 \r\n";

        string CopyTextE = "LOBBY 5 \r\n";
        string CopyTextF = "LOBBY 6 \r\n";
        string CopyTextG = "LOBBY 7 \r\n";
        string CopyTextH = "LOBBY 8 \r\n";

        string CopyTextI = "LOBBY 9 \r\n";
        string CopyTextJ = "LOBBY 10 \r\n";
        string CopyTextK = "LOBBY 11 \r\n";
        string CopyTextL = "LOBBY 12 \r\n";

        string CopyTextM = "LOBBY 13 \r\n";
        string CopyTextN = "LOBBY 14 \r\n";
        string CopyTextO = "LOBBY 15 \r\n";
        string CopyTextP = "LOBBY 16 \r\n";

        List<string> ListOfString = new List<string>();

        private void B_Generate_Click(object sender, RoutedEventArgs e)
        {

            RandomPlayers = PlayerObject.RandomizePlayers();

            foreach (List<__Player> l in ListOfLobbies)
            {
                l.Clear();
            }

            foreach (string s in ListOfString)
            {
                s.Remove(0);
            }


            switch (PlayersNumber)
            {
                case 8:

                    for (int i = 0; i < 8; i++){
                        CopyTextA += "@" + RandomPlayers[i].DCN + "-" + RandomPlayers[i].IGN + "\r\n";

                        CopyTextB += "8 PLAYERS MODE \r\n";
                        CopyTextC += "8 PLAYERS MODE \r\n";
                        CopyTextD += "8 PLAYERS MODE \r\n";
                        TempLobby1.Add(new __Player() { IGN = RandomPlayers[i].IGN });              
                    }
                    OutputNames_Lobby1.ItemsSource = TempLobby1;
                    break;


                case 16:

                    for (int i = 0; i < 8; i++){
                        CopyTextA += "@" + RandomPlayers[i].DCN + "-" + RandomPlayers[i].IGN + "\r\n";
                        TempLobby1.Add(new __Player() { IGN = RandomPlayers[i].IGN });

                        CopyTextB += "@" + RandomPlayers[i+8].DCN + "-" + RandomPlayers[i+8].IGN + "\r\n";
                        TempLobby2.Add(new __Player() { IGN = RandomPlayers[i+8].IGN });

                        CopyTextC += "16 PLAYERS MODE \r\n";
                        CopyTextD += "16 PLAYERS MODE \r\n";
                    }
                    OutputNames_Lobby1.ItemsSource = TempLobby1;
                    OutputNames_Lobby2.ItemsSource = TempLobby2;
                    break;


                case 24:
                    for (int i = 0; i < 8; i++){
                        CopyTextA += "@" + RandomPlayers[i].DCN + "-" + RandomPlayers[i].IGN + "\r\n";
                        TempLobby1.Add(new __Player() { IGN = RandomPlayers[i].IGN });

                        CopyTextB += "@" + RandomPlayers[i + 8].DCN + "-" + RandomPlayers[i + 8].IGN + "\r\n";
                        TempLobby2.Add(new __Player() { IGN = RandomPlayers[i+8].IGN });

                        CopyTextC += "@" + RandomPlayers[i + 16].DCN + "-" + RandomPlayers[i + 16].IGN + "\r\n";
                        TempLobby3.Add(new __Player() { IGN = RandomPlayers[i+16].IGN });

                        CopyTextD += "24 PLAYERS MODE \r\n";
                    }
                    OutputNames_Lobby1.ItemsSource = TempLobby1;
                    OutputNames_Lobby2.ItemsSource = TempLobby2;
                    OutputNames_Lobby3.ItemsSource = TempLobby3;
                    break;


                case 32:
                    for (int i = 0; i < 8; i++){
                        CopyTextA += "@" + RandomPlayers[i].DCN + "-" + RandomPlayers[i].IGN + "\r\n";
                        TempLobby1.Add(new __Player() { IGN = RandomPlayers[i].IGN });

                        CopyTextB += "@" + RandomPlayers[i + 8].DCN + "-" + RandomPlayers[i + 8].IGN + "\r\n";
                        TempLobby2.Add(new __Player() { IGN = RandomPlayers[i+8].IGN });

                        CopyTextC += "@" + RandomPlayers[i + 16].DCN + "-" + RandomPlayers[i + 16].IGN + "\r\n";
                        TempLobby3.Add(new __Player() { IGN = RandomPlayers[i+16].IGN });

                        CopyTextD += "@" + RandomPlayers[i + 24].DCN + "-" + RandomPlayers[i + 24].IGN + "\r\n";
                        TempLobby4.Add(new __Player() { IGN = RandomPlayers[i+24].IGN });
                    }
                    OutputNames_Lobby1.ItemsSource = TempLobby1;
                    OutputNames_Lobby2.ItemsSource = TempLobby2;
                    OutputNames_Lobby3.ItemsSource = TempLobby3;
                    OutputNames_Lobby4.ItemsSource = TempLobby4;
                    break;

                case 128:
                    for (int i = 0; i < 8; i++)
                    {
                        CopyTextA += "@" + RandomPlayers[i].DCN + "-" + RandomPlayers[i].IGN + "\r\n";
                        TempLobby1.Add(new __Player() { IGN = RandomPlayers[i].IGN });

                        CopyTextB += "@" + RandomPlayers[i + 8].DCN + "-" + RandomPlayers[i + 8].IGN + "\r\n";
                        TempLobby2.Add(new __Player() { IGN = RandomPlayers[i + 8].IGN });

                        CopyTextC += "@" + RandomPlayers[i + 16].DCN + "-" + RandomPlayers[i + 16].IGN + "\r\n";
                        TempLobby3.Add(new __Player() { IGN = RandomPlayers[i + 16].IGN });

                        CopyTextD += "@" + RandomPlayers[i + 24].DCN + "-" + RandomPlayers[i + 24].IGN + "\r\n";
                        TempLobby4.Add(new __Player() { IGN = RandomPlayers[i + 24].IGN });

                        //

                        CopyTextE += "@" + RandomPlayers[i + 32].DCN + "-" + RandomPlayers[i + 32].IGN + "\r\n";
                        TempLobby5.Add(new __Player() { IGN = RandomPlayers[i + 32].IGN });

                        CopyTextF += "@" + RandomPlayers[i + 40].DCN + "-" + RandomPlayers[i + 40].IGN + "\r\n";
                        TempLobby6.Add(new __Player() { IGN = RandomPlayers[i + 40].IGN });

                        CopyTextG += "@" + RandomPlayers[i + 48].DCN + "-" + RandomPlayers[i + 48].IGN + "\r\n";
                        TempLobby7.Add(new __Player() { IGN = RandomPlayers[i + 48].IGN });

                        CopyTextH += "@" + RandomPlayers[i + 56].DCN + "-" + RandomPlayers[i + 56].IGN + "\r\n";
                        TempLobby8.Add(new __Player() { IGN = RandomPlayers[i + 56].IGN });
                        
                        //

                        CopyTextI += "@" + RandomPlayers[i + 64].DCN + "-" + RandomPlayers[i +64].IGN + "\r\n";
                        TempLobby9.Add(new __Player() { IGN = RandomPlayers[i + 64].IGN });

                        CopyTextJ += "@" + RandomPlayers[i + 72].DCN + "-" + RandomPlayers[i + 72].IGN + "\r\n";
                        TempLobby10.Add(new __Player() { IGN = RandomPlayers[i + 72].IGN });

                        CopyTextK += "@" + RandomPlayers[i + 80].DCN + "-" + RandomPlayers[i + 80].IGN + "\r\n";
                        TempLobby11.Add(new __Player() { IGN = RandomPlayers[i + 80].IGN });

                        CopyTextL += "@" + RandomPlayers[i + 88].DCN + "-" + RandomPlayers[i + 88].IGN + "\r\n";
                        TempLobby12.Add(new __Player() { IGN = RandomPlayers[i + 88].IGN });

                        //

                        CopyTextM += "@" + RandomPlayers[i + 96].DCN + "-" + RandomPlayers[i +96].IGN + "\r\n";
                        TempLobby13.Add(new __Player() { IGN = RandomPlayers[i + 96].IGN });

                        CopyTextN += "@" + RandomPlayers[i + 104].DCN + "-" + RandomPlayers[i + 104].IGN + "\r\n";
                        TempLobby14.Add(new __Player() { IGN = RandomPlayers[i + 104].IGN });

                        CopyTextO += "@" + RandomPlayers[i + 112].DCN + "-" + RandomPlayers[i + 112].IGN + "\r\n";
                        TempLobby15.Add(new __Player() { IGN = RandomPlayers[i + 112].IGN });

                        CopyTextP += "@" + RandomPlayers[i + 120].DCN + "-" + RandomPlayers[i + 120].IGN + "\r\n";
                        TempLobby16.Add(new __Player() { IGN = RandomPlayers[i + 120].IGN });

                    }
                //    OutputNames_Lobby1.ItemsSource = TempLobby1;
               //     OutputNames_Lobby2.ItemsSource = TempLobby2;
               //     OutputNames_Lobby3.ItemsSource = TempLobby3;
                 //   OutputNames_Lobby4.ItemsSource = TempLobby4;
                    break;


            }

//            TextBox_Team1.Text = CopyTextA;
  //          TextBox_Team2.Text = CopyTextB;
    //        TextBox_Team3.Text = CopyTextC;
      //      TextBox_Team4.Text = CopyTextD;

            #region STARA WERSJA 
            /* STARA WERSJA 
for (int i = 0; i < PlayersNumber; i++)
{
    ResultNicks[i].Text = RandomPlayers[i].IGN;
}*/

            /*
            for (int i = ResultNicks.Count / 2; i < ResultNicks.Count; i++)
            {
                OutputNamesTeam2.Add(RandomPlayers[i]);
            }

            TextBox_Team1.Text = PlayerObject.FindPlayerByID(0).IGN;
            ResultNick1.Text = PlayerObject.FindPlayerByID(0).IGN; */
            #endregion
        }





        void WriteTextes(int i)
        {

            OutputNames_Lobby1.ItemsSource = null;
            OutputNames_Lobby2.ItemsSource = null;
            OutputNames_Lobby3.ItemsSource = null;
            OutputNames_Lobby4.ItemsSource = null;


           switch (i)
            {
                case 0:
                    OutputNames_Lobby1.ItemsSource = TempLobby1;
                    OutputNames_Lobby2.ItemsSource = TempLobby2;
                    OutputNames_Lobby3.ItemsSource = TempLobby3;
                    OutputNames_Lobby4.ItemsSource = TempLobby4;

                    TextBox_Team1.Text = CopyTextA;
                    TextBox_Team2.Text = CopyTextB;
                    TextBox_Team3.Text = CopyTextC;
                    TextBox_Team4.Text = CopyTextD;
                    break;

                case 1:
                    OutputNames_Lobby1.ItemsSource = "CIPA";
                    OutputNames_Lobby2.ItemsSource = "DUPA";
                    OutputNames_Lobby3.ItemsSource = "PIZDA";
                    OutputNames_Lobby4.ItemsSource = "CHUJ";

                    TextBox_Team1.Text = CopyTextE;
                    TextBox_Team2.Text = CopyTextF;
                    TextBox_Team3.Text = CopyTextG;
                    TextBox_Team4.Text = CopyTextH;
                    break;

                case 2:
                    OutputNames_Lobby1.ItemsSource = TempLobby9;
                    OutputNames_Lobby2.ItemsSource = TempLobby10;
                    OutputNames_Lobby3.ItemsSource = TempLobby11;
                    OutputNames_Lobby4.ItemsSource = TempLobby12;

                    TextBox_Team1.Text = CopyTextI;
                    TextBox_Team2.Text = CopyTextJ;
                    TextBox_Team3.Text = CopyTextK;
                    TextBox_Team4.Text = CopyTextL;
                    break;

                case 3:
                    OutputNames_Lobby1.ItemsSource = TempLobby13;
                    OutputNames_Lobby2.ItemsSource = TempLobby14;
                    OutputNames_Lobby3.ItemsSource = TempLobby15;
                    OutputNames_Lobby4.ItemsSource = TempLobby16;

                    TextBox_Team1.Text = CopyTextM;
                    TextBox_Team2.Text = CopyTextN;
                    TextBox_Team3.Text = CopyTextO;
                    TextBox_Team4.Text = CopyTextP;
                    break;

            } 
        }


    List<TextBlock> PlacingsInRound = new List<TextBlock>();

        void GenerateListOfPlacings()
        {
            PlacingInRounds.Add(PlacingInRound1); PlacingInRounds.Add(PlacingInRound2); PlacingInRounds.Add(PlacingInRound3); PlacingInRounds.Add(PlacingInRound4); PlacingInRounds.Add(PlacingInRound5); PlacingInRounds.Add(PlacingInRound6); PlacingInRounds.Add(PlacingInRound7); PlacingInRounds.Add(PlacingInRound8); PlacingInRounds.Add(PlacingInRound9); PlacingInRounds.Add(PlacingInRound10); PlacingInRounds.Add(PlacingInRound11); PlacingInRounds.Add(PlacingInRound12); PlacingInRounds.Add(PlacingInRound13); PlacingInRounds.Add(PlacingInRound14); PlacingInRounds.Add(PlacingInRound15); PlacingInRounds.Add(PlacingInRound16);
            PlacingInRounds.Add(PlacingInRound17); PlacingInRounds.Add(PlacingInRound18); PlacingInRounds.Add(PlacingInRound19); PlacingInRounds.Add(PlacingInRound20); PlacingInRounds.Add(PlacingInRound21); PlacingInRounds.Add(PlacingInRound22); PlacingInRounds.Add(PlacingInRound23); PlacingInRounds.Add(PlacingInRound24); PlacingInRounds.Add(PlacingInRound25); PlacingInRounds.Add(PlacingInRound26); PlacingInRounds.Add(PlacingInRound27); PlacingInRounds.Add(PlacingInRound28); PlacingInRounds.Add(PlacingInRound29); PlacingInRounds.Add(PlacingInRound30); PlacingInRounds.Add(PlacingInRound31); PlacingInRounds.Add(PlacingInRound32);

        }

        private void B_Submitt_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            int points = 0;
            foreach (__Player p in RandomPlayers)
            {
                points = PointsFromPlace(PlacingInRounds[i].Text);
                p.Score += points;
                i++;
            }
            WriteLeaderBoard(0, PlayersNumber);

            /*
            foreach (__Player p in LeaderBoardList)
            {
                TempLeaderBoard.Add(new __Player() {DCN = LeaderBoardList[j].DCN, IGN = LeaderBoardList[j].IGN,Score = LeaderBoardList[j].Score });
                j++;
               
            }*/
           

        }

        void WriteLeaderBoard(int i, int j)
        {
            List<__Player> LeaderBoardList = PlayerObject.LeaderBoardList(RandomPlayers);
            List<__Player> EmptyList = new List<__Player>();
            List<__Player> TempLeaderBoard = new List<__Player>();

            LeaderboardBox.ItemsSource = null;
            for (int k = i; k < j; k++)
            {
                TempLeaderBoard.Add(new __Player() { DCN = LeaderBoardList[k].DCN, IGN = LeaderBoardList[k].IGN, Score = LeaderBoardList[k].Score });
                k++;
            }
            LeaderboardBox.ItemsSource = TempLeaderBoard;
        }
         
        /*
                PlayerList.Clear();
                    lvUsers.ItemsSource = null;
                    //   PlayerUsers.Clear();
                    for (int j = 0; j<PlayersNumber; j++)
                    {
                        PlayerList.Add(new __Player() { DiscordName = DiscordName1.GetLineText(j).TrimEnd('\n').TrimEnd('\r'), InGameNick = Nickname1.GetLineText(j).TrimEnd('\n').TrimEnd('\r') });
                        PlayerUsers.Add(items[j]);
                    }
            lvUsers.ItemsSource = items;
        */





        List<string> Nicknames = new List<string>();
        List<string> DiscordNames = new List<string>();


        List<__Player> RandomPlayers = new List<__Player>();

        List<TextBlock> ResultNicks = new List<TextBlock>();

        List<__Player> OutputNamesTeam1 = new List<__Player>();
        List<__Player> OutputNamesTeam2 = new List<__Player>();

        List<TextBox> PlacingInRounds = new List<TextBox>();
       // List<TextBlock> PointsInRounds = new List<TextBlock>();

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
            /* STARAWERSJA
            Nicknames.Add(Nickname1.Text); Nicknames.Add(Nickname2.Text); Nicknames.Add(Nickname3.Text); Nicknames.Add(Nickname4.Text); Nicknames.Add(Nickname5.Text); Nicknames.Add(Nickname6.Text); Nicknames.Add(Nickname7.Text); Nicknames.Add(Nickname8.Text); Nicknames.Add(Nickname9.Text); Nicknames.Add(Nickname10.Text); Nicknames.Add(Nickname11.Text); Nicknames.Add(Nickname12.Text); Nicknames.Add(Nickname13.Text); Nicknames.Add(Nickname14.Text); Nicknames.Add(Nickname15.Text); Nicknames.Add(Nickname16.Text);
            DiscordNames.Add(DiscordName1.Text); DiscordNames.Add(DiscordName2.Text); DiscordNames.Add(DiscordName3.Text); DiscordNames.Add(DiscordName4.Text); DiscordNames.Add(DiscordName5.Text); DiscordNames.Add(DiscordName6.Text); DiscordNames.Add(DiscordName7.Text); DiscordNames.Add(DiscordName8.Text); DiscordNames.Add(DiscordName9.Text); DiscordNames.Add(DiscordName10.Text); DiscordNames.Add(DiscordName11.Text); DiscordNames.Add(DiscordName12.Text); DiscordNames.Add(DiscordName13.Text); DiscordNames.Add(DiscordName14.Text); DiscordNames.Add(DiscordName15.Text); DiscordNames.Add(DiscordName16.Text);

            ResultNicks.Add(ResultNick1); ResultNicks.Add(ResultNick2); ResultNicks.Add(ResultNick3); ResultNicks.Add(ResultNick4); ResultNicks.Add(ResultNick5); ResultNicks.Add(ResultNick6); ResultNicks.Add(ResultNick7); ResultNicks.Add(ResultNick8); ResultNicks.Add(ResultNick9); ResultNicks.Add(ResultNick10); ResultNicks.Add(ResultNick11); ResultNicks.Add(ResultNick12); ResultNicks.Add(ResultNick13); ResultNicks.Add(ResultNick14); ResultNicks.Add(ResultNick15); ResultNicks.Add(ResultNick16);

            PlacingInRounds.Add(PlacingInRound1); PlacingInRounds.Add(PlacingInRound2); PlacingInRounds.Add(PlacingInRound3); PlacingInRounds.Add(PlacingInRound4); PlacingInRounds.Add(PlacingInRound5); PlacingInRounds.Add(PlacingInRound6); PlacingInRounds.Add(PlacingInRound7); PlacingInRounds.Add(PlacingInRound8); PlacingInRounds.Add(PlacingInRound9); PlacingInRounds.Add(PlacingInRound10); PlacingInRounds.Add(PlacingInRound11); PlacingInRounds.Add(PlacingInRound12); PlacingInRounds.Add(PlacingInRound13); PlacingInRounds.Add(PlacingInRound14); PlacingInRounds.Add(PlacingInRound15); PlacingInRounds.Add(PlacingInRound16);
            PointsInRounds.Add(PointsInRound1); PointsInRounds.Add(PointsInRound2); PointsInRounds.Add(PointsInRound3); PointsInRounds.Add(PointsInRound4); PointsInRounds.Add(PointsInRound5); PointsInRounds.Add(PointsInRound6); PointsInRounds.Add(PointsInRound7); PointsInRounds.Add(PointsInRound8); PointsInRounds.Add(PointsInRound9); PointsInRounds.Add(PointsInRound10); PointsInRounds.Add(PointsInRound11); PointsInRounds.Add(PointsInRound12); PointsInRounds.Add(PointsInRound13); PointsInRounds.Add(PointsInRound14); PointsInRounds.Add(PointsInRound15); PointsInRounds.Add(PointsInRound16);

            LeaderBoardNicks.Add(LeaderBoardNick1); LeaderBoardNicks.Add(LeaderBoardNick2); LeaderBoardNicks.Add(LeaderBoardNick3); LeaderBoardNicks.Add(LeaderBoardNick4); LeaderBoardNicks.Add(LeaderBoardNick5); LeaderBoardNicks.Add(LeaderBoardNick6); LeaderBoardNicks.Add(LeaderBoardNick7); LeaderBoardNicks.Add(LeaderBoardNick8); LeaderBoardNicks.Add(LeaderBoardNick9); LeaderBoardNicks.Add(LeaderBoardNick10); LeaderBoardNicks.Add(LeaderBoardNick11); LeaderBoardNicks.Add(LeaderBoardNick12); LeaderBoardNicks.Add(LeaderBoardNick13); LeaderBoardNicks.Add(LeaderBoardNick14); LeaderBoardNicks.Add(LeaderBoardNick15); LeaderBoardNicks.Add(LeaderBoardNick16);
            LeaderBoardDiscords.Add(LeaderBoardDiscord1); LeaderBoardDiscords.Add(LeaderBoardDiscord2); LeaderBoardDiscords.Add(LeaderBoardDiscord3); LeaderBoardDiscords.Add(LeaderBoardDiscord4); LeaderBoardDiscords.Add(LeaderBoardDiscord5); LeaderBoardDiscords.Add(LeaderBoardDiscord6); LeaderBoardDiscords.Add(LeaderBoardDiscord7); LeaderBoardDiscords.Add(LeaderBoardDiscord8); LeaderBoardDiscords.Add(LeaderBoardDiscord9); LeaderBoardDiscords.Add(LeaderBoardDiscord10); LeaderBoardDiscords.Add(LeaderBoardDiscord11); LeaderBoardDiscords.Add(LeaderBoardDiscord12); LeaderBoardDiscords.Add(LeaderBoardDiscord13); LeaderBoardDiscords.Add(LeaderBoardDiscord14); LeaderBoardDiscords.Add(LeaderBoardDiscord15); LeaderBoardDiscords.Add(LeaderBoardDiscord16);
            LeaderBoardScores.Add(LeaderBoardScore1); LeaderBoardScores.Add(LeaderBoardScore2); LeaderBoardScores.Add(LeaderBoardScore3); LeaderBoardScores.Add(LeaderBoardScore4); LeaderBoardScores.Add(LeaderBoardScore5); LeaderBoardScores.Add(LeaderBoardScore6); LeaderBoardScores.Add(LeaderBoardScore7); LeaderBoardScores.Add(LeaderBoardScore8); LeaderBoardScores.Add(LeaderBoardScore9); LeaderBoardScores.Add(LeaderBoardScore10); LeaderBoardScores.Add(LeaderBoardScore11); LeaderBoardScores.Add(LeaderBoardScore12); LeaderBoardScores.Add(LeaderBoardScore13); LeaderBoardScores.Add(LeaderBoardScore14); LeaderBoardScores.Add(LeaderBoardScore15); LeaderBoardScores.Add(LeaderBoardScore16);
        */
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
            WriteLeaderBoard(0, 64);
        }

        private void B_R2_Click(object sender, RoutedEventArgs e)
        {

            WriteLeaderBoard(17, 32);
        }

        private void RadioButton_PlayersNumber_8_Checked(object sender, RoutedEventArgs e)
        {
            SetPlayersNumber(8);
        }

        private void RadioButton_PlayersNumber_16_Checked(object sender, RoutedEventArgs e)
        {
            SetPlayersNumber(16);
        }

        private void RadioButton_PlayersNumber_24_Checked(object sender, RoutedEventArgs e)
        {
            SetPlayersNumber(32);
        }

        private void RadioButton_PlayersNumber_128_Checked(object sender, RoutedEventArgs e)
        {
            SetPlayersNumber(128);
        }

        private void LvUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_Team1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_Team3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void B_R5_Copy_Click(object sender, RoutedEventArgs e)
        {
            WriteTextes(1);
        }

        private void B_R5_Copy2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void B_R5_Copy3_Click(object sender, RoutedEventArgs e)
        {
            WriteTextes(0);
        }

        private void B_R5_Copy5_Click(object sender, RoutedEventArgs e)
        {
            WriteTextes(3);
        }

        private void B_R3_Click(object sender, RoutedEventArgs e)
        {
            WriteLeaderBoard(33, 48);
        }
    }

    public class User
    {
        public string DiscordName { get; set; }
        public string InGameNick { get; set; }
    }


    public class __Player
    {
        int IDCounter = 0;


        public string IGN { get; set; }
        public string DCN { get; set; }
        public int  Score { get; set; }
        public int Place { get; set; }
        public int ID;


        public List<__Player> PlayersList = new List<__Player>();
        public List<__Player> InputList = new List<__Player>();

        public __Player()
        {

        }

        public __Player(string DN, string RN, int id)
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


