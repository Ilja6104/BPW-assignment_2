using UnityEngine;

public class cartMovement : MonoBehaviour {

    public Transform target;

    public float smoothSpeed = 0.25f;
    private bool cartFollow = false;
    private Vector3 offset;
    public float distaneToGrab;
    public Vector3 position;
    private Vector3 relativePos;
    private bool inRange;

    private void Update()
    {
        
        relativePos = transform.position - target.transform.position;
    
            if (relativePos.x >= 0)
            {
                offset.x = 2.5f;

            }
            else if (relativePos.x < 0)
            {
                offset.x = -2.5f;

            }

       // Debug.Log(relativePos);

        if(relativePos.x <= distaneToGrab && relativePos.x >= 1.7f || relativePos.x >= -distaneToGrab && relativePos.x <= -1.7 )
        {
            inRange = true;
        }
        else
        {
            inRange = false;
        }

        

         position = transform.position;

        if (inRange == true && cartFollow == false && Input.GetKey(KeyCode.LeftControl))
        {
            cartFollow = true;
            print("on");
        }

        if (cartFollow == true && Input.GetKey(KeyCode.RightControl))
        {
            cartFollow = false;
            print("off");

        }

    }

    void LateUpdate()
    {
        if (cartFollow == true)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }



}

