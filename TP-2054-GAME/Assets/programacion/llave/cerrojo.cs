using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerrojo : MonoBehaviour {

	public auxiliar puerta;

	void Start () { }
	void Update () { }





	private void OnTriggerEnter(Collider other)
	{
		if ((other.gameObject.tag == "capitana") && (puerta.solucion == true)) 
			Debug.Log ("solucionado!!!");
		
		
	}
}
