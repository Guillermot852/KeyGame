using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Move the obstacle to the left
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Destroy the obstacle if it goes off-screen
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}
