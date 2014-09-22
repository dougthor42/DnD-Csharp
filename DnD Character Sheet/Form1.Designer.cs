namespace WindowsFormsApplication1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.proficient_str = new System.Windows.Forms.CheckBox();
            this.proficient_dex = new System.Windows.Forms.CheckBox();
            this.proficient_con = new System.Windows.Forms.CheckBox();
            this.proficient_int = new System.Windows.Forms.CheckBox();
            this.proficient_wis = new System.Windows.Forms.CheckBox();
            this.proficient_cha = new System.Windows.Forms.CheckBox();
            this.label_strength = new System.Windows.Forms.Label();
            this.label_dexterity = new System.Windows.Forms.Label();
            this.label_constitution = new System.Windows.Forms.Label();
            this.label_intelligence = new System.Windows.Forms.Label();
            this.label_wisdom = new System.Windows.Forms.Label();
            this.label_charisma = new System.Windows.Forms.Label();
            this.ui_pts_str = new System.Windows.Forms.NumericUpDown();
            this.ui_pts_dex = new System.Windows.Forms.NumericUpDown();
            this.ui_pts_con = new System.Windows.Forms.NumericUpDown();
            this.ui_pts_int = new System.Windows.Forms.NumericUpDown();
            this.ui_pts_wis = new System.Windows.Forms.NumericUpDown();
            this.ui_pts_cha = new System.Windows.Forms.NumericUpDown();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.label_class = new System.Windows.Forms.Label();
            this.comboBox_race = new System.Windows.Forms.ComboBox();
            this.label_race = new System.Windows.Forms.Label();
            this.ui_points_str_total = new System.Windows.Forms.TextBox();
            this.ui_points_dex_total = new System.Windows.Forms.TextBox();
            this.points_con_total = new System.Windows.Forms.TextBox();
            this.points_int_total = new System.Windows.Forms.TextBox();
            this.points_wis_total = new System.Windows.Forms.TextBox();
            this.points_int_cha = new System.Windows.Forms.TextBox();
            this.label_score = new System.Windows.Forms.Label();
            this.label_attr_points = new System.Windows.Forms.Label();
            this.label_attr_points_total = new System.Windows.Forms.Label();
            this.ui_score_str = new System.Windows.Forms.TextBox();
            this.ui_score_dex = new System.Windows.Forms.TextBox();
            this.score_con = new System.Windows.Forms.TextBox();
            this.score_int = new System.Windows.Forms.TextBox();
            this.score_wis = new System.Windows.Forms.TextBox();
            this.score_cha = new System.Windows.Forms.TextBox();
            this.label_attr_proficient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ability_scores = new System.Windows.Forms.Label();
            this.label_saving_throws = new System.Windows.Forms.Label();
            this.label_attr_saving_throw_bonus = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ui_pts_str)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_pts_dex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_pts_con)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_pts_int)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_pts_wis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_pts_cha)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // proficient_str
            // 
            this.proficient_str.AutoSize = true;
            this.proficient_str.Location = new System.Drawing.Point(208, 60);
            this.proficient_str.Name = "proficient_str";
            this.proficient_str.Size = new System.Drawing.Size(15, 14);
            this.proficient_str.TabIndex = 1;
            this.proficient_str.UseVisualStyleBackColor = true;
            // 
            // proficient_dex
            // 
            this.proficient_dex.AutoSize = true;
            this.proficient_dex.Location = new System.Drawing.Point(208, 86);
            this.proficient_dex.Name = "proficient_dex";
            this.proficient_dex.Size = new System.Drawing.Size(15, 14);
            this.proficient_dex.TabIndex = 1;
            this.proficient_dex.UseVisualStyleBackColor = true;
            // 
            // proficient_con
            // 
            this.proficient_con.AutoSize = true;
            this.proficient_con.Location = new System.Drawing.Point(208, 111);
            this.proficient_con.Name = "proficient_con";
            this.proficient_con.Size = new System.Drawing.Size(15, 14);
            this.proficient_con.TabIndex = 1;
            this.proficient_con.UseVisualStyleBackColor = true;
            // 
            // proficient_int
            // 
            this.proficient_int.AutoSize = true;
            this.proficient_int.Location = new System.Drawing.Point(208, 137);
            this.proficient_int.Name = "proficient_int";
            this.proficient_int.Size = new System.Drawing.Size(15, 14);
            this.proficient_int.TabIndex = 1;
            this.proficient_int.UseVisualStyleBackColor = true;
            // 
            // proficient_wis
            // 
            this.proficient_wis.AutoSize = true;
            this.proficient_wis.Location = new System.Drawing.Point(208, 165);
            this.proficient_wis.Name = "proficient_wis";
            this.proficient_wis.Size = new System.Drawing.Size(15, 14);
            this.proficient_wis.TabIndex = 1;
            this.proficient_wis.UseVisualStyleBackColor = true;
            // 
            // proficient_cha
            // 
            this.proficient_cha.AutoSize = true;
            this.proficient_cha.Location = new System.Drawing.Point(208, 189);
            this.proficient_cha.Name = "proficient_cha";
            this.proficient_cha.Size = new System.Drawing.Size(15, 14);
            this.proficient_cha.TabIndex = 1;
            this.proficient_cha.UseVisualStyleBackColor = true;
            this.proficient_cha.CheckedChanged += new System.EventHandler(this.proficient_cha_CheckedChanged);
            // 
            // label_strength
            // 
            this.label_strength.AutoSize = true;
            this.label_strength.Location = new System.Drawing.Point(20, 64);
            this.label_strength.Name = "label_strength";
            this.label_strength.Size = new System.Drawing.Size(47, 13);
            this.label_strength.TabIndex = 2;
            this.label_strength.Text = "Strength";
            this.label_strength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_dexterity
            // 
            this.label_dexterity.AutoSize = true;
            this.label_dexterity.Location = new System.Drawing.Point(19, 90);
            this.label_dexterity.Name = "label_dexterity";
            this.label_dexterity.Size = new System.Drawing.Size(48, 13);
            this.label_dexterity.TabIndex = 2;
            this.label_dexterity.Text = "Dexterity";
            this.label_dexterity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_constitution
            // 
            this.label_constitution.AutoSize = true;
            this.label_constitution.Location = new System.Drawing.Point(5, 116);
            this.label_constitution.Name = "label_constitution";
            this.label_constitution.Size = new System.Drawing.Size(62, 13);
            this.label_constitution.TabIndex = 2;
            this.label_constitution.Text = "Constitution";
            this.label_constitution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_intelligence
            // 
            this.label_intelligence.AutoSize = true;
            this.label_intelligence.Location = new System.Drawing.Point(6, 142);
            this.label_intelligence.Name = "label_intelligence";
            this.label_intelligence.Size = new System.Drawing.Size(61, 13);
            this.label_intelligence.TabIndex = 2;
            this.label_intelligence.Text = "Intelligence";
            this.label_intelligence.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_wisdom
            // 
            this.label_wisdom.AutoSize = true;
            this.label_wisdom.Location = new System.Drawing.Point(22, 168);
            this.label_wisdom.Name = "label_wisdom";
            this.label_wisdom.Size = new System.Drawing.Size(45, 13);
            this.label_wisdom.TabIndex = 2;
            this.label_wisdom.Text = "Wisdom";
            this.label_wisdom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_charisma
            // 
            this.label_charisma.AutoSize = true;
            this.label_charisma.Location = new System.Drawing.Point(17, 194);
            this.label_charisma.Name = "label_charisma";
            this.label_charisma.Size = new System.Drawing.Size(50, 13);
            this.label_charisma.TabIndex = 2;
            this.label_charisma.Text = "Charisma";
            this.label_charisma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_pts_str
            // 
            this.ui_pts_str.Location = new System.Drawing.Point(69, 60);
            this.ui_pts_str.Name = "ui_pts_str";
            this.ui_pts_str.Size = new System.Drawing.Size(42, 20);
            this.ui_pts_str.TabIndex = 2;
            this.ui_pts_str.ValueChanged += new System.EventHandler(this.points_str_ValueChanged);
            // 
            // ui_pts_dex
            // 
            this.ui_pts_dex.Location = new System.Drawing.Point(69, 86);
            this.ui_pts_dex.Name = "ui_pts_dex";
            this.ui_pts_dex.Size = new System.Drawing.Size(42, 20);
            this.ui_pts_dex.TabIndex = 3;
            // 
            // ui_pts_con
            // 
            this.ui_pts_con.Location = new System.Drawing.Point(69, 112);
            this.ui_pts_con.Name = "ui_pts_con";
            this.ui_pts_con.Size = new System.Drawing.Size(42, 20);
            this.ui_pts_con.TabIndex = 4;
            // 
            // ui_pts_int
            // 
            this.ui_pts_int.Location = new System.Drawing.Point(69, 138);
            this.ui_pts_int.Name = "ui_pts_int";
            this.ui_pts_int.Size = new System.Drawing.Size(42, 20);
            this.ui_pts_int.TabIndex = 5;
            // 
            // ui_pts_wis
            // 
            this.ui_pts_wis.Location = new System.Drawing.Point(69, 164);
            this.ui_pts_wis.Name = "ui_pts_wis";
            this.ui_pts_wis.Size = new System.Drawing.Size(42, 20);
            this.ui_pts_wis.TabIndex = 6;
            // 
            // ui_pts_cha
            // 
            this.ui_pts_cha.Location = new System.Drawing.Point(69, 190);
            this.ui_pts_cha.Name = "ui_pts_cha";
            this.ui_pts_cha.Size = new System.Drawing.Size(42, 20);
            this.ui_pts_cha.TabIndex = 7;
            // 
            // comboBox_class
            // 
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Items.AddRange(new object[] {
            "Barbarian",
            "Cleric",
            "Druid",
            "Fighter",
            "Hunter",
            "Monk",
            "Paladin",
            "Sorcorer",
            "Warlock",
            "Wizard"});
            this.comboBox_class.Location = new System.Drawing.Point(12, 155);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(121, 21);
            this.comboBox_class.TabIndex = 1;
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.Location = new System.Drawing.Point(11, 139);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(32, 13);
            this.label_class.TabIndex = 5;
            this.label_class.Text = "Class";
            // 
            // comboBox_race
            // 
            this.comboBox_race.FormattingEnabled = true;
            this.comboBox_race.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Halfling",
            "Human",
            "Dragonborn",
            "Gnome",
            "Half-Elf",
            "Half-Orc",
            "Tiefling"});
            this.comboBox_race.Location = new System.Drawing.Point(12, 100);
            this.comboBox_race.Name = "comboBox_race";
            this.comboBox_race.Size = new System.Drawing.Size(121, 21);
            this.comboBox_race.TabIndex = 0;
            this.comboBox_race.SelectedIndexChanged += new System.EventHandler(this.comboBox_race_SelectedIndexChanged);
            // 
            // label_race
            // 
            this.label_race.AutoSize = true;
            this.label_race.Location = new System.Drawing.Point(11, 84);
            this.label_race.Name = "label_race";
            this.label_race.Size = new System.Drawing.Size(33, 13);
            this.label_race.TabIndex = 5;
            this.label_race.Text = "Race";
            // 
            // ui_points_str_total
            // 
            this.ui_points_str_total.Location = new System.Drawing.Point(114, 60);
            this.ui_points_str_total.Name = "ui_points_str_total";
            this.ui_points_str_total.ReadOnly = true;
            this.ui_points_str_total.Size = new System.Drawing.Size(30, 20);
            this.ui_points_str_total.TabIndex = 8;
            this.ui_points_str_total.TabStop = false;
            this.ui_points_str_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ui_points_dex_total
            // 
            this.ui_points_dex_total.Location = new System.Drawing.Point(114, 87);
            this.ui_points_dex_total.Name = "ui_points_dex_total";
            this.ui_points_dex_total.ReadOnly = true;
            this.ui_points_dex_total.Size = new System.Drawing.Size(30, 20);
            this.ui_points_dex_total.TabIndex = 8;
            this.ui_points_dex_total.TabStop = false;
            this.ui_points_dex_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // points_con_total
            // 
            this.points_con_total.Location = new System.Drawing.Point(114, 112);
            this.points_con_total.Name = "points_con_total";
            this.points_con_total.ReadOnly = true;
            this.points_con_total.Size = new System.Drawing.Size(30, 20);
            this.points_con_total.TabIndex = 8;
            this.points_con_total.TabStop = false;
            this.points_con_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // points_int_total
            // 
            this.points_int_total.Location = new System.Drawing.Point(114, 138);
            this.points_int_total.Name = "points_int_total";
            this.points_int_total.ReadOnly = true;
            this.points_int_total.Size = new System.Drawing.Size(30, 20);
            this.points_int_total.TabIndex = 8;
            this.points_int_total.TabStop = false;
            this.points_int_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // points_wis_total
            // 
            this.points_wis_total.Location = new System.Drawing.Point(114, 164);
            this.points_wis_total.Name = "points_wis_total";
            this.points_wis_total.ReadOnly = true;
            this.points_wis_total.Size = new System.Drawing.Size(30, 20);
            this.points_wis_total.TabIndex = 8;
            this.points_wis_total.TabStop = false;
            this.points_wis_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // points_int_cha
            // 
            this.points_int_cha.Location = new System.Drawing.Point(114, 190);
            this.points_int_cha.Name = "points_int_cha";
            this.points_int_cha.ReadOnly = true;
            this.points_int_cha.Size = new System.Drawing.Size(30, 20);
            this.points_int_cha.TabIndex = 8;
            this.points_int_cha.TabStop = false;
            this.points_int_cha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Location = new System.Drawing.Point(151, 42);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(35, 13);
            this.label_score.TabIndex = 9;
            this.label_score.Text = "Score";
            // 
            // label_attr_points
            // 
            this.label_attr_points.AutoSize = true;
            this.label_attr_points.Location = new System.Drawing.Point(71, 42);
            this.label_attr_points.Name = "label_attr_points";
            this.label_attr_points.Size = new System.Drawing.Size(36, 13);
            this.label_attr_points.TabIndex = 10;
            this.label_attr_points.Text = "Points";
            // 
            // label_attr_points_total
            // 
            this.label_attr_points_total.AutoSize = true;
            this.label_attr_points_total.Location = new System.Drawing.Point(113, 42);
            this.label_attr_points_total.Name = "label_attr_points_total";
            this.label_attr_points_total.Size = new System.Drawing.Size(31, 13);
            this.label_attr_points_total.TabIndex = 11;
            this.label_attr_points_total.Text = "Total";
            // 
            // ui_score_str
            // 
            this.ui_score_str.Location = new System.Drawing.Point(150, 60);
            this.ui_score_str.Name = "ui_score_str";
            this.ui_score_str.ReadOnly = true;
            this.ui_score_str.Size = new System.Drawing.Size(30, 20);
            this.ui_score_str.TabIndex = 8;
            this.ui_score_str.TabStop = false;
            this.ui_score_str.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ui_score_dex
            // 
            this.ui_score_dex.Location = new System.Drawing.Point(150, 87);
            this.ui_score_dex.Name = "ui_score_dex";
            this.ui_score_dex.ReadOnly = true;
            this.ui_score_dex.Size = new System.Drawing.Size(30, 20);
            this.ui_score_dex.TabIndex = 8;
            this.ui_score_dex.TabStop = false;
            this.ui_score_dex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // score_con
            // 
            this.score_con.Location = new System.Drawing.Point(150, 112);
            this.score_con.Name = "score_con";
            this.score_con.ReadOnly = true;
            this.score_con.Size = new System.Drawing.Size(30, 20);
            this.score_con.TabIndex = 8;
            this.score_con.TabStop = false;
            this.score_con.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // score_int
            // 
            this.score_int.Location = new System.Drawing.Point(150, 138);
            this.score_int.Name = "score_int";
            this.score_int.ReadOnly = true;
            this.score_int.Size = new System.Drawing.Size(30, 20);
            this.score_int.TabIndex = 8;
            this.score_int.TabStop = false;
            this.score_int.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // score_wis
            // 
            this.score_wis.Location = new System.Drawing.Point(150, 164);
            this.score_wis.Name = "score_wis";
            this.score_wis.ReadOnly = true;
            this.score_wis.Size = new System.Drawing.Size(30, 20);
            this.score_wis.TabIndex = 8;
            this.score_wis.TabStop = false;
            this.score_wis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // score_cha
            // 
            this.score_cha.Location = new System.Drawing.Point(150, 190);
            this.score_cha.Name = "score_cha";
            this.score_cha.ReadOnly = true;
            this.score_cha.Size = new System.Drawing.Size(30, 20);
            this.score_cha.TabIndex = 8;
            this.score_cha.TabStop = false;
            this.score_cha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_attr_proficient
            // 
            this.label_attr_proficient.AutoSize = true;
            this.label_attr_proficient.Location = new System.Drawing.Point(192, 42);
            this.label_attr_proficient.Name = "label_attr_proficient";
            this.label_attr_proficient.Size = new System.Drawing.Size(57, 13);
            this.label_attr_proficient.TabIndex = 12;
            this.label_attr_proficient.Text = "Proficient?";
            this.label_attr_proficient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_ability_scores);
            this.panel1.Controls.Add(this.label_saving_throws);
            this.panel1.Controls.Add(this.label_attr_saving_throw_bonus);
            this.panel1.Controls.Add(this.label_attr_proficient);
            this.panel1.Controls.Add(this.proficient_str);
            this.panel1.Controls.Add(this.label_attr_points_total);
            this.panel1.Controls.Add(this.proficient_dex);
            this.panel1.Controls.Add(this.label_attr_points);
            this.panel1.Controls.Add(this.proficient_con);
            this.panel1.Controls.Add(this.label_score);
            this.panel1.Controls.Add(this.proficient_int);
            this.panel1.Controls.Add(this.textBox18);
            this.panel1.Controls.Add(this.score_cha);
            this.panel1.Controls.Add(this.proficient_wis);
            this.panel1.Controls.Add(this.points_int_cha);
            this.panel1.Controls.Add(this.proficient_cha);
            this.panel1.Controls.Add(this.textBox17);
            this.panel1.Controls.Add(this.score_wis);
            this.panel1.Controls.Add(this.label_strength);
            this.panel1.Controls.Add(this.points_wis_total);
            this.panel1.Controls.Add(this.label_dexterity);
            this.panel1.Controls.Add(this.textBox16);
            this.panel1.Controls.Add(this.score_int);
            this.panel1.Controls.Add(this.label_constitution);
            this.panel1.Controls.Add(this.points_int_total);
            this.panel1.Controls.Add(this.label_intelligence);
            this.panel1.Controls.Add(this.textBox15);
            this.panel1.Controls.Add(this.score_con);
            this.panel1.Controls.Add(this.label_wisdom);
            this.panel1.Controls.Add(this.points_con_total);
            this.panel1.Controls.Add(this.label_charisma);
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Controls.Add(this.ui_score_dex);
            this.panel1.Controls.Add(this.ui_pts_str);
            this.panel1.Controls.Add(this.ui_points_dex_total);
            this.panel1.Controls.Add(this.ui_pts_dex);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.ui_score_str);
            this.panel1.Controls.Add(this.ui_pts_con);
            this.panel1.Controls.Add(this.ui_points_str_total);
            this.panel1.Controls.Add(this.ui_pts_int);
            this.panel1.Controls.Add(this.ui_pts_wis);
            this.panel1.Controls.Add(this.ui_pts_cha);
            this.panel1.Location = new System.Drawing.Point(197, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 235);
            this.panel1.TabIndex = 13;
            // 
            // label_ability_scores
            // 
            this.label_ability_scores.AutoSize = true;
            this.label_ability_scores.Location = new System.Drawing.Point(90, 25);
            this.label_ability_scores.Name = "label_ability_scores";
            this.label_ability_scores.Size = new System.Drawing.Size(70, 13);
            this.label_ability_scores.TabIndex = 15;
            this.label_ability_scores.Text = "Ability Scores";
            // 
            // label_saving_throws
            // 
            this.label_saving_throws.AutoSize = true;
            this.label_saving_throws.Location = new System.Drawing.Point(214, 25);
            this.label_saving_throws.Name = "label_saving_throws";
            this.label_saving_throws.Size = new System.Drawing.Size(78, 13);
            this.label_saving_throws.TabIndex = 14;
            this.label_saving_throws.Text = "Saving Throws";
            // 
            // label_attr_saving_throw_bonus
            // 
            this.label_attr_saving_throw_bonus.AutoSize = true;
            this.label_attr_saving_throw_bonus.Location = new System.Drawing.Point(264, 42);
            this.label_attr_saving_throw_bonus.Name = "label_attr_saving_throw_bonus";
            this.label_attr_saving_throw_bonus.Size = new System.Drawing.Size(37, 13);
            this.label_attr_saving_throw_bonus.TabIndex = 13;
            this.label_attr_saving_throw_bonus.Text = "Bonus";
            this.label_attr_saving_throw_bonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(271, 187);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(30, 20);
            this.textBox18.TabIndex = 8;
            this.textBox18.TabStop = false;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(271, 161);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(30, 20);
            this.textBox17.TabIndex = 8;
            this.textBox17.TabStop = false;
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(271, 135);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(30, 20);
            this.textBox16.TabIndex = 8;
            this.textBox16.TabStop = false;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(271, 109);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(30, 20);
            this.textBox15.TabIndex = 8;
            this.textBox15.TabStop = false;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(271, 84);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(30, 20);
            this.textBox14.TabIndex = 8;
            this.textBox14.TabStop = false;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(271, 57);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(30, 20);
            this.textBox13.TabIndex = 8;
            this.textBox13.TabStop = false;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_race);
            this.Controls.Add(this.comboBox_race);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.comboBox_class);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ui_pts_str)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_pts_dex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_pts_con)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_pts_int)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_pts_wis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_pts_cha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox proficient_str;
        private System.Windows.Forms.CheckBox proficient_dex;
        private System.Windows.Forms.CheckBox proficient_con;
        private System.Windows.Forms.CheckBox proficient_int;
        private System.Windows.Forms.CheckBox proficient_wis;
        private System.Windows.Forms.CheckBox proficient_cha;
        private System.Windows.Forms.Label label_strength;
        private System.Windows.Forms.Label label_dexterity;
        private System.Windows.Forms.Label label_constitution;
        private System.Windows.Forms.Label label_intelligence;
        private System.Windows.Forms.Label label_wisdom;
        private System.Windows.Forms.Label label_charisma;
        private System.Windows.Forms.NumericUpDown ui_pts_str;
        private System.Windows.Forms.NumericUpDown ui_pts_dex;
        private System.Windows.Forms.NumericUpDown ui_pts_con;
        private System.Windows.Forms.NumericUpDown ui_pts_int;
        private System.Windows.Forms.NumericUpDown ui_pts_wis;
        private System.Windows.Forms.NumericUpDown ui_pts_cha;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.ComboBox comboBox_race;
        private System.Windows.Forms.Label label_race;
        private System.Windows.Forms.TextBox ui_points_str_total;
        private System.Windows.Forms.TextBox ui_points_dex_total;
        private System.Windows.Forms.TextBox points_con_total;
        private System.Windows.Forms.TextBox points_int_total;
        private System.Windows.Forms.TextBox points_wis_total;
        private System.Windows.Forms.TextBox points_int_cha;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_attr_points;
        private System.Windows.Forms.Label label_attr_points_total;
        private System.Windows.Forms.TextBox ui_score_str;
        private System.Windows.Forms.TextBox ui_score_dex;
        private System.Windows.Forms.TextBox score_con;
        private System.Windows.Forms.TextBox score_int;
        private System.Windows.Forms.TextBox score_wis;
        private System.Windows.Forms.TextBox score_cha;
        private System.Windows.Forms.Label label_attr_proficient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_attr_saving_throw_bonus;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label_ability_scores;
        private System.Windows.Forms.Label label_saving_throws;
    }
}

