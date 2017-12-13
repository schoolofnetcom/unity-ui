using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MudaView : MonoBehaviour {

	[SerializeField]Toggle tg;
	[SerializeField]bool tgStatus = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void mudaView(){
		tgStatus = !tgStatus;
		gameObject.SetActive (tgStatus);
	}
}
