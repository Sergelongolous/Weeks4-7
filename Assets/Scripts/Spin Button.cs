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
        if (isSpinning == true)
        {
            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.z += rotateSpeed * Time.deltaTime;

            transform.eulerAngles = currentRotation;
        }
    }

    public void StartSpin()
    {
        if (isSpinning == true)
        {
            rotateSpeed = 100f;
        }
    }

    public void StopSpin()
    {
        if (isSpinning == true)
        {
            rotateSpeed = 0f;
        }
    }
}
