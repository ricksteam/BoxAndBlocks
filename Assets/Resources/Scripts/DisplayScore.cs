using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

    public Text leftHighScore;
    public Text rightHighScore;

    Score score = new Score();
    void Awake()
    {
        score.Load(); 
    }
    // Use this for initialization
    void Start () {
        
        leftHighScore.text = "Top Score: " + score.maxScoreLeft;
        rightHighScore.text = "Top Score: " + score.maxScoreRight;
    }
    public void updateText()
    {
        Debug.Log("Updated: " + score.maxScoreRight);
        leftHighScore.text = "Top Score: " + score.maxScoreLeft;
        rightHighScore.text = "Top Score: " + score.maxScoreRight;
    }
	
	
}
