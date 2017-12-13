using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntradaDeTextoBeta : MonoBehaviour {

    [SerializeField] Text textoValue;
    [SerializeField] InputField inputText;
    private string textoGlobal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InputMudanca(string texto)
    {
        textoGlobal = texto;
    }

    public void AcabouDeEditar()
    {
        textoValue.text = textoGlobal;
    }
}
