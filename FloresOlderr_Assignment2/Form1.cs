/********************************************************************************
 * 
 * Programmers: Joshua Flores, Adam Olderr
 * 
 * Assignment Number : 2
 * 
 * Due Date: February 14, 2018
 * 
 * Class: CSCI504
 * 
 * Instructor: Daniel Rogness
 * 
 * 
 * *******************************************************************************/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.IO;

namespace FloresOlderr_Assignment2
{

    public partial class Form1 : Form
    {
        //Lists for overall storge and retrieval throughtout the app.
        Dictionary<string, string> customGuilds = new Dictionary<string, string>();

        List<Player> player_roster = new List<Player>();
        List<Guild> guild_roster = new List<Guild>();
        Player selected_player;
        Guild selected_guild;

        List<Player> readPlayers()
        {
            List<Player> players = new List<Player>();
            bool readingID = true, readingName = false, readingRace = false, readingClassString = false, readingLevel = false, readingExp = false, readingGuild = false;
            string digits = "0123456789";
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string alphanumeric = digits + alphabet;
            string id = "";
            string name = "";
            string race = "";
            string classString = "";
            string level = "";
            string exp = "";
            string guild = "";
            int i = 0;
            char ch = ' ';

            using (StreamReader inFile = new StreamReader("players.txt")) {
                while (!inFile.EndOfStream) {
                    StringBuilder objectBuffer = new StringBuilder();
                    // Get through the white spaces.
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = alphanumeric.IndexOf(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            break;
                        }
                    while (i == -1);
                    objectBuffer.Append(ch);
                    // Read the digits of the id.
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = digits.IndexOf(ch);
                            objectBuffer.Append(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            break;
                        }
                    while (i != -1);
                    id = objectBuffer.ToString().Trim();
                    objectBuffer = new StringBuilder();
                    // Get through the white spaces.
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = alphabet.IndexOf(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            break;
                        }
                    while (i == -1);
                    objectBuffer.Append(ch);
                    // Read the name.
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = alphabet.IndexOf(ch);
                            objectBuffer.Append(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            break;
                        }
                    while (i != -1);
                    name = objectBuffer.ToString().Trim();
                    objectBuffer = new StringBuilder();
                    // Get through the white spaces.
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = digits.IndexOf(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            break;
                        }
                    while (i == -1);
                    objectBuffer.Append(ch);
                    // Read the digits of the race string.
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = digits.IndexOf(ch);
                            objectBuffer.Append(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            break;
                        }
                    while (i != -1);
                    race = objectBuffer.ToString().Trim();
                    objectBuffer = new StringBuilder();
                    // Get through the white spaces.
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = digits.IndexOf(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            break;
                        }
                    while (i == -1);
                    objectBuffer.Append(ch);
                    // Read the digits of the classString string.
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = digits.IndexOf(ch);
                            objectBuffer.Append(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            break;
                        }
                    while (i != -1);
                    classString = objectBuffer.ToString().Trim();
                    objectBuffer = new StringBuilder();
                    // Get through the white spaces.
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = digits.IndexOf(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            break;
                        }
                    while (i == -1);
                    objectBuffer.Append(ch);
                    // Read the digits of the level string. 
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = digits.IndexOf(ch);
                            objectBuffer.Append(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            break;
                        }
                    while (i != -1);
                    level = objectBuffer.ToString().Trim();
                    objectBuffer = new StringBuilder();
                    // Get through the white spaces.
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = digits.IndexOf(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            break;
                        }
                    while (i == -1);
                    objectBuffer.Append(ch);
                    // Read the digits of the exp string.
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = digits.IndexOf(ch);
                            objectBuffer.Append(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            break;
                        }
                    while (i != -1);
                    exp = objectBuffer.ToString().Trim();
                    objectBuffer = new StringBuilder();
                    // Get through the white spaces.
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = digits.IndexOf(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            break;
                        }
                    while (i == -1);
                    objectBuffer.Append(ch);
                    // Read the digits of the guild string.
                    do
                        try {
                            ch = (char)inFile.Read();
                            i = digits.IndexOf(ch);
                            objectBuffer.Append(ch);
                        } catch (IndexOutOfRangeException ioorexc) {
                            Console.WriteLine(objectBuffer.ToString() + "reading");
                            break;
                        }
                    while (i != -1);
                    guild = objectBuffer.ToString().Trim();
                    Player P = new Player(id, name, race, classString, level, exp, guild);
                    players.Add(P);
                }
            }
            return players;
        }

        List<Guild> ReadGuilds()
        {
            List<Guild> guilds = new List<Guild>();
            string digits = "1234567890";
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string alphanumeric = digits + alphabet;
            string id = "";
            string name = "";
            string server = ""; 
            int i = 0;
            char ch = ' ';

            using (StreamReader inFile = new StreamReader("guilds.txt"))
            {
                while (!inFile.EndOfStream)
                {
                    StringBuilder objectBuffer = new StringBuilder();
                    do
                        try
                        {
                            ch = (char)inFile.Read();
                            i = digits.IndexOf(ch);
                        }
                        catch (IndexOutOfRangeException aioobexc)
                        {
                            break;
                        }
                    while (i == -1);
                    objectBuffer.Append(ch);
                    do
                    {
                        try
                        {
                            ch = (char)inFile.Read();
                            i = digits.IndexOf(ch);
                            objectBuffer.Append(ch);
                        }
                        catch (IndexOutOfRangeException aioobexc)
                        {
                            break;
                        }
                    } while (i != -1);
                    id = objectBuffer.ToString().Trim();
                    objectBuffer = new StringBuilder();
                    do
                        try
                        {
                            ch = (char)inFile.Read();
                            i = alphabet.IndexOf(ch);
                        }
                        catch (IndexOutOfRangeException aioobexc)
                        {
                            break;
                        }
                    while (i == -1);
                    objectBuffer.Append(ch);
                    do
                    {
                        try
                        {
                            ch = (char)inFile.Read();
                            objectBuffer.Append(ch);
                        }
                        catch (IndexOutOfRangeException aioobexc)
                        {
                            break;
                        }
                    } while (ch != '-');
                    name = objectBuffer.ToString();
                    objectBuffer = new StringBuilder();
                    do
                    {
                        try
                        {
                            ch = (char)inFile.Read();
                            i = alphanumeric.IndexOf(ch);
                            objectBuffer.Append(ch);
                        }
                        catch (IndexOutOfRangeException aioobexc)
                        {
                            break;
                        }
                    } while (i != -1);
                    server = objectBuffer.ToString();
                    Guild G = new Guild(id, name, server);
                    guilds.Add(G);
                }
            }

            return guilds;
        }

        public Form1()
        {
            InitializeComponent();
           
            ListView OutputListView = getOutputListView();
            guild_roster = ReadGuilds();
            foreach (Guild g in guild_roster)
            {
                GuildsListView.Items.Add(g.ToString());
                SearchGuildTextBox.AutoCompleteCustomSource.Add(g.Server);
            }

            player_roster = readPlayers();
            foreach (Player p in player_roster)
            {
                PlayersListView.Items.Add(p.ToString());
                SearchPlayerTextBox.AutoCompleteCustomSource.Add(p.Name);
                Console.WriteLine("My roster includes " + p.Name + " inside the guild " + getGuildString(p.GuildID));
            }
        }

        public ListView OutputList { get; }

        private void printGuild_Click(object sender, EventArgs e)
        {
            try
            {
                string guild_item = GuildsListView.SelectedItems[0].Text;
                StringBuilder guildSelectionBuilder = new StringBuilder();
                foreach (char ch
                in guild_item.ToCharArray())
                {
                    if (ch == '[')
                    {
                        break;
                    }
                    guildSelectionBuilder.Append(ch);
                }
                string guildName = guildSelectionBuilder.ToString().Trim();
                foreach (Guild G in guild_roster)
                {
                    if (G.Name.Equals(guildName))
                    {
                        selected_guild = G;
                        break;
                    }
                }
                OutputListView.Clear();
                List<Player> members = new List<Player>();
                foreach (Player p in player_roster)
                {
                    if (p.GuildID.Equals(selected_guild.ID))
                    {
                        members.Add(p);
                    }
                }
              
                StringBuilder header_text = new StringBuilder(String.Format("Guild Listing for {0, -30} [{1}] \n", selected_guild.Name, selected_guild.Server.ToString()));
               
                OutputListView.Items.Add(header_text.ToString());
                members.Sort((x, y) => x.Name.CompareTo(y.Name));
                OutputListView.Items.Add("------------------------------------------------------------------------------------------\n");
                foreach (Player p in members)
                {
                    StringBuilder outputBuilder = new StringBuilder(String.Format("\nName: {0} Race: {1, -20} Level: {2, -2} Guild: {3, 20}-{4} \n", p.Name, getRaceString(p.Race), p.Level, getGuildString(p.GuildID), selected_guild));
                    OutputListView.Items.Add(outputBuilder.ToString());
                }
            }
            catch (ArgumentOutOfRangeException aoorexc)
            {
                // 
                //OutputListView.Clear();
                //OutputListView.Items.Add("You need to ensure both a Player and Guild have been selected.");
            }
        }

        private void selectClass_ComboBox(object sender, EventArgs e)
        {
            RoleComboBox.Items.Clear();
            int index = ClassComboBox.SelectedIndex;

            switch(index)
            {
                case 0:
                    RoleComboBox.Items.Add("Tank");
                    RoleComboBox.Items.Add("DPS");
                    break;
                case 1:
                    RoleComboBox.Items.Add("DPS");
                    break;
                case 2:
                    RoleComboBox.Items.Add("Tank");
                    RoleComboBox.Items.Add("Healer");
                    RoleComboBox.Items.Add("DPS");
                    break;
                case 3:
                    RoleComboBox.Items.Add("Healer");
                    RoleComboBox.Items.Add("DPS");
                    break;
                case 4:
                    RoleComboBox.Items.Add("DPS");
                    break;
                case 5:
                    RoleComboBox.Items.Add("DPS");
                    break;
                case 6:
                    RoleComboBox.Items.Add("Tank");
                    RoleComboBox.Items.Add("Healer");
                    RoleComboBox.Items.Add("DPS");
                    break;
                case 7:
                    RoleComboBox.Items.Add("DPS");
                    break;
                case 8:
                    RoleComboBox.Items.Add("Healer");
                    RoleComboBox.Items.Add("DPS");
                    break;
            }
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string id = Player.getID()+ "";
            string guildId = "";
            string name = PlayerNameTextBox.Text;
            string race = RaceComboBox.Text;
            string class_String = ClassComboBox.Text;
            string role = RoleComboBox.Text;
            switch(random.Next(0, 12))
            {
                case 0:
                    guildId = "475186";
                    break;
                case 1:
                    guildId = "748513";
                    break;
                case 2:
                    guildId = "154793";
                    break;
                case 3:
                    guildId = "928126";
                    break;
                case 4:
                    guildId = "513487";
                    break;
                case 5:
                    guildId = "864722";
                    break;
                case 6:
                    guildId = "185470";
                    break;
                case 7:
                    guildId = "726518";
                    break;
                case 8:
                    guildId = "623818";
                    break;
                case 9:
                    guildId = "019274";
                    break;
                case 10:
                    guildId = "028671";
                    break;
                case 11:
                    guildId = "267481";
                    break;
            }
            Player player = new Player(id, name, getRaceString(race), GetClass(class_String), "0", "0", guildId);
            player_roster.Add(player);
            PlayersListView.Items.Add(player.ToString());
        }


        // This method just filters the ListViews
        private void SearchButton_Click(object sender, EventArgs e)
        {
            PlayersListView.Clear();
            GuildsListView.Clear();
            string player_filter = SearchPlayerTextBox.Text.Trim();
            if (!player_filter.Equals(""))
            {
                foreach (Player p in player_roster)
                {
                    if (p.Name.ToUpper().Contains(player_filter.ToUpper()))
                    {
                        PlayersListView.Items.Add(p.ToString());
                    }
                }
            }
            else
            {
                foreach (Player p in player_roster)
                {
                    PlayersListView.Items.Add(p.ToString());
                }
            }
            string guild_filter = SearchGuildTextBox.Text.Trim();

            if (!guild_filter.Equals(""))
            { 
                foreach (Guild g in guild_roster)
                {
                    if (g.Server.ToUpper().Contains(guild_filter.ToUpper()))
                    {
                        GuildsListView.Items.Add(g.ToString());
                    }
                }
            }
            else
            {
                foreach (Guild g in guild_roster)
                {
                    GuildsListView.Items.Add(g.ToString());
                }
            }

            OutputListView.Clear();
            if (selected_player != null)
            {
                OutputListView.Items.Add(selected_player.ToString());
            }
            if (selected_guild != null)
            {
                OutputListView.Items.Add(selected_guild.ToString());
            }
            if (selected_player == null && selected_guild == null) // Both null 
            {
                // Error messge...
                OutputListView.Clear();
                OutputListView.Items.Add("Nothing was a match for your filtering criteria");
            }

        }

        private string getGuildString(string guildId)
        {
            string guild_string = "";

            switch (guildId)
            {
                case "475186":
                    guild_string = "Knights of Cydonia";
                    break;
                case "748513":
                    guild_string = "Death and Taxes";
                    break;
                case "154794":
                    guild_string = "I Just Crit My Pants";
                    break;
                case "928126":
                    guild_string = "What Have We Here";
                    break;
                case "513487":
                    guild_string = "Big Dumb Guild";
                    break;
                case "864722":
                    guild_string = "Honestly";
                    break;
                case "185470":
                    guild_string = "Sacred Heart";
                    break;
                case "726518":
                    guild_string = "Dont Click Rez";
                    break;
                case "623818":
                    guild_string = "Less Than Three";
                    break;
                case "019274":
                    guild_string = "Is Bad At This Game";
                    break;
                case "028671":
                    guild_string = "Roll For Initiative";
                    break;
                case "267481":
                    guild_string = "Death and Taxes";
                    break;
                default:
                    try
                    {
                        guild_string = customGuilds[guildId];
                    }
                    catch(KeyNotFoundException knfe)
                    {
                        guild_string = "";
                    }
                    break;
            }
            return guild_string;
        }

        private string getRaceString(string raceId)
        {
            switch(raceId)
            {
                case "1":
                    return "Troll";
                case "2":
                    return "Tauren";
                case "3":
                    return "Forsaken";
                default:
                    return "Orc";
            }
        }

        public static string GetClass(string class_string)
        {
            switch (class_string)
            {
                case "0":
                    return "Warrior";
                case "1":
                    return "Mage";
                case "2":
                    return "Druid";
                case "3":
                    return "Priest";
                case "4":
                    return "Warlock";
                case "5":
                    return "Rogue";
                case "6":
                    return "Palladin";
                case "7":
                    return "Hunter";
                default:
                    return "Shaman";
            }
        }

        private void LeaveGuildButton_Click(object sender, EventArgs e)
        {

            int count = PlayersListView.SelectedItems.Count;
            int i = 0;
            OutputListView.Clear();

            while (i < count)
            {
                try
                {
                    string player_item = PlayersListView.SelectedItems[i].Text;

                    StringBuilder playerSelectionBuilder = new StringBuilder();

                    foreach (char ch in player_item.ToCharArray())
                    {
                        if (ch == ' ')

                        {

                            break;
                        }
                        playerSelectionBuilder.Append(ch);
                    }

                    string playerName = playerSelectionBuilder.ToString().Trim();

                    foreach (Player P in player_roster)
                    {
                        if (P.Name.Equals(playerName))
                        {
                            selected_player = P;

                            break;
                        }
                    }
                    string original_guild = getGuildString(selected_player.GuildID);

                    selected_player.GuildID = "";

                   OutputListView.Items.Add(selected_player.Name + " has left " + original_guild + "\n");
                }
                catch (ArgumentOutOfRangeException aoorexc)
                {
                    // 
                    OutputListView.Clear();
                    OutputListView.Items.Add("You need to ensure a Player has been selected.");
                }
                i++;
            }
        }

        private void JoinGuildButton_Click(object sender, EventArgs e)
        {
            try
            {
                string player_item = PlayersListView.SelectedItems[0].Text;
                
                string guild_item = GuildsListView.SelectedItems[0].Text;

                StringBuilder playerSelectionBuilder = new StringBuilder();

                foreach (char ch in player_item.ToCharArray())
                {
                    if (ch == ' ')

                    {

                        break;
                    }
                    playerSelectionBuilder.Append(ch);
                }

                string playerName = playerSelectionBuilder.ToString().Trim();

                foreach (Player P in player_roster)
                {
                    if (P.Name.Equals(playerName))
                    {
                        selected_player = P;

                        break;
                    }
                }
                StringBuilder guildSelectionBuilder = new StringBuilder();
                foreach (char ch
                in guild_item.ToCharArray())
                {
                    if (ch == '[')
                    {
                        break;
                    }
                    guildSelectionBuilder.Append(ch);
                }
                string guildName = guildSelectionBuilder.ToString().Trim();
                foreach (Guild G
                in guild_roster)
                {
                    if (G.Name.Equals(guildName))
                    {
                        selected_guild = G;
                        break;
                    }
                }
                OutputListView.Clear();
                Console.WriteLine("Got the players/guilds : " + selected_player.Name + "  " + selected_guild.Name);
                selected_player.GuildID = selected_guild.ID;
                OutputListView.Items.Add(selected_player.Name + " has joined " + selected_guild.Name + "\n");
            }
            catch (ArgumentOutOfRangeException aoorexc)
            {
                // 
                OutputListView.Clear();
                OutputListView.Items.Add("You need to ensure both a Player and Guild have been selected.");
            }
        }

        private void AddGuildButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string id = Guild.getID() + "";
            string name = GuildNameTextBox.Text;
            string server = ServerComboBox.Text;
            string type = GuildTypeComboBox.Text;

            Guild guild = new Guild(id, name, server);
            guild_roster.Add(guild);
            GuildsListView.Items.Add(guild.ToString());
            SearchGuildTextBox.AutoCompleteCustomSource.Add(guild.Server);
            customGuilds.Add(id, name);
        }

        private void DisbandGuildButton_Click(object sender, EventArgs e)
        {

            try
            {
                string guild_item = GuildsListView.SelectedItems[0].Text;
                StringBuilder guildSelectionBuilder = new StringBuilder();
                foreach (char ch
                in guild_item.ToCharArray())
                {
                    if (ch == '[')
                    {
                        break;
                    }
                    guildSelectionBuilder.Append(ch);
                }
                string guildName = guildSelectionBuilder.ToString().Trim();
                foreach (Guild G in guild_roster)
                {
                    if (G.Name.Equals(guildName))
                    {
                        selected_guild = G;
                        break;
                    }
                }  
                OutputListView.Clear();
                int players_removed = 0;
                List<Player> removals = new List<Player>();
                foreach (Player p in player_roster)
                {
                    if (p.GuildID.Equals(selected_guild.ID))
                    {
                        p.GuildID = "";
                        removals.Add(p);
                        players_removed++;
                        Console.WriteLine(p.Name + " is leaving " + selected_guild.Name);
                    }
                }
                bool removed;
                do
                {
                    removed = false;
                    foreach (Guild G in guild_roster)
                    {
                        if (G.ID.Equals(selected_guild.ID))
                        {
                            removed = true;
                            guild_roster.Remove(G);
                            break;
                        }
                    }
                }
                while (removed);
                OutputListView.Items.Add(players_removed + " player have been disbanded from " + selected_guild.Name);
                foreach (Player p in removals)
                {
                    OutputListView.Items.Add(p.ToString());
                }
                GuildsListView.Clear();
                foreach(Guild G in guild_roster)
                {
                    GuildsListView.Items.Add(G.ToString());
                }
            }
            catch (ArgumentOutOfRangeException aoorexc)
            {
                // 
                //OutputListView.Clear();
                //OutputListView.Items.Add("You need to ensure both a Player and Guild have been selected.");
            }

            //string guild_Name = SearchGuildTextBox.Text.ToString();
            //bool removed = false;
            //OutputListView.Clear();
            //OutputListView.Items.Add(guild_Name);
            //do
            //{
            //    removed = false;
            //    foreach (Guild g in guild_roster)
            //    {
            //        if (guild_Name.Trim().Equals(g.Name.Trim()))
            //        {
            //            int players_removed = 0;
            //            List<Player> removals = new List<Player>();
            //            foreach (Player p in player_roster)
            //            {
            //                if (p.GuildID == g.ID)
            //                {
            //                    p.GuildID = "";
            //                    removals.Add(p);
            //                    ++players_removed;                              
            //                }
            //            }
            //            OutputListView.Clear();
            //            OutputListView.Items.Add(players_removed + " Players have been disbanded from " + g.Name);
            //            foreach (Player player in removals)
            //            {
            //                OutputListView.Items.Add(player.Name + player.Race + player.Level, player.GuildID);
            //            }
            //            guild_roster.Remove(g);
            //            removed = true;
            //            SearchGuildTextBox.AutoCompleteCustomSource.Remove(g.Server);
            //            break;
            //        }
            //    }
            //}
            //while (removed);
        }

        private void GuildsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( GuildsListView.SelectedItems.Count > 0)
            {
                for( int lcount = 0; lcount <= GuildsListView.Items.Count; lcount ++)
                {
                    if (GuildsListView.Items[lcount].Selected)
                    {
                        string text = GuildsListView.Items[lcount].Text;
                        StringBuilder guild_name_builder = new StringBuilder();
                        foreach(char ch in text.ToCharArray())
                        {
                            if (ch == '[')
                                break;
                            guild_name_builder.Append(ch);
                        }
                        string g_name = guild_name_builder.ToString().Trim();
                        //SearchGuildTextBox = guild_name.ToString();
                        foreach(Guild g in guild_roster)
                        {
                            if (g.Name.Equals(g_name))
                            {
                                selected_guild = g;
                            }
                        }
                        break;
                    }
                }
            }
        }
    }

    class Guild
    {
        static int nextID;
        private string id;
        private string name;
        private string server;

        public Guild(string id, string name, string server)
        {
            this.id = id;
            this.name = name;
            this.server = server;

            if (name.ToCharArray()[name.Length - 1] == '-')
            {
                this.name = this.name.Substring(0, this.name.Length - 1);
            }
        }

        public static int getID()
        {
            return nextID++;
        }

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Server
        {
            get
            {
                return server;
            }
            set
            {
                server = value;
            }
        } 

        public override string ToString()
        {

            return String.Format("{0: -20} [{1: 20}]", name, server);
        }

    }

    class Player
    {
        static int nextId;
        private string id;
        private string name;
        private string race;
        private string classString;
        private string level;
        private string exp;
        private string guildID;

        public Player(string id, string name, string race, string classString, string level, string exp, string guildID)
        {
            this.id = id;
            this.name = name;
            this.race = race;
            this.classString = classString;
            this.level = level;
            this.exp = exp;
            this.guildID = guildID;
        }
        
        public static int getID()
        {
            return nextId++;
        }

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Race
        {
            get
            {
                return race;
            }
            set
            {
                race = value;
            }
        }

        public string ClassString
        {
            get
            {
                return classString;
            }
            set
            {
                classString = value;
            }
        }

        public string Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        public string Exp
        {
            get
            {
                return exp;
            }
            set
            {
                exp = value;
            }
        }

        public string GuildID
        {
            get
            {
                return guildID;
            }
            set
            {
                guildID = value;
            }
        }
        public int CompareTo(object alpha)
        {
            Player itemObject = (Player)alpha;
            int value = itemObject.Name.CompareTo(this.Name);
            if (value == 1)
                return 1;
            else if (value == -1)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(String.Format("{0, -13} {1, 12} {2, 2}", name, Form1.GetClass(classString), Level));

            return stringBuilder.ToString();
        }
    }
}