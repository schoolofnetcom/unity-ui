using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Aumento : MonoBehaviour {
	[SerializeField]Slider sld;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void AdjustSize(float value){
		transform.localScale = new Vector3 (value, value, value);
	}
}
