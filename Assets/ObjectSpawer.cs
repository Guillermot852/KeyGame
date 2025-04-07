using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; // The obstacle to spawn
    public float spawnInterval = 2f;  // Time between spawns
    public float spawnHeightRange = 3f; // Range of heights for spawning obstacles
    public float spawnXPosition = 10f; // X position from where obstacles spawn
    public float obstacleSpeed = 5f;  // Speed at which obstacles move

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0;
        }
    }

    void SpawnObstacle()
    {
        // Randomize the Y position of the obstacle
        float spawnYPosition = Random.Range(-spawnHeightRange, spawnHeightRange);

        // Instantiate the obstacle
        GameObject newObstacle = Instantiate(obstaclePrefab, new Vector3(spawnXPosition, spawnYPosition, 0), Quaternion.identity);

        // Add a script to move the obstacle
        ObstacleMovement movement = newObstacle.AddComponent<ObstacleMovement>();
        movement.speed = obstacleSpeed;
    }
}
