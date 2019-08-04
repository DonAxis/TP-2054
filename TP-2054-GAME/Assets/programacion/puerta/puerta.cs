using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour {


	public Collider tocar;
	void Start () {
		tocar = GetComponent<Collider>();
	}


	void Update () {
		
	}
	private void OnTriggerStay(Collider other)
	{
		Debug.Log ("oprime Y para seguir");
		if ((other.gameObject.tag == "capitana")&&(Input.GetKeyDown (KeyCode.Y))){
			
			tocar.enabled = !tocar.enabled;	
		}
	}
}
