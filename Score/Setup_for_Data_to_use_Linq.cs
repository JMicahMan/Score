using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;


namespace GuidedExercise_05
{

   
    
    public partial class Form1 : Form
    {
          
        public static string Filenamecsv = "datadoit.csv";
        public List<Score> PlayerScores = new List<Score>();
      

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            public static string Filenamecsv = "datadoit.csv";
            foreach (var line in playerdata)
            {
                var entry = line.Split(',');
                var score = new Score
                {
                    levelName = entry[0],
                    playerName = entry[1],
                    score = float.Parse(entry[2]),
                    levelTime = float.Parse(entry[3]),
                    enemiesKilled = (int) float.Parse(entry[4]),
                    levelCompleted = float.Parse(entry[5]) > 0 
                };

                PlayerScores.Add(score);

               playerInfoTextBox.Text += line + Environment.NewLine;
            }

    string text = "players who didn't complete level 1";
    var Q1 = PlayerScores.Where(score => score.levelName = "Level1");
    playerInfoTextBox.Text+= text += Environment.NewLine;
   
     }
    }
}