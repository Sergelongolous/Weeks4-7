using System.IO.Pipes;
using UnityEngine;
using UnityEngine.UI;

public class SteamButton : MonoBehaviour
{
    //public variable for the Steam prefab
    public GameObject steamPrefab;

    //public varaible for the Slider
    public Slider rSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SteamSpawn()
    {
        //Using Instantiate, the prefab spwans in the scene when clicking the button
    
        GameObject spawnedObject = Instantiate(steamPrefab, transform.position, transform.rotation);

        //Fellow peer helped with this code, how to call for the actual prefab in the code and how to connect code from other scripts.
        SteamPrefab steam = spawnedObject.GetComponent<SteamPrefab>();

        //makes it so that the rasing slider is conncted to this script.
        //Now every spawned prefab raises the slider and stops sliding when the spawned prefab gets destroyed.
        steam.raisingSlider = rSlider;
    }
}

