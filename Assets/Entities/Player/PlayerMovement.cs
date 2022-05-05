using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Start is called before the first frame update
    float xmin;
    float xmax;
    public float speed = 30f;
    bool speedUp = false;

    public GameObject laserPrefab;

    void Start()
    {
        Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        xmin = leftmost.x;
        xmax = rightmost.x;
    }

    // Update is called once per frame



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab, transform.position, Quaternion.identity);
        }


        if (speedUp) speed = 5.5f;
        else speed = 2.2f;

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            speedUp = !speedUp;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-0.01f, 0, 0)*speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.01f, 0, 0)*speed;
        }

        float PlayerX = Mathf.Clamp(transform.position.x, -6, 6);
        transform.position = new Vector3(PlayerX, transform.position.y, transform.position.z);

        
        if (Health < 1)
            Destroy(gameObject);
    
    }

    public int Health = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health--;
    }
    
    

}