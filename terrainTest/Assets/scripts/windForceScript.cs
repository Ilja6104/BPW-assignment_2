using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class windForceScript : MonoBehaviour {


   public Rigidbody playerRigidbody;
    public Rigidbody cartRigidbody;
    public static float windStrength = 9f;
    //public characterMovement characterMovement;

    void Awake () {
        playerRigidbody = playerRigidbody.GetComponent<Rigidbody>();
       cartRigidbody = cartRigidbody.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        playerRigidbody.AddForce(Vector3.left * windStrength, ForceMode.Force);
        cartRigidbody.AddForce(Vector3.left * windStrength, ForceMode.Force);
       // characterMovement.hsp -= 2;
    }
}
