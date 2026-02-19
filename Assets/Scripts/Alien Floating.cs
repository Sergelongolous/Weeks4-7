using UnityEngine;

public class AlienFloating : MonoBehaviour
{
    public Transform startValue;
    public Transform endValue;
    public float T;
    public AnimationCurve alienCurve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Counting in seconds instead of frames (hence the Time.deltaTime)
        T += Time.deltaTime;
        if (T > 2)
        {
            //resets the time to 0
            T = 0;
        }

        //using Lerp to make the alien seem likes its floating by moving up and down
        transform.position = Vector3.Lerp(startValue.position, endValue.position, alienCurve.Evaluate(T));

    }
}
