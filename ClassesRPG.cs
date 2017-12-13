using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassesRPG : MonoBehaviour {

    public Dropdown classesDropDown;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AlterarValorDropDown(int opcao)
    {
        Debug.Log("O Usuário selecionou a opção: "+opcao);
    }
}
