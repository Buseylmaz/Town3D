using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform targetObje;

    public Vector3 cameraOffset;
    public float smoothFactor = 0.5f;
    public bool lookAtTarget = false;

    private void Start()
    {
        cameraOffset = transform.position - targetObje.transform.position;
    }

    private void LateUpdate()
    {
        Vector3 newPosition=targetObje.transform.position+ cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);

        if(lookAtTarget)
        {
            transform.LookAt(targetObje);
        }
    }
}
