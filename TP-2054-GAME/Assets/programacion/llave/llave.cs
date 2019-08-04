using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llave : MonoBehaviour {

	//public estafetas solucion;
	public auxiliar muestra;


	void Start () {	
		this.gameObject.SetActive (false);
	}
	void Update () { }


	private void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject.tag == "capitana") {
			muestra.tomar = true;
			Debug.Log("recibeCurita");
			muestra.solucion=true;
			this.gameObject.SetActive (false);
		}
	}


}
