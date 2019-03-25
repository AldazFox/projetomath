using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //SceneManager.LoadScene("MainFase", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CarregarMainFase()
    {
        Debug.Log("Deve carregar a MainFase");
        SceneManager.LoadScene("MainFase", LoadSceneMode.Single);
    }
}
