using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{

    public float velocidade;
    public Vector3 posicao, localScale;
    bool direcaoDireita = true;
    public GameObject plasma;
    int municao;



    // Use this for initialization
    void Start()
    {
        posicao = transform.position;
        localScale = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moverDireita();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moverEsquerda();
        }
        //if (Input.GetKey(KeyCode.W))
        //{
        //    moverCima();
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    moverBaixo();
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            disparar();
        }
    }
    void moverDireita()
    {
        posicao += transform.right * Time.deltaTime * velocidade;
        transform.position = posicao;
        if (direcaoDireita == false)
        {
            localScale.x *= -1;
            transform.localScale = localScale;
            direcaoDireita = true;
        }
    }
    void moverEsquerda()
    {
        posicao -= transform.right * Time.deltaTime * velocidade;
        transform.position = posicao;
        if (direcaoDireita == true)
        {
            localScale.x *= -1;
            transform.localScale = localScale;
            direcaoDireita = false;
        }
    }
    void moverCima()
    {
        posicao += transform.up * Time.deltaTime * velocidade;
        transform.position = posicao;
    }
    void moverBaixo()
    {
        posicao -= transform.up * Time.deltaTime * velocidade;
        transform.position = posicao;
    }

    void disparar()
    {
        //if (municao > 0)
        //{
        //    GameObject plasmaGO = Instantiate(plasma, transform.position, transform.rotation);
        //    municao--;
        //}
        bool respostaCerta =false;
        respostaCerta = GameObject.FindGameObjectWithTag("Desafio").GetComponent<Desafio>().compararResposta();
        if (respostaCerta)
        {
            GameObject plasmaGO = Instantiate(plasma, transform.position, transform.rotation);
        }
    }
    public void Recaregar()
    {
        if (municao < 3)
        {
            municao++;
            Debug.Log(municao);
        }
        else
            return;
    }
}
