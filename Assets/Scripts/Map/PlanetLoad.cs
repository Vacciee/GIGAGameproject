using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlanetLoad : MonoBehaviour
{
    #region Variables;
    [Tooltip("Name the scene name exactly how its written in scene folder!")] public string scenePath;
    #endregion

    #region Scene Loading
    // Main menu Control script

    private void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene(scenePath);
    }

    // public void LoadMenu()
    // {
    //     SceneManager.LoadScene(scenePath);
    // }
    #endregion
}