using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLaser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0, -0.02f, 0);

        if (transform.position.y < -16)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
