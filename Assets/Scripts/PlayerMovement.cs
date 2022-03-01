using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float xrange = 10f;
    public float zrange = 45f;
    private Rigidbody playerRb;
    public float movementforce;
    public bool gameover = false;
    public bool win = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            Debug.Log("Game Over");

            gameover = true;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("finish"))
        {

            win = true;
            Debug.Log("You Win");
        }
    }

    private void MovePlayer()
    {
        if (transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }


        if (transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }


        if (transform.position.z < -zrange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,-zrange);
        }


        if (transform.position.z > zrange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zrange);
        }

        if (!gameover)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                playerRb.AddForce(Vector3.forward * movementforce, ForceMode.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                playerRb.AddForce(Vector3.back * movementforce, ForceMode.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playerRb.AddForce(Vector3.right * movementforce, ForceMode.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                playerRb.AddForce(Vector3.left * movementforce, ForceMode.Impulse);
            }
        }
    }
}
                                