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
            }
        }

        public ListView OutputList { get; }

        private void printGuild_Click(object sender, EventArgs e)
        { 
            foreach(Guild g in guild_roster)
            {
                string guild_string = getGuildString(g.ID);
                string server = g.Server;
                string output_heading = "Guild Listing for " + guild_string + " [" + server + "]\n";
                OutputListView.Items.Add(output_heading);
                OutputListView.Items.Add("-----------------------------------------------------------");
                foreach (Player p in player_roster)
                {
                    string race = getRaceString(p.Race);
                    if (p.GuildID == g.ID)
                    {
                        OutputListView.Items.Add(String.Format("Name: {0} Race: {1} Level: {2} Guild: {3}", p.Name, race, p.Level, guild_string));
                    }
                }
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
            Player player = new Player(id, name, race, class_String, "0", "0", guildId);
            player_roster.Add(player);
            PlayersListView.Items.Add(player.ToString());
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string playerName = SearchPlayerTextBox.Text.ToString();
            string guildName = SearchGuildTextBox.Text.ToString();
            bool found = false;
            foreach( Player p in player_roster)
            {
               
                if ( playerName.Equals(p.Name) )
                {
                    selected_player = p;

                    break;
                }
            }
            foreach ( Guild g in guild_roster)
            {
                if ( guildName.Trim().Equals(g.Name.Trim()) )
                {
                    selected_guild = g;
                    break;
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
            string playerName = SearchPlayerTextBox.ToString();

            foreach (Player p in player_roster)
            {
                if (playerName == SearchPlayerTextBox.ToString())
                {
                    string guild_string = getGuildString(p.GuildID);

                    p.GuildID = "";
                    OutputListView.Clear();
                    OutputListView.Items.Add(p.Name + " left guild " + guild_string);
                    break;
                }
            }
        }

        private void SearchPlayerTextBox_TextChanged(object sender, EventArgs e)
        {
            PlayersListView.Clear();
            foreach (Player p in player_roster)
            {
                if(p.Name.Contains(SearchPlayerTextBox.Text))
                PlayersListView.Items.Add(String.Format("{0} {1} {2}",p.Name, GetClass(p.ClassString), p.Level));
            }
        }

        private void JoinGuildButton_Click(object sender, EventArgs e)
        {
            try
            {
                string nextGuildID = selected_guild.ID;
                selected_player.ID = nextGuildID;
                foreach(Player p in player_roster)
                {
                    if (p.ID.Equals(selected_player.ID) )
                    {
                        p.GuildID = nextGuildID;
                        OutputListView.Clear();
                        OutputListView.Items.Add(p.Name + " joined " + selected_guild.Name + " - " + "[" + selected_guild.Server + "]");
                    } 
                }
            } catch (NullReferenceException nre)
            {

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
        }

     

        private void SearchGuildTextBox_TextChanged(object sender, EventArgs e)
        {
            GuildsListView.Clear();
            if (SearchGuildTextBox.Text.Equals(""))
            {
                foreach(Guild g in guild_roster)
                {
                    GuildsListView.Items.Add(String.Format("{0} [{1}]", g.Name, g.Server));
                }
                return;
            }

            foreach (Guild g in guild_roster)
            {
                if (g.Server.Contains(SearchGuildTextBox.Text))
                {
                    GuildsListView.Items.Add(String.Format("{0} [{1}]", g.Name, g.Server));
                }
            }

        }

        private void DisbandGuildButton_Click(object sender, EventArgs e)
        {
            string guild_Name = SearchGuildTextBox.Text.ToString();
            bool removed = false;
            OutputListView.Clear();
            OutputListView.Items.Add(guild_Name);
            do
            {
                removed = false;
                foreach (Guild g in guild_roster)
                {
                    if (guild_Name.Trim().Equals(g.Name.Trim()))
                    {
                        int players_removed = 0;
                        List<Player> removals = new List<Player>();
                        foreach (Player p in player_roster)
                        {
                            if (p.GuildID == g.ID)
                            {
                                p.GuildID = "";
                                removals.Add(p);
                                ++players_removed;                              
                            }
                        }
                        OutputListView.Clear();
                        OutputListView.Items.Add(players_removed + " Players have been disbanded from " + g.Name);
                        foreach (Player player in removals)
                        {
                            OutputListView.Items.Add(player.Name + player.Race + player.Level, player.GuildID);
                        }
                        guild_roster.Remove(g);
                        removed = true;
                        SearchGuildTextBox.AutoCompleteCustomSource.Remove(g.Server);
                        break;
                    }
                }
            }
            while (removed);
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

                        Console.WriteLine("GUILD NAME = " + g_name);
                        break;
                    }
                }
            }
            //foreach (Guild g in guild_roster)
            //{
            //    Console.WriteLine("NAMEEEEEEEEEE ====== " + g.Name + "    " + guild_name);
            //    if (g.Name.Trim().Equals(guild_name.Trim()))
            //    {
            //        selected_guild = g;
            //        SearchGuildTextBox.Text = g.Name;
            //        Console.WriteLine("Name ====== " + g.Name);
            //    }
            //}
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

        public override string ToString()
        {
            return String.Format("{0: -20} {1: -20} {2: 10}", name, Form1.GetClass(classString), Level);
        }
    }
}