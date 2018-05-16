using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour
{
    public string[] achievementList =
    {
        "Get exactly 10 blocks",
        "Get No blocks!",
        "Get only blue blocks"
    };

    public int[] completed =
   {
        0,
        0,
        0 
    };

    public void checkAllAchievements(int count)
    {
        for (int i = 0; i < achievementList.Length; i++)
        {
            checkAchievement(i, count);
        }
    }

    public void checkAchievement(int index, int count)
    {

        switch (index)
        {
            case 0:
                if (count == 10)
                {
                    completed[0] = 1;
                    saveResults(0, 1);
                }
                break;
            case 1:
                if (count == 0)
                    completed[1] = 1;
                saveResults(1, 1);
                break;
        }

    }
    public void saveResults(int index, int value)
    {
        PlayerPrefs.SetInt("CompletedIndex", index);
        PlayerPrefs.SetInt("CompletedValue", value);
        
        PlayerPrefs.Save();
    }
    public void loadResults()
    {
        
        completed[PlayerPrefs.GetInt("CompletedIndex")] = PlayerPrefs.GetInt("CompletedValue");
       
    }

}
