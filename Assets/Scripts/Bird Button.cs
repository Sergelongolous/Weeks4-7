using UnityEngine;
using UnityEngine.InputSystem;

public class BirdButton : MonoBehaviour
{
    private bool isRotating = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating == true)
        {
            Vector3 currentMousePosition = Mouse.current.position.ReadValue();
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
            worldMousePosition.z = 0;

            //Setting the direction we're looking in
            //To get the direction we do END - START
            transform.up = worldMousePosition - transform.position;

            transform.position += transform.up * 1f * Time.deltaTime;
        }
    }

    public void OnClick()
    {
        isRotating = true;
    }

    public void OffClick()
    {
        isRotating = false;
    }
}
