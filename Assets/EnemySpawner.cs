using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float spawnInterval = 3f;

    public float spawnRadius = 8f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Vector2 randomPos =
            (Vector2)transform.position +
            Random.insideUnitCircle * spawnRadius;

        Instantiate(
            enemyPrefab,
            randomPos,
            Quaternion.identity
        );
    }
}