using UnityEngine;

public class VerticalMover : MonoBehaviour
{
    [Header("Movement Settings")]
    [Tooltip("The distance the object will move up and down from its starting position.")]
    public float amplitude = 1.0f;
    
    [Tooltip("The speed of the oscillation.")]
    public float speed = 1.0f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float offset = (Mathf.Sin(Time.time * speed) * 0.5f + 0.5f) * amplitude;
        transform.position = new Vector3(startPosition.x, startPosition.y + offset, startPosition.z);
    }
}
