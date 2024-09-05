using UnityEngine;

public class RotateGlobe : MonoBehaviour
{
    public float rotationSpeed = 10f; // Speed of rotation

    void Update()
    {
        // Rotate the globe around its y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
