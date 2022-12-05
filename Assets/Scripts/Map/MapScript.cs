using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    private Transform playerPos;
    private GameManager gm;
    public List<Transform> spawns;

    private void Awake()
    {
        playerPos = GameObject.Find("PlayerScaler").transform;

        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void Start()
    {
        // Setting where the player spawns when the scene loads
        playerPos.position = spawns[gm.currentPlanet].position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Mercury"))
        {
            gm.currentPlanet = 1;
            Debug.Log("Current planet set to Mercury");
        }

    }

}
