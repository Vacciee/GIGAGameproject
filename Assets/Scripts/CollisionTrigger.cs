using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTrigger : MonoBehaviour
{
    [SerializeField]
    public string scenePath;
    [Range(0, 1)] public int active = 0;
    public GameObject interractionMenu;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(active == 0)
        {
            SceneManager.LoadScene(scenePath);
        }
        else
        {
            if (!interractionMenu.activeInHierarchy)
            {
                interractionMenu.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                interractionMenu.SetActive(false);
            }            
        }        
    }
}