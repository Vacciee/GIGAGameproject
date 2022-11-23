using System.Collections;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public Movement2 movement;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Asteroid")
        {
            StartCoroutine(MoveDisable());
        }
    }

    private IEnumerator MoveDisable()
    {
        movement.enabled = false;
        yield return new WaitForSeconds(0.5f);
        movement.enabled = true;
    }
}
