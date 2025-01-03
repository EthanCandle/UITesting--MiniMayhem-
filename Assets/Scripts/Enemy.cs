using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemy, enemyMoveTo;
    public float moveSpeed;
    public Clicky cl;
    // Start is called before the first frame update
    void Start()
    {
        enemyMoveTo = GameObject.FindGameObjectWithTag("MoveTo");
        cl = GameObject.FindGameObjectWithTag("ClickyMinigame").GetComponent<Clicky>(); ;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, enemyMoveTo.transform.position, moveSpeed);

        if(!cl.gameIsPlaying)
        {
            Destroy(gameObject);
        }
      
    }

    private void OnMouseOver()
    {
        cl.GainScore();
        Destroy(gameObject);

    }




}
