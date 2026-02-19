using TMPro;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightButton : MonoBehaviour
{
    public Camera gameCamera;
    //public GameObject lightButton;
    private bool isPressed = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed == true)
        {
            //lightButton.
                GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    public void ColorChange()
    {
        if (isPressed == true)
        {
            //Color p = new Color(9, 10, 34, 0);
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
