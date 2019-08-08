using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour {
	public float velocidad,turbo,empuje;		//su movimiento y salto
	float PV,PE,salto;							//variables auxiliares PV=pausa velocidad
	public Rigidbody capi;						//empuje necesita rigidbody




	void Start () {
		
		PV = velocidad;
		PE = empuje;

	}
	

	void Update () {
	

			
			if ((Input.GetKey (KeyCode.W)) && (salto == 0)) {											//Saltar
			capi.AddForce (transform.up * empuje/2, ForceMode.Impulse);		//.VelocityChange);	//.Force);	//.Impulse);
				salto++;
			}


		if(Input.GetKey (KeyCode.LeftShift ))
			velocidad=turbo;
		//else
		//	velocidad=PV;
			

			if (Input.GetKey (KeyCode.D)) 													//caminar adelante
			transform.Translate (Vector3.forward * Time.deltaTime * velocidad);
		

			if (Input.GetKey (KeyCode.A)) 													//caminar atras
			transform.Translate (Vector3.forward * Time.deltaTime * -velocidad);
		

			
	}

	IEnumerator desactivacion()
	{
		
		empuje=velocidad = 0;
		Debug.Log ("quieto 2 segundos");
		yield return new WaitForSeconds(2);
		Debug.Log ("ya");
		velocidad = PV;
		empuje = PE;
	}



	private void OnTriggerEnter(Collider other)
	{
		//Debug.Log(other.name);
		if (other.name == "fuego") {
			Debug.Log ("te quemas");

			capi.AddForce (transform.up * empuje / 5, ForceMode.Impulse);
			capi.AddForce (-transform.forward * empuje, ForceMode.Impulse);
			StartCoroutine (desactivacion ());

			}


	}

	void OnCollisionEnter(Collision collision)
	{
		
		if (collision.gameObject.tag == "plataforma")
		{
			salto = 0;

		}
	}








}
