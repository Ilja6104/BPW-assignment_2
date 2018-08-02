using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour {

    public static float speed = 0.1f;
    public float jumpHeight;
    private Rigidbody rb;
    private bool grounded = true;
   public int windPushback = 0;

    private int rightInput;
    private int leftInput;
    public static float hsp = 0;
    private int move;
    private Vector3 horizontalPosition;

    public windForceScript windScript;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        horizontalPosition = new Vector3(0.0f, 0.0f, 0.0f);
    }

    void Update() {

        if (Input.GetKey(KeyCode.D))
        {
            // transform.position += Vector3.right * Time.deltaTime * speed;
            //rb.AddForce(Vector3.right * speed, ForceMode.Force);
            rightInput = 1;
            //Debug.Log("right: " + rightInput); 
        }
        else
        {
            rightInput = 0;

        }


        if (Input.GetKey(KeyCode.A))
        {
            // transform.position += Vector3.left * Time.deltaTime * speed;
          //  rb.AddForce(Vector3.left * speed, ForceMode.Force);
            leftInput = -1;
            //Debug.Log("left: " + leftInput);
        }
        else
        {
            leftInput = 0;

        }

       // Debug.Log("move: " + move);
        //Debug.Log("hsp: " + hsp);

        move = leftInput + rightInput;
        hsp = move * speed /*-  windForceScript.windStrength*/;
        transform.position += new Vector3(hsp, 0.0f, 0.0f);
        //horizontalPosition.transform.x += hsp;

        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
       {
            // rb.AddForce(0, jumpHeight, 0, ForceMode.Impulse);
            rb.velocity = new Vector3(0, jumpHeight, 0);
            grounded = false;
        }



    }

    
    void OnCollisionEnter(Collision col)
    {
        

        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Cart")
        {
            grounded = true;
        }

    }
}
