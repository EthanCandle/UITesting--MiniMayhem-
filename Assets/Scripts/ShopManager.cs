using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public GameObject shopMinigame;
    public float score, scoreGain, scoreGoal, scoreGainTotal;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI workersText;
    public TextMeshProUGUI gainScoreText;
    //score minigame objects

    public bool leaving;
    public float leaveTime;
    //transmission time

    public bool gameIsPlaying = true;
    //minigame should be able to play

    public float workers, workersCost, workersSell;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString("0");
        //scoreText .font .color .text

        workersText.text = "Workers: " + workers.ToString("0");

        gainScoreText.text = "Gain Score   (+" + scoreGainTotal.ToString("0") + ")";

        if (leaving)
        {
            gameIsPlaying = false;
            leaveTime -= 1 * Time.deltaTime;

        }

        if (leaveTime <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            shopMinigame.SetActive(false);
        }

        if (gameIsPlaying)
        {
            score += workers * Time.deltaTime;
        }

        scoreGainTotal = scoreGain + workers;

    }

    public void GainScore()
    {
        if (gameIsPlaying)
        {
            score += scoreGainTotal;
        }
    }
    public void BuyWorkers()
    {
        if(score >= workersCost && gameIsPlaying)
        {
            score -= workersCost;
            workers += 1;
        }
    }

    public void SellWorkers()
    {
        if (workers >= 1 && gameIsPlaying)
        {
            score += workersSell;
            workers -= 1;
        }
    }

    public void BuyWin()
    {
        if (score >= scoreGoal && gameIsPlaying)
        {
            score -= scoreGoal;
            leaving = true;
        }

    }




}
