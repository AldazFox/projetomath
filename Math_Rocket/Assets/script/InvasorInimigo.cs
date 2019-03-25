using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvasorInimigo : MonoBehaviour {

    public GameObject naveInvasora;

    public GameObject[] posicoesAlvo;
    public GameObject[] minhasNaves;

	// Use this for initialization
	void Start () {
        MandarNaveInimiga();
		
	}
	
	// Update is called once per frame
	void Update () {
        minhasNaves = GameObject.FindGameObjectsWithTag("NaveInimiga");
        if(minhasNaves.Length <= 0)
        {
            MandarNaveInimiga();
        }
	}

    void MandarNaveInimiga()
    {
        GameObject invasorGO = Instantiate(naveInvasora, transform.position, transform.rotation);
        invasorGO.GetComponent<NaveInvasora>().PosAlvo(posicoesAlvo[Random.Range(0, posicoesAlvo.Length)].transform.position);
    }
}
