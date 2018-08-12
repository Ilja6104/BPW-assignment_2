using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class debrisStormCollition : MonoBehaviour {

    public ParticleSystem particleLauncher;
    public characterHealth playerHealthScript;
    private int debrisDamage = 5;
    AudioSource audioData;
    public AudioClip impact;

    private void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    public void OnParticleCollision(GameObject other)
    {
        audioData.PlayOneShot(impact);

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player has been hit!");
            CameraShaker.Instance.ShakeOnce(2f, 4f, 0.3f, 0.6f);
            characterHealth.onHit(debrisDamage);
        }
        
        
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
