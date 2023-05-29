using System.Collections;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform enemy;
    public float timeBeforeSpawning = 1.5f;
    public float timeBetweenEnemies = 0.25f;
    public float timeBeforeWaves = 2.0f;
    public int enemiesPerWave = 10;
    private int currentNumberOfEnemies = 0;
    private int score = 0;
    private int waveNumber = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI waveText;

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
                waveNumber++;
                if (waveNumber < 10)
                    waveText.text = "00" + waveNumber;
                else if (waveNumber < 100 & waveNumber >10)
                    waveText.text = "0" + waveNumber;
                else if (waveNumber < 1000 & waveNumber > 100)
                    waveText.text = "" + waveNumber;
                else
                    waveNumber = 0;

                float randDirection;
                float randDistance;
                for (int i = 0; i < enemiesPerWave; i++)
                {
                    randDistance = Random.Range(10, 25);
                    randDirection = Random.Range(45, 125);
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

    public void IncreaseScore(int increase)
    {
        score += increase;
        scoreText.text = "Очки: " + score;
    }
}
