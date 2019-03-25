using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Desafio : MonoBehaviour
{

    public GameObject desafioTextGO;
    public GameObject respostaTextGO;
    Text respostaTexto;
    public string[] desafios;
    public string desafioEscolhido;
    int desafioIndex;
    public string[] respostas;
    public string resp;
    
    // Use this for initialization
    void Start()
    {

        pegarDesafio();
        respostaTexto = respostaTextGO.GetComponent<Text>(); 

    }

    // Update is called once per frame
    void Update()
    {
        pegarNumeros();

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            compararResposta();
        }
    }

    void pegarDesafio()
    {
        //string des = "";
        desafioIndex = Random.Range(0, desafios.Length);
        desafioTextGO.GetComponent<Text>().text = desafioEscolhido = desafios[desafioIndex];
        
    }

    void pegarNumeros()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            resp = resp + "0";
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            resp = resp + "1";
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            resp = resp + "2";
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            resp = resp + "3";
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            resp = resp + "4";
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            resp = resp + "5";
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            resp = resp + "6";
        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            resp = resp + "7";
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            resp = resp + "8";
        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            resp = resp + "9";
        }
        respostaTexto.text = resp;
    }

    public void compararResposta()
    {
        if (respostas[desafioIndex] == resp)
        {
            //Debug.Log("acertou o resultado");
            resp = "";
            pegarDesafio();
            GameObject.FindGameObjectWithTag("Player").GetComponent<Nave>().Recaregar();
        }
        else
        {
            resp = "";
            pegarDesafio();
        }
    }
}
