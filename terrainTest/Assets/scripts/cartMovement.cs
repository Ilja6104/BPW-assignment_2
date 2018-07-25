using UnityEngine;

public class cartMovement : MonoBehaviour {

    public Transform target;

    public float smoothSpeed = 0.25f;

    private bool cartFollow = false;
    public Vector3 offset;
    public float distance;
    public float distaneToGrab = 2.5f;

    private void Update()
    {
        distance = Vector3.Distance(transform.position, target.transform.position);
    }

    void LateUpdate()
    {


        
    }



}

