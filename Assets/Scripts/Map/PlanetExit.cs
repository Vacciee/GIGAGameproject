using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetExit : MonoBehaviour
{

    [SerializeField]
    GameObject PlanetExitArea;

    [SerializeField]
    GameObject SpawnArea;

    Transform SpawnAreaLocation;
    void Start()
    {
        SpawnAreaLocation = SpawnArea.transform;

        PlanetExitArea.GetComponent<GameObject>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null && collision.CompareTag("planetExitArea")) {

   transform.position = SpawnArea.transform.position;
            SceneManager.LoadScene("Map");
         

            Debug.Log("Exiting planet");
        }
    }

    void Update()
    {
        
    }
}
