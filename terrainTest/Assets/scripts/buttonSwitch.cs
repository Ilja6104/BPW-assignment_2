using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSwitch : MonoBehaviour {

    private Light myLight;
    private Animator animator;

    // Use this for initialization
    void Start () {
        myLight = transform.GetChild(0).GetComponent<Light>();
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collide?");
        if (other.gameObject.tag == "Player")
        {
            //transform.GetChild(0).GetComponent<Light>().enabled = true;
            myLight.enabled = true;
            animator.SetBool("activated", true);
            Debug.Log("on?");
        }

    }
}
