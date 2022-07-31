using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;
    public int maxProgress = 100;
    public int currentProgress;

    void Start()
    {
        // Making sure we have no points to begin with
        currentProgress = 0;
    }

    void Update()
    {

    }

    public void SetMinProgress(int progress)
    {
        slider.minValue = progress;
        slider.value = progress;
    }

    public void SetProgress(int progress)
    {
        slider.value = progress;
    }
}