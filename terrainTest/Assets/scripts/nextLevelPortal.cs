using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevelPortal : MonoBehaviour {

    public postProcessingSwitch postProcessingScript;


    void Start()
    {

    }


    
    void Update () {



	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("");
        if (other.gameObject.tag == "Player")
        {
            postProcessingSwitch.endLevelLerp = true;
            Debug.Log("");
        }

    }
}
