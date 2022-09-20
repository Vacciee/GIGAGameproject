using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTrigger : MonoBehaviour
{
    #region Variables
    [SerializeField]
    public string scenePath;
    [Range(0, 1)] public int active = 0;
    public GameObject interractionMenu;
    public GameObject Kettu1_Final;
    #endregion

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (active == 0)
        {
            SceneManager.LoadScene(scenePath);
        }
        else
        {
            if (!interractionMenu.activeInHierarchy)
            {
                interractionMenu.SetActive(true);
                Kettu1_Final.SetActive(true);
            }
            else
            {
                interractionMenu.SetActive(false);
                Kettu1_Final.SetActive(false);
            }
        }
    }
}