using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileInvader : MonoBehaviour
{
    public float speed;
    public InvaderManager im;
    // Start is called before the first frame update
    void Start()
    {
        im = GameObject.FindGameObjectWithTag("InvaderMinigame").GetComponent<InvaderManager>(); ;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);


    }

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Invader"))
        {

            Destroy(other.gameObject);
            im.enemies -= 1;
            Destroy(gameObject);
        }



        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Key"))
        {
            Destroy(other.gameObject);
            im.isKeyCollected = true;
            Destroy(gameObject);
        }

    }




}
