using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Adjust rotation speed as needed
    public float rotationSpeed = 45f;

    void Update()
    {
        // Rotate around the local y-axis (coin's upright axis)
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
