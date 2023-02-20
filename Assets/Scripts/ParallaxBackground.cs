using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public Transform cameraTransform;
    [SerializeField] private Vector2 relativeMovement;
    private Vector3 previousCameraPosition;
    // public bool lockYMovement = false;
    private void Start()
    {
        //cameraTransform = Camera.main.transform;
        previousCameraPosition = cameraTransform.position;
    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - previousCameraPosition;
        transform.position += new Vector3(deltaMovement.x * relativeMovement.x, deltaMovement.y * relativeMovement.y);
        previousCameraPosition = cameraTransform.position;

        // if (lockYMovement)
        // {
        //     transform.position = new Vector2(cameraTransform.position.x * relativeMovement, transform.position.y);
        // }
        // else
        // {
        //     transform.position = new Vector2(cameraTransform.position.x * relativeMovement, cameraTransform.position.y * relativeMovement);
        // }
    }
}
