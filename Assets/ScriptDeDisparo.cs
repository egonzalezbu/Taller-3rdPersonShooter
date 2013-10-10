using UnityEngine;
using System.Collections;

public class ScriptDeDisparo : MonoBehaviour {
	public GameObject bala;
	public Transform cam;
	public float bulletSpeed = 200;
	// Use this for initialization
	void Start () {
	Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = new Vector3(0,cam.eulerAngles.y,0);
		if (Input.GetButtonDown("Fire1")){
			GameObject velocidad = (GameObject)Instantiate(bala, new Vector3(transform.position.x,transform.position.y +0.5f,transform.position.z),transform.rotation);
			velocidad.transform.eulerAngles = new Vector3(cam.eulerAngles.x,transform.eulerAngles.y,transform.eulerAngles.z);
			Physics.IgnoreCollision(collider,velocidad.collider);
			velocidad.rigidbody.AddForce(velocidad.transform.forward * bulletSpeed,ForceMode.Impulse);
		}
	}
}
