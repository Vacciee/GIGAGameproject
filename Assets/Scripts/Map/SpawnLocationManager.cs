using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnLocationManager : MonoBehaviour
{

    [SerializeField]
    private SpawnLocationList spawnLocationList;

    public GameObject player;
    public static string previousScene;

    //void OnEnable()
    //{
    //    SceneManager.sceneLoaded += OnSceneLoaded;
    //}

    //void OnDisable()
    //{
    //    SceneManager.sceneLoaded -= OnSceneLoaded;
    //}

    //void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    //{
    //    player = GameObject.FindWithTag("Player");
    //    Debug.Log("---- Player tag found!");
    //}

    GameObject SpawnArea;
  
    public static Transform SpawnAreaLocation;

    public Transform [] SpawnAreaList = new Transform[1];

    private void Awake()
    {
      //DontDestroyOnLoad(this);
    }
    void Start()
    {
        Debug.Log(spawnLocationList.myString);

        Debug.Log("Coming from the scene : " + previousScene);
        previousScene = SceneManager.GetActiveScene().name;
        Debug.Log("Scene now is : " + previousScene);

       // SpawnAreaLocation = spawnLocationList.location.transform;

    //  SpawnAreaLocation = SpawnAreaList[0].transform;

        if (previousScene == "Earth")
        {
  //  player.transform.position = SpawnAreaLocation.position;
        }

        //transform.position = SpawnAreaLocation.position;

        //Debug.Log("Spawn area location is: " + SpawnAreaLocation.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null && collision.CompareTag("planetExitArea")) {
            //if (SpawnArea != null)
            //{
             //  player.transform.position = SpawnArea.transform.position;
                SceneManager.LoadScene("Map");


                Debug.Log("Exiting planet");
         //   }
        }
    }


}
