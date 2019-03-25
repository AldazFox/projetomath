using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveInvasora : MonoBehaviour
{

    Vector3 posAlvo;
    bool chegueiPosAlvo = false;
    bool fugir = false;
    public float tempoFugir;
    float esperaTempo;
    public float velocidade;
    public float velFuga;
    public Vector3 posicao;

    // Use this for initialization
    void Start()
    {
        posicao = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (chegueiPosAlvo == false)
            MoverPosAlvo();

        if (fugir)
        {
            esperaTempo += Time.deltaTime;
        }
        if (esperaTempo > tempoFugir)
        {
            MoverFugir();
        }
        if (fugir == true && Vector3.Distance(posAlvo, posicao) >= 10)
        {
            AutoDestuir();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        GameObject.FindGameObjectWithTag("Recorde").GetComponent<Recorde>().MarcarPontos(100);
        GameObject.FindGameObjectWithTag("Sound").GetComponent<SoundFX>().ExplosaoNave();
        AutoDestuir();
        //spriteMove = -0.1f;
    }


    public void PosAlvo(Vector3 p)
    {
        posAlvo = p;
        //Debug.Log(posAlvo);
    }

    void MoverPosAlvo()
    {
        // posição alvo esta a esqueda da nave
        //Debug.Log(posAlvo.x < posicao.x);
        if (posAlvo.x < posicao.x)
        {
            posicao -= transform.right * Time.deltaTime * velocidade;
            transform.position = posicao;
        }
        // posição alvo esta a direita da nave
        if (posAlvo.x > posicao.x)
        {
            posicao += transform.right * Time.deltaTime * velocidade;
            transform.position = posicao;
        }
        // posição alvo esta a acima da nave
        if (posAlvo.y < posicao.y)
        {
            posicao -= transform.up * Time.deltaTime * velocidade;
            transform.position = posicao;
        }

        //Debug.Log(Vector3.Distance(posAlvo, posicao));

        if (Vector3.Distance(posAlvo, posicao)<0.1)
        {
            //Debug.Log("fugir");
            chegueiPosAlvo = true;
            fugir = true;
        }
    }
    void MoverFugir()
    {
        posicao += transform.up * Time.deltaTime * velFuga;
        transform.position = posicao;
    }
    void AutoDestuir()
    {
        Destroy(this.gameObject);
    }
}
