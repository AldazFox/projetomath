using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip plasmaBall;
    public AudioClip naveExplosion;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void TocarTiro()
    {
        audioSource.PlayOneShot(plasmaBall);
    }
    public void ExplosaoNave()
    {
        audioSource.PlayOneShot(naveExplosion);
    }

}
