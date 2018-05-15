using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CountDown : MonoBehaviour {
    public Grab lefthand;
    public Grab righthand;
    public GameObject leftbutton;
    public GameObject rightbutton;
    public GameObject data;
    public GameObject databtn;
    public CountUp counttext;

    public GameObject scoreHolder;
    private float time;                     //countdown time (always 60 seconds)
    private float startTime = 20.00f;
    private bool startCountDown = false;    //if we are counting down
    private List<GameObject> blocks;
    void Start () {
        time = startTime;
	}

	void Update () {
        if (startCountDown)
        {
            //display time every frame
            time -= Time.deltaTime;
            if (time < 0.00f)
            {
                time = 0.00f;
                startCountDown = false;
                destroyAllBlocks();
            }
            gameObject.GetComponent<Text>().text = "Time: " + time.ToString("0.00");
        }
	}

    public void StartCountDown()
    {
        startCountDown = true;
    }

    public void destroyAllBlocks()
    {
        lefthand.StopGrabbing();
        righthand.StopGrabbing();
        blocks = SpawnBlocks.GetSpawnedBlocks();
        foreach (GameObject i in blocks)
        {
            if (i != null)
            {
                i.layer = 0;
            }
            
        }
        InvokeRepeating("destroyBlock", 0, 0.1f);
    }

    public void destroyBlock()
    {
        if (blocks.Count == 0)
        {
            leftbutton.gameObject.SetActive(true);
            rightbutton.gameObject.SetActive(true);
            data.gameObject.SetActive(true);
            databtn.gameObject.SetActive(true);
            time = startTime;
            Score.calculateFavoriteColor();
            scoreHolder.GetComponent<DisplayScore>().updateText();
            CountUp.txt = "Please Select a Hand...";
            CountUp.hand = 0;
            counttext.setCount(0);
            CancelInvoke();
            return;
        }
        GameObject block = blocks.ToArray()[0];
        Destroy(block);
        blocks.Remove(block);
    }

}
