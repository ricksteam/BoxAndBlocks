using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

    Score score = new Score();
    Achievements achievements = new Achievements();

    public Text leftHighScore;
    public Text rightHighScore;
    public Text data;

    public void Start()
    {
        leftHighScore = GameObject.Find("LeftScore").GetComponent<Text>();
        rightHighScore = GameObject.Find("RightScore").GetComponent<Text>();
        data = GameObject.Find("DataText").GetComponent<Text>();
        
    }

public void updateText(int maxScoreLeft, int maxScoreRight)
    {

        leftHighScore.text = "Top Score: " + maxScoreLeft;
        rightHighScore.text = "Top Score: " + maxScoreRight;
        data.text = "Achievements:\n\n";
        for (int i = 0; i < achievements.achievementList.Length; i++)
        {
            string s = "";
            s += achievements.achievementList[i];
            if (achievements.completed[i] == 0)
            {
                data.text += s + "\n";
            }
            else
            {
                data.text += StrikeThrough(s) + "\n";
            }

        }


    }
    public string StrikeThrough(string s)
    {
        string strikethrough = "";
        foreach (char c in s)
        {
            strikethrough = strikethrough + c + '\u0336';
        }
        return strikethrough;
    }

}
