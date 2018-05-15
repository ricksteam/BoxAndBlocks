using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

    public Text leftFavColor;
    public Text rightFavColor;
    public Text leftHighScore;
    public Text rightHighScore;


    // Use this for initialization
    void Start () {
        leftFavColor.text = "Favorite Color: " + Score.favoriteColor;
        rightFavColor.text = "Favorite Color: " + Score.favoriteColor;
        leftHighScore.text = "Top Score: " + Score.maxScoreLeft;
        rightHighScore.text = "Top Score: " + Score.maxScoreRight;
    }
    public void updateText()
    {
        leftFavColor.text = "Favorite Color: " + Score.favoriteColor;
        rightFavColor.text = "Favorite Color: " + Score.favoriteColor;
        leftHighScore.text = "Top Score: " + Score.maxScoreLeft;
        rightHighScore.text = "Top Score: " + Score.maxScoreRight;
    }
	
	
}
