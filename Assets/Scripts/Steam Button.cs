using System.IO.Pipes;
using UnityEngine;

public class SteamButton : MonoBehaviour
{
    public GameObject steamObject;

    public float waitDuration;
    public float destroyDuration;
    public float clockDuration;

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
            GameObject spawnedObject = Instantiate(steamObject, transform.position, Quaternion.identity);

            SteamButton spawnedsteamObject = steamObject.GetComponent<SteamButton>();
            spawnedsteamObject.transform.position = transform.position;
       



            Destroy(spawnedsteamObject, destroyDuration);

            waitProgress = 0f;
        }
    }

    public void SteamSpawn()
    {
        clockDuration -= Time.deltaTime * 1;

        if (clockDuration <= 0)
        {

            Destroy(steamObject);
        }
    }
}
