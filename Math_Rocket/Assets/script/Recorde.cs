using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recorde : MonoBehaviour {

    int recorde;
    Text recordeTxt;

	// Use this for initialization
	void Start () {
        recordeTxt = GameObject.FindGameObjectWithTag("Recorde").GetComponent<Text>();
	}
	
	public void MarcarPontos(int p)
    {
        recorde += p;
        recordeTxt.text = recorde.ToString();
    }

}
