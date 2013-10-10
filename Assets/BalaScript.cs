using UnityEngine;
using System.Collections;

public class BalaScript : MonoBehaviour {
	private float tiempoVidaBala = 5f;
	private float tiempoDeVida;
	void Start(){
		tiempoDeVida = Time.time;
	}
	void Update(){
		if((Time.time-tiempoDeVida)>=tiempoVidaBala){
			Destroy(this.gameObject);
		}
	}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.name=="Sphere"){
			Destroy(col.gameObject);
			Destroy(this.gameObject);
		}
	}
}
