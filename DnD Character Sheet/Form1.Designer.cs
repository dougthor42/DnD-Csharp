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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.ui_saving_throw_dex = new System.Windows.Forms.TextBox();
            this.ui_saving_throw_str = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.proficient_str, "proficient_str");
            this.proficient_str.Name = "proficient_str";
            this.proficient_str.UseVisualStyleBackColor = true;
            this.proficient_str.CheckedChanged += new System.EventHandler(this.proficient_str_CheckedChanged);
            // 
            // proficient_dex
            // 
            resources.ApplyResources(this.proficient_dex, "proficient_dex");
            this.proficient_dex.Name = "proficient_dex";
            this.proficient_dex.UseVisualStyleBackColor = true;
            // 
            // proficient_con
            // 
            resources.ApplyResources(this.proficient_con, "proficient_con");
            this.proficient_con.Name = "proficient_con";
            this.proficient_con.UseVisualStyleBackColor = true;
            // 
            // proficient_int
            // 
            resources.ApplyResources(this.proficient_int, "proficient_int");
            this.proficient_int.Name = "proficient_int";
            this.proficient_int.UseVisualStyleBackColor = true;
            // 
            // proficient_wis
            // 
            resources.ApplyResources(this.proficient_wis, "proficient_wis");
            this.proficient_wis.Name = "proficient_wis";
            this.proficient_wis.UseVisualStyleBackColor = true;
            // 
            // proficient_cha
            // 
            resources.ApplyResources(this.proficient_cha, "proficient_cha");
            this.proficient_cha.Name = "proficient_cha";
            this.proficient_cha.UseVisualStyleBackColor = true;
            this.proficient_cha.CheckedChanged += new System.EventHandler(this.proficient_cha_CheckedChanged);
            // 
            // label_strength
            // 
            resources.ApplyResources(this.label_strength, "label_strength");
            this.label_strength.Name = "label_strength";
            // 
            // label_dexterity
            // 
            resources.ApplyResources(this.label_dexterity, "label_dexterity");
            this.label_dexterity.Name = "label_dexterity";
            // 
            // label_constitution
            // 
            resources.ApplyResources(this.label_constitution, "label_constitution");
            this.label_constitution.Name = "label_constitution";
            // 
            // label_intelligence
            // 
            resources.ApplyResources(this.label_intelligence, "label_intelligence");
            this.label_intelligence.Name = "label_intelligence";
            // 
            // label_wisdom
            // 
            resources.ApplyResources(this.label_wisdom, "label_wisdom");
            this.label_wisdom.Name = "label_wisdom";
            // 
            // label_charisma
            // 
            resources.ApplyResources(this.label_charisma, "label_charisma");
            this.label_charisma.Name = "label_charisma";
            // 
            // ui_pts_str
            // 
            resources.ApplyResources(this.ui_pts_str, "ui_pts_str");
            this.ui_pts_str.Name = "ui_pts_str";
            this.ui_pts_str.ValueChanged += new System.EventHandler(this.points_str_ValueChanged);
            // 
            // ui_pts_dex
            // 
            resources.ApplyResources(this.ui_pts_dex, "ui_pts_dex");
            this.ui_pts_dex.Name = "ui_pts_dex";
            // 
            // ui_pts_con
            // 
            resources.ApplyResources(this.ui_pts_con, "ui_pts_con");
            this.ui_pts_con.Name = "ui_pts_con";
            // 
            // ui_pts_int
            // 
            resources.ApplyResources(this.ui_pts_int, "ui_pts_int");
            this.ui_pts_int.Name = "ui_pts_int";
            // 
            // ui_pts_wis
            // 
            resources.ApplyResources(this.ui_pts_wis, "ui_pts_wis");
            this.ui_pts_wis.Name = "ui_pts_wis";
            // 
            // ui_pts_cha
            // 
            resources.ApplyResources(this.ui_pts_cha, "ui_pts_cha");
            this.ui_pts_cha.Name = "ui_pts_cha";
            // 
            // comboBox_class
            // 
            resources.ApplyResources(this.comboBox_class, "comboBox_class");
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Items.AddRange(new object[] {
            resources.GetString("comboBox_class.Items"),
            resources.GetString("comboBox_class.Items1"),
            resources.GetString("comboBox_class.Items2"),
            resources.GetString("comboBox_class.Items3"),
            resources.GetString("comboBox_class.Items4"),
            resources.GetString("comboBox_class.Items5"),
            resources.GetString("comboBox_class.Items6"),
            resources.GetString("comboBox_class.Items7"),
            resources.GetString("comboBox_class.Items8"),
            resources.GetString("comboBox_class.Items9")});
            this.comboBox_class.Name = "comboBox_class";
            // 
            // label_class
            // 
            resources.ApplyResources(this.label_class, "label_class");
            this.label_class.Name = "label_class";
            // 
            // comboBox_race
            // 
            resources.ApplyResources(this.comboBox_race, "comboBox_race");
            this.comboBox_race.FormattingEnabled = true;
            this.comboBox_race.Items.AddRange(new object[] {
            resources.GetString("comboBox_race.Items"),
            resources.GetString("comboBox_race.Items1"),
            resources.GetString("comboBox_race.Items2"),
            resources.GetString("comboBox_race.Items3"),
            resources.GetString("comboBox_race.Items4"),
            resources.GetString("comboBox_race.Items5"),
            resources.GetString("comboBox_race.Items6"),
            resources.GetString("comboBox_race.Items7"),
            resources.GetString("comboBox_race.Items8")});
            this.comboBox_race.Name = "comboBox_race";
            this.comboBox_race.SelectedIndexChanged += new System.EventHandler(this.comboBox_race_SelectedIndexChanged);
            // 
            // label_race
            // 
            resources.ApplyResources(this.label_race, "label_race");
            this.label_race.Name = "label_race";
            // 
            // ui_points_str_total
            // 
            resources.ApplyResources(this.ui_points_str_total, "ui_points_str_total");
            this.ui_points_str_total.Name = "ui_points_str_total";
            this.ui_points_str_total.ReadOnly = true;
            this.ui_points_str_total.TabStop = false;
            // 
            // ui_points_dex_total
            // 
            resources.ApplyResources(this.ui_points_dex_total, "ui_points_dex_total");
            this.ui_points_dex_total.Name = "ui_points_dex_total";
            this.ui_points_dex_total.ReadOnly = true;
            this.ui_points_dex_total.TabStop = false;
            // 
            // points_con_total
            // 
            resources.ApplyResources(this.points_con_total, "points_con_total");
            this.points_con_total.Name = "points_con_total";
            this.points_con_total.ReadOnly = true;
            this.points_con_total.TabStop = false;
            // 
            // points_int_total
            // 
            resources.ApplyResources(this.points_int_total, "points_int_total");
            this.points_int_total.Name = "points_int_total";
            this.points_int_total.ReadOnly = true;
            this.points_int_total.TabStop = false;
            // 
            // points_wis_total
            // 
            resources.ApplyResources(this.points_wis_total, "points_wis_total");
            this.points_wis_total.Name = "points_wis_total";
            this.points_wis_total.ReadOnly = true;
            this.points_wis_total.TabStop = false;
            // 
            // points_int_cha
            // 
            resources.ApplyResources(this.points_int_cha, "points_int_cha");
            this.points_int_cha.Name = "points_int_cha";
            this.points_int_cha.ReadOnly = true;
            this.points_int_cha.TabStop = false;
            // 
            // label_score
            // 
            resources.ApplyResources(this.label_score, "label_score");
            this.label_score.Name = "label_score";
            // 
            // label_attr_points
            // 
            resources.ApplyResources(this.label_attr_points, "label_attr_points");
            this.label_attr_points.Name = "label_attr_points";
            // 
            // label_attr_points_total
            // 
            resources.ApplyResources(this.label_attr_points_total, "label_attr_points_total");
            this.label_attr_points_total.Name = "label_attr_points_total";
            // 
            // ui_score_str
            // 
            resources.ApplyResources(this.ui_score_str, "ui_score_str");
            this.ui_score_str.Name = "ui_score_str";
            this.ui_score_str.ReadOnly = true;
            this.ui_score_str.TabStop = false;
            // 
            // ui_score_dex
            // 
            resources.ApplyResources(this.ui_score_dex, "ui_score_dex");
            this.ui_score_dex.Name = "ui_score_dex";
            this.ui_score_dex.ReadOnly = true;
            this.ui_score_dex.TabStop = false;
            // 
            // score_con
            // 
            resources.ApplyResources(this.score_con, "score_con");
            this.score_con.Name = "score_con";
            this.score_con.ReadOnly = true;
            this.score_con.TabStop = false;
            // 
            // score_int
            // 
            resources.ApplyResources(this.score_int, "score_int");
            this.score_int.Name = "score_int";
            this.score_int.ReadOnly = true;
            this.score_int.TabStop = false;
            // 
            // score_wis
            // 
            resources.ApplyResources(this.score_wis, "score_wis");
            this.score_wis.Name = "score_wis";
            this.score_wis.ReadOnly = true;
            this.score_wis.TabStop = false;
            // 
            // score_cha
            // 
            resources.ApplyResources(this.score_cha, "score_cha");
            this.score_cha.Name = "score_cha";
            this.score_cha.ReadOnly = true;
            this.score_cha.TabStop = false;
            // 
            // label_attr_proficient
            // 
            resources.ApplyResources(this.label_attr_proficient, "label_attr_proficient");
            this.label_attr_proficient.Name = "label_attr_proficient";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
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
            this.panel1.Controls.Add(this.ui_saving_throw_dex);
            this.panel1.Controls.Add(this.ui_score_dex);
            this.panel1.Controls.Add(this.ui_pts_str);
            this.panel1.Controls.Add(this.ui_points_dex_total);
            this.panel1.Controls.Add(this.ui_pts_dex);
            this.panel1.Controls.Add(this.ui_saving_throw_str);
            this.panel1.Controls.Add(this.ui_score_str);
            this.panel1.Controls.Add(this.ui_pts_con);
            this.panel1.Controls.Add(this.ui_points_str_total);
            this.panel1.Controls.Add(this.ui_pts_int);
            this.panel1.Controls.Add(this.ui_pts_wis);
            this.panel1.Controls.Add(this.ui_pts_cha);
            this.panel1.Name = "panel1";
            // 
            // label_ability_scores
            // 
            resources.ApplyResources(this.label_ability_scores, "label_ability_scores");
            this.label_ability_scores.Name = "label_ability_scores";
            // 
            // label_saving_throws
            // 
            resources.ApplyResources(this.label_saving_throws, "label_saving_throws");
            this.label_saving_throws.Name = "label_saving_throws";
            // 
            // label_attr_saving_throw_bonus
            // 
            resources.ApplyResources(this.label_attr_saving_throw_bonus, "label_attr_saving_throw_bonus");
            this.label_attr_saving_throw_bonus.Name = "label_attr_saving_throw_bonus";
            // 
            // textBox18
            // 
            resources.ApplyResources(this.textBox18, "textBox18");
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.TabStop = false;
            // 
            // textBox17
            // 
            resources.ApplyResources(this.textBox17, "textBox17");
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.TabStop = false;
            // 
            // textBox16
            // 
            resources.ApplyResources(this.textBox16, "textBox16");
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.TabStop = false;
            // 
            // textBox15
            // 
            resources.ApplyResources(this.textBox15, "textBox15");
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.TabStop = false;
            // 
            // ui_saving_throw_dex
            // 
            resources.ApplyResources(this.ui_saving_throw_dex, "ui_saving_throw_dex");
            this.ui_saving_throw_dex.Name = "ui_saving_throw_dex";
            this.ui_saving_throw_dex.ReadOnly = true;
            this.ui_saving_throw_dex.TabStop = false;
            // 
            // ui_saving_throw_str
            // 
            resources.ApplyResources(this.ui_saving_throw_str, "ui_saving_throw_str");
            this.ui_saving_throw_str.Name = "ui_saving_throw_str";
            this.ui_saving_throw_str.ReadOnly = true;
            this.ui_saving_throw_str.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_race);
            this.Controls.Add(this.comboBox_race);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.comboBox_class);
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox ui_saving_throw_dex;
        private System.Windows.Forms.TextBox ui_saving_throw_str;
        private System.Windows.Forms.Label label_ability_scores;
        private System.Windows.Forms.Label label_saving_throws;
        private System.Windows.Forms.Button button1;
    }
}

