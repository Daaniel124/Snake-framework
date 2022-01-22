using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Snake
{
    class Score
    {
        public static int playerScore;
        public void Increase()
        {
            playerScore++;
            Text.WriteText("Очки: " + playerScore, 81, 1);
        }

        public void ScoresSave(string name, int score)
        {
            string text;
            StreamWriter use = new StreamWriter(@"..\..\Scores.txt", true);
            text = score + " " + name;
            use.WriteLine(text);
            use.Close();
        }
    }
}

