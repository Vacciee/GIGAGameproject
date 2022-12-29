using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetExit : MonoBehaviour
{

    [SerializeField]
    GameObject SpawnArea = null;

    static Transform SpawnAreaLocation;

  
    public GameObject [] SpawnAreaList = new GameObject[5];

    private void Awake()
    {
        DontDestroyOnLoad(this);    
    }
    void Start()
    {
        SpawnAreaLocation = SpawnAreaList[0].transform;


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null && collision.CompareTag("planetExitArea")) {
            if (SpawnArea != null)
            {
                transform.position = SpawnArea.transform.position;
                SceneManager.LoadScene("Map");


                Debug.Log("Exiting planet");
            }
        }
    }

    void Update()
    {
        
    }
}
