using UnityEngine;

public class FloatingText : MonoBehaviour
{
    public float floatSpeed = 1f;  // Speed at which the text floats
    public float lifetime = 2f;   // How long the text exists
    public Vector2 randomDirectionRange = new Vector2(-1f, 1f); // Random direction range

    private Vector3 randomDirection;

    void Start()
    {
        // Generate a random direction for the text to float
        randomDirection = new Vector3(
            Random.Range(randomDirectionRange.x, randomDirectionRange.y),
            Random.Range(randomDirectionRange.x, randomDirectionRange.y),
            Random.Range(randomDirectionRange.x, randomDirectionRange.y)
        );

        // Destroy the text after the specified lifetime
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        // Move the text in the random direction over time
        transform.Translate(randomDirection * floatSpeed * Time.deltaTime, Space.World);
    }
}
