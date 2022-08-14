using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public Vector2 speed;

    //Mihin klikattu
    public Vector2 targetPosition;
    //Alkuperäinen sijainti
    public Vector2 relativePosition;

    private bool moving = false;

    private Vector2 movement;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private void Start()
    {

    }

    void Update()
    {
        // 3 - Retrieve the mouse position
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        //4 - Find the relative poistion of the target based upon the current position
        // Update each frame to account for any movement
        relativePosition = new Vector2(
            targetPosition.x - gameObject.transform.position.x,
            targetPosition.y - gameObject.transform.position.y);
    }

    void FixedUpdate()
    {
        // 5 - If you are about to overshoot the target, reduce velocity to that distance
        //      Else cap the Movement by a maximum speed per direction (x then y)
        if (speed.x * Time.deltaTime >= Mathf.Abs(relativePosition.x))
        {
            movement.x = relativePosition.x;
        }
        else
        {
            movement.x = speed.x * Mathf.Sign(relativePosition.x);
        }
        if (speed.y * Time.deltaTime >= Mathf.Abs(relativePosition.y))
        {
            movement.y = relativePosition.y;
        }
        else
        {
            movement.y = speed.y * Mathf.Sign(relativePosition.y);
        }

        // 6 - Move the game object using the physics engine
        if (moving)
        {
            GetComponent<Rigidbody2D>().velocity = movement;

        }

    }
}