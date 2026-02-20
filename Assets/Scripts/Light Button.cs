using TMPro;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightButton : MonoBehaviour
{
    private bool isOn = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightOn()
    {
        //If statements that makes the destroys the game object entirelly after a single clikc of the UI POWER Button
        if (isOn == false)
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
