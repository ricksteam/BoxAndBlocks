using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public static int maxScoreLeft = 0;
    public static int count = 0;
    public static int maxScoreRight = 0;
    public static int red = 0;
    public static int blue = 0;
    public static int green = 0; 

    public static string favoriteColor = "";
    public static void calculateFavoriteColor()
    {
        int max = Math.Max(Math.Max(red, blue), green);
        if (max == blue)
        {
            favoriteColor = "Blue";
        }
        else if (max == green)
        {
            favoriteColor = "Green";

        }
        else if (max == red)
        {
            favoriteColor = "Red";
        }
        else
        {
            favoriteColor = "";
        }
        red = 0;
        blue = 0;
        green = 0; 
    }
     
    
}
