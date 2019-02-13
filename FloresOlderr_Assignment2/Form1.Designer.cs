using System.Windows.Forms;

namespace FloresOlderr_Assignment2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }  

        public ListView getOutputListView()
        {
            return this.OutputListView;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrintGuildButton = new System.Windows.Forms.Button();
            this.DisbandGuildButton = new System.Windows.Forms.Button();
            this.JoinGuildButton = new System.Windows.Forms.Button();
            this.LeaveGuildButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PlayersListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchPlayerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchGuildTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GuildsListView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.RaceComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AddGuildButton = new System.Windows.Forms.Button();
            this.GuildTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ServerComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GuildNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.OutputListView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintGuildButton
            // 
            this.PrintGuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintGuildButton.Location = new System.Drawing.Point(6, 28);
            this.PrintGuildButton.Name = "PrintGuildButton";
            this.PrintGuildButton.Size = new System.Drawing.Size(150, 20);
            this.PrintGuildButton.TabIndex = 0;
            this.PrintGuildButton.Text = "Print Guild Roster";
            this.PrintGuildButton.UseVisualStyleBackColor = true;
            this.PrintGuildButton.Click += new System.EventHandler(this.printGuild_Click);
            // 
            // DisbandGuildButton
            // 
            this.DisbandGuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisbandGuildButton.Location = new System.Drawing.Point(6, 54);
            this.DisbandGuildButton.Name = "DisbandGuildButton";
            this.DisbandGuildButton.Size = new System.Drawing.Size(150, 20);
            this.DisbandGuildButton.TabIndex = 1;
            this.DisbandGuildButton.Text = "Disband Guild";
            this.DisbandGuildButton.UseVisualStyleBackColor = true;
            this.DisbandGuildButton.Click += new System.EventHandler(this.DisbandGuildButton_Click);
            // 
            // JoinGuildButton
            // 
            this.JoinGuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinGuildButton.Location = new System.Drawing.Point(6, 80);
            this.JoinGuildButton.Name = "JoinGuildButton";
            this.JoinGuildButton.Size = new System.Drawing.Size(150, 20);
            this.JoinGuildButton.TabIndex = 2;
            this.JoinGuildButton.Text = "Join Guild";
            this.JoinGuildButton.UseVisualStyleBackColor = true;
            this.JoinGuildButton.Click += new System.EventHandler(this.JoinGuildButton_Click);
            // 
            // LeaveGuildButton
            // 
            this.LeaveGuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveGuildButton.Location = new System.Drawing.Point(6, 106);
            this.LeaveGuildButton.Name = "LeaveGuildButton";
            this.LeaveGuildButton.Size = new System.Drawing.Size(150, 20);
            this.LeaveGuildButton.TabIndex = 3;
            this.LeaveGuildButton.Text = "Leave Guild";
            this.LeaveGuildButton.UseVisualStyleBackColor = true;
            this.LeaveGuildButton.Click += new System.EventHandler(this.LeaveGuildButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(6, 132);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(150, 20);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Apply Search Criteria";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PlayersListView
            // 
            this.PlayersListView.HideSelection = false;
            this.PlayersListView.LabelWrap = false;
            this.PlayersListView.Location = new System.Drawing.Point(395, 100);
            this.PlayersListView.Name = "PlayersListView";
            this.PlayersListView.Size = new System.Drawing.Size(203, 296);
            this.PlayersListView.TabIndex = 5;
            this.PlayersListView.UseCompatibleStateImageBehavior = false;
            this.PlayersListView.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search Player (by Name)";
            // 
            // SearchPlayerTextBox
            // 
            this.SearchPlayerTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchPlayerTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchPlayerTextBox.Location = new System.Drawing.Point(174, 44);
            this.SearchPlayerTextBox.Name = "SearchPlayerTextBox";
            this.SearchPlayerTextBox.Size = new System.Drawing.Size(121, 20);
            this.SearchPlayerTextBox.TabIndex = 8;
            this.SearchPlayerTextBox.TextChanged += new System.EventHandler(this.SearchPlayerTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search Guild (by Server)";
            // 
            // SearchGuildTextBox
            // 
            this.SearchGuildTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchGuildTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchGuildTextBox.Location = new System.Drawing.Point(174, 86);
            this.SearchGuildTextBox.Name = "SearchGuildTextBox";
            this.SearchGuildTextBox.Size = new System.Drawing.Size(118, 20);
            this.SearchGuildTextBox.TabIndex = 10;
            this.SearchGuildTextBox.TextChanged += new System.EventHandler(this.SearchGuildTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrintGuildButton);
            this.groupBox1.Controls.Add(this.SearchGuildTextBox);
            this.groupBox1.Controls.Add(this.DisbandGuildButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.JoinGuildButton);
            this.groupBox1.Controls.Add(this.SearchPlayerTextBox);
            this.groupBox1.Controls.Add(this.LeaveGuildButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 156);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Management Functions";
            // 
            // GuildsListView
            // 
            this.GuildsListView.HideSelection = false;
            this.GuildsListView.LabelWrap = false;
            this.GuildsListView.Location = new System.Drawing.Point(701, 104);
            this.GuildsListView.Name = "GuildsListView";
            this.GuildsListView.Size = new System.Drawing.Size(277, 291);
            this.GuildsListView.TabIndex = 12;
            this.GuildsListView.UseCompatibleStateImageBehavior = false;
            this.GuildsListView.View = System.Windows.Forms.View.List;
            this.GuildsListView.SelectedIndexChanged += new System.EventHandler(this.GuildsListView_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(701, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Guilds";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClassComboBox);
            this.groupBox2.Controls.Add(this.AddPlayerButton);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.RoleComboBox);
            this.groupBox2.Controls.Add(this.RaceComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PlayerNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 117);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create New Player";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Druid",
            "Priest",
            "Warlock",
            "Rogue",
            "Paladin",
            "Hunter",
            "Shaman"});
            this.ClassComboBox.Location = new System.Drawing.Point(6, 82);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(100, 21);
            this.ClassComboBox.TabIndex = 0;
            this.ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.selectClass_ComboBox);
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(261, 38);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.AddPlayerButton.TabIndex = 8;
            this.AddPlayerButton.Text = "Add Player";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Role";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Race";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(133, 82);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(121, 21);
            this.RoleComboBox.TabIndex = 0;
            // 
            // RaceComboBox
            // 
            this.RaceComboBox.FormattingEnabled = true;
            this.RaceComboBox.Items.AddRange(new object[] {
            "Orc",
            "Troll",
            "Tauren",
            "Forsaken"});
            this.RaceComboBox.Location = new System.Drawing.Point(133, 38);
            this.RaceComboBox.Name = "RaceComboBox";
            this.RaceComboBox.Size = new System.Drawing.Size(121, 21);
            this.RaceComboBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Player Name";
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.Location = new System.Drawing.Point(6, 39);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlayerNameTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.AddGuildButton);
            this.groupBox3.Controls.Add(this.GuildTypeComboBox);
            this.groupBox3.Controls.Add(this.ServerComboBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.GuildNameTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 114);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create New Guild";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Server";
            // 
            // AddGuildButton
            // 
            this.AddGuildButton.Location = new System.Drawing.Point(264, 34);
            this.AddGuildButton.Name = "AddGuildButton";
            this.AddGuildButton.Size = new System.Drawing.Size(75, 23);
            this.AddGuildButton.TabIndex = 4;
            this.AddGuildButton.Text = "Add Guild";
            this.AddGuildButton.UseVisualStyleBackColor = true;
            this.AddGuildButton.Click += new System.EventHandler(this.AddGuildButton_Click);
            // 
            // GuildTypeComboBox
            // 
            this.GuildTypeComboBox.FormattingEnabled = true;
            this.GuildTypeComboBox.Items.AddRange(new object[] {
            "Causal",
            "Questing",
            "Mythic+",
            "Raiding",
            "PVP"});
            this.GuildTypeComboBox.Location = new System.Drawing.Point(136, 87);
            this.GuildTypeComboBox.Name = "GuildTypeComboBox";
            this.GuildTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.GuildTypeComboBox.TabIndex = 0;
            // 
            // ServerComboBox
            // 
            this.ServerComboBox.FormattingEnabled = true;
            this.ServerComboBox.Items.AddRange(new object[] {
            "Beta4Azeroth",
            "TKWasASetback",
            "ZappyBoi"});
            this.ServerComboBox.Location = new System.Drawing.Point(136, 37);
            this.ServerComboBox.Name = "ServerComboBox";
            this.ServerComboBox.Size = new System.Drawing.Size(121, 21);
            this.ServerComboBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Guild Name";
            // 
            // GuildNameTextBox
            // 
            this.GuildNameTextBox.Location = new System.Drawing.Point(10, 37);
            this.GuildNameTextBox.Name = "GuildNameTextBox";
            this.GuildNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.GuildNameTextBox.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Output";
            // 
            // OutputListView
            // 
            this.OutputListView.AccessibleName = "";
            this.OutputListView.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.OutputListView.LabelWrap = false;
            this.OutputListView.Location = new System.Drawing.Point(12, 466);
            this.OutputListView.Name = "OutputListView";
            this.OutputListView.Size = new System.Drawing.Size(1021, 125);
            this.OutputListView.TabIndex = 17;
            this.OutputListView.TileSize = new System.Drawing.Size(250, 30);
            this.OutputListView.UseCompatibleStateImageBehavior = false;
            this.OutputListView.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 618);
            this.Controls.Add(this.OutputListView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GuildsListView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayersListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrintGuildButton;
        private System.Windows.Forms.Button DisbandGuildButton;
        private System.Windows.Forms.Button JoinGuildButton;
        private System.Windows.Forms.Button LeaveGuildButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListView PlayersListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchPlayerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchGuildTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView GuildsListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.ComboBox RaceComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PlayerNameTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ServerComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox GuildNameTextBox;
        private System.Windows.Forms.Button AddGuildButton;
        private System.Windows.Forms.ComboBox GuildTypeComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView OutputListView;
        private Label label12;
        private Label label11;
        private ComboBox ClassComboBox;
    }
}

