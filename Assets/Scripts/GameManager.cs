using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables
    public int cargo;

    public static GameManager manager;
    #endregion

    public string currentPlanet;
    public bool Planet1;
    public int planet1Score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Screen.SetResolution(1920, 1080, true, 60);
        #region Check managers

        // Luodaan Manageri ja tsekataan, onko toinen olemassa ja tuhotaan toinen. 
        if (manager == null)
        {
            // Jos ei ole manageria kerrotaan, etta tama luokka on manageri.
            // Kerrotaan, etta tama manageri ei saa tuhoutua jos scene vaihtuu toiseen. 
            DontDestroyOnLoad(gameObject);
            manager = this;

        }
        else
        {
            // Jos on olemassa manageri, niin silloin tama manageri on toinen manageri ja se on liikaa!
            // Joten tama manageri tuhotaan pois, jolloin ja vain se ensimmainen jaljelle. 
            Destroy(gameObject);
        }
        #endregion
    }

    // Save game
    public void Save()
    {
        Debug.Log("Game Saved");
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        PlayerData playerData = new PlayerData();
        playerData.currentPlanet = currentPlanet;
        playerData.Planet1 = Planet1;
        playerData.planet1Score = planet1Score;

        bf.Serialize(file, playerData);
        file.Close();
    }

    // Load saved game
    public void Load()
    {
        // Tsekataan onko tallennettua tiedostoa olemassa
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            Debug.Log("Game Loaded");
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData playerData = (PlayerData)bf.Deserialize(file);
            file.Close();
            currentPlanet = playerData.currentPlanet;
            Planet1 = playerData.Planet1;
            planet1Score = playerData.planet1Score;
        }
    }

    // Data that gets saved
    [Serializable]
    class PlayerData
    {
        public string currentPlanet;
        public bool Planet1;
        public int planet1Score;
    }
}
