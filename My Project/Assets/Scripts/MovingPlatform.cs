using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveDistance = 2f;       // Distance to move left and right
    public float moveSpeed = 2f;          // Speed of movement

    private Vector3 startPosition;

    void Start()
    {
        // Store the starting position of the platform
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position using Mathf.PingPong for back and forth movement
        float movement = Mathf.PingPong(Time.time * moveSpeed, moveDistance * 2) - moveDistance;
        transform.position = new Vector3(startPosition.x + movement, startPosition.y, startPosition.z);
    }
}
