using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    private float xbounds = 60;
    void Start()
    {
        xbounds = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xbounds || transform.position.x > xbounds )
        {
            Destroy(gameObject);
        }
    }
}
