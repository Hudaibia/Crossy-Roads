using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{

    public float minz = -20;
    public float maxz = 30;
    private float delay = 2;
    private float spawnx = 25;
    private PlayerMovement pm;
    public GameObject carleftpf;
    public GameObject carrightpf;

    // Start is called before the first frame update
    void Start()
    {
        pm = GameObject.Find("Player").GetComponent<PlayerMovement>();

      
        
        InvokeRepeating("Spawnleft", delay, delay);

        InvokeRepeating("Spawnright", delay, delay);
    }

   void Spawnleft()
    {
        if (!pm.gameover && !pm.win)
        {
            Vector3 spawnpos = new Vector3(spawnx, 0, Random.Range(minz, maxz));

            Instantiate(carleftpf, spawnpos, carleftpf.transform.rotation);

            
        }

    }

    void Spawnright()
    {

        if (!pm.gameover && !pm.win)
        {
            Vector3 spawnpos = new Vector3(-spawnx, 0, Random.Range(minz, maxz));

            Instantiate(carrightpf, spawnpos, carrightpf.transform.rotation);


        }
    }
}
