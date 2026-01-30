using System.Security.Claims;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawningPrefab;

    public float waitDuration;
    public float destroyDuration;

    public Color pacerColor;
    public float pacerSpeed;

    private float destroyProgress = 0f;
    private float waitProgress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Vector3 originPosition = Vector3.zero;
        //Quaternion originRotation = Quaternion.identity;

        //Instantiate(spawningPrefab, transform.position, Quaternion.identity);

        //SPWANING AT THE POSITION OF THE SPAWNER (WITH THE SPAWNER'S ROTATION)
        //Instantiate(spawningPrefab, transform.position, transform.rotation);

        //SPAWNING AT THE ORIGIN
        //Instantiate(spawningPrefab);

    }

    // Update is called once per frame
    void Update()
    {
        waitProgress += Time.deltaTime;
        if (waitProgress > waitDuration)
        {
            GameObject spawnedObject = Instantiate(spawningPrefab, transform.position, Quaternion.identity);

            //TypeOfComponent variableName = variableOfObject.GetComponent<TypeOfComponent>();

            Pacer spawnedPacer = spawnedObject.GetComponent<Pacer>();
            spawnedPacer.speed = pacerSpeed;

            //set the color of out pacer spawner to be pacerColor
            //SpriteRenderer of the pacer
            SpriteRenderer spawnedRenderer = spawnedObject.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = pacerColor;

            //Destroy(spawnedObject, destroyDuration);

            waitProgress = 0f;
        }
    }

    public void IncreasePacerSpeed()
    {
        pacerSpeed++;
        //this syntax is basically the same as pacerSpeed += 1f;
    }
}
