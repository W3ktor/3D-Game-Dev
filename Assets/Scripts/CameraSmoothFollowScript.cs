using UnityEngine;
using System.Collections;

public class CameraSmoothFollowScript : MonoBehaviour
{
    public Transform target;
    public Vector3 targetOffset;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.transform.position + targetOffset;

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
