using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TextAppear : MonoBehaviour
{
    public GameObject bird;
    public GameObject birdText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isHovered = (bool)Mouse.current.ReadValueAsObject();
        if (isHovered)
        {
            birdText.SetActive(true);
        }
    }
}
