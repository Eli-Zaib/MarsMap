using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera mainCamera; // Reference to the main camera
    public float zoomSpeed = 10f; // Speed of zooming
    public float minFOV = 10f; // Minimum field of view
    public float maxFOV = 60f; // Maximum field of view

    void Update()
    {
        if (mainCamera != null)
        {
            // Get the scroll wheel input
            float scroll = Input.GetAxis("Mouse ScrollWheel");

            if (Mathf.Abs(scroll) > Mathf.Epsilon) // Check if the scroll value is non-zero
            {
            

                // Adjust the camera's field of view
                mainCamera.fieldOfView -= scroll * zoomSpeed;
                mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView, minFOV, maxFOV);
            }
        }
    }
}
