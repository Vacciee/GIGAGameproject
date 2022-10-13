using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    private Transform playerPos, cameraPos;
    private Vector3 view1, view2, view3, view4;
    private int currentView;
    private GameManager gm;
    [HideInInspector]
    public List<Transform> spawns;

    private void Awake()
    {
        playerPos = GameObject.Find("PlayerScaler").transform;
        cameraPos = GameObject.Find("Main Camera").transform;
        view1 = new Vector3(0, 0, -1);
        view2 = new Vector3(16, 0, -1);
        view3 = new Vector3(32, 0, -1);
        view4 = new Vector3(48, 0, -1);

        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        // Spawn 1 is the starting position, when player has not completed any planet yet
        spawns.Add(GameObject.Find("Spawn1").GetComponent<Transform>());
        spawns.Add(GameObject.Find("Spawn2").GetComponent<Transform>());
        spawns.Add(GameObject.Find("Spawn3").GetComponent<Transform>());
        spawns.Add(GameObject.Find("Spawn4").GetComponent<Transform>());
        spawns.Add(GameObject.Find("Spawn5").GetComponent<Transform>());
        spawns.Add(GameObject.Find("Spawn6").GetComponent<Transform>());
        spawns.Add(GameObject.Find("Spawn7").GetComponent<Transform>());
        spawns.Add(GameObject.Find("Spawn8").GetComponent<Transform>());
        spawns.Add(GameObject.Find("Spawn9").GetComponent<Transform>());
        spawns.Add(GameObject.Find("Spawn10").GetComponent<Transform>());

    }
    private void Start()
    {
        // Setting where the player spawns when the scene loads
        playerPos.position = spawns[gm.currentPlanet].position;
        // Setting initial camera position
        if (gm.currentPlanet <= 2)
        {
            cameraPos.transform.position = view1;
            currentView = 1;
        }
        else if (gm.currentPlanet > 2 && gm.currentPlanet <= 4)
        {
            cameraPos.transform.position = view2;
            currentView = 2;
        }
        else if (gm.currentPlanet > 4 && gm.currentPlanet <= 6)
        {
            cameraPos.transform.position = view3;
            currentView = 3;
        }
        else
        {
            cameraPos.transform.position = view4;
            currentView = 4;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trigger1R") && currentView == 1)
        {
            cameraPos.transform.position = view2;
            Debug.Log("Hit Trigger1R");
        }
        if (other.CompareTag("Trigger2L") && cameraPos.transform.position == view2)
        {
            cameraPos.transform.position = view1;
        }















    }

}
