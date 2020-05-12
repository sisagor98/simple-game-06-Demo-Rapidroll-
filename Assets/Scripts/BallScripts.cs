using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScripts : MonoBehaviour
{
    public float speeds = 10f;
    public GameObject ball;
        

    // Update is called once per frame
    void Update()
    {
        Move(); 
    }

    private void Move()
    {

        float moveX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speeds * moveX * Time.deltaTime);

        if (transform.position.x >2.3f)
        {
            transform.position = new Vector3(2.3f,transform.position.y, 0);
        }
        else if (transform.position.x < -2.3f)
        {
            transform.position = new Vector3(-2.3f, transform.position.y, 0);
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "destoy")
        {
            Destroy(gameObject, 2f);
            // Instantiate(this,)
           /* GameObject newBall = Instantiate(ball);
             newBall.transform.SetParent(this.transform)*/;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


        }
    }

}
