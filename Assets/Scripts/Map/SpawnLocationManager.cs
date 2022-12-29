using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnLocationManager : MonoBehaviour
{
    public GameObject player;

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        player = GameObject.FindWithTag("Player");
    }

    GameObject SpawnArea;

   public static Transform SpawnAreaLocation;

  
    //public GameObject [] SpawnAreaList = new GameObject[5];

    private void Awake()
    {
      DontDestroyOnLoad(this);
    }
    void Start()
    {
        //SpawnAreaLocation= GetComponent<Transform>();

        //SpawnAreaLocation = SpawnAreaList[2].transform;
        //transform.position = SpawnAreaLocation.position;
        player.transform.position= Vector3.zero;
        //Debug.Log("Spawn area location is: " + SpawnAreaLocation.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null && collision.CompareTag("planetExitArea")) {
            if (SpawnArea != null)
            {
               player.transform.position = SpawnArea.transform.position;
                SceneManager.LoadScene("Map");


                Debug.Log("Exiting planet");
            }
        }
    }

    void Update()
    {
        
    }
}
