using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NomeScript : MonoBehaviour {

	//[SerializeField]InputField caixaDeTexto;
	[SerializeField]Text nomeTexto;
	private string valorTexto;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MudaValor(string valor){
		valorTexto = valor;
	} 

	public void AplicarMudanca(){
		nomeTexto.text = valorTexto;
	}
}
