﻿using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public Transform target;

    public float smoothSpeed = 0.25f;

    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed );
        transform.position = smoothedPosition;
    }



}
