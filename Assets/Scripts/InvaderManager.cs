using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class InvaderManager : MonoBehaviour
{

    public float enemies, enemiesGoal;
    public TextMeshProUGUI enemiesText;
    public GameObject projectilePrefab, player, key;
    //score minigame objects

    public bool leaving, isKeyCollected;
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
        enemiesText.text = "Enemies: " + enemies + "/3";
        //scoreText .font .color .text

        if (enemies <= enemiesGoal)
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

        }
    }

    public void Shoot()
    {
        if (gameIsPlaying)
        {
            Instantiate(projectilePrefab, player.transform.position, player.transform.rotation);
        }
    }

}
