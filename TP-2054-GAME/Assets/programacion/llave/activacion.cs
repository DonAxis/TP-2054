using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activacion : MonoBehaviour {

//	public petete[] ActivaJugete;
//	public GameObject[] piesas;

	public auxiliar piesas;

	void Start () { }
	void Update () { }



	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "capitana") {
			if (piesas.regreso == false) {
				Debug.Log ("ve por el petete");
				piesas.PasoUno ();
			} else
				Debug.Log ("chamaco da solucion");


		}
	}
}
