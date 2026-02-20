using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class TankColor : MonoBehaviour
{

    //Used tutorial video from the week 5 reading to achieve this, it was very helpfull
    SpriteRenderer tc;

    public GameObject tank;
    public TextMeshProUGUI levelValue;
    public Slider slider;

    private bool isPressed = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //calls for the SpriteRenderer of the game object, makes it so that we can tamper with it with our code.
        tc = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //text that tracks teh slider level as you slide it side to side
        //Also used the tutorial video from the week 5 reading, a nice addition
        levelValue.text = slider.value.ToString();

        //if statement that usesa  bool expresion, calls for the UI button to work
        if (isPressed == true)
        {
            ColorChange();
        }
    }

    public void ColorChange()
    {
        //another if statement, this time it makes the color of the game object randomize it's color when sliding the slider
        //I advise players to slide it slowlly, the color randomizing can be a bit much for the eyes.
        if (isPressed == false)
        {
            tc.color = Random.ColorHSV();
        }
        
    }
}
