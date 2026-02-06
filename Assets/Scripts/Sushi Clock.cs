using UnityEngine;
using UnityEngine.UI;

public class SushiClock : MonoBehaviour
{
    public Slider sushiSlider;
    public float clockDuration;
    public GameObject warperObject;

    private float timeWaiting = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sushiSlider.maxValue = clockDuration;
    }

    // Update is called once per frame
    void Update()
    {
        timeWaiting += Time.deltaTime * 1;
        sushiSlider.value = timeWaiting;

        if (timeWaiting > clockDuration)
        {
            timeWaiting = 0f;
            Debug.Log("Time Is Up");

            //WHEN TIMER IS UP:
            //EITHER:
            //Turn the warper object on when it's off
            //Turn the warper object off whe  it is on

            bool shouldTurnOn = !warperObject.activeInHierarchy;
            bool shouldTurnOff = warperObject.activeInHierarchy;
            if (shouldTurnOn == true)
            {
                warperObject.SetActive(true);
            }

            if (shouldTurnOff)
            {
                warperObject.SetActive(false);
            }

        }
    }
}
