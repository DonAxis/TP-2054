using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacionEspecial : MonoBehaviour {
		public Animator andar;
		public movimiento golpes;
		public Material ropa;
		public Color ColorGolpe;
	void Start () {
		andar = GetComponent<Animator>();
		ColorGolpe = ropa.color;
	}


	void Update () {
		
		if (Input.GetKey (KeyCode.LeftShift )&&	((Input.GetKey (KeyCode.A)) || (Input.GetKey (KeyCode.D))) && golpes.velocidad!=0) {
			andar.SetBool ("correr", true);
				
					if(Input.GetKey (KeyCode.A))
						transform.localScale=new Vector3(2,2,-2);
					else
						transform.localScale=new Vector3(2,2,2);
			
		} else
			andar.SetBool ("correr", false);






		if (((Input.GetKey (KeyCode.A)) || (Input.GetKey (KeyCode.D))) && golpes.velocidad!=0) {
			andar.SetBool ("caminar", true);
						
						if(Input.GetKey (KeyCode.A))
							transform.localScale=new Vector3(2,2,-2);
						else
							transform.localScale=new Vector3(2,2,2);
		
		} else
			andar.SetBool ("caminar", false);




		if ((Input.GetKey (KeyCode.W)) 	&& golpes.velocidad!=0)
			andar.SetBool ("saltar", true);
		else
			andar.SetBool ("saltar", false);
	
	
		if (golpes.velocidad == 0)
			ropa.color = Color.red;
		else
			ropa.color = ColorGolpe;
	}



}
