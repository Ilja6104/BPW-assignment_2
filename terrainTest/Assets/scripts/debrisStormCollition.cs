using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class debrisStormCollition : MonoBehaviour {

    public ParticleSystem particleLauncher;
    public characterHealth playerHealthScript;
    private int debrisDamage = 5;

    private void OnParticleCollision(GameObject other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player has been hit!");
            CameraShaker.Instance.ShakeOnce(2f, 4f, 0.3f, 0.6f);
            characterHealth.onHit(debrisDamage);
        }
        else
        {

    
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
