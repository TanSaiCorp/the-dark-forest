using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 previousCameraPosition;
    // Start is called before the first frame update
    private void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - previousCameraPosition;
        transform.position += deltaMovement;
        previousCameraPosition = cameraTransform.position;
    }
}
