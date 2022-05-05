using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public GameObject enemyLaser;
    // Update is called once per frame
    void Update()
    {
        if (Random.value < 0.01)
        {
            Instantiate(enemyLaser, transform.position, Quaternion.identity);
        }
        
    }


    public GameObject explosion;

    private void OnTriggerExit2D(Collider2D collision)
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Debug.Log("Score");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }


}
