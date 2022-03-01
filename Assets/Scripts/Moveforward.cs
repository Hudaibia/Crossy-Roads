using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveforward : MonoBehaviour
{

    private float speed = 10;
    private PlayerMovement pm;
    // Start is called before the first frame update
    void Start()
    {
        pm = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!pm.gameover && !pm.win)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }
}
