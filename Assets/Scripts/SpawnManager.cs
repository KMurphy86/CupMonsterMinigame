using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] monsterPrefab;
    private float spawnRangex = 15;
    private float spawnPosZ = 25;
    private float startDelay = 1.4f;
    private float spawnInterval = 1.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomMonster", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomMonster ()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex), -.6f, spawnPosZ);
        int monsterIndex = Random.Range(0, monsterPrefab.Length);

        Instantiate(monsterPrefab[monsterIndex], spawnPos, monsterPrefab[monsterIndex].transform.rotation);
    }


}
