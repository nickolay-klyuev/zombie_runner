using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool reSpawn = false;
    public Transform playerSpawnPoints;
    public AudioClip whatHappened;

    private Transform[] spawnPoints;
    private HelicopterController helicopterController;
    private AudioSource innerVoice;
    //private bool lastToggle = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        helicopterController = GameObject.FindObjectOfType<HelicopterController>();
        
        AudioSource[] audioSources = GetComponents<AudioSource>();
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.priority == 1)
            {
                innerVoice = audioSource;
            }
        }

        innerVoice.clip = whatHappened;
        innerVoice.Play();
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
        helicopterController.Call();
    }
}
