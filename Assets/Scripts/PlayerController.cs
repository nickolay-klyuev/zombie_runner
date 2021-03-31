using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool reSpawn = false;
    public Transform playerSpawnPoints;

    private Transform[] spawnPoints;
    //private bool lastToggle = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (lastToggle != reSpawn)
        {
            Respawn();
            reSpawn = false;
        }
        else
        {
            lastToggle = reSpawn;
        }*/
    }

    private void Respawn()
    {
        int spawnPoint = Random.Range(1, spawnPoints.Length);
        gameObject.transform.position = spawnPoints[spawnPoint].transform.position;
    }

    void OnFindClearArea()
    {
        Invoke("DropFlare", 3f);
    }

    void DropFlare()
    {
        
    }
}
