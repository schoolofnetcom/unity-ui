using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaDeVida : MonoBehaviour {

	[SerializeField]Text vidaText;
	[SerializeField]Button curarBtn;
	[SerializeField]Button danoBtn;
	private int vida = 100;
	void Start () {
		vidaText.text = vida.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		vidaText.text = vida.ToString();
	}

	public void Curar(){
		vida += 10;
	}

	public void Dano(){
		vida -= 10;
	}
}
