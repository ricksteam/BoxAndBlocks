using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int maxScoreLeft;
    public int maxScoreRight;

    public Text leftHighScore;
    public Text rightHighScore;
    public Text data; 

    Achievements achievements = new Achievements();
    DisplayScore ds = new DisplayScore();

     
    void Start()
    {
        leftHighScore = leftHighScore.GetComponent<Text>();
        rightHighScore = rightHighScore.GetComponent<Text>();
        data = data.GetComponent<Text>();
        Load();
    }
	
     public void Save()
    {
        if (!PlayerPrefs.HasKey("maxScoreLeft"))
        {
            PlayerPrefs.SetInt("maxScoreLeft", this.maxScoreLeft); 
        }
        else
        {
            int prevLeft = PlayerPrefs.GetInt("maxScoreLeft");
            Debug.Log(this.maxScoreLeft + " > " + prevLeft);
            if (this.maxScoreLeft > prevLeft)
            {
                PlayerPrefs.SetInt("maxScoreLeft", this.maxScoreLeft);
            }
        }

        if (!PlayerPrefs.HasKey("maxScoreRight"))
        {
            PlayerPrefs.SetInt("maxScoreRight", this.maxScoreRight);
        }
        else
        {
            int prevRight = PlayerPrefs.GetInt("maxScoreRight");
            if (this.maxScoreRight > prevRight)
            {
                PlayerPrefs.SetInt("maxScoreRight", this.maxScoreRight);
            }
        }

        PlayerPrefs.Save();
        Load();
    }

    public void Load()
    {
        if (PlayerPrefs.HasKey("maxScoreLeft"))
        {
            this.maxScoreLeft = PlayerPrefs.GetInt("maxScoreLeft");
        }
        else
        {
            this.maxScoreLeft = 0;
        }
        if (PlayerPrefs.HasKey("maxScoreRight"))
        {     
            this.maxScoreRight = PlayerPrefs.GetInt("maxScoreRight");
        }
        else
        {
            this.maxScoreRight = 0;
        }
        achievements.loadResults();
        ds.updateText(this.maxScoreLeft, this.maxScoreRight);
    }
   
}
