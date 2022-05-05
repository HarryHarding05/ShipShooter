using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFormation : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float width = 10;
    public float height = 5;
    public float speed = 0.1f;
    private float xmax;
    private float xmin;

    public static int Score; 
    

    


    public bool movingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            GameObject enemy = Instantiate(enemyPrefab, child.transform.position, Quaternion.identity) as GameObject;
            enemy.transform.parent = child;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >6)
        {
            movingRight = false;
        }

        if (transform.position.x <-6)
        {
            movingRight = true; 
        }


        if (movingRight)
        {

            transform.position += new Vector3(0.02f, 0);
        }

        else
        {
            transform.position += new Vector3(-0.02f, 0);
        }
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(6, 6));
    }
}
