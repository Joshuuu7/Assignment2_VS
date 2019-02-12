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

    //public enum Race { Orc = 0, Troll = 1, Tauren = 2, Forsaken = 3 };

    public partial class Form1 : Form
    {
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

                    //guild = objectBuffer.ToString().Trim();
                    //Race ra;
                    //switch (race.Trim()) {
                    //    case "0":
                    //        ra = Race.Forsaken;
                    //        break;
                    //    case "1":
                    //        ra = Race.Orc;
                    //        break;
                    //    case "2":
                    //        ra = Race.Tauren;
                    //        break;
                    //    default:
                    //        ra = Race.Troll;
                    //        break;
                    //}

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
                    //Console.WriteLine("object Buffer = " + objectBuffer.ToString());
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
                    //System.Console.WriteLine("after reading the ID, obj buf = " + objectBuffer.ToString());
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
                            //i = alphabet.IndexOf(ch);
                            objectBuffer.Append(ch);
                        }
                        catch (IndexOutOfRangeException aioobexc)
                        {
                            break;
                        }
                    } while (ch != '-');
                    name = objectBuffer.ToString();
                    //Console.WriteLine("naming object buffer = " + objectBuffer.ToString());
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
                    //Console.WriteLine("id: " + id + " name: " + name + " server: " + server);
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
            //getAllPlayers();
        }

        public ListView OutputList { get; }

        //public static List<Player> getAllPlayers()
        //{
        //    string alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //    string alphabetLower = "abcdefghijklmnopqrstuvwxyz";
        //    string digits = "1234567890";
        //    string allPossibleChars = alphabetUpper + alphabetLower + digits;
        //    uint GEAR_SLOTS = 14;
        //    List<Player> player_roster = new List<Player>();
        //    using (StreamReader inFile = new StreamReader("players.txt"))
        //    {

        //        string idString = "";
        //        string nameString = "";
        //        string raceString = "";
        //        string levelString = "";
        //        string expString = "";
        //        string guildString = "";
        //        uint[] gear = new uint[GEAR_SLOTS];
        //        List<uint> inventory = new List<uint>();

        //        bool readingID = false;
        //        bool readingName = false;
        //        bool readingRace = false;
        //        bool readingLevel = false;
        //        bool readingExp = false;
        //        bool readingGuild = false;
        //        bool readingGear0 = false, readingGear1 = false, readingGear2 = false, readingGear3 = false, readingGear4 = false, readingGear5 = false, readingGear6 = false, readingGear7 = false, readingGear8 = false, readingGear9 = false, readingGear10 = false, readingGear11 = false, readingGear12 = false, readingGear13 = false;

        //        Race race;

        //        readingID = true;
        //        StringBuilder variableBuilder = new StringBuilder();
        //        uint g_index = 0;
        //        while (!inFile.EndOfStream)
        //        {
        //            char ch = (char)inFile.Read();
        //            int index_of = allPossibleChars.IndexOf(ch);
        //            if (index_of == -1)
        //            {
        //                if (readingID)
        //                {
        //                    idString = variableBuilder.ToString();
        //                    variableBuilder = new StringBuilder();
        //                    readingID = false;
        //                    readingName = true;
        //                }
        //                else if (readingName)
        //                {
        //                    nameString = variableBuilder.ToString();
        //                    variableBuilder = new StringBuilder();
        //                    readingName = false;
        //                    readingRace = true;
        //                }
        //                else if (readingRace)
        //                {
        //                    raceString = variableBuilder.ToString();
        //                    variableBuilder = new StringBuilder();
        //                    readingRace = false;
        //                    readingLevel = true;
        //                }
        //                else if (readingLevel)
        //                {
        //                    levelString = variableBuilder.ToString();
        //                    variableBuilder = new StringBuilder();
        //                    readingLevel = false;
        //                    readingExp = true;
        //                }
        //                else if (readingExp)
        //                {
        //                    expString = variableBuilder.ToString();
        //                    variableBuilder = new StringBuilder();
        //                    readingExp = false;
        //                    readingGuild = true;
        //                }
        //                else if (readingGuild)
        //                {
        //                    guildString = variableBuilder.ToString();
        //                    variableBuilder = new StringBuilder();
        //                    readingGuild = false;
        //                    readingGear0 = true;
        //                }
        //                else if (readingGear0)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear0 = false;
        //                    readingGear1 = true;
        //                }
        //                else if (readingGear1)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear1 = false;
        //                    readingGear2 = true;
        //                }
        //                else if (readingGear2)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear2 = false;
        //                    readingGear3 = true;
        //                }
        //                else if (readingGear3)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear3 = false;
        //                    readingGear4 = true;
        //                }
        //                else if (readingGear4)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear4 = false;
        //                    readingGear5 = true;
        //                }
        //                else if (readingGear5)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear5 = false;
        //                    readingGear6 = true;
        //                }
        //                else if (readingGear6)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear6 = false;
        //                    readingGear7 = true;
        //                }
        //                else if (readingGear7)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear7 = false;
        //                    readingGear8 = true;
        //                }
        //                else if (readingGear8)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear8 = false;
        //                    readingGear9 = true;
        //                }
        //                else if (readingGear9)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear9 = false;
        //                    readingGear10 = true;
        //                }
        //                else if (readingGear10)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear10 = false;
        //                    readingGear11 = true;
        //                }
        //                else if (readingGear11)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear11 = false;
        //                    readingGear12 = true;
        //                }
        //                else if (readingGear12)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear12 = false;
        //                    readingGear13 = true;
        //                }
        //                else if (readingGear13)
        //                {
        //                    gear[g_index++] = Convert.ToUInt32(variableBuilder.ToString());
        //                    variableBuilder = new StringBuilder();
        //                    readingGear13 = false;
        //                    switch (Convert.ToUInt32(raceString))
        //                    {
        //                        case 0:
        //                            race = Race.Orc;
        //                            break;
        //                        case 1:
        //                            race = Race.Troll;
        //                            break;
        //                        case 2:
        //                            race = Race.Tauren;
        //                            break;
        //                        default:
        //                            race = Race.Forsaken;
        //                            break;
        //                    }
        //                    player_roster.Add(new Player(Convert.ToUInt32(idString), nameString, race, Convert.ToUInt32(levelString), Convert.ToUInt32(expString), Convert.ToUInt32(guildString), gear, inventory));
        //                    gear = new uint[GEAR_SLOTS];
        //                    g_index = 0;
        //                    inFile.Read();
        //                    readingID = true;
        //                }
        //            }
        //            else
        //            {
        //                variableBuilder.Append(ch);
        //            }
        //        }
        //        inventory.Add(Convert.ToUInt32(variableBuilder.ToString()));
        //        switch (Convert.ToUInt32(raceString))
        //        {
        //            case 0:
        //                race = Race.Orc;
        //                break;
        //            case 1:
        //                race = Race.Troll;
        //                break;
        //            case 2:
        //                race = Race.Tauren;
        //                break;
        //            default:
        //                race = Race.Forsaken;
        //                break;
        //        }
        //        gear[g_index] = Convert.ToUInt32(variableBuilder.ToString());
        //        player_roster.Add(new Player(Convert.ToUInt32(idString), nameString, race, Convert.ToUInt32(levelString), Convert.ToUInt32(expString), Convert.ToUInt32(guildString), gear, inventory));
        //    }
        //    Console.WriteLine(player_roster);
        //    return player_roster;
        //}

        private void printGuild_Click(object sender, EventArgs e)
        {
            // This function happens when you click on the button that says 'Print Guild Roster'. 
            //Console.WriteLine("I will print the guild roster :)");
            //OutputListView.Items.Add("I m inside the guild roster :)");
            string reader = "";
            string guildWithoutSpaces = "";
            string[] guilds = { };
            using (StreamReader inFile = new StreamReader(@"guilds.txt"))
            {
                string guild = "";
                while (!inFile.EndOfStream)
                {
                    reader = inFile.ReadLine().ToString();
                    {
                        {
                            // Code from https://stackoverflow.com/questions/7411438/remove-characters-from-c-sharp-string 
                            guild = new string((from c in reader where char.IsWhiteSpace(c) || char.IsLetter(c) select c).ToArray());
                            char[] ch = guild.ToCharArray();
                            ch[0] = ' ';
                            guildWithoutSpaces = new string(ch);
                            OutputListView.Items.Add(guildWithoutSpaces);
                        }
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


        //public class Player : IComparable
        //{
        //    private readonly string name;
        //    private readonly Race race;
        //    private string class_String;
        //    private uint guildID;

        //    public string Name
        //    {
        //        get
        //        {
        //            return name;
        //        }
        //    }

        //    public Race Race
        //    {
        //        get
        //        {
        //            return race;
        //        }
        //    }

        //    public string Class_String
        //    {
        //        get
        //        {
        //            return class_String;
        //        }
        //        set
        //        {
        //            class_String = value;
        //        }
        //    }

        //    public uint GuildID
        //    {
        //        get
        //        {
        //            return guildID;
        //        }
        //        set
        //        {
        //            guildID = value;
        //        }
        //    }

        //    public Player()
        //    {
        //        name = Name;
        //        race = Race.Orc;
        //        class_String = Class_String;
        //        guildID = 475186;
        //    }

        //    public Player(string name, Race race, string class_String, uint guildId)
        //    {

        //        this.name = name;
        //        this.race = race;
        //        this.guildID = guildId;
        //    }

        //    // Used to sort the objects.
        //    public int CompareTo(object alpha)
        //    {
        //        Player itemObject = (Player)alpha;
        //        int value = itemObject.Name.CompareTo(this.Name);
        //        if (value == 1)
        //            return 1;
        //        else if (value == -1)
        //            return -1;
        //        else
        //            return 0;
        //    }
        //    public override string ToString()
        //    {
        //        string guild_string = "";
        //        switch (guildID)
        //        {
        //            case 475186:
        //                guild_string = "Knights of Cydonia";
        //                break;
        //            case 748513:
        //                guild_string = "Death and Taxes";
        //                break;
        //            case 154794:
        //                guild_string = "I Just Crit My Pants";
        //                break;
        //            case 928126:
        //                guild_string = "What Have We Here";
        //                break;
        //            case 513487:
        //                guild_string = "Big Dumb Guild";
        //                break;
        //            case 864722:
        //                guild_string = "Honestly";
        //                break;
        //            case 185470:
        //                guild_string = "Sacred Heart";
        //                break;
        //            case 726518:
        //                guild_string = "Dont Click Rez";
        //                break;
        //            case 623818:
        //                guild_string = "Less Than Three";
        //                break;
        //            case 019274:
        //                guild_string = "Is Bad At This Game";
        //                break;
        //            case 028671:
        //                guild_string = "Roll For Initiative";
        //                break;
        //            case 267481:
        //                guild_string = "Death and Taxes";
        //                break;
        //        }
        //        return string.Format("Name: {0, -20} Role: {1, -10} Class: {2, -10}", name, race, class_String);
        //    }
        //}




        private void PlayersListView_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            string guildServer = SearchGuildTextBox.Text.ToString();
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
                if ( guildServer.Trim().Equals(g.Server.Trim()) )
                {
                    selected_guild = g;
                    Console.WriteLine(g.Server + " " + guildServer);

                    break;
                }
                Console.WriteLine(g.Server + " message " + guildServer);
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
            //if(selected_player == null || selected_player.Name == "" || selected_guild == null || selected_guild.Server == "")
            //{
            //    OutputListView.Clear();
            //    OutputListView.Items.Add("Nothing was a match for your filtering criteria");
            //}
        }

        private void LeaveGuildButton_Click(object sender, EventArgs e)
        {
            string playerName = SearchPlayerTextBox.ToString();
            string guildServer = SearchGuildTextBox.ToString();

            foreach (Player p in player_roster)
            {
                if (playerName == SearchPlayerTextBox.ToString() && SearchGuildTextBox.ToString() == "" )
                {
                    PlayersListView.Items.Clear();
                    GuildsListView.Items.Clear();

                    PlayersListView.Items.Add(p.ToString());
                    GuildsListView.Items.Add("Cool Guild");
                }
                else
                {
                    string errorSearch = "Nothing was a match for your filtering criteria";
                    OutputListView.Items.Clear();
                    OutputListView.Items.Add(errorSearch);
                }
            }
        }

        private void SearchPlayerTextBox_TextChanged(object sender, EventArgs e)
        {
            //    List<string> player_names = new List<string>();
            //    foreach(Player p in player_roster)
            //    {
            //        player_names.Add(p.Name);
            //    }
            //    string myString = SearchPlayerTextBox.Text;
            //    int index = player_names.FindIndex(x => x.Equals(myString));

            //    for (int i = 0; i <= PlayersListView.Items.Count -1; i++)
            //    {
            //        if (PlayersListView.Items[i].ToString().Contains(myString))
            //        {
            //            PlayersListView.SetSelected();
            //        }
            //    }
            //    int index_string = PlayersListView.FindString(myString, -1);
            //    Console.WriteLine(index);
        }

        private void JoinGuildButton_Click(object sender, EventArgs e)
        {
            try
            {
                string nextGuildID = selected_guild.ID;
                selected_player.ID = nextGuildID;
                foreach(Player p in player_roster)
                {
                    OutputListView.Clear();
                    Console.WriteLine(p.ToString());
                    OutputListView.Items.Add(p.ToString());
                }
            } catch (NullReferenceException nre)
            {

            }
        }
    }

    /*
         *  Josh, you may only want to copy what is inside this namespace.
         */

    /*enum Race
    { // I don't know if this already exists.
        Orc, Troll, Tauren, Forsaken;
    }*/

    class Guild
    {

        private string id;
        private string name;
        private string server;

        public Guild(string id, string name, string server)
        {
            this.id = id;
            this.name = name;
            this.server = server;
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
            return name + "   " + server + "\n";
        }

    }

    class Player
    { // Josh, I remodeled the player class. 
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

        public string ToString()
        {
            return name + "   " + classString + "   " +  Level;
        }
    }
}