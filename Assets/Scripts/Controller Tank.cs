using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerTank : MonoBehaviour
{
    public Camera gameCamera;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        //transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
