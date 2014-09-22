using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int score_str = -5;
            int score_dex = -5;
            int score_con = -5;
            int score_int = -5;
            int score_wis = -5;
            int score_cha = -5;

            int points_str = 0;
            int points_dex = 0;
            int points_con = 0;
            int points_int = 0;
            int points_wis = 0;
            int points_cha = 0;

            int saving_throw_str = 0;
            int saving_throw_dex = 0;
            int saving_throw_con = 0;
            int saving_throw_int = 0;
            int saving_throw_wis = 0;
            int saving_throw_cha = 0;

            ui_pts_str.Value = points_str;
            ui_pts_dex.Value = points_dex;

        }
        
        private void proficient_cha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_race_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void points_str_ValueChanged(object sender, EventArgs e)
        {
            //float str = points_str
            double score = Math.Floor((float)ui_pts_str.Value / 2) - 5;
            ui_score_str.Text = score.ToString();
        }
    }
}
