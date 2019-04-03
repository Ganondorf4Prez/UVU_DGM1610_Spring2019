using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFinPart : MonoBehaviour {

    private ParticleSystem thisParticleSystem;
	// Use this for initialization
	void Start () {

        thisParticleSystem = GetComponent<ParticleSystem>();
        
	}

	void Update () {
		
        if(thisParticleSystem.isPlaying)
            return;
        Destroy(gameObject);

	}

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
