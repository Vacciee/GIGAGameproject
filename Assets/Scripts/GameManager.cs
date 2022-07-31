using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables
    public int cargo;

    public static GameManager manager;
    #endregion

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
}
