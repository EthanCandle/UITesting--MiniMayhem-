using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Clicky : MonoBehaviour
{
    public GameObject clickyMinigame;
    public float scoreClicky, scoreGainClicky, scoreGoalClicky;
    public TextMeshProUGUI scoreTextClick, goalTextClick;
    //clicky minigame objects

    public bool leaving;
    public float leaveTime;
    //transmission time

    public bool gameIsPlaying = true;
    //minigame should be able to play



    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        scoreTextClick.text = "Score: " + scoreClicky;
        //scoreText .font .color .text

        goalTextClick.text = "Goal: " + scoreGoalClicky;

        if (scoreClicky >= scoreGoalClicky)
        {
            leaving = true;
        }

        if (leaving)
        {
            gameIsPlaying = false;
            leaveTime -= 1 * Time.deltaTime;

        }

        if (leaveTime <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            clickyMinigame.SetActive(false);
        }
    }

    public void GainScore ()
    {
        if (gameIsPlaying)
        {
            scoreClicky += scoreGainClicky;
        }
    }


}
