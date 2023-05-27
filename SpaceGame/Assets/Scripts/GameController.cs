using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform enemy;
    public float timeBeforeSpawning = 1.5f;
    public float timeBetweenEnemies = 0.25f;
    public float timeBeforeWaves = 2.0f;
    public int enemiesPerWave = 10;
    private int currentNumberOfEnemies = 0;
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    void Update()
    {
        
    }

    IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(timeBeforeSpawning);
        while (true)
        {
            if (currentNumberOfEnemies <= 0)
            {
                float randDirection;
                float randDistance;
                for (int i = 0; i < enemiesPerWave; i++)
                {
                    randDistance = Random.Range(10, 25);
                    randDirection = Random.Range(0, 360);
                    float posX = this.transform.position.x + (Mathf.Cos((randDirection) * Mathf.Deg2Rad) * randDistance);
                    float posY = this.transform.position.y + (Mathf.Sin((randDirection) * Mathf.Deg2Rad) * randDistance);
                    Instantiate(enemy, new Vector3(posX, posY, 0), this.transform.rotation);
                    currentNumberOfEnemies++;
                    yield return new WaitForSeconds(timeBetweenEnemies);
                }
            }
            yield return new WaitForSeconds(timeBeforeWaves);
        }
    }

    public void KilledEnemy()
    {
        currentNumberOfEnemies--;
    }
}
