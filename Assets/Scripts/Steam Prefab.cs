using UnityEngine;
using UnityEngine.UI;

public class SteamPrefab : MonoBehaviour
{
    public float clockDuration;
    public Slider raisingSlider;
    float t = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        //calls ofr the spanwed prefab to be destroyed after a particlar amount of time.
        Destroy(gameObject, 1.0f);

        //Makes it so that the prefab clones spawn in a particular angle instead of the usual 0 on the z-axis
        Vector3 r = transform.eulerAngles;
        r.z = -26.1f;
        transform.eulerAngles = r;
    }

    // Update is called once per frame
    void Update()
    {
        //Line of code that calls for the slider to move in par with each spawned prefab, using a custom timer
        t += Time.deltaTime;

        if (t >= 1)
        {
            t = 0;
        }
        
        raisingSlider.value = t;

    }
}
