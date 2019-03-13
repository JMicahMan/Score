using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;


namespace GuidedExercise_05
{

    public class Score
    {
        public string levelName = "level";
        public string playerName = "name";
        public float score = 000;
        public float levelTime = 0;
        public float enemiesKilled = 0;
        public bool levelCompleted = true;
    }
    public partial class Form1 : Form
    {

        public static string Filenamecsv = "datadoit.csv";
        public List<Score> PlayerScores = new List<Score>();
      

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var playerdata = File.ReadAllLines(Filenamecsv);


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

               // playerInfoTextBox.Text += line + Environment.NewLine;
            }
        }
    }
}