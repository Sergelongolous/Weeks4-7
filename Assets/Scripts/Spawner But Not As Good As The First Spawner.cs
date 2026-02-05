using NUnit.Framework.Internal;
using UnityEngine;

public class SpawnerButNotAsGoodAsTheFirstSpawner : MonoBehaviour
{
    public GameObject spawningPrefab;

    public float waitDuration;
    public float destroyDuration;

    public Color ballColor;

    private float destroyProgress = 0f;
    private float waitProgress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waitProgress += Time.deltaTime;
        if (waitProgress > waitDuration)
        {
            GameObject spawnedObject = Instantiate(spawningPrefab, transform.position, Quaternion.identity);

            //TypeOfComponent variableName = variableOfObject.GetComponent<TypeOfComponent>();

            Pacer spawnedPacBall = spawnedObject.GetComponent<Pacer>();
            spawnedPacBall.transform.position = transform.position;

            SpriteRenderer spawnedRenderer = spawnedObject.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = ballColor;

            Destroy(spawnedObject, destroyDuration);

            waitProgress = 0f;
        }
    }

    public void SpawnClick()
    {
        transform.position = Random.insideUnitSphere;
    }
}
