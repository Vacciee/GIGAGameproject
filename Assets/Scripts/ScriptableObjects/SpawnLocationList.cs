using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnLocation", menuName = "Location")]
public class SpawnLocationList : ScriptableObject
{

    public GameObject location;
    // Singleton, call from any script
    public static SpawnLocationList instance;

    // fill in inspector
    public Transform [] locations;

    public string myString;


}
