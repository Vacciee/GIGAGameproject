using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckLoaderScript : MonoBehaviour
{
    public GameObject item1, item2, item3, item4;
    private GameObject spawnLimitLeft, spawnLimitRight;
    // Tehdään itemeistä Trucking lapsia
    private Transform parent;
    // List for all prefabs
    private List<GameObject> itemList;
    public int maxProgress = 100;
    public int progress;
    public int maxFill = 14;
    public float fill;

    private void Start()
    {
        spawnLimitLeft = GameObject.Find("SpawnLimitLeft");
        spawnLimitRight = GameObject.Find("SpawnLimitRight");
        parent = GameObject.Find("Truck").transform;
        // Listing the prefabs so we can pick one randomly
        itemList = new List<GameObject>();
        itemList.Add(item1);
        itemList.Add(item2);
        itemList.Add(item3);
        itemList.Add(item4);
        progress = 0;
        fill = 0;
    }

    public void LoadNewItem()
    {
        Instantiate(
            // Getting a prefab from the list randomly
            itemList[UnityEngine.Random.Range(0, itemList.Count)],
            // Giving it a spawn point
            new Vector3(UnityEngine.Random.Range(spawnLimitLeft.transform.position.x, spawnLimitRight.transform.position.x), spawnLimitLeft.transform.position.y, 0),
            Quaternion.identity, parent
            );
    }



}
