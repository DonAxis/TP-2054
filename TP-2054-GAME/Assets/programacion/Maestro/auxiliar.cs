using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auxiliar : MonoBehaviour {

	public GameObject[] piesasPetete;
	public int conteoPetete;		
	public bool regreso;			//interaccion 1

	public GameObject llave;		//interaccion 2
	public bool tomar,solucion;	


	void Start () {
		for (int i = 0; i < piesasPetete.Length; i++) 
			piesasPetete [i].gameObject.SetActive (false);

		conteoPetete = piesasPetete.Length;					//cuantas piesas forman el petete

		Debug.Log ("ve el chamaco te ayudara");				//primera mision
		tomar = solucion = regreso = false;
	}
	

	void Update () {	
		if ((conteoPetete == 0) && tomar==false) {												//pieasas por juntar
			regreso = true;
			llave.gameObject.SetActive (true);

		}

	}


	public void PasoUno(){													//darle al niño lo que quiere
		
		Debug.Log ("faltan " + conteoPetete + " piesas, consiguelas");
	
		for (int i = 0; i < piesasPetete.Length; i++) {						//revisa que no esten activados los petetes
			if (piesasPetete [i].gameObject.activeSelf == true) {
				Debug.Log ("no terminaste aun");
				return;
			}
		}
			


		for (int i = 0; i < piesasPetete.Length; i++) 						//activa los petetetes
			piesasPetete [i].gameObject.SetActive (true);
		
		

	}

//	public void PasoDos(){													//conceguir todas las poesas del petete
//		conteoPetete++;
//	}

	public void PasoTres(){

	}



}
