using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PiratePop : MonoBehaviour
{
    private bool isClicked = false;
    public GameObject pirate;

    public List<GameObject> knives;
    private GameObject spawningPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject spawnedKnife = Instantiate(spawningPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (isClicked == true)
        {
            Destroy(spawningPrefab);
        }

        if (isClicked == true)
        {
            Vector3 p = new Vector3(0, Random.Range(0, 4), 0);
            pirate.transform.position = p;
        }

        if (pirate.transform.position.y < 4)
        {
            isClicked = false;
        }
    }
}
