using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnRate = 1.0f;
    public List<GameObject> enemies;
    public Clicky cl;

    public bool rate;
    public bool isGamePlaying;

    // Start is called before the first frame update
    void Start()
    {
        rate = true;
        isGamePlaying = true;
        StartCoroutine(SpawnTarget());
    }

    // Update is called once per frame
    void Update()
    {
        if (!cl.gameIsPlaying)
        {
            isGamePlaying = false;

        }

        if (rate && isGamePlaying)
        {
            StartCoroutine(diff(3));
            rate = false;
        }


        IEnumerator diff(float time)
        {
            yield return new WaitForSeconds(time);
            rate = true;


        }
    }


    IEnumerator SpawnTarget()
    {
        while (true)
        {
            
                yield return new WaitForSeconds(spawnRate);
                int index = Random.Range(0, enemies.Count);
                Instantiate(enemies[index]);
            
        }
    }



}
