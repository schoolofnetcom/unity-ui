using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto : MonoBehaviour {

    [SerializeField]Text texto;
    [SerializeField] string conteudo; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        texto.text = conteudo;
	}
}
