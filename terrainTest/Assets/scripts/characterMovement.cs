using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour {

    public float speed = 6f;
    public float jumpHeight = 40f;
    public Rigidbody rb;
    private bool grounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {


        float translation = Input.GetAxis("Horizontal") * speed;
        

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
       {

            // rb.AddForce(0, jumpHeight, 0, ForceMode.Impulse);
            rb.velocity = new Vector3(0, jumpHeight, 0);
            grounded = false;
        }



    }

    
    void OnCollisionEnter(Collision col)
    {
        

        if (col.gameObject.tag == "Ground")
        {
            grounded = true;
        }

    }
}
