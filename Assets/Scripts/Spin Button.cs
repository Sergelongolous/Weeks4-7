using UnityEngine;

public class SpinButton : MonoBehaviour
{
    public Camera gameCamera;
    public float rotateSpeed;
    private bool isSpinning = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //IMPORTANT- This code was the same one I wrote for a previous coding gym exercise. This came in handy in the long run.
        //if statement that calla for the object to rotate on the z axis overtime as long as the bool is true

        if (isSpinning == true)
        {
            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.z += rotateSpeed * Time.deltaTime;

            transform.eulerAngles = currentRotation;
        }
    }

    public void StartSpin()
    {
        //happens if the "Raise" button is pressed, makes the speed be set to a number that makes it move

        if (isSpinning == true)
        {
            rotateSpeed = 100f;
        }
    }

    public void StopSpin()
    {
        //happnes if the "Stop" button is pressed, makes the speed be set to 0 and stops it from rotating

        if (isSpinning == true)
        {
            rotateSpeed = 0f;
        }
    }
}


