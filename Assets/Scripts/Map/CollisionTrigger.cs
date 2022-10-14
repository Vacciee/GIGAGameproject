using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTrigger : MonoBehaviour
{
    #region Variables
    public GameObject interractionMenu;
    public GameObject closeMenu;

    public GameObject planet;
    public GameObject person;
    #endregion

    private void OnCollisionEnter2D(Collision2D planet)
    {
        GameObject.Find("PlayerScaler").GetComponent<Movement2>().enabled = false;

        if (!interractionMenu.activeInHierarchy)
        {
            interractionMenu.SetActive(true);
            person.SetActive(true);
        }
    }
}
