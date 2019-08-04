using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petete : MonoBehaviour {


	public auxiliar conteo;

	void Start () {	

//		this.gameObject.SetActive (false);
	}
	void Update () { }


	private void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "capitana") {
			Debug.Log("petete+1");
			conteo.conteoPetete--;
			this.gameObject.SetActive (false);
		}
	}

}
