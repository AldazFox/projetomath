using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plasma : MonoBehaviour {


    public float velocidade;
    public Vector3 posicao;
    float autoDestruirTime;
    float tempoVida;

	// Use this for initialization
	void Start () {
        posicao = transform.position;
        autoDestruirTime = 1.0f;
        tempoVida = 0.0f;
        GameObject.FindGameObjectWithTag("Sound").GetComponent<SoundFX>().TocarTiro();
	}
	
	// Update is called once per frame
	void Update () {
        mover();
        tempoVida += Time.deltaTime;
        //Debug.Log(tempoVida);
        if(tempoVida>= autoDestruirTime)
        {
            autoDestuir();
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        autoDestuir();
    }

    void mover()
    {
        posicao += transform.up * Time.deltaTime * velocidade;
        transform.position = posicao;
    }
    void autoDestuir()
    {
        Destroy(this.gameObject);
    }
}
