using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EsferaTamanho : MonoBehaviour {
    [SerializeField] Slider sld;
	// Use this for initialization
	void Start () {
		
	}
	void Update () {
		
	}
    public void AlteraTamanho(float valor)
    {
        transform.localScale = new Vector3(valor, valor, valor);
    }
}
