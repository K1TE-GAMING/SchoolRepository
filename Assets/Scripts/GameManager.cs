using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject woodPrefab;
    public float spawnTimer = 0.0f;
    public float rateOfSpawn = 3.0f;
    public Transform[] posRefArray;

    void Start()
    {
        
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= rateOfSpawn)
        {
            //Spawn a wood
            SpawnWood();
            spawnTimer = 0.0f;
        }

    }

    private void SpawnWood()
    {
        int randomPosIdx = Random.Range(0, posRefArray.Length);
        Instantiate(woodPrefab, posRefArray[randomPosIdx].position, Quaternion.identity);
    }
}
