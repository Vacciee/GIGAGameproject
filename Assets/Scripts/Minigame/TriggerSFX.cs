using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public GameObject options;

    [SerializeField]
    private AudioSource playSound;
    [SerializeField]
    private AudioSource playIdle;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playSound.volume = 1;
            playIdle.volume = 0;
        }
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            playSound.volume = 0;
            playIdle.volume = 1;
        }

        #region Show options menu by key input
        if (!options.activeInHierarchy)
        {
            playSound.mute = false;
            playIdle.mute = false;
        }

        if (options.activeInHierarchy)
        {
            playSound.mute = true;
            playIdle.mute = true;
        }
        #endregion
    }

}
