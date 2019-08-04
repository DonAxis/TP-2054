using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion : MonoBehaviour {
		public Animator andar;
		public movimiento golpes;
		public Material ropa;
		public Color ColorGolpe;
	void Start () {
		andar = GetComponent<Animator>();
		ColorGolpe = ropa.color;
	}


	void Update () {

		if (((Input.GetKey (KeyCode.A)) || (Input.GetKey (KeyCode.D))) && golpes.velocidad!=0) {
			andar.SetBool ("camino", true);



						if(Input.GetKey (KeyCode.A))
							transform.localScale=new Vector3(.3f,.3f,-.3f);
						else
							transform.localScale=new Vector3(.3f,.3f,.3f);



		} else
			andar.SetBool ("camino", false);




		if ((Input.GetKey (KeyCode.W)) 	&& golpes.velocidad!=0)
			andar.SetBool ("salto", true);
		else
			andar.SetBool ("salto", false);
	
	
		if (golpes.velocidad == 0)
			ropa.color = Color.red;
		else
			ropa.color = ColorGolpe;
	}



}
