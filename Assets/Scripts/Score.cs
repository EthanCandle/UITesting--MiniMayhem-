using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public GameObject scoreMinigame;
    public float score, scoreGain, scoreGoal;
    public TextMeshProUGUI scoreText, goalText;
    //score minigame objects

    public bool leaving;
    public float leaveTime;
    //transmission time

    public bool gameIsPlaying = true;
    //minigame should be able to play



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;

        goalText.text = "Goal: " + scoreGoal;
        //scoreText .font .color .text

        if (score >= scoreGoal)
        {
            leaving = true;
        }

        if(leaving)
        {
            gameIsPlaying = false;
            leaveTime -= 1 * Time.deltaTime;

        }

        if(leaveTime <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            scoreMinigame.SetActive(false);
        }
    }

    public void GainScore ()
    {
        if (gameIsPlaying)
        {
            score += scoreGain;
        }
    }






}
