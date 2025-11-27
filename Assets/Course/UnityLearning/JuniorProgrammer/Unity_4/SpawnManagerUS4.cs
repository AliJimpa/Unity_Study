using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerUS4 : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float Rediosspawn = 1;
    public int  FirstWave = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(FirstWave);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            int randomEnemy = Random.Range(0, enemyPrefabs.Length);
            Instantiate(enemyPrefabs[randomEnemy], GenerateSpawnPosition(),
            enemyPrefabs[randomEnemy].transform.rotation);
        }
    }

    Vector3 GenerateSpawnPosition()
    {
        float x = Random.Range( -Rediosspawn , Rediosspawn );
        float z = Random.Range( -Rediosspawn , Rediosspawn );
        return new Vector3(x, transform.position.y ,z);
    }

}
